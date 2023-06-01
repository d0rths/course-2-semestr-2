namespace Lab1
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            завантажитиРисунокToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            завершенняРоботиToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            lblMaxContrast = new Label();
            lblCurrentContrast = new Label();
            lblMinContrast = new Label();
            trackBar1 = new TrackBar();
            groupBox2 = new GroupBox();
            lblMaxBrightness = new Label();
            lblCurrentBrightness = new Label();
            lblMinBrightness = new Label();
            trackBar2 = new TrackBar();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            lblMaxOpacity = new Label();
            lblCurrentOpacity = new Label();
            lblMinOpacity = new Label();
            trackBar3 = new TrackBar();
            groupBox4 = new GroupBox();
            lblMaxRotate = new Label();
            lblCurrentRotate = new Label();
            lblMinRotate = new Label();
            trackBar4 = new TrackBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox5 = new GroupBox();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 27);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { завантажитиРисунокToolStripMenuItem, зберегтиToolStripMenuItem, проПрограмуToolStripMenuItem, завершенняРоботиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(948, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // завантажитиРисунокToolStripMenuItem
            // 
            завантажитиРисунокToolStripMenuItem.Name = "завантажитиРисунокToolStripMenuItem";
            завантажитиРисунокToolStripMenuItem.Size = new Size(90, 20);
            завантажитиРисунокToolStripMenuItem.Text = "Завантажити";
            завантажитиРисунокToolStripMenuItem.Click += завантажитиРисунокToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(72, 20);
            зберегтиToolStripMenuItem.Text = "Зберегти ";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(99, 20);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // завершенняРоботиToolStripMenuItem
            // 
            завершенняРоботиToolStripMenuItem.Name = "завершенняРоботиToolStripMenuItem";
            завершенняРоботиToolStripMenuItem.Size = new Size(131, 20);
            завершенняРоботиToolStripMenuItem.Text = "Завершення роботи";
            завершенняРоботиToolStripMenuItem.Click += завершенняРоботиToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMaxContrast);
            groupBox1.Controls.Add(lblCurrentContrast);
            groupBox1.Controls.Add(lblMinContrast);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 501);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(948, 73);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contrast";
            // 
            // lblMaxContrast
            // 
            lblMaxContrast.Anchor = AnchorStyles.Right;
            lblMaxContrast.AutoSize = true;
            lblMaxContrast.Location = new Point(910, 49);
            lblMaxContrast.Name = "lblMaxContrast";
            lblMaxContrast.Size = new Size(38, 15);
            lblMaxContrast.TabIndex = 3;
            lblMaxContrast.Text = "label6";
            // 
            // lblCurrentContrast
            // 
            lblCurrentContrast.Anchor = AnchorStyles.Right;
            lblCurrentContrast.AutoSize = true;
            lblCurrentContrast.Location = new Point(464, 49);
            lblCurrentContrast.Name = "lblCurrentContrast";
            lblCurrentContrast.Size = new Size(38, 15);
            lblCurrentContrast.TabIndex = 2;
            lblCurrentContrast.Text = "label5";
            // 
            // lblMinContrast
            // 
            lblMinContrast.Anchor = AnchorStyles.Right;
            lblMinContrast.AutoSize = true;
            lblMinContrast.Location = new Point(0, 49);
            lblMinContrast.Name = "lblMinContrast";
            lblMinContrast.Size = new Size(38, 15);
            lblMinContrast.TabIndex = 1;
            lblMinContrast.Text = "label4";
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.Dock = DockStyle.Top;
            trackBar1.Location = new Point(3, 19);
            trackBar1.Maximum = 500;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(942, 31);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMaxBrightness);
            groupBox2.Controls.Add(lblCurrentBrightness);
            groupBox2.Controls.Add(lblMinBrightness);
            groupBox2.Controls.Add(trackBar2);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 422);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(948, 79);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Brightness";
            // 
            // lblMaxBrightness
            // 
            lblMaxBrightness.Anchor = AnchorStyles.Right;
            lblMaxBrightness.AutoSize = true;
            lblMaxBrightness.Location = new Point(910, 54);
            lblMaxBrightness.Name = "lblMaxBrightness";
            lblMaxBrightness.Size = new Size(38, 15);
            lblMaxBrightness.TabIndex = 3;
            lblMaxBrightness.Text = "label3";
            // 
            // lblCurrentBrightness
            // 
            lblCurrentBrightness.Anchor = AnchorStyles.Right;
            lblCurrentBrightness.AutoSize = true;
            lblCurrentBrightness.Location = new Point(464, 54);
            lblCurrentBrightness.Name = "lblCurrentBrightness";
            lblCurrentBrightness.Size = new Size(38, 15);
            lblCurrentBrightness.TabIndex = 2;
            lblCurrentBrightness.Text = "label2";
            // 
            // lblMinBrightness
            // 
            lblMinBrightness.Anchor = AnchorStyles.Right;
            lblMinBrightness.AutoSize = true;
            lblMinBrightness.Location = new Point(0, 54);
            lblMinBrightness.Name = "lblMinBrightness";
            lblMinBrightness.Size = new Size(38, 15);
            lblMinBrightness.TabIndex = 1;
            lblMinBrightness.Text = "label1";
            // 
            // trackBar2
            // 
            trackBar2.AutoSize = false;
            trackBar2.Dock = DockStyle.Top;
            trackBar2.Location = new Point(3, 19);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(942, 32);
            trackBar2.TabIndex = 0;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 389);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblMaxOpacity);
            groupBox3.Controls.Add(lblCurrentOpacity);
            groupBox3.Controls.Add(lblMinOpacity);
            groupBox3.Controls.Add(trackBar3);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(869, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(79, 395);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Opacity";
            // 
            // lblMaxOpacity
            // 
            lblMaxOpacity.AutoSize = true;
            lblMaxOpacity.Location = new Point(40, 19);
            lblMaxOpacity.Name = "lblMaxOpacity";
            lblMaxOpacity.Size = new Size(38, 15);
            lblMaxOpacity.TabIndex = 3;
            lblMaxOpacity.Text = "label3";
            // 
            // lblCurrentOpacity
            // 
            lblCurrentOpacity.AutoSize = true;
            lblCurrentOpacity.Location = new Point(40, 198);
            lblCurrentOpacity.Name = "lblCurrentOpacity";
            lblCurrentOpacity.Size = new Size(38, 15);
            lblCurrentOpacity.TabIndex = 2;
            lblCurrentOpacity.Text = "label2";
            // 
            // lblMinOpacity
            // 
            lblMinOpacity.AutoSize = true;
            lblMinOpacity.Location = new Point(40, 365);
            lblMinOpacity.Name = "lblMinOpacity";
            lblMinOpacity.Size = new Size(38, 15);
            lblMinOpacity.TabIndex = 1;
            lblMinOpacity.Text = "label1";
            // 
            // trackBar3
            // 
            trackBar3.Dock = DockStyle.Left;
            trackBar3.Location = new Point(3, 19);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Orientation = Orientation.Vertical;
            trackBar3.RightToLeft = RightToLeft.No;
            trackBar3.Size = new Size(45, 373);
            trackBar3.TabIndex = 0;
            trackBar3.Value = 255;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblMaxRotate);
            groupBox4.Controls.Add(lblCurrentRotate);
            groupBox4.Controls.Add(lblMinRotate);
            groupBox4.Controls.Add(trackBar4);
            groupBox4.Dock = DockStyle.Right;
            groupBox4.Location = new Point(789, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(80, 395);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rotate";
            // 
            // lblMaxRotate
            // 
            lblMaxRotate.AutoSize = true;
            lblMaxRotate.Location = new Point(41, 19);
            lblMaxRotate.Name = "lblMaxRotate";
            lblMaxRotate.Size = new Size(38, 15);
            lblMaxRotate.TabIndex = 3;
            lblMaxRotate.Text = "label3";
            // 
            // lblCurrentRotate
            // 
            lblCurrentRotate.AutoSize = true;
            lblCurrentRotate.Location = new Point(41, 198);
            lblCurrentRotate.Name = "lblCurrentRotate";
            lblCurrentRotate.Size = new Size(38, 15);
            lblCurrentRotate.TabIndex = 2;
            lblCurrentRotate.Text = "label2";
            // 
            // lblMinRotate
            // 
            lblMinRotate.AutoSize = true;
            lblMinRotate.Location = new Point(41, 365);
            lblMinRotate.Name = "lblMinRotate";
            lblMinRotate.Size = new Size(38, 15);
            lblMinRotate.TabIndex = 1;
            lblMinRotate.Text = "label1";
            // 
            // trackBar4
            // 
            trackBar4.Dock = DockStyle.Left;
            trackBar4.Location = new Point(3, 19);
            trackBar4.Maximum = 90;
            trackBar4.Name = "trackBar4";
            trackBar4.Orientation = Orientation.Vertical;
            trackBar4.Size = new Size(45, 373);
            trackBar4.TabIndex = 0;
            trackBar4.Scroll += trackBar4_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(6, 37);
            button1.Name = "button1";
            button1.Size = new Size(137, 56);
            button1.TabIndex = 6;
            button1.Text = "По горизонтальній осі";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 99);
            button2.Name = "button2";
            button2.Size = new Size(137, 55);
            button2.TabIndex = 7;
            button2.Text = "По вертикальній осі";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 160);
            button3.Name = "button3";
            button3.Size = new Size(137, 51);
            button3.TabIndex = 8;
            button3.Text = "За заданим кутом";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(643, 254);
            button4.Name = "button4";
            button4.Size = new Size(137, 51);
            button4.TabIndex = 9;
            button4.Text = "Збільшити масштаб";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button2);
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(637, 27);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(149, 221);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Повернути зображення";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 574);
            Controls.Add(button4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem завантажитиРисунокToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStripMenuItem завершенняРоботиToolStripMenuItem;
        private GroupBox groupBox1;
        private Label lblMaxContrast;
        private Label lblCurrentContrast;
        private Label lblMinContrast;
        private TrackBar trackBar1;
        private GroupBox groupBox2;
        private Label lblMaxBrightness;
        private Label lblCurrentBrightness;
        private Label lblMinBrightness;
        private TrackBar trackBar2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblMaxOpacity;
        private Label lblCurrentOpacity;
        private Label lblMinOpacity;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private Label lblMaxRotate;
        private Label lblCurrentRotate;
        private Label lblMinRotate;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox5;
    }
}