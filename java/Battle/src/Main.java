import java.util.function.Function;

public class Main {
    public static void main(String[] args) {
    	final Function<String, String> mi = azz -> "Your " + azz + " done been foo-ed!";
    	System.out.printf("%s\t%s", mi.apply("Not Today"), "Daaaammmmnnn!");
    }
}
