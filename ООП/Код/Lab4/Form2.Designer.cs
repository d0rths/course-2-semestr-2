namespace Lab4
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            buttonExpand = new Button();
            panel1 = new Panel();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            buttonOK = new Button();
            panel2 = new Panel();
            radioView = new RadioButton();
            radioSave = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(66, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(654, 306);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 150F;
            Column1.HeaderText = "Прізвище";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 80F;
            Column2.HeaderText = "Група";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 150F;
            Column3.HeaderText = "Дисципліна";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 60F;
            Column4.HeaderText = "Оцінка";
            Column4.Name = "Column4";
            // 
            // buttonExpand
            // 
            buttonExpand.Location = new Point(66, 404);
            buttonExpand.Name = "buttonExpand";
            buttonExpand.Size = new Size(99, 34);
            buttonExpand.TabIndex = 1;
            buttonExpand.Text = "Більше";
            buttonExpand.UseVisualStyleBackColor = true;
            buttonExpand.Click += buttonExpand_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(66, 364);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 34);
            panel1.TabIndex = 2;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(363, 9);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(67, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Рядок 5";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(274, 9);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(67, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Рядок 4";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(185, 9);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(67, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Рядок 3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(96, 9);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(67, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Рядок 2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(7, 9);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Рядок 1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(171, 404);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(99, 34);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioView);
            panel2.Controls.Add(radioSave);
            panel2.Location = new Point(521, 364);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 34);
            panel2.TabIndex = 3;
            // 
            // radioView
            // 
            radioView.AutoSize = true;
            radioView.Location = new Point(109, 9);
            radioView.Name = "radioView";
            radioView.Size = new Size(77, 19);
            radioView.TabIndex = 1;
            radioView.TabStop = true;
            radioView.Text = "Перегляд";
            radioView.UseVisualStyleBackColor = true;
            // 
            // radioSave
            // 
            radioSave.AutoSize = true;
            radioSave.Location = new Point(12, 9);
            radioSave.Name = "radioSave";
            radioSave.Size = new Size(75, 19);
            radioSave.TabIndex = 0;
            radioSave.TabStop = true;
            radioSave.Text = "Зберегти";
            radioSave.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOK);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonExpand);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button buttonExpand;
        private Panel panel1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Panel panel2;
        private RadioButton radioView;
        private RadioButton radioSave;
        private Button buttonOK;
    }
}