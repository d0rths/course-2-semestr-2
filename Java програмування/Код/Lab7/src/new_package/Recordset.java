package new_package;

import java.io.*;
import java.util.*;

public class Recordset {
    private ArrayList<Record> records;

    public Recordset() {
        records = new ArrayList<>();
    }

    public void loadRecords(String fileName) {
        try (BufferedReader reader = new BufferedReader(new FileReader(fileName))) {
            String line;
            while ((line = reader.readLine()) != null) {
                String[] data = line.split(";");
                String student = data[0];
                int birthYear = Integer.parseInt(data[1]);
                double averageGrade = Double.parseDouble(data[2].replace(",", ".")); // Заміна коми на крапку

                Record record = new Record(student, birthYear, averageGrade);
                records.add(record);
            }
        } catch (IOException e) {
            System.out.println("Виникла помилка при читанні з файлу: " + e.getMessage());
        } catch (NumberFormatException e) {
            System.out.println("Виникла помилка при перетворенні рядка на число: " + e.getMessage());
        }
    }

    public ArrayList<Record> getRecords() {
        return records;
    }
}
