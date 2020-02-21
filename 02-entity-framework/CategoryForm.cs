using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BD_Entity
{
    public partial class CategoryForm : Form
    {
        private int currentCategoryID;
        private bool isSavingMode;
        private ProdContext prodContext;
        private String companyName;
        private decimal totalPrice;
        public CategoryForm(String companyName)
        {
            InitializeComponent();           
            this.companyName = companyName;
            this.totalPrice = 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            prodContext = new ProdContext();
            prodContext.Categories.Load();
            prodContext.Products.Load();
            prodContext.Orders.Load();

            isSavingMode = false;

            if (companyName == "Admin")
            {
                this.saveButton.Enabled = false;
                this.switchModeButton.Text = "Edit mode";
            }
            else
            {
                this.saveButton.Visible = false;
                this.switchModeButton.Visible = false;                               
            }

            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;

            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;

            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;

            this.categoryBindingSource.DataSource = prodContext.Categories.Local.ToBindingList();
            this.productBindingSource.DataSource = prodContext.Products.Local.ToBindingList();
            this.orderBindingSource.DataSource = prodContext.Orders.Local.Where(ord => ord.CompanyName == companyName).ToList();

            this.totalPrice = 0;
            foreach (Order order in (List<Order>) orderBindingSource.DataSource)
            {
                Product currentProduct = order.Product;
                this.totalPrice += currentProduct.UnitPrice * order.NumberOfUnits;
            }

            this.totalPriceLabel.Text = Convert.ToString(this.totalPrice);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            prodContext.SaveChanges();

            this.categoryDataGridView.Refresh();
            this.productDataGridView.Refresh();
        }

        private void handleCategorySelection(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            Category selectedCategory = (Category)categoryDataGridView.Rows[selectedRow].DataBoundItem;

            if (selectedCategory != null)
            {
                currentCategoryID = selectedCategory.CategoryID;
                if (!this.isSavingMode)
                {
                    // query based syntax
                    this.productBindingSource.DataSource = (from prod in prodContext.Products
                                                            where prod.CategoryID == currentCategoryID
                                                            select prod).ToList();

                    // method based syntax
                    //this.productBindingSource.DataSource = prodContext.Products.Where(prod => prod.CategoryID == currentCategoryID).ToList();
                }
            }            
        }

        private void productDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["prodDGVCategoryID"].Value = currentCategoryID;            
        }

        private void switchModeButton_Click(object sender, EventArgs e)
        {
            if(isSavingMode)
            {                
                this.switchModeButton.Text = "Edit mode";

                this.productBindingSource.DataSource = prodContext.Products.Where(prod => prod.CategoryID == currentCategoryID).ToList();
            }
            else
            {
                this.switchModeButton.Text = "Read mode";

                productBindingSource.DataSource = prodContext.Products.Local.ToBindingList();
            }

            this.saveButton.Enabled = !this.saveButton.Enabled;

            this.productDataGridView.AllowUserToAddRows = !this.productDataGridView.AllowUserToAddRows;
            this.productDataGridView.AllowUserToDeleteRows = !this.productDataGridView.AllowUserToDeleteRows;

            this.categoryDataGridView.AllowUserToAddRows = !this.categoryDataGridView.AllowUserToAddRows;
            this.categoryDataGridView.AllowUserToDeleteRows = !this.categoryDataGridView.AllowUserToDeleteRows;

            isSavingMode = !isSavingMode;
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            int selectedProductRowIndex = productDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedProductRow = productDataGridView.Rows[selectedProductRowIndex];
            int maxUnits = Convert.ToInt32(selectedProductRow.Cells["prodDGVUnitsInStock"].Value);

            if(this.numberOfUnitsUpDown.Value == 0 || this.numberOfUnitsUpDown.Value > maxUnits)
            {
                MessageBox.Show("Incorrect unit number!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Order newOrder = new Order();
                newOrder.CompanyName = this.companyName;
                newOrder.NumberOfUnits = (int) this.numberOfUnitsUpDown.Value;
                newOrder.ProductID = Convert.ToInt32(selectedProductRow.Cells["prodDGVProductID"].Value);
                prodContext.Orders.Add(newOrder);

                orderBindingSource.DataSource = prodContext.Orders.Local.Where(ord => ord.CompanyName == companyName).ToList();               

                Product productToModify = prodContext.Products.First(prod => prod.ProductID == newOrder.ProductID);
                productToModify.UnitsInStock -= newOrder.NumberOfUnits;
                productDataGridView.Refresh();

                this.totalPrice += productToModify.UnitPrice * newOrder.NumberOfUnits;
                this.totalPriceLabel.Text = Convert.ToString(this.totalPrice);
            }
        }

        private void deleteFromOrder_Click(object sender, EventArgs e)
        {
            int selectedOrderRowIndex = orderDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedOrderRow = orderDataGridView.Rows[selectedOrderRowIndex];
            int productToChangeID = Convert.ToInt32(selectedOrderRow.Cells["orderDGVProductID"].Value);
            int cancelledUnits = Convert.ToInt32(selectedOrderRow.Cells["orderDGVNumberOfUnits"].Value);
            int cancelledOrderID = Convert.ToInt32(selectedOrderRow.Cells["orderDGVOrderID"].Value);

            Order orderToRemove = prodContext.Orders.Local.First(ord => 
            (ord.ProductID == productToChangeID)  &&
            ((ord.ProductID == productToChangeID) &&
            (ord.NumberOfUnits == cancelledUnits) &&
            (String.Compare(ord.CompanyName, this.companyName) == 0)));
            
            Product productToModify = prodContext.Products.First(prod => prod.ProductID == productToChangeID);
            productToModify.UnitsInStock += cancelledUnits;
            productDataGridView.Refresh();

            this.totalPrice -= cancelledUnits * productToModify.UnitPrice;
            this.totalPriceLabel.Text = Convert.ToString(this.totalPrice);

            prodContext.Orders.Local.Remove(orderToRemove);
            orderBindingSource.DataSource = prodContext.Orders.Local.Where(ord => ord.CompanyName == companyName).ToList();
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            prodContext.SaveChanges();
            this.orderDataGridView.Refresh();
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            prodContext.Dispose();
            prodContext = new ProdContext();
            
            prodContext.Categories.Load();
            prodContext.Products.Load();
            prodContext.Orders.Load();
            prodContext.Orders.Local.Clear();

            this.orderBindingSource.DataSource = prodContext.Orders.Local.Where(ord => ord.CompanyName == companyName).ToList();
            this.categoryBindingSource.DataSource = prodContext.Categories.Local.ToBindingList();
            this.productBindingSource.DataSource = (from prod in prodContext.Products
                                                    where prod.CategoryID == currentCategoryID
                                                    select prod).ToList();

            this.totalPrice = 0;
            this.totalPriceLabel.Text = Convert.ToString(this.totalPrice);
        }
    }    
}
