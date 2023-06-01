#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>
#include "Windows.h"

using namespace std;

/// <summary>
/// Клас роботи з масивом
/// </summary>
class Array {
	int* arr;
	int Size;
public:
	double Min;
	double Max;
	ifstream readFile;
	ofstream writeFile;
	string filePath = "array.txt";

	/// <summary>
	/// Метод для отримання розміру масива в файлі
	/// </summary>
	void GetSize() {
		Size = 0;
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
	}
	/// <summary>
	/// Метод для отримання масива з файла
	/// </summary>
	void GetArray() {
		GetSize();
		readFile.open(filePath);
		if (!readFile.is_open())
		{
			cout << "Помилка відкриття файлу!" << endl;
		}
		else
		{
			arr = new int[Size];
			for (int i = 0; i < Size; i++)
			{
				readFile >> arr[i];
			}
		}

	}
	/// <summary>
	/// Метод для виведення масива в консоль
	/// </summary>
	void Show() {
		for (int i = 0; i < Size; i++)
		{
			cout << arr[i] << " ";
		}
		cout << endl << endl;
	}
	/// <summary>
	/// Метод зміни елемента за індексом
	/// </summary>
	/// <param name="element"> Новий елемент </param>
	/// <param name="index"> Індекс </param>
	void ElementChange(int index, int element) {
		writeFile.open(filePath);
		if (!writeFile.is_open())
		{
			cout << "Помилка відкриття файлу" << endl;
		}
		else
		{
			arr[index] = element;
			for (int i = 0; i < Size; i++)
			{
				writeFile << arr[i] << " ";
			}
		}
		writeFile.close();
	}

