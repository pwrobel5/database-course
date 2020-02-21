import java.util.Scanner;
import java.util.function.Consumer;

public class MenuEntry {
    private String description;
    private Consumer<Scanner> entryAction;

    public MenuEntry(String description, Consumer<Scanner> entryAction) {
        this.description = description;
        this.entryAction = entryAction;
    }

    public String getDescription() {
        return description;
    }

    public Consumer<Scanner> getEntryAction() {
        return entryAction;
    }
}
