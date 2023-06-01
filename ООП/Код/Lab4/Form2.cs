using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form2 : Form
    {
        private bool isExpanded = false; // Змінна для відстеження стану розширення форми
        private Point originalButtonExpandLocation; // Початкова позиція кнопки
        private Point originalButtonOKLocation; // Початкова позиція кнопки
        public Form2()
        {
            InitializeComponent();
            this.Resize += Form1_Resize; // Підписка на подію Form.Resize

            int buttonTop = dataGridView1.Top + dataGridView1.Height + 10; // Визначення вертикального положення кнопки
            buttonExpand.Location = new Point(buttonExpand.Left, buttonTop); // Встановлення нової позиції кнопки
            buttonOK.Location = new Point(buttonExpand.Right, buttonTop); // Встановлення нової позиції кнопки
            originalButtonExpandLocation = buttonExpand.Location; // Зберегти початкову позицію кнопки
            originalButtonOKLocation = buttonOK.Location; // Зберегти початкову позицію кнопки
            this.Height = 450; // Встановлення вихідної висоти форми
            panel1.Visible = false; // Приховування панелі
            panel2.Visible = false; // Приховування панелі
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int desiredWidth = (int)(this.Width * 0.8); // Обчислення 80% від ширини форми
            dataGridView1.Width = desiredWidth; // Встановлення ширини сітки DataGridView
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            int desiredWidth = (int)(this.Width * 0.8); // Обчислення 80% від ширини форми
            dataGridView1.Width = desiredWidth; // Встановлення ширини сітки DataGridView
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                // Зменшення розміру форми до вихідних значень
                this.Height = 450; // Встановлення вихідної висоти форми
                panel1.Visible = false; // Приховування панелі
                panel2.Visible = false; // Приховування панелі

                buttonExpand.Text = "Більше"; // Зміна тексту кнопки на "Більше"

                // Переміщення кнопок на початкову позицію
                buttonExpand.Location = originalButtonExpandLocation;
                buttonOK.Location = originalButtonOKLocation;

                isExpanded = false; // Встановлення прапорця розширення в "вимкнено"
            }
            else
            {
                // Збільшення розміру форми та відкриття панелі
                this.Height = 480; // Встановлення нової висоти форми
                panel1.Visible = true; // Відображення панелі
                panel2.Visible = true; // Відображення панелі

                buttonExpand.Text = "Менше"; // Зміна тексту кнопки на "Менше"

                // Зміщення кнопки вниз на висоту панелі
                buttonExpand.Location = new Point(originalButtonExpandLocation.X, originalButtonExpandLocation.Y + panel1.Height);
                buttonOK.Location = new Point(originalButtonOKLocation.X, originalButtonOKLocation.Y + panel1.Height);

                isExpanded = true; // Встановлення прапорця розширення в "увімкнено"
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioSave.Checked)
            {
                SaveSelectedRowsToFile("H:\\University\\2 курс\\2 семестр\\ООП\\Код\\Lab4\\selected_rows.txt");
            }
            else if (radioView.Checked)
            {
                ConfigureGridViewAppearance();
            }
        }
        private void SaveSelectedRowsToFile(string filePath)
        {
            // Відкриття файлу для запису
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Проходження по кожному рядку таблиці
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Перевірка, чи рядок є виділеним
                    if (row.Selected)
                    {
                        // Збереження значення рядка у файл
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            string value = row.Cells[j].Value?.ToString() ?? string.Empty;
                            writer.Write(value);

                            if (j < dataGridView1.Columns.Count - 1)
                            {
                                writer.Write(" ");
                            }
                        }

                        writer.WriteLine();
                    }
                }
            }

            // Повідомлення про успішне збереження
            MessageBox.Show("Рядки були успішно збережені у файл.");
        }
        private void ConfigureGridViewAppearance()
        {
            // Задати вікну білий колір
            this.BackColor = Color.White;

            // Задати межам сітки в dataGridView1 чорний колір
            dataGridView1.GridColor = Color.Black;

            // Зменшити вертикальний розмір dataGridView1 до розмірів сітки
            dataGridView1.Height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dataGridView1.ColumnHeadersHeight;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SelectDataGridViewRow(0, checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SelectDataGridViewRow(1, checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SelectDataGridViewRow(2, checkBox3.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            SelectDataGridViewRow(3, checkBox4.Checked);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            SelectDataGridViewRow(4, checkBox5.Checked);
        }

        private void SelectDataGridViewRow(int rowIndex, bool isSelected)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[rowIndex].Selected = isSelected;
            }
        }
    }
}
