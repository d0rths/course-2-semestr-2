package class3;

public class class3 {
    public static class TLine{
        char Symbol;
        public TLine(char symbol){
            Symbol = symbol;
        };
        public void show(){
            for (int i = 0;i < 10; i++){
                System.out.print(Symbol);
            }
            System.out.println();
        }
    }
    public static void main(String[] args) {
        TLine line = new TLine('-');

        person Oleg = new person("Олег", 24);
        line.show();
        Oleg.show();
        line.show();

        student Ivan = new student("Іван", 19, "ІПЗ-20-1", "Інженерія програмного забезпечення");
        Ivan.show();
        line.show();

    }
}
