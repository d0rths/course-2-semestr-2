#include <iostream>
#include <iomanip>
#include <fstream>
#include <Windows.h>
using namespace std;

/// <summary>
/// Клас роботи з чергою
/// </summary>
/// <typeparam name="T"></typeparam>
template <typename T>
class Queue {
private:
    T* p;
    int count;

    ifstream readFile;
    ofstream writeFile;
    string filePath = "queue.txt";
public:
	/// <summary>
	/// Метод для отримання розміру черги в файлі
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
	/// <summary>
	/// Метод для отримання черги з файла
	/// </summary>
	void AddQueueFromTheFile() {
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
                Push(temp);
			}
		}

	}

    /// <summary>
    /// Конструктор
    /// </summary>
    Queue() {
        count = 0;
    }
    /// <summary>
    /// Додавання елемента
    /// </summary>
    /// <param name="item"> Елемент </param>
    void Push(T item) {
		T* p2;
		p2 = p;

		p = new T[count + 1];
        
		for (int i = 0; i < count; i++)
			p[i] = p2[i];

		p[count] = item;
		count++;
		if (count > 1) 
			delete[] p2;
    }
    /// <summary>
    /// Видалення першого елемента
    /// </summary>
    T Pop() {
		if (count == 0) 
			return 0;

		T* p2;
		p2 = new T[count - 1];
		count--;
		for (int i = 0; i < count; i++)
			p2[i] = p[i + 1];
		if (count > 0)
			delete[] p;
		p = p2;
    }
    /// <summary>
    /// Декструктор
    /// </summary>
    ~Queue() {
        if (count > 0)
            delete[] p;
    }
    /// <summary>
    /// Видалення черги
    /// </summary>
    void Clear() {
        if (count > 0)
        {
            delete[] p; 
            count = 0;
        }
    }
    /// <summary>
    /// Виведення черги
    /// </summary>
    void Print() {
        if (count == 0)
            cout << "Черга порожня";

        for (int i = 0; i < count; i++)
            cout << p[i] << " ";
        cout << endl << endl;
    }
	/// <summary>
	/// Запис черги в файл
	/// </summary>
	void WriteToTheFile() {
		writeFile.open(filePath);
		if (!writeFile.is_open())
		{
			cout << "Помилка відкриття файлу" << endl;
		}
		else
		{
			for (int i = 0; i < count; i++)
			{
				writeFile << p[i] << " ";
			}
		}
		writeFile.close();
	}

	/// <summary>
	/// Метод зміни елемента за індексом
	/// </summary>
	/// <param name="element"> Новий елемент </param>
	/// <param name="index"> Індекс </param>
	void ElementChange(int index, int element) {
		p[index] = element;
	}
	/// <summary>
	/// Метод отримання мінімального елемента
	/// </summary>
	/// <returns> Повертає мінімальний елемент </returns>
	double GetMin() {
		int Min = p[0];
		for (int i = 0; i < count; i++)
		{

			if (p[i] < Min)
				Min = p[i];
			else
				continue;
		}
		return Min;
	}
	/// <summary>
	/// Метод отримання максимального елемента
	/// </summary>
	/// <returns> Повертає максимальний елемент </returns>
	double GetMax() {
		int Max = p[0];
		for (int i = 0; i < count; i++)
		{
			if (p[i] > Max)
				Max = p[i];
			else
				continue;
		}
		return Max;
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
		int result;
		if (check == true)
		{
			for (int i = 0; i < count; i++)
			{
				if (p[i] % 2 == 0) {
					result = p[i];
					break;
				}
				else
					continue;
			}
		}
		else
		{
			for (int i = 0; i < count; i++)
			{
				if (p[i] % 2 != 0) {
					result = p[i];
					break;
				}
				else
					continue;
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
		int result;
		if (check == true)
		{
			for (int i = 0; i < count; i++)
			{
				if (p[i] > 0) {
					result = p[i];
					break;
				}
				else
					continue;
			}
		}
		else
		{
			for (int i = 0; i < count; i++)
			{
				if (p[i] < 0) {
					result = p[i];
					break;
				}
				else
					continue;
			}
		}

		return result;
	}
	/// <summary>
	/// Метод для пошуку всіх елементів, рівних заданому
	/// </summary>
	/// <param name="element"> Заданий елемент </param>
	void Search(int element) {
		for (int i = 0; i < count; i++)
		{
			if (element == p[i])
			{
				cout << p[i] << "(" << i << " index)\n";
			}
		}
		cout << endl;
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
    cout << "Завантажити чергу [0]\n";
    cout << "Відобразити чергу [1]\n";
    cout << "Замінити елемент черги [2]\n";
    cout << "Додати елемент [3]\n";
    cout << "Видалити елемент [4]\n";
    cout << "Знайти елемент за критерієм [5]\n";
    cout << "Видалити чергу [6]\n";
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

    Queue<int> q;
	int choice;
	int index, element;
	for (; ; )
	{
		choice = Menu();
		switch (choice)
		{
		case 0:
			system("cls");

			q.AddQueueFromTheFile();

			break;
		case 1:
			system("cls");

			q.Print();

			break;
		case 2:
			system("cls");

			cout << "Введіть індекс і елемент: ";
			cin >> index >> element;
			q.ElementChange(index, element);
			q.Print();
			q.WriteToTheFile();

			break;
		case 3:
			system("cls");

			cout << "Введіть елемент: ";
			cin >> element;
			q.Push(element);
			q.Print();
			q.WriteToTheFile();

			break;
		case 4:
			system("cls");

			q.Pop();
			q.Print();
			q.WriteToTheFile();

			break;
		case 51:
			system("cls");

			cout << "Найбільший елемент = " << q.GetMax() << "\n";
			q.Print();

			break;
		case 52:
			system("cls");

			cout << "Найменший елемент = " << q.GetMin() << "\n";
			q.Print();

			break;
		case 53:
			system("cls");

			cout << "Перший парний елемент = " << q.EvenOrOddCheck(true) << "\n";
			q.Print();

			break;
		case 54:
			system("cls");

			cout << "Перший непарний елемент = " << q.EvenOrOddCheck(false) << "\n";
			q.Print();

			break;
		case 55:
			system("cls");

			cout << "Перший додатній елемент = " << q.PositiveCheck(true) << "\n";
			q.Print();

			break;
		case 56:
			system("cls");

			cout << "Перший від'ємний елемент = " << q.PositiveCheck(false) << "\n";
			q.Print();

			break;
		case 57:
			system("cls");

			cout << "Введіть елемент: ";
			cin >> element;
			cout << "\nЕлементи, рівні заданому:\n";
			q.Search(element);
			q.Print();

			break;
		case 6:
			system("cls");

			q.Clear();
			q.WriteToTheFile();

			break;
		case 7:
			system("cls");

			q.Close();

			system("pause");
			break;
		}
	}
}

