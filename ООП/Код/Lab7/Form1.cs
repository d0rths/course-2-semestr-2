using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lab7
{
    public partial class Form1 : Form
    {
        // Змінні, що зберігають значення за замовчуванням для логіна, пароля та IP-адреси
        private const string defaultLogin = "admin";
        private const string defaultPassword = "1234";
        private const string defaultIpAdress = "127.0.0.1";

        // Сокет сервера і прапор, що вказує, чи виконано вхід
        private Socket serverSocket;
        private bool isLoggedIn = false;

        // З'єднання з базою даних
        private OleDbConnection dbConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Edit1.Text = "";

            

        }

        // Метод, який запускає сервер у окремому потоці
        private void StartServer()
        {
            try
            {
                // Запускаємо клієнтську програму у новому процесі
                string clientApplicationPath = "H:\\University\\2 курс\\2 семестр\\ООП\\Код\\Lab7(Client)\\bin\\Debug\\Lab7(Client).exe";
                Process.Start(clientApplicationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Під час запуску клієнтської програми сталася помилка: {ex.Message}", "Помилка");
            }

            try
            {
                // Створюємо сокет сервера, прив'язуємо його до IP-адреси та порту і слухаємо підключення
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Parse(defaultIpAdress), GetPort()));
                serverSocket.Listen(1);

                // Оновлюємо інтерфейс користувача для показу статусу сервера
                Invoke(new Action(() =>
                {
                    buttonConnect.Enabled = false;
                    labelSessionStatus.Text = $"Серверний сокет успішно ініціалізовано. {defaultIpAdress}:{GetPort()}";
                    labelSessionStatus.ForeColor = Color.LightGreen;
                }));

                while (true)
                {
                    // Приймаємо підключення клієнта і запускаємо для нього окремий потік
                    Socket clientSocket = serverSocket.Accept();
                    Thread clientThread = new Thread(HandleClient);
                    clientThread.Start(clientSocket);
                }
            }
            catch (Exception ex)
            {

            }
        }

        // Метод, що обробляє підключення клієнта
        private void HandleClient(object clientSocketObj)
        {
            Socket clientSocket = (Socket)clientSocketObj;

            try
            {
                // Створюємо потоки для зчитування та запису даних через мережу
                using (NetworkStream networkStream = new NetworkStream(clientSocket))
                using (StreamReader reader = new StreamReader(networkStream))
                using (StreamWriter writer = new StreamWriter(networkStream))
                {
                    while (true)
                    {
                        string request = reader.ReadLine();
                        if (request == null)
                            break;

                        string response = ProcessRequest(request); // Обробляємо отриманий запит
                        writer.WriteLine(response); // Відправляємо відповідь клієнту
                        writer.Flush();
                    }
                }
            }
            catch (IOException)
            {
                // З'єднання закрите клієнтом
            }
            finally
            {
                clientSocket.Close();
            }
        }

        // Метод, який обробляє запити від клієнта
        private string ProcessRequest(string request)
        {
            if (!isLoggedIn) // Якщо входу не виконано
            {
                string[] credentials = request.Split(';');
                string login = credentials[0];
                string password = credentials[1];

                if (login == defaultLogin && password == defaultPassword) // Перевіряємо логін та пароль
                {
                    isLoggedIn = true;

                    // Підключаємося до бази даних
                    try
                    {
                        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Сесія.accdb;";
                        dbConnection = new OleDbConnection(connectionString);
                        dbConnection.Open();
                    }
                    catch (Exception ex)
                    {
                        return $"Під час підключення до бази даних сталася помилка: {ex.Message}";
                    }
                }
                else
                {
                    return "Неправильне ім'я користувача або пароль.";
                }
            }

            if (request == "колір")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK) // Показуємо діалогове вікно для вибору кольору
                {
                    Invoke(new Action(() => { this.BackColor = colorDialog1.Color; })); // Змінюємо колір форми
                }
            }
            else if (request == "шрифт")
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK) // Показуємо діалогове вікно для вибору шрифту
                {
                    Invoke(new Action(() => { labelSessionStatus.Font = fontDialog1.Font; })); // Змінюємо шрифт надпису
                }
            }
            else if (request == "текст")
            {
                try
                {
                    string text = File.ReadAllText("text.txt"); // Зчитуємо текст з файлу
                    Invoke(new Action(() => { richTextBox1.Text = text; })); // Відображаємо текст у RichTextBox
                }
                catch (Exception ex)
                {
                    return $"Під час завантаження текстового файлу сталася помилка: {ex.Message}";
                }
            }
            else if (request == "малюнок")
            {
                try
                {
                    string imagePath = "Gumball.jpg";
                    if (File.Exists(imagePath))
                    {
                        Image image = Image.FromFile(imagePath); // Завантажуємо зображення з файлу
                        Invoke(new Action(() =>
                        {
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Image = image; // Відображаємо зображення в PictureBox
                        }));
                    }
                    else
                    {
                        return "Файл зображення не знайдено.";
                    }
                }
                catch (Exception ex)
                {
                    return $"Під час завантаження зображення сталася помилка: {ex.Message}";
                }
            }
            else
            {
                if (isLoggedIn) // Якщо вхід виконано
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(request, dbConnection)) // Виконуємо запит до бази даних
                        {
                            adapter.Fill(dataTable); // Заповнюємо таблицю результатами запиту
                        }

                        Invoke(new Action(() => { dataGridView1.DataSource = dataTable; })); // Відображаємо результати запиту у DataGridView
                    }
                    catch (Exception ex)
                    {
                        // Обробка помилок під час виконання запиту до бази даних
                    }
                }
            }

            return "OK"; // Повертаємо відповідь клієнту
        }

        private int GetPort()
        {
            if (int.TryParse(Edit1.Text, out int port))
            {
                if (port < 1 || port > 65535)
                {
                    Invoke(new Action(() =>
                    {
                        labelSessionStatus.Text = "Неправильний номер порту. Будь ласка, введіть правильний порт.";
                        labelSessionStatus.ForeColor = Color.Red;
                    }));
                }
                else
                {
                    return port;
                }
            }
            else
            {
                Invoke(new Action(() =>
                {
                    labelSessionStatus.Text = "Неправильний номер порту. Будь ласка, введіть правильний порт.";
                    labelSessionStatus.ForeColor = Color.Red;
                }));
            }

            return 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закриття ресурсів при закритті форми
            serverSocket?.Close(); // Закриваємо серверний сокет, якщо він відкритий
            dbConnection?.Close(); // Закриваємо з'єднання з базою даних, якщо воно відкрите
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(StartServer); // Запускаємо сервер у окремому потоці
            serverThread.Start();
        }

        private void textBoxRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (!isLoggedIn)
                {
                    string login = Edit2.Text;
                    string password = Edit3.Text;

                    if (login == defaultLogin && password == defaultPassword)
                    {
                        isLoggedIn = true;

                        // Підключення до бази даних
                        try
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Сесія.accdb;";
                            dbConnection = new OleDbConnection(connectionString);
                            dbConnection.Open();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Під час підключення до бази даних сталася помилка: {ex.Message}", "Помилка");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невірний логін або пароль.", "Помилка");
                        return;
                    }
                }

                string request = textBoxRequest.Text;
                DialogResult result;

                // Виконання запиту
                if (request == "колір")
                {
                    result = colorDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.BackColor = colorDialog1.Color;
                    }
                }
                if (request == "шрифт")
                {
                    result = fontDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        labelSessionStatus.Font = fontDialog1.Font;
                    }
                }
                if (request == "текст")
                {
                    try
                    {
                        string text = File.ReadAllText("text.txt");
                        richTextBox1.Text = text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Під час завантаження текстового файлу сталася помилка: {ex.Message}", "Помилка");
                    }
                }
                if (request == "малюнок")
                {
                    try
                    {
                        string imagePath = "Gumball.jpg";
                        if (File.Exists(imagePath))
                        {
                            Image image = Image.FromFile(imagePath);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Image = image;
                        }
                        else
                        {
                            MessageBox.Show("Файл зображення не знайдено.", "Помилка");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Під час завантаження зображення сталася помилка: {ex.Message}", "Помилка");
                    }
                }

                if (isLoggedIn)
                {
                    try
                    {
                        // Виконати запит і відобразити результати в сітці
                        OleDbDataAdapter adapter = new OleDbDataAdapter(request, dbConnection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {

                    }
                }

                textBoxRequest.Text = "";
            }
        }
    }
}
