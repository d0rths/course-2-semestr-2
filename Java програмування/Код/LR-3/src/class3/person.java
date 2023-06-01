package class3;

public class person {
    public String Name;
    public int Age;

    public person(String name, int age){
        Name = name;
        Age = age;
    }

    public void show(){
        System.out.println("Ім'я: " + Name + "\nВік: " + Age);
    }
}
