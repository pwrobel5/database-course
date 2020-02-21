namespace BD_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        NumberOfUnits = c.Int(nullable: false),
                        CompanyName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CompanyName)
                .Index(t => t.CompanyName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CompanyName", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CompanyName" });
            DropTable("dbo.Orders");
        }
    }
}
