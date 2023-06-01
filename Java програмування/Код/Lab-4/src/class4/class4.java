package class4;

public class class4 {
    public static void main(String[] args){
        int numOfMonth = 12;
        int numOfSeason = 4;
        float averageDaysInMonth = 0;
        String result = "";

        String[] month = new String[] {"Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень", "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень"};
        String[] season = new String[] {"Зима", "Весна", "Літо", "Осінь"};
        int[] days = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        for (int i = 0; i < numOfMonth; i++){
            result += month[i] + " це ";
            switch (i){
                case 0:
                    result += season[0];
                    break;
                case 1:
                    result += season[0];
                    break;
                case 2:
                    result += season[1];
                    break;
                case 3:
                    result += season[1];
                    break;
                case 4:
                    result += season[1];
                    break;
                case 5:
                    result += season[2];
                    break;
                case 6:
                    result += season[2];
                    break;
                case 7:
                    result += season[2];
                    break;
                case 8:
                    result += season[3];
                    break;
                case 9:
                    result += season[3];
                    break;
                case 10:
                    result += season[3];
                    break;
                case 11:
                    result += season[0];
                    break;
            }
            if (days[i] == 31){
                result += " і містить " + days[i] + " день.";
            }
            else{
                result += " і містить " + days[i] + " днів.";
            }

            System.out.println(result);
            result = "";
        }
        int i = 0;
        while (i != numOfMonth){
            averageDaysInMonth += days[i];
            if (i != numOfMonth-1){
                i++;
                continue;
            }
            else{
                String average = String.format("%.2f", averageDaysInMonth/numOfMonth);
                System.out.println("Середня кількість днів на місяць року = " + average);
                i++;
            }
        }

        if (days[1] == 28){
            System.out.println("Рік не високосний.");
        }
        else{
            System.out.println("Рік високосний.");
        }

    }
}
