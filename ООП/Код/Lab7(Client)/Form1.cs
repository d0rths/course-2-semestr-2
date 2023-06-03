using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7_Client_
{
    public partial class Form1 : Form
    {
        private const string defaultIpAdress = "127.0.0.1";
        private const int defaultPort = 8888;
        private const string defaultLogin = "admin";
        private const string defaultPassword = "1234";

        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonClientConnect_Click(object sender, EventArgs e)
        {
            string ip = Edit2.Text;
            int port = Convert.ToInt32(Edit1.Text);
            string login = Edit4.Text;
            string password = Edit5.Text;

            if (ConnectToServer(ip, port, login, password))
            {
                // З'єднання встановлено
                buttonClientConnect.Enabled = false;
                button2.Enabled = true;
                Edit3.Enabled = true;
                labelConnectionStatus.Text = "Connected to server.";
                labelConnectionStatus.ForeColor = Color.LightGreen;
            }
        }
        private bool ConnectToServer(string ip, int port, string login, string password)
        {
            try
            {
                client = new TcpClient();
                client.Connect(ip, port);

                NetworkStream networkStream = client.GetStream();
                reader = new StreamReader(networkStream);
                writer = new StreamWriter(networkStream);

                // Надсилаємо логін та пароль серверу
                writer.WriteLine($"{login};{password}");
                writer.Flush();

                // Отримуємо відповідь від серверу
                string response = reader.ReadLine();

                if (response == "OK")
                {
                    // Вдало авторизовано
                    return true;
                }
                else
                {
                    // Помилка авторизації
                    MessageBox.Show(response, "Error");
                    DisconnectFromServer();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Помилка підключення до сервера
                MessageBox.Show($"An error occurred while connecting to the server: {ex.Message}", "Error");
                return false;
            }
        }

        private void DisconnectFromServer()
        {
            // Закриваємо з'єднання з сервером
            writer?.Close();
            reader?.Close();
            client?.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectFromServer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string request = Edit3.Text;

            if (!string.IsNullOrEmpty(request))
            {
                try
                {
                    // Надсилаємо запит до сервера
                    writer.WriteLine(request);
                    writer.Flush();

                    // Отримуємо відповідь від сервера
                    string response = reader.ReadLine();
                    MessageBox.Show(response, "Response");
                }
                catch (Exception ex)
                {
                    // Помилка взаємодії з сервером
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}", "Error");
                }
            }
        }
    }
}
