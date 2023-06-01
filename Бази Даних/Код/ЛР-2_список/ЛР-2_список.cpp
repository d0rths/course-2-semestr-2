#include <iostream>
#include <iomanip>  
#include <fstream>
#include <Windows.h>  

using namespace std;

/// <summary>
/// Структура, що представляє вузол списку
/// </summary>
/// <typeparam name="T"></typeparam>
template <class T>
struct Node {
    T data;
    Node* next;
};

/// <summary>
/// Клас, що представляє однозв'язний список
/// </summary>
/// <typeparam name="T"></typeparam>
template <class T>
class List {
private:
    Node<T>* begin;
    Node<T>* end;
    int count;

    T MAX;
    T MIN;
    ifstream readFile;
    ofstream writeFile;
    string filePath = "list.txt";

    /// <summary>
    /// Метод для пошуку елемента за індексом
    /// </summary>
    /// <param name="index"> Індекс </param>
    /// <returns> Повертає елемент </returns>
    Node<T>* Move(int index) {
        if (count > 0)
        {
            Node<T>* t = begin;
            for (int i = 0; i < index; i++)
            {
                t = t->next;
            }
            return t;
        }
        return nullptr;
    }

    /// <summary>
    /// Метод для отримання розміру списка в файлі
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
    List() {
        begin = end = nullptr;
        count = 0;
    }
    /// <summary>
    /// Метод для додавання елемента
    /// </summary>
    /// <param name="_data"> Елемент </param>
    void Add(T _data) {
        Node<T>* node = new Node<T>;
        node->data = _data;
        node->next = nullptr;

        if (begin == nullptr)
            begin = end = node;
        else
        {
            end->next = node;
            end = node;
        }

        count++;
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
            throw out_of_range("Неправильний індекс.");
        }

        Node<T>* t = Move(index);


