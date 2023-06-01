package new_package;

public class Record {
    private String student;
    private int birthYear;
    private double averageGrade;

    public Record(String student, int birthYear, double averageGrade) {
        this.student = student;
        this.birthYear = birthYear;
        this.averageGrade = averageGrade;
    }

    public String getStudent() {
        return student;
    }

    public int getBirthYear() {
        return birthYear;
    }

    public double getAverageGrade() {
        return averageGrade;
    }
}
