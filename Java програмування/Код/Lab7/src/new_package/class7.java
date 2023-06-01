package new_package;

import java.util.*;

public class class7 {
    public static void main(String[] args) {
        String[] students = new String[10];
        Student_Array student_arr = new Student_Array();

        student_arr.getStudent(students);
        student_arr.writeStudents(students);

        Recordset recordset = new Recordset();
        recordset.loadRecords("StudData.txt");
        ArrayList<Record> records = recordset.getRecords();

        // Виведення завантажених елементів типу Record в консоль
        for (Record record : records) {
            System.out.println("Прізвище: " + record.getStudent());
            System.out.println("Рік народження: " + record.getBirthYear());
            System.out.println("Середній бал: " + record.getAverageGrade());
            System.out.println("-----------------------");
        }

        // Розрахунок статистичних показників
        double maxGrade = Double.MIN_VALUE;
        double minGrade = Double.MAX_VALUE;
        double sum = 0;
        double sumSquaredDiff = 0;

        for (Record record : records) {
            double grade = record.getAverageGrade();

            if (grade > maxGrade) {
                maxGrade = grade;
            }

            if (grade < minGrade) {
                minGrade = grade;
            }

            sum += grade;
            sumSquaredDiff += Math.pow(grade, 2);
        }

        double mean = sum / records.size();
        double variance = (sumSquaredDiff / records.size()) - Math.pow(mean, 2);

        System.out.println("Максимальне значення: " + maxGrade);
        System.out.println("Мінімальне значення: " + minGrade);
        System.out.println("Математичне очікування: " + mean);
        System.out.println("Дисперсія: " + variance);
    }
}
