namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервісToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.даніПроСнарядиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершенняРоботиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crossSectionalAreaComboBox = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dragCoefficientTextBox = new System.Windows.Forms.TextBox();
            this.initialVelocityTextBox = new System.Windows.Forms.TextBox();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.labelFlightTime = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сервісToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.завершенняРоботиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem,
            this.завантажитиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // завантажитиToolStripMenuItem
            // 
            this.завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            this.завантажитиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.завантажитиToolStripMenuItem.Text = "Завантажити";
            this.завантажитиToolStripMenuItem.Click += new System.EventHandler(this.завантажитиToolStripMenuItem_Click);
            // 
            // сервісToolStripMenuItem
            // 
            this.сервісToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.даніПроСнарядиToolStripMenuItem});
            this.сервісToolStripMenuItem.Name = "сервісToolStripMenuItem";
            this.сервісToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.сервісToolStripMenuItem.Text = "Сервіс";
            // 
            // даніПроСнарядиToolStripMenuItem
            // 
            this.даніПроСнарядиToolStripMenuItem.Name = "даніПроСнарядиToolStripMenuItem";
            this.даніПроСнарядиToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.даніПроСнарядиToolStripMenuItem.Text = "Дані про снаряди";
            this.даніПроСнарядиToolStripMenuItem.Click += new System.EventHandler(this.даніПроСнарядиToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // завершенняРоботиToolStripMenuItem
            // 
            this.завершенняРоботиToolStripMenuItem.Name = "завершенняРоботиToolStripMenuItem";
            this.завершенняРоботиToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.завершенняРоботиToolStripMenuItem.Text = "Завершення роботи";
            this.завершенняРоботиToolStripMenuItem.Click += new System.EventHandler(this.завершенняРоботиToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 542);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crossSectionalAreaComboBox);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dragCoefficientTextBox);
            this.groupBox1.Controls.Add(this.initialVelocityTextBox);
            this.groupBox1.Controls.Add(this.massTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(940, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дані про снаряд";
            // 
            // crossSectionalAreaComboBox
            // 
            this.crossSectionalAreaComboBox.FormattingEnabled = true;
            this.crossSectionalAreaComboBox.Location = new System.Drawing.Point(21, 165);
            this.crossSectionalAreaComboBox.Name = "crossSectionalAreaComboBox";
            this.crossSectionalAreaComboBox.Size = new System.Drawing.Size(144, 21);
            this.crossSectionalAreaComboBox.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(21, 330);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 33);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Коефіціент опору";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Початкова швидкість";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Калібр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Маса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Назва";
            // 
            // dragCoefficientTextBox
            // 
            this.dragCoefficientTextBox.Location = new System.Drawing.Point(21, 285);
            this.dragCoefficientTextBox.Name = "dragCoefficientTextBox";
            this.dragCoefficientTextBox.Size = new System.Drawing.Size(144, 20);
            this.dragCoefficientTextBox.TabIndex = 4;
            // 
            // initialVelocityTextBox
            // 
            this.initialVelocityTextBox.Location = new System.Drawing.Point(21, 225);
            this.initialVelocityTextBox.Name = "initialVelocityTextBox";
            this.initialVelocityTextBox.Size = new System.Drawing.Size(144, 20);
            this.initialVelocityTextBox.TabIndex = 3;
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(21, 105);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(144, 20);
            this.massTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(21, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(144, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(940, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Снаряд";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Назва";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonLaunch);
            this.groupBox3.Controls.Add(this.labelFlightTime);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.angleTextBox);
            this.groupBox3.Location = new System.Drawing.Point(22, 591);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1102, 90);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Запуск снаряда";
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.BackColor = System.Drawing.Color.Red;
            this.buttonLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLaunch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLaunch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.buttonLaunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaunch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.buttonLaunch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLaunch.Location = new System.Drawing.Point(929, 15);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(165, 65);
            this.buttonLaunch.TabIndex = 14;
            this.buttonLaunch.Text = "ЗАПУСК";
            this.buttonLaunch.UseVisualStyleBackColor = false;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // labelFlightTime
            // 
            this.labelFlightTime.AutoSize = true;
            this.labelFlightTime.Location = new System.Drawing.Point(212, 25);
            this.labelFlightTime.Name = "labelFlightTime";
            this.labelFlightTime.Size = new System.Drawing.Size(120, 13);
            this.labelFlightTime.TabIndex = 13;
            this.labelFlightTime.Text = "Час польоту: 0 секунд";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(212, 39);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(688, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Кут відхилення снаряду";
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(28, 43);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(144, 20);
            this.angleTextBox.TabIndex = 10;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(21, 31);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(108, 13);
            this.labelRange.TabIndex = 5;
            this.labelRange.Text = "Дальність польоту: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelRange);
            this.groupBox4.Location = new System.Drawing.Point(940, 515);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 70);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результат";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1139, 693);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Projectile Flight Model";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантажитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервісToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem даніПроСнарядиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершенняРоботиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dragCoefficientTextBox;
        private System.Windows.Forms.TextBox initialVelocityTextBox;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Label labelFlightTime;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox crossSectionalAreaComboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

