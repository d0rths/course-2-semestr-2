#include <iostream>
#include <iomanip>
#include <fstream>
#include <Windows.h>
using namespace std;

/// <summary>
/// Структура, що представляє вузол стека
/// </summary>
/// <typeparam name="T"></typeparam>
template <class T>
struct Node {
    T data;
    Node* next;
};

/// <summary>
/// Клас, що представляє роботу стека
/// </summary>
/// <typeparam name="T"></typeparam>
template <class T>
class Stack {
private:
    Node<T>* head;
    int count;

    T MAX;
    T MIN;
    ifstream readFile;
    ofstream writeFile;
    string filePath = "stack.txt";

    /// <summary>
    /// Метод для пошуку елемента за індексом
    /// </summary>
    /// <param name="index"> Індекс </param>
    /// <returns> Повертає елемент </returns>
    Node<T>* Move(int index) {
        if (count > 0)
        {
            Node<T>* t = head;
            for (int i = 0; i < index; i++)
            {
                t = t->next;
            }
            return t;
        }
        return nullptr;
    }

    /// <summary>
    /// Метод для отримання розміру стека в файлі
    /// </summary>
    int GetSize() {
        int Size = 0;
        readFile.open(filePath);
        if (!readFile.is_open())
        {
            cout << "Помилка відкриття файлу!" << endl;
        }
        else
        {
            int x;
            while (readFile >> x)
            {
                Size++;
            }
            readFile.close();
        }

        return Size;
    }

public:
    /// <summary>
    /// Конструктор
    /// </summary>
    Stack() {
        head = nullptr;
        count = 0;
    }

    /// <summary>
    /// Заповнення стека з файлу
    /// </summary>
    void AddFromTheFile() {
        int Size = GetSize();
        readFile.open(filePath);
        if (!readFile.is_open())
        {
            cout << "Помилка відкриття файлу!" << endl;
        }
        else
        {
            T* t = new T[Size];
            for (int i = 0; i < Size; i++)
                readFile >> t[i];

            for (int j = Size-1; j >= 0; j--)
                Push(t[j]);
        }
    }
    /// <summary>
    /// Метод для додавання елемента
    /// </summary>
    /// <param name="_data"> Елемент </param>
    void Push(T _data) {
        Node<T>* node = new Node<T>;
        node->data = _data;
        node->next = head;
        head = node;

        count++;
    }
    /// <summary>
    /// Метод для видалення елемента
    /// </summary>
    void Pop() {
        Node<T>* node;
        T data;

        data = head->data;
        node = head;
        head = head->next;

        count--;
        delete node;
    }
    /// <summary>
    /// Виведення стека
    /// </summary>
    void Print() {
        if (head == nullptr)
            cout << "Стек порожній\n";
        else
        {
            Node<T>* node;
            node = head;
            while (node != nullptr)
            {
                cout << node->data << " ";
                node = node->next;
            }
            cout << endl << endl;
        }
    }
    /// <summary>
    /// Очищення стеку
    /// </summary>
    void Clear() {
        Node<T>* node;
        Node<T>* node2;

        node = head;
        while (node != nullptr)
        {
            node2 = node;
            node = node->next;
            delete node2;
            count--;
        }
        head = nullptr;
    }
    /// <summary>
    /// Метод для зміни елемента за індексом
    /// </summary>
    /// <param name="index"> Індекс </param>
    /// <returns> Повертає елемент </returns>
    T& operator[](int index)
    {
        if ((index < 0) || (index > count - 1))
        {
            throw out_of_range("Неправильний індекс");
        }

        Node<T>* t = Move(index);

        return t->data;
    }
    /// <summary>
    /// Знаходження максимальнго елемента
    /// </summary>
    /// <returns> Повертає максимальний елемент </returns>
    T GetMax() {
        Node<T>* node = head;
        MAX = node->data;

        int i = 0;
        while (i != count)
        {
            if (node->data > MAX)
            {
                MAX = node->data;
            }

            node = node->next;
            i++;
        }

        return MAX;
    }
    /// <summary>
    /// Знаходження мінімального елемента
    /// </summary>
    /// <returns> Повертає мінімальний елемент </returns>
    T GetMin() {
        Node<T>* node = head;
        MIN = node->data;

        int i = 0;
        while (i != count)
        {
            if (node->data < MIN)
            {
                MIN = node->data;
            }

            node = node->next;
            i++;
        }

        return MIN;
    }
    /// <summary>
    /// Метод для пошуку першого парного або непарного елементу
    /// </summary>
    /// <param name="check">
    /// true - пошук першого парного 
    /// false - пошук першого непарного 
    /// </param>
    /// <returns> Повертає результат пошуку </returns>
    int EvenOrOddCheck(bool check) {
        Node<T>* ptr = head;
        T result;

        if (check == true)
        {
            int i = 0;
            while (i != count)
            {
                if (ptr->data % 2 == 0)
                {
                    result = ptr->data;
                    break;
                }
                else {
                    ptr = ptr->next;
                    i++;
                    continue;
                }
            }
        }
        else
        {
            int i = 0;
            while (i != count)
            {
                if (ptr->data % 2 != 0)
                {
                    result = ptr->data;
                    break;
                }
                else {
                    ptr = ptr->next;
                    i++;
                    continue;
                }
            }
        }

        return result;
    }
    /// <summary>
    /// Метод для пошуку першого додатнього або від'ємного елементу
    /// </summary>
    /// <param name="check">
    /// true - пошук першого додатнього 
    /// false - пошук першого від'ємного 
    /// </param>
    /// <returns> Повертає результат пошуку </returns>
    int PositiveCheck(bool check) {
        Node<T>* ptr = head;
        T result;

        if (check == true)
        {
            int i = 0;
            while (i != count)
            {
                if (ptr->data > 0)
                {
                    result = ptr->data;
                    break;
                }
                else {
                    ptr = ptr->next;
                    i++;
                    continue;
                }
            }
        }
        else
        {
            int i = 0;
            while (i != count)
            {
                if (ptr->data < 0)
                {
                    result = ptr->data;
                    break;
                }
                else {
                    ptr = ptr->next;
                    i++;
                    continue;
                }
            }
        }

        return result;
    }
    /// <summary>
    /// Метод для пошуку всіх елементів, рівних заданому
    /// </summary>
    /// <param name="element"> Заданий елемент </param>
    void Search(int element) {
        Node<T>* ptr = head;

        int i = 0;
        while (i != count)
        {
            if (ptr->data == element)
            {
                cout << ptr->data << "(" << i << " index)\n";
            }

            ptr = ptr->next;
            i++;
        }
        cout << endl;
    }

