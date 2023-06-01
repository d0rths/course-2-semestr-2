package class6;
import java.io.*;
public class class_file {
    public void writeFile(String[] student, double[] grade, int N){
        try {
            FileWriter writer = new FileWriter("list.txt", false);
            for (int i = 0; i < N; i++){
                writer.append(student[i]);
                writer.append('\n');
                writer.append(grade[i]+"\n");
            }
            writer.flush();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
    public void readFile(String[] student, double[] grade, int N){
        try(FileReader r = new FileReader("list.txt"))
        {
            BufferedReader reader = new BufferedReader(r);
            String line = reader.readLine();
            student[0] = line;
            int i = 1;
            int j = 0;

            while (j < N) {
                if (i % 2 == 0){
                    line = reader.readLine();
                    student[j] = line;
                    i++;
                }
                else {
                    line = reader.readLine();
                    grade[j] = Double.parseDouble(line);
                    i++;
                    j++;
                }
            }
        }
        catch(IOException ex){
            System.out.println(ex.getMessage());
        }
    }
}
