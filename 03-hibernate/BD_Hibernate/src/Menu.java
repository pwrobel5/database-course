import java.util.HashMap;
import java.util.Scanner;
import java.util.function.Consumer;

public class Menu {
    private String entryText;
    private HashMap<Integer, MenuEntry> options;
    private Integer index;
    private boolean continueAction = true;

    public Menu(String entryText) {
        this.entryText = entryText;
        this.index = new Integer(1);
        this.options = new HashMap<>();
    }

    public void addOption(String description, Consumer<Scanner> action) {
        this.options.put(this.index, new MenuEntry(description, action));
        this.index += 1;
    }

    public void display() {
        System.out.println(this.entryText);

        Scanner inputScanner = new Scanner(System.in);
        while (this.continueAction) {
            for (int i = 1; i < index; i++) {
                System.out.printf("%d - %s\n", i, this.options.get(i).getDescription());
            }

            System.out.print("Enter option number: ");
            Integer chosenOption = Integer.parseInt(inputScanner.nextLine());

            if (this.options.containsKey(chosenOption)) {
                this.options.get(chosenOption).getEntryAction().accept(inputScanner);
            } else {
                System.out.println("Wrong action!");
            }
        }

    }
}