    /// <summary>
    /// Запис списка в файл
    /// </summary>
    void WriteToTheFile() {
        writeFile.open(filePath);
        if (!writeFile.is_open())
        {
            cout << "Помилка відкриття файлу" << endl;
        }
        else
        {
            Node<T>* ptr = head;

            int i = 0;
            while (i != count)
            {
                writeFile << ptr->data << " ";

                ptr = ptr->next;
                i++;
            }
        }
        writeFile.close();
    }

    /// <summary>
    /// Метод для закриття файлу
    /// </summary>
    void Close() {
        readFile.close();
    }
};

/// <summary>
/// Функція, що викликає меню
/// </summary>
/// <returns> Повертає значення, введене користувачем </returns>
int Menu() {
    int check;
    cout << "Завантажити стек [0]\n";
    cout << "Відобразити стек [1]\n";
    cout << "Замінити елемент стека [2]\n";
    cout << "Додати елемент [3]\n";
    cout << "Видалити елемент [4]\n";
    cout << "Знайти елемент за критерієм [5]\n";
    cout << "Видалити список [6]\n";
    cout << "Закінчити виконання програми [7]\n";
    cout << "\nОберіть команду: ";
    cin >> check;

    if (check == 5)
    {
        system("cls");
        cout << "Критерій\n";
        cout << "   Найбільший [1]\n";
        cout << "   Найменший [2]\n";
        cout << "   Перший парний [3]\n";
        cout << "   Перший непарний [4]\n";
        cout << "   Перший додатній [5]\n";
        cout << "   Перший від'ємний [6]\n";
        cout << "   Всі рівні заданому [7]\n";
        cout << "\nОберіть команду: ";
        cin >> check;
        check += 50;
    }

    return check;
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    Stack<int> St;

    int choice;
    int index, element;
    for (; ; )
    {
        choice = Menu();
        switch (choice)
        {
        case 0:
            system("cls");

            St.AddFromTheFile();

            break;
        case 1:
            system("cls");

            St.Print();

            break;
        case 2:
            system("cls");

            cout << "Введіть індекс і елемент: ";
            cin >> index >> element;
            St[index] = element;
            St.Print();

            St.WriteToTheFile();
            break;
        case 3:
            system("cls");

            cout << "Введіть елемент: ";
            cin >> element;
            St.Push(element);
            St.Print();

            St.WriteToTheFile();
            break;
        case 4:
            system("cls");

            St.Pop();
            St.Print();

            St.WriteToTheFile();
            break;
        case 51:
            system("cls");

            cout << "Найбільший елемент = " << St.GetMax() << endl;
            St.Print();

            break;
        case 52:
            system("cls");

            cout << "Найменший елемент = " << St.GetMin() << endl;
            St.Print();

            break;
        case 53:
            system("cls");

            cout << "Перший парний елемент = " << St.EvenOrOddCheck(true) << endl;
            St.Print();

            break;
        case 54:
            system("cls");

            cout << "Перший непарний елемент = " << St.EvenOrOddCheck(false) << endl;
            St.Print();

            break;
        case 55:
            system("cls");

            cout << "Перший додатній елемент = " << St.PositiveCheck(true) << endl;
            St.Print();

            break;
        case 56:
            system("cls");

            cout << "Перший від'ємний елемент = " << St.PositiveCheck(false) << endl;
            St.Print();

            break;
        case 57:
            system("cls");

            cout << "Введіть елемент: ";
            cin >> element;
            cout << "\nЕлементи, рівні заданому:\n";
            St.Search(element);
            St.Print();

            break;
        case 6:
            system("cls");
         
            St.Clear();
            St.WriteToTheFile();
         
            break;
        case 7:
            system("cls");

            St.Close();

            system("pause");
            break;
        }
    }
}