        return t->data;
    }
    /// <summary>
    /// Метод для видалення елемента за індексом
    /// </summary>
    /// <param name="index"> Індекс </param>
    void Delete(int index) {
        if (count == 0)
            return;

        if ((index < 0) || (index >= count))
            return;

        if (index == 0)
        {
            Node<T>* t = begin;
            begin = begin->next;
            delete t;
        }
        else
        {
            Node<T>* t = Move(index - 1);
            Node<T>* t2 = t->next;
            t->next = t2->next;

            delete t2;
        }

        count--;
    }
    /// <summary>
    /// Видалення першого елемента
    /// </summary>
    void Delete() {
        Delete(0);
    }
    /// <summary>
    /// Метод для очищення списку
    /// </summary>
    void Clear() {
        while (begin != nullptr)
        {
            Delete();
        }
    }
    /// <summary>
    /// Деструктор
    /// </summary>
    ~List() {
        Clear();
    }
    /// <summary>
    /// Виведення списку
    /// </summary>
    void Print() {
        if (count == 0)
        {
            cout << "Список порожній" << endl << endl; 
            return;
        }

        Node<T>* t = begin;

        while (t != nullptr)
        {
            cout << t->data << " ";
            t = t->next;
        }
        cout << endl << endl;
    }
    /// <summary>
    /// Заповнення списка з файлу
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
            int temp;
            for (int i = 0; i < Size; i++)
            {
                readFile >> temp;
                Add(temp);
            }
        }
    }
    /// <summary>
    /// Сортування
    /// </summary>
    /// <param name="check"> 
    /// true - сортування за спаданням
    /// false - сортування за зростанням
    /// </param>
    void Sort(bool check) {
        Node<T>* ptrN = begin;

        while (ptrN->next != NULL)
        {
            Node<T>* ptr = begin;

            while (ptr->next != NULL)
            {
                if (check == true)
                {
                    if (ptr->data > ptr->next->data)
                    {
                        T temp = ptr->data;
                        ptr->data = ptr->next->data;
                        ptr->next->data = temp;
                    }
                }
                else
                {
                    if (ptr->data < ptr->next->data)
                    {
                        T temp = ptr->data;
                        ptr->data = ptr->next->data;
                        ptr->next->data = temp;
                    }
                }

                ptr = ptr->next;
            }

            ptrN = ptrN->next;
        }
    }
    /// <summary>
    /// Знаходження максимальнго елемента
    /// </summary>
    /// <returns> Повертає максимальний елемент </returns>
    T GetMax() {
        Node<T>* ptr = begin;
        MAX = ptr->data;

        int i = 0;
        while (i != count)
        {
            if (ptr->data > MAX)
            {
                MAX = ptr->data;
            }

            ptr = ptr->next;
            i++;
        }

        return MAX;
    }
    /// <summary>
    /// Знаходження мінімального елемента
    /// </summary>
    /// <returns> Повертає мінімальний елемент </returns>
    T GetMin() {
        Node<T>* ptr = begin;
        MIN = ptr->data;

        int i = 0;
        while (i != count)
        {
            if (ptr->data < MIN)
            {
                MIN = ptr->data;
            }

            ptr = ptr->next;
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
        Node<T>* ptr = begin;
        T result;

        if (check == true)
        {
            int i = 0;
            while (i != count)
            {
                if (ptr->data%2 == 0)
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
        Node<T>* ptr = begin;
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
        Node<T>* ptr = begin;

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
            Node<T>* ptr = begin;

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
    cout << "Завантажити список [0]\n";
    cout << "Відобразити список [1]\n";
    cout << "Замінити елемент списка [2]\n";
    cout << "Додати елемент [3]\n";
    cout << "Видалити елемент [4]\n";
    cout << "Сортувати список [5]\n";
    cout << "Знайти елемент за критерієм [6]\n";
    cout << "Видалити список [7]\n";
    cout << "Закінчити виконання програми [8]\n";
    cout << "\nОберіть команду: ";
    cin >> check;

    if (check == 4)
    {
        system("cls");
        cout << "Видалення:\n";
        cout << "   Першого елемента [1]\n";
        cout << "   За індексом [2]\n";
        cout << "\nОберіть команду: ";
        cin >> check;
        check += 40;
    }
    if (check == 5)
    {
        system("cls");
        cout << "Сортування:\n";
        cout << "   За зростанням [1]\n";
        cout << "   За спаданням [2]\n";
        cout << "\nОберіть команду: ";
        cin >> check;
        check += 50;
    }
    if (check == 6)
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
        check += 60;
    }

    return check;
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    List<int> L;

    int choice;
    int index, element;
    for (; ; )
    {
        choice = Menu();
        switch (choice)
        {
        case 0:
            system("cls");

            L.AddFromTheFile();

            break;
        case 1:
            system("cls");

            L.Print();

            break;
        case 2:
            system("cls");

            cout << "Введіть індекс і елемент: ";
            cin >> index >> element;
            L[index] = element;
            L.Print();

            L.WriteToTheFile();
            break;
        case 3:
            system("cls");
            
            cout << "Введіть елемент: ";
            cin >> element;
            L.Add(element);
            L.Print();

            L.WriteToTheFile();
            break;
        case 41:
            system("cls");
            
            L.Delete();
            L.Print();

            L.WriteToTheFile();
            break;
        case 42:
            system("cls");

            cout << "Введіть індекс: ";
            cin >> index;
            L.Delete(index);
            L.Print();

            L.WriteToTheFile();
            break;
        case 51:
            system("cls");

            L.Sort(true);
            L.Print();

            L.WriteToTheFile();
            break;
        case 52:
            system("cls");

            L.Sort(false);
            L.Print();

            L.WriteToTheFile();
            break;
        case 61:
            system("cls");

            cout << "Найбільший елемент = " << L.GetMax() << endl;
            L.Print();

            L.WriteToTheFile();
            break;
        case 62:
            system("cls");

            cout << "Найменший елемент = " << L.GetMin() << endl;
            L.Print();

            L.WriteToTheFile();
            break;
        case 63:
            system("cls");

            cout << "Перший парний елемент = " << L.EvenOrOddCheck(true) << endl;
            L.Print();

            L.WriteToTheFile();
            break;
        case 64:
            system("cls");

            cout << "Перший непарний елемент = " << L.EvenOrOddCheck(false) << endl;
            L.Print();

            L.WriteToTheFile();
            break;
        case 65:
            system("cls");

            cout << "Перший додатній елемент = " << L.PositiveCheck(true) << endl;
            L.Print();

            L.WriteToTheFile();
            break;
        case 66:
            system("cls");

            cout << "Перший від'ємний елемент = " << L.PositiveCheck(false) << endl;
            L.Print();

            L.WriteToTheFile();
            break;
        case 67:
            system("cls");

            cout << "Введіть елемент: ";
            cin >> element;
            cout << "\nЕлементи, рівні заданому:\n";
            L.Search(element);
            L.Print();

            L.WriteToTheFile();
            break;
        case 7:
            system("cls");
            L.Clear();
            L.WriteToTheFile();
            break;
        case 8:
            system("cls");
            L.Close();
            system("pause");
            break;
        }
    }
}