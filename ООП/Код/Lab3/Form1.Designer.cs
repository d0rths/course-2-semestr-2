namespace Lab3
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            завантажитиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            завершитиРоботуToolStripMenuItem = new ToolStripMenuItem();
            редагуватиToolStripMenuItem = new ToolStripMenuItem();
            дозволитиРедагуватиToolStripMenuItem = new ToolStripMenuItem();
            заборонитиРедагуватиToolStripMenuItem = new ToolStripMenuItem();
            змінитиКолірВмістуТаблицьToolStripMenuItem = new ToolStripMenuItem();
            змінитиКолірТаблицьToolStripMenuItem = new ToolStripMenuItem();
            сервісToolStripMenuItem = new ToolStripMenuItem();
            показатиДаніToolStripMenuItem = new ToolStripMenuItem();
            приховатиДаніToolStripMenuItem = new ToolStripMenuItem();
            сортуванняЗаСтовпцямиToolStripMenuItem = new ToolStripMenuItem();
            сортуванняЗаРядкамиToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            dataGridView2 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            colorDialog1 = new ColorDialog();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, редагуватиToolStripMenuItem, сервісToolStripMenuItem, проПрограмуToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1042, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { завантажитиToolStripMenuItem, зберегтиToolStripMenuItem, завершитиРоботуToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // завантажитиToolStripMenuItem
            // 
            завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            завантажитиToolStripMenuItem.Size = new Size(178, 22);
            завантажитиToolStripMenuItem.Text = "Завантажити";
            завантажитиToolStripMenuItem.Click += завантажитиToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(178, 22);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // завершитиРоботуToolStripMenuItem
            // 
            завершитиРоботуToolStripMenuItem.Name = "завершитиРоботуToolStripMenuItem";
            завершитиРоботуToolStripMenuItem.Size = new Size(178, 22);
            завершитиРоботуToolStripMenuItem.Text = "Завершити роботу";
            завершитиРоботуToolStripMenuItem.Click += завершитиРоботуToolStripMenuItem_Click;
            // 
            // редагуватиToolStripMenuItem
            // 
            редагуватиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { дозволитиРедагуватиToolStripMenuItem, заборонитиРедагуватиToolStripMenuItem, змінитиКолірВмістуТаблицьToolStripMenuItem, змінитиКолірТаблицьToolStripMenuItem });
            редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            редагуватиToolStripMenuItem.Size = new Size(87, 20);
            редагуватиToolStripMenuItem.Text = "Редагування";
            редагуватиToolStripMenuItem.Click += редагуватиToolStripMenuItem_Click;
            // 
            // дозволитиРедагуватиToolStripMenuItem
            // 
            дозволитиРедагуватиToolStripMenuItem.Name = "дозволитиРедагуватиToolStripMenuItem";
            дозволитиРедагуватиToolStripMenuItem.Size = new Size(238, 22);
            дозволитиРедагуватиToolStripMenuItem.Text = "Дозволити редагувати";
            дозволитиРедагуватиToolStripMenuItem.Click += дозволитиРедагуватиToolStripMenuItem_Click;
            // 
            // заборонитиРедагуватиToolStripMenuItem
            // 
            заборонитиРедагуватиToolStripMenuItem.Name = "заборонитиРедагуватиToolStripMenuItem";
            заборонитиРедагуватиToolStripMenuItem.Size = new Size(238, 22);
            заборонитиРедагуватиToolStripMenuItem.Text = "Заборонити редагувати";
            заборонитиРедагуватиToolStripMenuItem.Click += заборонитиРедагуватиToolStripMenuItem_Click;
            // 
            // змінитиКолірВмістуТаблицьToolStripMenuItem
            // 
            змінитиКолірВмістуТаблицьToolStripMenuItem.Name = "змінитиКолірВмістуТаблицьToolStripMenuItem";
            змінитиКолірВмістуТаблицьToolStripMenuItem.Size = new Size(238, 22);
            змінитиКолірВмістуТаблицьToolStripMenuItem.Text = "Змінити колір вмісту таблиць";
            змінитиКолірВмістуТаблицьToolStripMenuItem.Click += змінитиКолірВмістуТаблицьToolStripMenuItem_Click;
            // 
            // змінитиКолірТаблицьToolStripMenuItem
            // 
            змінитиКолірТаблицьToolStripMenuItem.Name = "змінитиКолірТаблицьToolStripMenuItem";
            змінитиКолірТаблицьToolStripMenuItem.Size = new Size(238, 22);
            змінитиКолірТаблицьToolStripMenuItem.Text = "Змінити колір таблиць";
            змінитиКолірТаблицьToolStripMenuItem.Click += змінитиКолірТаблицьToolStripMenuItem_Click;
            // 
            // сервісToolStripMenuItem
            // 
            сервісToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { показатиДаніToolStripMenuItem, приховатиДаніToolStripMenuItem, сортуванняЗаСтовпцямиToolStripMenuItem, сортуванняЗаРядкамиToolStripMenuItem });
            сервісToolStripMenuItem.Name = "сервісToolStripMenuItem";
            сервісToolStripMenuItem.Size = new Size(55, 20);
            сервісToolStripMenuItem.Text = "Сервіс";
            // 
            // показатиДаніToolStripMenuItem
            // 
            показатиДаніToolStripMenuItem.Name = "показатиДаніToolStripMenuItem";
            показатиДаніToolStripMenuItem.Size = new Size(216, 22);
            показатиДаніToolStripMenuItem.Text = "Показати дані";
            показатиДаніToolStripMenuItem.Click += показатиДаніToolStripMenuItem_Click;
            // 
            // приховатиДаніToolStripMenuItem
            // 
            приховатиДаніToolStripMenuItem.Name = "приховатиДаніToolStripMenuItem";
            приховатиДаніToolStripMenuItem.Size = new Size(216, 22);
            приховатиДаніToolStripMenuItem.Text = "Приховати дані";
            приховатиДаніToolStripMenuItem.Click += приховатиДаніToolStripMenuItem_Click;
            // 
            // сортуванняЗаСтовпцямиToolStripMenuItem
            // 
            сортуванняЗаСтовпцямиToolStripMenuItem.Name = "сортуванняЗаСтовпцямиToolStripMenuItem";
            сортуванняЗаСтовпцямиToolStripMenuItem.Size = new Size(216, 22);
            сортуванняЗаСтовпцямиToolStripMenuItem.Text = "Сортування за стовпцями";
            сортуванняЗаСтовпцямиToolStripMenuItem.Click += сортуванняЗаСтовпцямиToolStripMenuItem_Click;
            // 
            // сортуванняЗаРядкамиToolStripMenuItem
            // 
            сортуванняЗаРядкамиToolStripMenuItem.Name = "сортуванняЗаРядкамиToolStripMenuItem";
            сортуванняЗаРядкамиToolStripMenuItem.Size = new Size(216, 22);
            сортуванняЗаРядкамиToolStripMenuItem.Text = "Сортування за рядками";
            сортуванняЗаРядкамиToolStripMenuItem.Click += сортуванняЗаРядкамиToolStripMenuItem_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(311, 168);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "1";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "2";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "3";
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "4";
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "5";
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10 });
            dataGridView2.Location = new Point(356, 78);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(311, 168);
            dataGridView2.TabIndex = 2;
            // 
            // Column6
            // 
            Column6.HeaderText = "1";
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // Column7
            // 
            Column7.HeaderText = "2";
            Column7.Name = "Column7";
            Column7.Width = 50;
            // 
            // Column8
            // 
            Column8.HeaderText = "3";
            Column8.Name = "Column8";
            Column8.Width = 50;
            // 
            // Column9
            // 
            Column9.HeaderText = "4";
            Column9.Name = "Column9";
            Column9.Width = 50;
            // 
            // Column10
            // 
            Column10.HeaderText = "5";
            Column10.Name = "Column10";
            Column10.Width = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Матриця 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 51);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Матриця 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(697, 51);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "Матриця 3";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column11, Column12, Column13, Column14, Column15 });
            dataGridView3.Location = new Point(697, 78);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(311, 168);
            dataGridView3.TabIndex = 6;
            // 
            // Column11
            // 
            Column11.HeaderText = "1";
            Column11.Name = "Column11";
            Column11.Width = 50;
            // 
            // Column12
            // 
            Column12.HeaderText = "2";
            Column12.Name = "Column12";
            Column12.Width = 50;
            // 
            // Column13
            // 
            Column13.HeaderText = "3";
            Column13.Name = "Column13";
            Column13.Width = 50;
            // 
            // Column14
            // 
            Column14.HeaderText = "4";
            Column14.Name = "Column14";
            Column14.Width = 50;
            // 
            // Column15
            // 
            Column15.HeaderText = "5";
            Column15.Name = "Column15";
            Column15.Width = 50;
            // 
            // button1
            // 
            button1.Location = new Point(272, 277);
            button1.Name = "button1";
            button1.Size = new Size(149, 36);
            button1.TabIndex = 7;
            button1.Text = "Сума";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(445, 277);
            button2.Name = "button2";
            button2.Size = new Size(147, 36);
            button2.TabIndex = 8;
            button2.Text = "Транспонування";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(615, 277);
            button3.Name = "button3";
            button3.Size = new Size(147, 36);
            button3.TabIndex = 9;
            button3.Text = "Знайти збіги";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 597);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Excel на гіпер мінімалках";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem завантажитиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem завершитиРоботуToolStripMenuItem;
        private ToolStripMenuItem редагуватиToolStripMenuItem;
        private ToolStripMenuItem дозволитиРедагуватиToolStripMenuItem;
        private ToolStripMenuItem заборонитиРедагуватиToolStripMenuItem;
        private ToolStripMenuItem змінитиКолірВмістуТаблицьToolStripMenuItem;
        private ToolStripMenuItem змінитиКолірТаблицьToolStripMenuItem;
        private ToolStripMenuItem сервісToolStripMenuItem;
        private ToolStripMenuItem показатиДаніToolStripMenuItem;
        private ToolStripMenuItem приховатиДаніToolStripMenuItem;
        private ToolStripMenuItem сортуванняЗаСтовпцямиToolStripMenuItem;
        private ToolStripMenuItem сортуванняЗаРядкамиToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView3;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
    }
}