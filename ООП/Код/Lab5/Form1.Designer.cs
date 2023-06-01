namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            підключитиБазуДанихToolStripMenuItem = new ToolStripMenuItem();
            відєднатиБазуДанихToolStripMenuItem = new ToolStripMenuItem();
            завершитиРоботуToolStripMenuItem = new ToolStripMenuItem();
            даніToolStripMenuItem = new ToolStripMenuItem();
            завантажитиДані1ToolStripMenuItem = new ToolStripMenuItem();
            завантажитиДані2ToolStripMenuItem = new ToolStripMenuItem();
            застосуватиЗапитНаВибіркуToolStripMenuItem = new ToolStripMenuItem();
            застосуватиЗапитНаМодифікаціюToolStripMenuItem = new ToolStripMenuItem();
            застосуватиЗапитНаВидаленняToolStripMenuItem = new ToolStripMenuItem();
            застосуватиЗапитНаДодаванняToolStripMenuItem = new ToolStripMenuItem();
            сервісToolStripMenuItem = new ToolStripMenuItem();
            встановитиШляхДоБазиДанихToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            group = new DataGridViewTextBoxColumn();
            student = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataSetBindingSource = new BindingSource(components);
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            groupBox4 = new GroupBox();
            textBox4 = new TextBox();
            groupBox5 = new GroupBox();
            textBox5 = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSetBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, даніToolStripMenuItem, сервісToolStripMenuItem, проПрограмуToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1096, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { підключитиБазуДанихToolStripMenuItem, відєднатиБазуДанихToolStripMenuItem, завершитиРоботуToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // підключитиБазуДанихToolStripMenuItem
            // 
            підключитиБазуДанихToolStripMenuItem.Name = "підключитиБазуДанихToolStripMenuItem";
            підключитиБазуДанихToolStripMenuItem.Size = new Size(203, 22);
            підключитиБазуДанихToolStripMenuItem.Text = "Підключити базу даних";
            підключитиБазуДанихToolStripMenuItem.Click += підключитиБазуДанихToolStripMenuItem_Click;
            // 
            // відєднатиБазуДанихToolStripMenuItem
            // 
            відєднатиБазуДанихToolStripMenuItem.Name = "відєднатиБазуДанихToolStripMenuItem";
            відєднатиБазуДанихToolStripMenuItem.Size = new Size(203, 22);
            відєднатиБазуДанихToolStripMenuItem.Text = "Від'єднати базу даних";
            відєднатиБазуДанихToolStripMenuItem.Click += відєднатиБазуДанихToolStripMenuItem_Click;
            // 
            // завершитиРоботуToolStripMenuItem
            // 
            завершитиРоботуToolStripMenuItem.Name = "завершитиРоботуToolStripMenuItem";
            завершитиРоботуToolStripMenuItem.Size = new Size(203, 22);
            завершитиРоботуToolStripMenuItem.Text = "Завершити роботу";
            завершитиРоботуToolStripMenuItem.Click += завершитиРоботуToolStripMenuItem_Click;
            // 
            // даніToolStripMenuItem
            // 
            даніToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { завантажитиДані2ToolStripMenuItem, завантажитиДані1ToolStripMenuItem, застосуватиЗапитНаВибіркуToolStripMenuItem, застосуватиЗапитНаМодифікаціюToolStripMenuItem, застосуватиЗапитНаВидаленняToolStripMenuItem, застосуватиЗапитНаДодаванняToolStripMenuItem });
            даніToolStripMenuItem.Name = "даніToolStripMenuItem";
            даніToolStripMenuItem.Size = new Size(43, 20);
            даніToolStripMenuItem.Text = "Дані";
            // 
            // завантажитиДані1ToolStripMenuItem
            // 
            завантажитиДані1ToolStripMenuItem.Name = "завантажитиДані1ToolStripMenuItem";
            завантажитиДані1ToolStripMenuItem.Size = new Size(266, 22);
            завантажитиДані1ToolStripMenuItem.Text = "Завантажити дані 2";
            завантажитиДані1ToolStripMenuItem.Click += завантажитиДані1ToolStripMenuItem_Click;
            // 
            // завантажитиДані2ToolStripMenuItem
            // 
            завантажитиДані2ToolStripMenuItem.Name = "завантажитиДані2ToolStripMenuItem";
            завантажитиДані2ToolStripMenuItem.Size = new Size(266, 22);
            завантажитиДані2ToolStripMenuItem.Text = "Завантажити дані 1";
            завантажитиДані2ToolStripMenuItem.Click += завантажитиДані2ToolStripMenuItem_Click;
            // 
            // застосуватиЗапитНаВибіркуToolStripMenuItem
            // 
            застосуватиЗапитНаВибіркуToolStripMenuItem.Name = "застосуватиЗапитНаВибіркуToolStripMenuItem";
            застосуватиЗапитНаВибіркуToolStripMenuItem.Size = new Size(266, 22);
            застосуватиЗапитНаВибіркуToolStripMenuItem.Text = "Застосувати запит на вибірку";
            застосуватиЗапитНаВибіркуToolStripMenuItem.Click += застосуватиЗапитНаВибіркуToolStripMenuItem_Click;
            // 
            // застосуватиЗапитНаМодифікаціюToolStripMenuItem
            // 
            застосуватиЗапитНаМодифікаціюToolStripMenuItem.Name = "застосуватиЗапитНаМодифікаціюToolStripMenuItem";
            застосуватиЗапитНаМодифікаціюToolStripMenuItem.Size = new Size(266, 22);
            застосуватиЗапитНаМодифікаціюToolStripMenuItem.Text = "Застосувати запит на модифікацію";
            застосуватиЗапитНаМодифікаціюToolStripMenuItem.Click += застосуватиЗапитНаМодифікаціюToolStripMenuItem_Click;
            // 
            // застосуватиЗапитНаВидаленняToolStripMenuItem
            // 
            застосуватиЗапитНаВидаленняToolStripMenuItem.Name = "застосуватиЗапитНаВидаленняToolStripMenuItem";
            застосуватиЗапитНаВидаленняToolStripMenuItem.Size = new Size(266, 22);
            застосуватиЗапитНаВидаленняToolStripMenuItem.Text = "Застосувати запит на видалення";
            застосуватиЗапитНаВидаленняToolStripMenuItem.Click += застосуватиЗапитНаВидаленняToolStripMenuItem_Click;
            // 
            // застосуватиЗапитНаДодаванняToolStripMenuItem
            // 
            застосуватиЗапитНаДодаванняToolStripMenuItem.Name = "застосуватиЗапитНаДодаванняToolStripMenuItem";
            застосуватиЗапитНаДодаванняToolStripMenuItem.Size = new Size(266, 22);
            застосуватиЗапитНаДодаванняToolStripMenuItem.Text = "Застосувати запит на додавання";
            застосуватиЗапитНаДодаванняToolStripMenuItem.Click += застосуватиЗапитНаДодаванняToolStripMenuItem_Click;
            // 
            // сервісToolStripMenuItem
            // 
            сервісToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { встановитиШляхДоБазиДанихToolStripMenuItem });
            сервісToolStripMenuItem.Name = "сервісToolStripMenuItem";
            сервісToolStripMenuItem.Size = new Size(55, 20);
            сервісToolStripMenuItem.Text = "Сервіс";
            // 
            // встановитиШляхДоБазиДанихToolStripMenuItem
            // 
            встановитиШляхДоБазиДанихToolStripMenuItem.Name = "встановитиШляхДоБазиДанихToolStripMenuItem";
            встановитиШляхДоБазиДанихToolStripMenuItem.Size = new Size(249, 22);
            встановитиШляхДоБазиДанихToolStripMenuItem.Text = "Встановити шлях до бази даних";
            встановитиШляхДоБазиДанихToolStripMenuItem.Click += встановитиШляхДоБазиДанихToolStripMenuItem_Click;
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(99, 20);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(532, 374);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { group, student, subject, grade });
            dataGridView2.Location = new Point(552, 41);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(532, 374);
            dataGridView2.TabIndex = 2;
            // 
            // group
            // 
            group.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            group.FillWeight = 20F;
            group.HeaderText = "Група";
            group.Name = "group";
            // 
            // student
            // 
            student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            student.FillWeight = 40F;
            student.HeaderText = "Прізвище";
            student.Name = "student";
            // 
            // subject
            // 
            subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject.FillWeight = 40F;
            subject.HeaderText = "Дисципліна";
            subject.Name = "subject";
            // 
            // grade
            // 
            grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grade.FillWeight = 20F;
            grade.HeaderText = "Оцінка";
            grade.Name = "grade";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(38, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataSetBindingSource
            // 
            dataSetBindingSource.DataSource = typeof(System.Data.DataSet);
            dataSetBindingSource.Position = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(740, 431);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 84);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Оцінка";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(194, 431);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 84);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Група";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(39, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(376, 431);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(176, 84);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Прізвище";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(39, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox4);
            groupBox4.Location = new Point(558, 431);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(176, 84);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Дисципліна";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(39, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox5);
            groupBox5.Location = new Point(12, 431);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(176, 84);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Таблиця";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(39, 32);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 569);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Лабораторна робота 5";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSetBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem підключитиБазуДанихToolStripMenuItem;
        private ToolStripMenuItem відєднатиБазуДанихToolStripMenuItem;
        private ToolStripMenuItem завершитиРоботуToolStripMenuItem;
        private ToolStripMenuItem даніToolStripMenuItem;
        private ToolStripMenuItem завантажитиДані1ToolStripMenuItem;
        private ToolStripMenuItem завантажитиДані2ToolStripMenuItem;
        private ToolStripMenuItem застосуватиЗапитНаВибіркуToolStripMenuItem;
        private ToolStripMenuItem застосуватиЗапитНаМодифікаціюToolStripMenuItem;
        private ToolStripMenuItem застосуватиЗапитНаВидаленняToolStripMenuItem;
        private ToolStripMenuItem застосуватиЗапитНаДодаванняToolStripMenuItem;
        private ToolStripMenuItem сервісToolStripMenuItem;
        private ToolStripMenuItem встановитиШляхДоБазиДанихToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource dataSetBindingSource;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn group;
        private DataGridViewTextBoxColumn student;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn grade;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private GroupBox groupBox4;
        private TextBox textBox4;
        private GroupBox groupBox5;
        private TextBox textBox5;
    }
}