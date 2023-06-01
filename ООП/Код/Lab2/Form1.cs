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

        private void ��������ʳ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // �������� ����� � RichTextBox
            string text = richTextBox1.Text;

            // ϳ��������� ������� ���
            int wordCount = GetWordCount(text);

            textBox1.Text = "" + wordCount;
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("���� ���������!");
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            richTextBox1.Text = fileText;
            MessageBox.Show("���� �������!");
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
            // �������� ����� � RichTextBox
            string text = richTextBox1.Text;

            // ϳ��������� ������� ���
            int wordCount = GetWordCount(text);

            textBox1.Text = "" + wordCount;
        }
        private int GetWordCount(string text)
        {
            // �������� ����� �� ����� ����� �� ��������� ������
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // ϳ��������� ������� ���
            return words.Length;
        }
        private int GetLetterCount(string text)
        {
            // �������� ������ � ������
            string textWithoutSpaces = text.Replace(" ", string.Empty);

            // ϳ��������� ������� ����
            return textWithoutSpaces.Length;
        }

        private void �������˳���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // �������� ����� � RichTextBox
            string text = richTextBox1.Text;

            // ϳ��������� ������� ����
            int letterCount = GetLetterCount(text);

            textBox2.Text = "" + letterCount;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // �������� ����� � RichTextBox
            string text = richTextBox1.Text;

            // ϳ��������� ������� ����
            int letterCount = GetLetterCount(text);

            textBox1.Text = "" + letterCount;
        }

        private void ���������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxFontSize.SelectedItem != null)
            {
                comboBoxFontSize.Text = "10";
                int fontSize = 10;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, fontSize);

                // ������������ ���� ������ �� �������������
                richTextBox1.SelectionColor = SystemColors.ControlText;
            }
        }

        private void FindWords(string letter)
        {
            // �������� ����� � ���� Memo
            string memoText = richTextBox1.Text;

            // �������� ����� �� ����� �����
            string[] words = memoText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // �������� ������ �2 ����� �����������
            listBox1.Items.Clear();

            // ������ �� ������� ����� � ���������, �� ������ ���� ������� �����
            foreach (string word in words)
            {
                if (word.Contains(letter))
                {
                    // ������ ����� � ������ �2
                    listBox1.Items.Add(word);
                }
            }
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string letter = editTextBox.Text;
            FindWords(letter);
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void �����������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // �������� ����� � ���� Memo
            string memoText = richTextBox1.Text;

            // ��������� ����� � ������ ������
            string upperCaseText = memoText.ToUpper();

            // ���������� ������������ ����� ����� � ���� Memo
            richTextBox1.Text = upperCaseText;
        }
    }
}