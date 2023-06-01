package new_package;

import java.util.*;
import java.lang.*;
import java.io.*;

public class Student_Array {
    String[] students = new String[10];

    public void getStudent(String[] student){
        Scanner in = new Scanner(System.in);

        for (int i = 0; i < 10; i++){
            System.out.println("Введіть ім'я студента: ");
            student[i] = in.next();
        }

        Arrays.sort(student);
    }

    public static void writeStudents(String[] student) {
        int[] birthYears = new int[10];
        double[] averageGrades = new double[10];

        Random random = new Random();

        // Заповнення масивів з випадковими даними
        for (int i = 0; i < student.length; i++) {
            birthYears[i] = random.nextInt(11) + 1990; // діапазон від 1990 до 2000
            averageGrades[i] = 2.0 + (random.nextDouble() * 3.0); // діапазон від 2.0 до 5.0
        }

        // Запис даних студентів у файл
        try (PrintWriter writer = new PrintWriter(new FileWriter("StudData.txt"))) {
            for (int i = 0; i < student.length; i++) {
                String formattedGrade = String.format("%.1f", averageGrades[i]);
                writer.println(student[i] + ";" + birthYears[i] + ";" + formattedGrade);
            }
            System.out.println("Дані про студентів записані у файл StudData.txt\n");
        } catch (IOException e) {
            System.out.println("Виникла помилка при записі у файл: " + e.getMessage() + "\n");
        }
    }
}
