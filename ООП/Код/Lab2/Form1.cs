using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";

            string[] fontSizeValues = { "10", "12", "14", "16", "18", "20", "22", "24", "28" };
            comboBoxFontSize.Items.AddRange(fontSizeValues);

            string[] fontStyles = { "Bold", "Italic", "Underline" };
            comboBoxFontStyle.Items.AddRange(fontStyles);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void показатиКількістьСлівУТекстіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отримати текст з RichTextBox
            string text = richTextBox1.Text;

            // Підрахувати кількість слів
            int wordCount = GetWordCount(text);

            textBox1.Text = "" + wordCount;
        }

        private void зберегтиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("Файл збережено!");
        }

        private void відкритиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            richTextBox1.Text = fileText;
            MessageBox.Show("Файл відкрито!");
        }

        private void завершитиРоботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void змінитиКолірТекстуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFontSize.SelectedItem != null)
            {
                int fontSize = int.Parse(comboBoxFontSize.SelectedItem.ToString());
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle fontStyle = currentFont.Style;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, fontSize, fontStyle);
            }
        }

        private void comboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFontSize.SelectedItem != null)
            {
                int fontSize = int.Parse(comboBoxFontSize.SelectedItem.ToString());
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, fontSize);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFontStyle.SelectedItem != null)
            {
                string selectedStyle = comboBoxFontStyle.SelectedItem.ToString();

                FontStyle fontStyle = FontStyle.Regular;

                if (selectedStyle == "Bold")
                {
                    fontStyle = FontStyle.Bold;
                }
                else if (selectedStyle == "Italic")
                {
                    fontStyle = FontStyle.Italic;
                }
                else if (selectedStyle == "Underline")
                {
                    fontStyle = FontStyle.Underline;
                }

                richTextBox1.SelectionFont = new Font(richTextBox1.Font, fontStyle);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Отримати текст з RichTextBox
            string text = richTextBox1.Text;

            // Підрахувати кількість слів
            int wordCount = GetWordCount(text);

            textBox1.Text = "" + wordCount;
        }
        private int GetWordCount(string text)
        {
            // Розділити текст на окремі слова за допомогою пробілів
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Підрахувати кількість слів
            return words.Length;
        }
        private int GetLetterCount(string text)
        {
            // Видалити пробіли з тексту
            string textWithoutSpaces = text.Replace(" ", string.Empty);

            // Підрахувати кількість літер
            return textWithoutSpaces.Length;
        }

        private void кількістьЛітерУТекстіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отримати текст з RichTextBox
            string text = richTextBox1.Text;

            // Підрахувати кількість літер
            int letterCount = GetLetterCount(text);

            textBox2.Text = "" + letterCount;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Отримати текст з RichTextBox
            string text = richTextBox1.Text;

            // Підрахувати кількість літер
            int letterCount = GetLetterCount(text);

            textBox1.Text = "" + letterCount;
        }

        private void скасуватиФорматуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxFontSize.SelectedItem != null)
            {
                comboBoxFontSize.Text = "10";
                int fontSize = 10;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, fontSize);

                // Встановлюємо колір тексту за замовчуванням
                richTextBox1.SelectionColor = SystemColors.ControlText;
            }
        }

        private void FindWords(string letter)
        {
            // Отримати текст з поля Memo
            string memoText = richTextBox1.Text;

            // Розділити текст на окремі слова
            string[] words = memoText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Очистити список №2 перед заповненням
            listBox1.Items.Clear();

            // Пройти по кожному слову і перевірити, чи містить воно введену літеру
            foreach (string word in words)
            {
                if (word.Contains(letter))
                {
                    // Додати слово в список №2
                    listBox1.Items.Add(word);
                }
            }
        }

        private void знайтиСловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string letter = editTextBox.Text;
            FindWords(letter);
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void перекластиТекстУВерхнійРегістерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отримати текст з поля Memo
            string memoText = richTextBox1.Text;

            // Перевести текст в верхній регістр
            string upperCaseText = memoText.ToUpper();

            // Встановити перетворений текст назад у поле Memo
            richTextBox1.Text = upperCaseText;
        }
    }
}