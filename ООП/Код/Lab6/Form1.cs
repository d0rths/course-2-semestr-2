using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.Data.Common;
using Access = Microsoft.Office.Interop.Access;
using DAO = Microsoft.Office.Interop.Access.Dao;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private string connectionString = string.Empty;
        OleDbConnection connection;
        int studentCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void встановитиШляхДоБазиДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Файли баз даних Access (*.mdb, *.accdb)|*.mdb;*.accdb|Всі файли (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog.FileName + ";Persist Security Info=False;";
                    textBoxDatabasePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void підключитиБазуДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Будь ласка, виберіть шлях до бази даних.");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Підключення до бази даних успішне!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при підключенні до бази даних: " + ex.Message);
            }
        }

        private void завантажитиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Будь ласка, спочатку виберіть шлях до бази даних.");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Створення запиту SQL для вибірки даних
                    string query = "SELECT * FROM Сесія";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        // Створення DataSet для збереження даних
                        DataSet dataSet = new DataSet();

                        // Заповнення таблиці з бази даних в DataSet
                        adapter.Fill(dataSet);

                        // Встановлення даних з DataSet в dataGridView1
                        dataGridView1.DataSource = dataSet.Tables[0];
                    }

                    MessageBox.Show("Дані були успішно завантажені!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при завантаженні даних: " + ex.Message);
            }
        }

        public void ReportGenerate()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Будь ласка, спочатку виберіть шлях до бази даних.");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Створення об'єкта Access.Application
                    Access.Application accessApp = new Access.Application();

                    // Відкриття бази даних Access
                    accessApp.OpenCurrentDatabase(connection.DataSource);

                    // Виклик запиту для отримання кількості студентів
                    string countQuery = "SELECT COUNT(*) FROM Сесія";

                    DAO.Database accessDb = accessApp.CurrentDb();
                    DAO.Recordset countRecordset = accessDb.OpenRecordset(countQuery);
                    studentCount = countRecordset.Fields[0].Value;

                    countRecordset.Close();

                    // Виклик звіту
                    accessApp.DoCmd.OpenReport("Звіт", Access.AcView.acViewPreview);

                    // Відображення вікна Access
                    accessApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при генерації звіту: " + ex.Message);
            }
        }

        private void застосуватиЗапитНаВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Будь ласка, спочатку виберіть шлях до бази даних.");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = textBox1.Text; // Отримуємо текст запиту з textBox1

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        // Створюємо DataSet для збереження даних
                        DataSet dataSet = new DataSet();

                        // Заповнюємо таблицю з бази даних в DataSet
                        adapter.Fill(dataSet);

                        // Встановлюємо дані з DataSet в dataGridView1
                        dataGridView1.DataSource = dataSet.Tables[0];
                    }

                    MessageBox.Show("Запит на вибірку було успішно застосовано!");

                    ReportGenerate();

                    // Оновлюємо кількість студентів
                    studentCount = dataGridView1.Rows.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при застосуванні запиту на вибірку: " + ex.Message);
            }
        }

        private void застосуватиЗапитНаМодифікаціюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Будь ласка, спочатку виберіть шлях до бази даних.");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = textBox1.Text; // Отримуємо текст запиту з textBox1

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Запит на модифікацію було успішно застосовано. Змінено " + rowsAffected + " рядків.");

                            LoadData();

                            ReportGenerate();

                            // Оновлюємо кількість студентів
                            studentCount = dataGridView1.Rows.Count - 1;
                        }
                        else
                        {
                            MessageBox.Show("Запит на модифікацію не змінив жодного рядка.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при застосуванні запиту на модифікацію: " + ex.Message);
            }
        }
        private void LoadData()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Будь ласка, спочатку виберіть шлях до бази даних.");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Створення запиту SQL для вибірки даних
                    string query = "SELECT * FROM Сесія";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        // Створення DataSet для збереження даних
                        DataSet dataSet = new DataSet();

                        // Заповнення таблиці з бази даних в DataSet
                        adapter.Fill(dataSet);

                        // Встановлення даних з DataSet в dataGridView1
                        dataGridView1.DataSource = dataSet.Tables[0];
                    }

                    MessageBox.Show("Дані були успішно оновлені!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при оновленні даних: " + ex.Message);
            }
        }

        private void відєднатиБазуДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очистити сітку dataGridView1
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Від'єднати базу даних
            connectionString = string.Empty;
        }

        private void завершитиРоботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }
    }
}
