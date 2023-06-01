package class6;
import java.io.*;
public class class6 {
    public static void main(String[] args) {
        int N = 10;
        String[] students = new String[N];
        double[] grades = new double[N];

        class_console student = new class_console();
        student.getStudent(students, grades, N);
        student.printStudent(students, grades, N);
        System.out.println("\n");

        class_file file = new class_file();
        file.writeFile(students, grades, N);
        file.readFile(students, grades, N);
        student.printStudent(students, grades, N);

        String filePath = "list.txt";
        file_info info = new file_info(filePath);
        if (info.checkFileExists()) {
            System.out.println("Файл існує");
        } else {
            System.out.println("Файл не знайдено");
        }

        info.path_finder();
        info.size_calculator();
    }
}
