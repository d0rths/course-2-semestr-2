using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TrackBar = System.Windows.Forms.TrackBar;
using static WindowsFormsApp1.ProjectilesBase;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Projectile> projectiles; // Список об'єктів Projectile

        public Form1()
        {
            InitializeComponent();

            projectiles = new List<Projectile>(); // Ініціалізація списку

            // Елемент TrackBar (з ім'ям trackBarFlightTime)
            TrackBar trackBar1 = new TrackBar();
            trackBar1.Minimum = 0; // Мінімальне значення - 1 секунда
            trackBar1.Maximum = 100; // Максимальне значення - 100 секунд
            trackBar1.TickFrequency = 1; // Інтервал між позначками трекбара
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            this.Controls.Add(trackBar1);

            // Додати на форму елемент Label (з ім'ям labelFlightTime)
            Label labelFlightTime = new Label();
            labelFlightTime.Text = "Flight Time: " + trackBar1.Value + " seconds";
            this.Controls.Add(labelFlightTime);

            // Додати значення в crossSectionalAreaComboBox
            crossSectionalAreaComboBox.Items.Add("155");
            crossSectionalAreaComboBox.Items.Add("152");
            crossSectionalAreaComboBox.Items.Add("122");

            // Встановити початкове значення
            crossSectionalAreaComboBox.SelectedIndex = 0;
        }

        public class Projectile
        {
            // Властивості снаряду
            public string Name { get; set; } // Назва снаряду
            public float Mass { get; set; } // Маса снаряду
            public float CrossSectionalArea { get; set; } // Площа розрізу снаряда
            public float InitialVelocity { get; set; } // Початкова швидкість
            public float DragCoefficient { get; set; } // Коефіціент опору


            // Конструктор класу
            public Projectile(string name, float mass, float crossSectionalArea, float initialVelocity, float dragCoefficient)
            {
                Name = name;
                Mass = mass;
                CrossSectionalArea = crossSectionalArea;
                InitialVelocity = initialVelocity;
                DragCoefficient = dragCoefficient;
            }
            // Метод для збереження даних про снаряд у файл
            public void SaveToFile(string fileName)
            {
                try
                {
                    // Відкриваємо файл для запису
                    using (StreamWriter writer = new StreamWriter(fileName, true))
                    {
                        // Записуємо дані про снаряд
                        string line = $"{Name} {Mass} {CrossSectionalArea} {InitialVelocity} {DragCoefficient}";
                        writer.WriteLine(line);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Під час збереження даних про снаряд сталася помилка:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Метод для завантаження всіх снарядів з файлу
            public static List<Projectile> LoadFromFile(string fileName)
            {
                List<Projectile> projectiles = new List<Projectile>();

                try
                {
                    // Зчитуємо всі рядки з файлу
                    string[] lines = File.ReadAllLines(fileName);

                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            // Розбиваємо рядок на компоненти
                            string[] values = line.Split(' ');

                            if (values.Length == 5)
                            {
                                // Перевіряємо типи даних та отримуємо значення
                                string name = values[0];
                                float mass, crossSectionalArea, initialVelocity, dragCoefficient;

                                if (float.TryParse(values[1], out mass) &&
                                    float.TryParse(values[2], out crossSectionalArea) &&
                                    float.TryParse(values[3], out initialVelocity) &&
                                    float.TryParse(values[4], out dragCoefficient))
                                {
                                    // Створюємо об'єкт Projectile та додаємо його до списку
                                    Projectile projectile = new Projectile(name, mass, crossSectionalArea, initialVelocity, dragCoefficient);
                                    projectiles.Add(projectile);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження даних про снаряди: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return projectiles;
            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Перевірка текстових полів на наявність даних
            if (nameTextBox.Text == "" || massTextBox.Text == "" || crossSectionalAreaComboBox.SelectedItem.ToString() == "" || initialVelocityTextBox.Text == "" || dragCoefficientTextBox.Text == "")
            {
                MessageBox.Show("Поля з даними порожні.", "Помилка!");
                return;
            }

            // Отримуємо значення з TextBox
            string name = nameTextBox.Text;
            float mass, crossSectionalArea, initialVelocity, dragCoefficient;

            string CSA = crossSectionalAreaComboBox.SelectedItem.ToString();
            crossSectionalArea = float.Parse(CSA);

            // Перевірка типу даних і конвертація значень
            if (!ValidateFloatInput(massTextBox.Text, out mass))
            {
                MessageBox.Show("Недійсне значення для маси. Введіть дійсне число з плаваючою комою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidateFloatInput(initialVelocityTextBox.Text, out initialVelocity))
            {
                MessageBox.Show("Недійсне значення для початкової швидкості. Введіть дійсне число з плаваючою комою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidateFloatInput(dragCoefficientTextBox.Text, out dragCoefficient))
            {
                MessageBox.Show("Недійсне значення для коефіцієнта опору. Введіть дійсне число з плаваючою комою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створюємо об'єкт Projectile зі значеннями з TextBox
            Projectile projectile = new Projectile(name, mass, crossSectionalArea, initialVelocity, dragCoefficient);

            // Додаємо об'єкт Projectile до списку
            projectiles.Add(projectile);

            // Очищаємо TextBox
            nameTextBox.Text = string.Empty;
            massTextBox.Text = string.Empty;
            initialVelocityTextBox.Text = string.Empty;
            dragCoefficientTextBox.Text = string.Empty;

            // Додаємо назву снаряду до ComboBox
            comboBox1.Items.Add(name);
        }
        // Метод для перевірки даних на тип в текстовому полі
        private bool ValidateFloatInput(string input, out float result)
        {
            return float.TryParse(input, out result);
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Відкриваємо діалогове вікно для вибору файлу для збереження
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save Projectile Data";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                // Зберігаємо дані про всі снаряди у файл
                foreach (Projectile projectile in projectiles)
                {
                    projectile.SaveToFile(fileName);
                }
            }
            MessageBox.Show("Дані про снаряд успішно збережено.", "Збереження даних", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Відкриваємо діалогове вікно для вибору файлу для завантаження
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "Load Projectile Data";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                // Викликаємо метод LoadAllFromFile класу Projectile для завантаження всіх снарядів з файлу
                List<Projectile> loadedProjectiles = Projectile.LoadFromFile(fileName);

                if (loadedProjectiles.Count > 0)
                {
                    // Очищаємо список снарядів та ComboBox
                    projectiles.Clear();
                    comboBox1.Items.Clear();

                    // Додаємо завантажені снаряди до списку та ComboBox
                    projectiles.AddRange(loadedProjectiles);
                    foreach (Projectile projectile in loadedProjectiles)
                    {
                        comboBox1.Items.Add(projectile.Name);
                    }

                    MessageBox.Show("Усі дані про снаряди успішно завантажено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("У файлі не знайдено дійсних даних про снаряди.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // Оновлення значення мітки з часом польоту
            Label labelFlightTime = this.Controls.Find("labelFlightTime", true).FirstOrDefault() as Label;
            TrackBar trackBar1 = sender as TrackBar;

            if (labelFlightTime != null)
            {
                labelFlightTime.Text = "Час польоту: " + trackBar1.Value + " секунд";
            }
        }
        private void CalculateProjectileFlight()
        {
            string selectedProjectileName = comboBox1.SelectedItem.ToString();

            // Знаходження обраного снаряда за назвою
            Projectile selectedProjectile = projectiles.FirstOrDefault(p => p.Name == selectedProjectileName);

            if (selectedProjectile != null)
            {
                float mass = selectedProjectile.Mass;
                float dragCoefficient = selectedProjectile.DragCoefficient;
                float crossSectionalArea = selectedProjectile.CrossSectionalArea;
                float initialVelocity = selectedProjectile.InitialVelocity;
                float angle = float.Parse(angleTextBox.Text);
                float flightTime = trackBar1.Value;

                if (crossSectionalArea == 155)
                {
                    crossSectionalArea = 0.01875f;
                }
                else if (crossSectionalArea == 152)
                {
                    crossSectionalArea = 0.01811f;
                }
                else if (crossSectionalArea == 122)
                {
                    crossSectionalArea = 0.01173f;
                }

                // Приклад даних про польот снаряда
                List<PointF> flightData = new List<PointF>(); 
                float g = 9.8f; // Прискорення вільного падіння

                for (float t = 0; t <= flightTime; t += 0.1f)
                {
                    float x = initialVelocity * (float)Math.Cos(angle * Math.PI / 180) * t; // Обчислення координати X
                    float y = initialVelocity * (float)Math.Sin(angle * Math.PI / 180) * t - 0.5f * g * t * t; // Обчислення координати Y

                    // Застосування формули для врахування опору повітря
                    float velocity = (float)Math.Sqrt(Math.Pow(initialVelocity * Math.Cos(angle * Math.PI / 180), 2) +
                                                       Math.Pow(initialVelocity * Math.Sin(angle * Math.PI / 180) - g * t, 2));
                    float dragForce = 0.5f * dragCoefficient * crossSectionalArea * velocity * velocity;
                    float acceleration = -dragForce / mass;
                    y += 0.5f * acceleration * t * t;

                    flightData.Add(new PointF(x, y));
                }

                // Отримання максимальних значень координат
                float maxX = flightData.Max(point => point.X);
                float maxY = flightData.Max(point => point.Y);

                // Створення нового графіку
                Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Очищення графіку
                    graphics.Clear(Color.White);

                    // Налаштування розмітки
                    Pen axisPen = new Pen(Color.Black);
                    Font axisFont = new Font("Arial", 10);
                    Brush axisBrush = new SolidBrush(Color.Black);

                    // Позначення осей координат
                    graphics.DrawLine(axisPen, 20, bitmap.Height - 20, 20, 20); // Вертикальна вісь X
                    graphics.DrawLine(axisPen, 20, bitmap.Height - 20, bitmap.Width - 20, bitmap.Height - 20); // Горизонтальна вісь Y

                    // Розмітка вертикальної вісі (X)
                    float stepX = maxX / 10;
                    for (float i = 0; i <= maxX; i += stepX)
                    {
                        int x = (int)(i + 20);
                        graphics.DrawLine(axisPen, x, bitmap.Height - 20, x, bitmap.Height - 15); // Мітка на вісі X
                        graphics.DrawString(i.ToString("F1"), axisFont, axisBrush, x * bitmap.Width / maxX - 10, bitmap.Height - 15); // Підпис під міткою
                    }

                    // Розмітка горизонтальної вісі (Y)
                    float stepY = maxY / 50;
                    for (float i = 0; i <= maxY; i += stepY)
                    {
                        int y = (int)(bitmap.Height - 20 - i);
                        graphics.DrawLine(axisPen, 15, y, 20, y); // Мітка на вісі Y
                        graphics.DrawString(i.ToString("F1"), axisFont, axisBrush, 0, y - 7); // Підпис біля мітки
                    }

                    // Налаштування лінії графіка
                    Pen linePen = new Pen(Color.Red);

                    // Малювання лінії графіка
                    for (int i = 1; i < flightData.Count; i++)
                    {
                        PointF startPoint = flightData[i - 1];
                        PointF endPoint = flightData[i];
                        graphics.DrawLine(linePen, startPoint.X * bitmap.Width / maxX + 20, bitmap.Height - startPoint.Y * bitmap.Height / maxY - 20,
                  endPoint.X * bitmap.Width / maxX + 20, bitmap.Height - endPoint.Y * bitmap.Height / maxY - 20);

                    }
                }

                // Визначення дальності польоту
                PointF arrivePoint = PointF.Empty;
                float range = 0;
                for (int i = 1; i < flightData.Count; i++)
                {
                    PointF previousPoint = flightData[i - 1];
                    PointF currentPoint = flightData[i];

                    if (previousPoint.Y >= 0 && currentPoint.Y <= 0)
                    {
                        float пропорція = (0 - previousPoint.Y) / (currentPoint.Y - previousPoint.Y);
                        range = previousPoint.X + пропорція * (currentPoint.X - previousPoint.X);
                        arrivePoint = new PointF(range, 0);
                        break;
                    }
                }
                labelRange.Text = $"Дальність: {range} м";

                // Збереження графіку в директорії проекта
                SaveGraph(bitmap, selectedProjectile, angle);

                // Відображення графіку
                pictureBox1.Image = bitmap;
            }
        }
        public void SaveGraph(Bitmap bitmap, Projectile selectedProjectile, float angle)
        {
            // Генерування унікального імені для зображення
            string imageName = $"{selectedProjectile.Name}_{angle}degrees.png";

            // Отримання шляху до папки "Графіки" у вашому проекті
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Graphs");

            // Переконайтеся, що папка існує, інакше створіть її
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Збереження зображення у папку "Графіки" з унікальним іменем
            string imagePath = Path.Combine(folderPath, imageName);
            bitmap.Save(imagePath);
        }

        public void UpdateProjectile(Projectile updatedProjectile)
        {
            int index = projectiles.FindIndex(p => p.Name == updatedProjectile.Name);
            if (index >= 0)
            {
                projectiles[index] = updatedProjectile;
            }
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Оберіт снаряд зі списку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (angleTextBox.Text == "")
            {
                MessageBox.Show("Введіть кут відхилення снаряду.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CalculateProjectileFlight();
        }

        private void даніПроСнарядиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectilesBase projectilesBase = new ProjectilesBase(this);
            projectilesBase.LoadData(projectiles); // Передача списку projectiles до Form2
            projectilesBase.Show();
        }
        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void завершенняРоботиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
