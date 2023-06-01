package class3;

public class student extends person{
    String Group;
    String Speciality;
    public student(String name, int age, String group, String speciality){
        super(name, age);
        Group = group;
        Speciality = speciality;
    }
    public void show(){
        System.out.println("Студент \nІм'я: " + Name + "\nВік: " + Age + "\nГрупа: " + Group + "\nСпеціальність: " + Speciality);
    }
}
