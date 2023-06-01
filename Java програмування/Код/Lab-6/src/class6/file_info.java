package class6;
import java.io.File;

public class file_info {
    private String filePath;

    public file_info(String filePath) {
        this.filePath = filePath;
    }

    public boolean checkFileExists() {
        File file = new File(filePath);
        return file.exists() && file.isFile();
    }
    public void path_finder(){
        File file = new File(filePath);
        if (file.exists()) {
            String absolutePath = file.getAbsolutePath();
            System.out.println("Повний шлях до файлу: " + absolutePath);
        }
        else {
            System.out.println("Файл не знайдено");
        }
    }
    public void size_calculator(){
        File file = new File(filePath);
        if (file.exists()) {
            long fileSizeBytes = file.length();
            System.out.println("Розмір файлу: " + fileSizeBytes + " байт");
        } else {
            System.out.println("Файл не знайдено");
        }
    }

}
