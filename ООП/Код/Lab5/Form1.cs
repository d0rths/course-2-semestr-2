using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public string filePath;
        OleDbConnection dbConnection;
        List<string[]> dataRows = new List<string[]>();
        List<string[]> dataRows2 = new List<string[]>();
        public Form1()
        {
            InitializeComponent();


        }

        public void �������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filePath = "����.accdb";
        }

        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ��������� �'�������
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath}"; // ������ �'�������
            dbConnection = new OleDbConnection(connectionString); // ��������� �'�������
        }

        private void ��������������1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            dbConnection.Open();
            string query = "SELECT * FROM ����";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("����� �� ��������!", "�������!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView2.Rows.Add(dbReader["�����"], dbReader["�������"], dbReader["���������"], dbReader["������"]);
                }
            }

            dbReader.Close();
            dbConnection.Close();

            // ���������� ���������� ������ �����
            dataRows2 = DataBackupList(dataGridView2, dataRows2);
        }

        private void ��������������2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // ��������� ������� � DataGridView1
            dataGridView1.Columns.Add("Column1", "�����");
            dataGridView1.Columns.Add("Column2", "�������");
            dataGridView1.Columns.Add("Column3", "���������");
            dataGridView1.Columns.Add("Column4", "������");

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridView1.Columns[0].FillWeight = 20;
            dataGridView1.Columns[1].FillWeight = 40;
            dataGridView1.Columns[2].FillWeight = 40;
            dataGridView1.Columns[3].FillWeight = 20;


            // ��������� ����� � DataGridView1
            dataGridView1.Rows.Add("ʲ-21", "�������", "����'������ �����", "3");
            dataGridView1.Rows.Add("ʲ-21", "�����", "����'������ �����������", "5");
            dataGridView1.Rows.Add("ʲ-21", "�������", "����'������ �����", "4");
            dataGridView1.Rows.Add("ʲ-21", "���������", "����������", "3");
            dataGridView1.Rows.Add("ʲ-21", "��������", "�����������", "5");

            // ���������� ���������� ������ �����
            dataRows = DataBackupList(dataGridView1, dataRows);
        }

        private List<string[]> DataBackupList(DataGridView dataGridView, List<string[]> dRows)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                string[] rowData = new string[dataGridView.Columns.Count];

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    // ����������, �� ������ �� � null
                    if (row.Cells[i].Value != null)
                    {
                        rowData[i] = row.Cells[i].Value.ToString();
                    }
                    else
                    {
                        rowData[i] = string.Empty; // ��� ���� �������� �� �������������
                    }
                }

                dRows.Add(rowData);
            }
            return dRows;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // �������� ����� �� ������ � TextBox
            string filter = textBox1.Text;

            // �������� ������ ����� � DataGridView2
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();

            foreach (string[] rowData in dataRows2)
            {
                if (rowData[0] != "")
                {
                    // ������ �� ������� ������ �����
                    string group = rowData[0];
                    string surname = rowData[1];
                    string discipline = rowData[2];
                    string grade = rowData[3];

                    if (Int32.Parse(grade) > Int32.Parse(filter))
                    {
                        dataGridView2.Rows.Add(group, surname, discipline, grade);
                    }
                }
                else
                    break;
            }
            dataRows2 = DataBackupList(dataGridView2, dataRows2);

            foreach (string[] rowData in dataRows)
            {
                if (rowData[0] != "")
                {
                    // ������ �� ������� ������ �����
                    string group = rowData[0];
                    string surname = rowData[1];
                    string discipline = rowData[2];
                    string grade = rowData[3];

                    if (Int32.Parse(grade) > Int32.Parse(filter))
                    {
                        dataGridView1.Rows.Add(group, surname, discipline, grade);
                    }
                }
                else
                    break;
            }
            dataRows = DataBackupList(dataGridView1, dataRows);
        }

        private void �����������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filter = textBox1.Text;
            string group_filter = textBox2.Text;

            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();

            foreach (string[] rowData in dataRows2)
            {
                if (rowData[0] != "")
                {
                    // ������ �� ������� ������ �����
                    string group = rowData[0];
                    string surname = rowData[1];
                    string discipline = rowData[2];
                    string grade = rowData[3];

                    if (Int32.Parse(grade) < Int32.Parse(filter) && group == group_filter)
                    {
                        dataGridView2.Rows.Add(group, surname, discipline, '1');
                    }
                    else
                    {
                        dataGridView2.Rows.Add(group, surname, discipline, grade);
                    }
                }
                else
                    break;
            }
            dataRows2 = DataBackupList(dataGridView2, dataRows2);

            foreach (string[] rowData in dataRows)
            {
                if (rowData[0] != "")
                {
                    // ������ �� ������� ������ �����
                    string group = rowData[0];
                    string surname = rowData[1];
                    string discipline = rowData[2];
                    string grade = rowData[3];

                    if (Int32.Parse(grade) < Int32.Parse(filter) && group == group_filter)
                    {
                        dataGridView1.Rows.Add(group, surname, discipline, '1');
                    }
                    else
                    {
                        dataGridView1.Rows.Add(group, surname, discipline, grade);
                    }
                }
                else
                    break;
            }
            dataRows = DataBackupList(dataGridView1, dataRows);
        }

        private void ���������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();

            string filter = textBox1.Text;

            foreach (string[] rowData in dataRows2)
            {
                if (rowData[0] != "")
                {
                    // ������ �� ������� ������ �����
                    string group = rowData[0];
                    string surname = rowData[1];
                    string discipline = rowData[2];
                    string grade = rowData[3];

                    if (Int32.Parse(grade) != Int32.Parse(filter))
                    {
                        dataGridView2.Rows.Add(group, surname, discipline, grade);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                    break;
            }
            foreach (string[] rowData in dataRows)
            {
                if (rowData[0] != "")
                {
                    // ������ �� ������� ������ �����
                    string group = rowData[0];
                    string surname = rowData[1];
                    string discipline = rowData[2];
                    string grade = rowData[3];

                    if (Int32.Parse(grade) != Int32.Parse(filter))
                    {
                        dataGridView1.Rows.Add(group, surname, discipline, grade);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                    break;
            }
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dbConnection.Close();
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ���������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string group = textBox2.Text;
            string surname = textBox3.Text;
            string discipline = textBox4.Text;
            string grade = textBox1.Text;

            if (textBox5.Text == "1")
            {
                dataGridView1.Rows.Add(group, surname, discipline, grade);
                dataRows = DataBackupList(dataGridView1, dataRows);
            }
            else if (textBox5.Text == "2")
            {
                dataGridView2.Rows.Add(group, surname, discipline, grade);
                dataRows2 = DataBackupList(dataGridView2, dataRows2);
            }
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }
    }
}