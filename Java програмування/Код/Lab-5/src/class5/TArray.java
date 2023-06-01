package class5;

public class TArray {
    String task;
    int[] arr;

    public void showTask(){
        System.out.println("Умова задачі: \"" + task + "\"");
    }
    public void arrayInit(int N){
        arr = new int[N];
        for (int i = 0; i < N; i++){
            arr[i] = (int)(Math.random()*20);
        }
    }
    public void printArray(){
        for (int i = 0; i < 20; i++) {
            System.out.println(i + ". " + arr[i]);
        }
    }
    public void taskSolution(){
        System.out.println("Парні елементи за зростанням індекса:");
        for (int i = 0; i < 20; i++){
            if (arr[i] % 2 == 0) {
                System.out.println(i + ". " + arr[i]);
            }
        }
        System.out.println("Непарні елементи за спаданням індекса:");
        for (int i = 19; i > 0; i--){
            if (arr[i] % 2 != 0) {
                System.out.println(i + ". " + arr[i]);
            }
        }
    }
    public void taskInit(String str){
        task = str;
    }
}
