package class5;

public class class5 {
    public static void main(String[] args) {
        TArray Arr = new TArray();

        Arr.taskInit("Дано цілісний масив розміру N=20. Вивести спочатку всі парні числа,\n що містяться в даному масиві, в порядку зростання їх індексів,\n а потім - усі непарні числа в порядку зменшення їх індексів.");
        Arr.showTask();
        Arr.arrayInit(20);
        Arr.printArray();
        System.out.println();
        Arr.taskSolution();
        System.out.println();

        System.out.println("Кількість символів в рядку: " + Arr.task.length());
        System.out.println("Позиція слова \"парні\" в рядку: " + Arr.task.indexOf("парні"));
        System.out.println("Рядок завдання у зворотньому порядку: " + new StringBuffer(Arr.task).reverse().toString());
    }
}
