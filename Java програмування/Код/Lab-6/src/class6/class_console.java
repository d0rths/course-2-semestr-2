package class6;

import java.io.InputStream;
import java.util.Scanner;

public class class_console {
    public void getStudent(String[] student, double[] grade, int N){
        Scanner in = new Scanner(System.in);

        for (int i = 0; i < N; i++){
            student[i] = in.next();
            grade[i] = in.nextDouble();
        }
    }
    public void printStudent(String[] student, double[] grade, int N){
        int x = 27;
        System.out.println("- - - - - - - - - - - - - - - - - -");
        System.out.println("|    Студент    |" + "  Середній бал   |");
        for (int i = 0; i < N; i++){
            x = x - student[i].length();
            System.out.println("- - - - - - - - - - - - - - - - - -");
            System.out.printf("|");
            System.out.printf("%-15s", student[i]);
            System.out.println("|       " + grade[i] + "       |");
        }
        System.out.println("- - - - - - - - - - - - - - - - - -");
    }
}
