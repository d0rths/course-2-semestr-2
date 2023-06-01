#include <iostream>
#include <iomanip>
#include <set>
#include "Windows.h"

using namespace std;

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    string input;
    set <char> result;

    cout << "Введіть слово: ";
    cin >> input;

    for (int i = 0; i < input.size(); i++)
        result.insert(input[i]);

    cout << "Результат: { ";
    for(auto item : result)
        cout << item << " ";
    cout << "}\n";

    system("pause");
    return 0;
}