	/// <summary>
	/// Метод отримання мінімального елемента
	/// </summary>
	/// <returns> Повертає мінімальний елемент </returns>
	double GetMin() {
		Min = arr[0];
		for (int i = 0; i < Size; i++)
		{

			if (arr[i] < Min)
				Min = arr[i];
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
		Max = arr[0];
		for (int i = 0; i < Size; i++)
		{
			if (arr[i] > Max)
				Max = arr[i];
			else
				continue;
		}
		return Max;
	}
	/// <summary>
	/// Метод для додавання елементу в масив
	/// </summary>
	/// <param name="value"> Значення елемента </param>
	/// <param name="index"> Індекс </param>
	void ElementAdd(int index, int value) {
		writeFile.open(filePath);
		if (!writeFile.is_open())
		{
			cout << "Помилка відкриття файлу" << endl;
		}
		else
		{
			if (index >= Size + 1)
			{
				cout << "Неправильно введений індекс\n";
				writeFile.close();
				return;
			}

			Size++;
			int* temp = new int[Size];
			temp[index] = value;

			int j = 0;
			for (int i = 0; i < Size; i++)
			{
				if (i != index)
				{
					temp[i] = arr[j];
					j++;
				}
				else
					continue;
			}
			arr = new int[Size];
			arr = temp;

			for (int i = 0; i < Size; i++)
			{
				writeFile << arr[i] << " ";
			}
		}
		writeFile.close();
	}
	/// <summary>
	/// Метод для видалення елемента
	/// </summary>
	/// <param name="index"> Індекс елемента </param>
	void ElementDelete(int index) {
		writeFile.open(filePath);
		if (!writeFile.is_open())
		{
			cout << "Помилка відкриття файлу" << endl;
		}
		else
		{
			if (index >= Size)
			{
				cout << "Неправильно введений індекс\n";
				writeFile.close();
				return;
			}
			int* temp = new int[Size];
			temp = arr;
			Size--;
			arr = new int[Size];
			int j = 0;
			for (int i = 0; i < Size + 1; i++)
			{
				if (i != index)
				{
					arr[j] = temp[i];
					j++;
				}
				else
					continue;
			}

			for (int i = 0; i < Size; i++)
			{
				writeFile << arr[i] << " ";
			}
		}
		writeFile.close();
	}
	/// <summary>
	/// Метод для сортування масиву
	/// </summary>
	/// <param name="check"> 
	/// true - сортування за спаданням
	/// false - сортування за зростанням
	/// </param>
	void Sort(bool check) {
		writeFile.open(filePath);
		if (!writeFile.is_open())
		{
			cout << "Помилка відкриття файлу" << endl;
		}
		else
		{
			if (check == true)
			{
				for (int i = 0; i < Size; i++)
				{
					for (int j = i; j < Size; j++)
					{
						if (arr[i] < arr[j])
						{
							int temp = arr[i];
							arr[i] = arr[j];
							arr[j] = temp;
						}
					}
				}
			}
			else
			{
				for (int i = 0; i < Size; i++)
				{
					for (int j = i; j < Size; j++)
					{
						if (arr[i] > arr[j])
						{
							int temp = arr[i];
							arr[i] = arr[j];
							arr[j] = temp;
						}
					}
				}
			}

			for (int i = 0; i < Size; i++)
			{
				writeFile << arr[i] << " ";
			}
		}
		writeFile.close();
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
			for (int i = 0; i < Size; i++)
			{
				if (arr[i] % 2 == 0) {
					result = arr[i];
					break;
				}
				else
					continue;
			}
		}
		else
		{
			for (int i = 0; i < Size; i++)
			{
				if (arr[i] % 2 != 0) {
					result = arr[i];
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
			for (int i = 0; i < Size; i++)
			{
				if (arr[i] > 0) {
					result = arr[i];
					break;
				}
				else
					continue;
			}
		}
		else
		{
			for (int i = 0; i < Size; i++)
			{
				if (arr[i] < 0) {
					result = arr[i];
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
		for (int i = 0; i < Size; i++)
		{
			if (element == arr[i])
			{
				cout << arr[i] << "(" << i << " index)\n";
			}
		}
		cout << endl;
	}
	/// <summary>
	/// Метод для видалення масиву
	/// </summary>
	void ArrayDelete() {
		delete[] arr;
		Size = 0;
		cout << "Масив видалено\n";
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
	cout << "Завантажити масив [0]\n";
	cout << "Відобразити масив [1]\n";
	cout << "Замінити елемент масива [2]\n";
	cout << "Додати елемент [3]\n";
	cout << "Видалити елемент [4]\n";
	cout << "Сортувати масив [5]\n";
	cout << "Знайти елемент за критерієм [6]\n";
	cout << "Видалити масив [7]\n";
	cout << "Завершити виконання програми [8]\n";
	cout << "\nОберіть команду: ";
	cin >> check;

	if (check == 5)
	{
		system("cls");
		cout << "Сортування\n";
		cout << "   За спаданням [1]\n";
		cout << "   За зростанням [2]\n";
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
	Array arr;
	int choice;
	int index, element;
	for (; ; )
	{
		choice = Menu();
		switch (choice)
		{
		case 0:
			system("cls");
			arr.GetArray();
			break;
		case 1:
			system("cls");
			arr.Show();
			break;
		case 2:
			system("cls");
			cout << "Введіть індекс і елемент: ";
			cin >> index >> element;
			arr.ElementChange(index, element);
			arr.Show();
			break;
		case 3:
			system("cls");
			cout << "Введіть індекс і елемент: ";
			cin >> index >> element;
			arr.ElementAdd(index, element);
			arr.Show();
			break;
		case 4:
			system("cls");
			cout << "Введіть індекс: ";
			cin >> index;
			arr.ElementDelete(index);
			arr.Show();
			break;
		case 51:
			system("cls");
			arr.Sort(true);
			arr.Show();
			break;
		case 52:
			system("cls");
			arr.Sort(false);
			arr.Show();
			break;
		case 61:
			system("cls");
			cout << "Найбільший елемент = " << arr.GetMax() << "\n";
			arr.Show();
			break;
		case 62:
			system("cls");
			cout << "Найменший елемент = " << arr.GetMin() << "\n";
			arr.Show();
			break;
		case 63:
			system("cls");
			cout << "Перший парний елемент = " << arr.EvenOrOddCheck(true) << "\n";
			arr.Show();
			break;
		case 64:
			system("cls");
			cout << "Перший непарний елемент = " << arr.EvenOrOddCheck(false) << "\n";
			arr.Show();
			break;
		case 65:
			system("cls");
			cout << "Перший додатній елемент = " << arr.PositiveCheck(true) << "\n";
			arr.Show();
			break;
		case 66:
			system("cls");
			cout << "Перший від'ємний елемент = " << arr.PositiveCheck(false) << "\n";
			arr.Show();
			break;
		case 67:
			system("cls");
			cout << "Введіть елемент: ";
			cin >> element;
			cout << "\nЕлементи, рівні заданому:\n";
			arr.Search(element);
			arr.Show();
			break;
		case 7:
			system("cls");
			arr.ArrayDelete();
			break;
		case 8:
			system("cls");
			arr.Close();
			system("pause");
			break;
		}
	}
}
