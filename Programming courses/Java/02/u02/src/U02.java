import java.util.Formatter;
import java.util.Scanner;
import java.io.File;
import java.io.FileNotFoundException;

public class U02 {

    public static void main(String[] args) throws FileNotFoundException {
        Scanner input = new Scanner(new File("text.txt"));
        // skip first line
        input.nextLine();
        StringBuilder sb = new StringBuilder();
        Formatter formatter = new Formatter(sb);
        while (input.hasNextLine()) {
            String[] col = input.nextLine().split(";");
            for (int i = 0; i < col.length; i++) {
                if (i == 0) {
                    sb.append(String.format("%-14s", col[i]));
                } else if (i == 1) {
                    sb.append(String.format(" bist geboren in %4s", col[i]));
                } else if (i == 2) {
                    sb.append(String.format(" und liebt %-10s", col[i]));
                } else {
                    sb.append(" und ");
                    sb.append("\n");
                    // kp warum das jetzt nicht klappt
                    // formatter.format("%7.2f%n",Double.parseDouble(col[i]));
                }
            }
        }
        System.out.print(sb);
    }

}
