namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.підключитиБазуДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відєднатиБазуДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитиРоботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.даніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.застосуватиЗапитНаВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.застосуватиЗапитНаМодифікаціюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервісToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.встановитиШляхДоБазиДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oleDbConnection = new System.Data.OleDb.OleDbConnection();
            this.dataSet1 = new System.Data.DataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.textBoxDatabasePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.даніToolStripMenuItem,
            this.сервісToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.підключитиБазуДанихToolStripMenuItem,
            this.відєднатиБазуДанихToolStripMenuItem,
            this.завершитиРоботуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // підключитиБазуДанихToolStripMenuItem
            // 
            this.підключитиБазуДанихToolStripMenuItem.Name = "підключитиБазуДанихToolStripMenuItem";
            this.підключитиБазуДанихToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.підключитиБазуДанихToolStripMenuItem.Text = "Підключити базу даних";
            this.підключитиБазуДанихToolStripMenuItem.Click += new System.EventHandler(this.підключитиБазуДанихToolStripMenuItem_Click);
            // 
            // відєднатиБазуДанихToolStripMenuItem
            // 
            this.відєднатиБазуДанихToolStripMenuItem.Name = "відєднатиБазуДанихToolStripMenuItem";
            this.відєднатиБазуДанихToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.відєднатиБазуДанихToolStripMenuItem.Text = "Від\'єднати базу даних";
            this.відєднатиБазуДанихToolStripMenuItem.Click += new System.EventHandler(this.відєднатиБазуДанихToolStripMenuItem_Click);
            // 
            // завершитиРоботуToolStripMenuItem
            // 
            this.завершитиРоботуToolStripMenuItem.Name = "завершитиРоботуToolStripMenuItem";
            this.завершитиРоботуToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.завершитиРоботуToolStripMenuItem.Text = "Завершити роботу";
            this.завершитиРоботуToolStripMenuItem.Click += new System.EventHandler(this.завершитиРоботуToolStripMenuItem_Click);
            // 
            // даніToolStripMenuItem
            // 
            this.даніToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завантажитиДаніToolStripMenuItem,
            this.застосуватиЗапитНаВибіркуToolStripMenuItem,
            this.застосуватиЗапитНаМодифікаціюToolStripMenuItem});
            this.даніToolStripMenuItem.Name = "даніToolStripMenuItem";
            this.даніToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.даніToolStripMenuItem.Text = "Дані";
            // 
            // завантажитиДаніToolStripMenuItem
            // 
            this.завантажитиДаніToolStripMenuItem.Name = "завантажитиДаніToolStripMenuItem";
            this.завантажитиДаніToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.завантажитиДаніToolStripMenuItem.Text = "Завантажити дані";
            this.завантажитиДаніToolStripMenuItem.Click += new System.EventHandler(this.завантажитиДаніToolStripMenuItem_Click);
            // 
            // застосуватиЗапитНаВибіркуToolStripMenuItem
            // 
            this.застосуватиЗапитНаВибіркуToolStripMenuItem.Name = "застосуватиЗапитНаВибіркуToolStripMenuItem";
            this.застосуватиЗапитНаВибіркуToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.застосуватиЗапитНаВибіркуToolStripMenuItem.Text = "Застосувати запит на вибірку";
            this.застосуватиЗапитНаВибіркуToolStripMenuItem.Click += new System.EventHandler(this.застосуватиЗапитНаВибіркуToolStripMenuItem_Click);
            // 
            // застосуватиЗапитНаМодифікаціюToolStripMenuItem
            // 
            this.застосуватиЗапитНаМодифікаціюToolStripMenuItem.Name = "застосуватиЗапитНаМодифікаціюToolStripMenuItem";
            this.застосуватиЗапитНаМодифікаціюToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.застосуватиЗапитНаМодифікаціюToolStripMenuItem.Text = "Застосувати запит на модифікацію";
            this.застосуватиЗапитНаМодифікаціюToolStripMenuItem.Click += new System.EventHandler(this.застосуватиЗапитНаМодифікаціюToolStripMenuItem_Click);
            // 
            // сервісToolStripMenuItem
            // 
            this.сервісToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.встановитиШляхДоБазиДанихToolStripMenuItem});
            this.сервісToolStripMenuItem.Name = "сервісToolStripMenuItem";
            this.сервісToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.сервісToolStripMenuItem.Text = "Сервіс";
            // 
            // встановитиШляхДоБазиДанихToolStripMenuItem
            // 
            this.встановитиШляхДоБазиДанихToolStripMenuItem.Name = "встановитиШляхДоБазиДанихToolStripMenuItem";
            this.встановитиШляхДоБазиДанихToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.встановитиШляхДоБазиДанихToolStripMenuItem.Text = "Встановити шлях до бази даних";
            this.встановитиШляхДоБазиДанихToolStripMenuItem.Click += new System.EventHandler(this.встановитиШляхДоБазиДанихToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // textBoxDatabasePath
            // 
            this.textBoxDatabasePath.Location = new System.Drawing.Point(6, 19);
            this.textBoxDatabasePath.Name = "textBoxDatabasePath";
            this.textBoxDatabasePath.Size = new System.Drawing.Size(453, 20);
            this.textBoxDatabasePath.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запит";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDatabasePath);
            this.groupBox2.Location = new System.Drawing.Point(12, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шлях до бази даних";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторна робота 6";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem підключитиБазуДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відєднатиБазуДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитиРоботуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem даніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантажитиДаніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem застосуватиЗапитНаВибіркуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem застосуватиЗапитНаМодифікаціюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервісToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem встановитиШляхДоБазиДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.OleDb.OleDbConnection oleDbConnection;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox textBoxDatabasePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

