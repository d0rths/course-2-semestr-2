#include <iostream>
#include <iomanip>
#include <fstream>
#include "Windows.h"

using namespace std;

struct Array {
private:
    double* arr;
    int SIZE;
public:
    double MIN;
    double MAX;
    ifstream readFile;
    ofstream writeFile;
    string PATH = "array.txt";
};




int Menu() {
    int check;
    cout << "Заповнити масив з файлу [0]\n";
    cout << "Додати елемент до масиву [1]\n";
    cout << "Видалити елемент з масиву [2]\n";
    cout << "Замінити елемент в масиві [3]\n";
    cout << "Впорядкувати елементи масиву [4]\n";
    cout << "Пошук елемента за критерієм [5]\n";
    cout << "Выберите команду: ";
    cin >> check;
    return check;
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    Array arr;

    system("pause");
    return 0;
}


