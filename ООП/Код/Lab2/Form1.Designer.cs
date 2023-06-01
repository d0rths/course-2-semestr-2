namespace Lab2
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
            відкритиФайлToolStripMenuItem = new ToolStripMenuItem();
            зберегтиФайлToolStripMenuItem = new ToolStripMenuItem();
            завершитиРоботуToolStripMenuItem = new ToolStripMenuItem();
            редагуватиToolStripMenuItem = new ToolStripMenuItem();
            змінитиКолірТекстуToolStripMenuItem = new ToolStripMenuItem();
            сервісToolStripMenuItem = new ToolStripMenuItem();
            показатиКількістьСлівУТекстіToolStripMenuItem = new ToolStripMenuItem();
            кількістьЛітерУТекстіToolStripMenuItem = new ToolStripMenuItem();
            перекластиТекстУВерхнійРегістерToolStripMenuItem = new ToolStripMenuItem();
            знайтиСловаToolStripMenuItem = new ToolStripMenuItem();
            скасуватиФорматуванняToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            groupBox1 = new GroupBox();
            comboBoxFontStyle = new ComboBox();
            comboBoxFontSize = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            editTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, редагуватиToolStripMenuItem, сервісToolStripMenuItem, проПрограмуToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відкритиФайлToolStripMenuItem, зберегтиФайлToolStripMenuItem, завершитиРоботуToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиФайлToolStripMenuItem
            // 
            відкритиФайлToolStripMenuItem.Name = "відкритиФайлToolStripMenuItem";
            відкритиФайлToolStripMenuItem.Size = new Size(178, 22);
            відкритиФайлToolStripMenuItem.Text = "Відкрити файл";
            відкритиФайлToolStripMenuItem.Click += відкритиФайлToolStripMenuItem_Click;
            // 
            // зберегтиФайлToolStripMenuItem
            // 
            зберегтиФайлToolStripMenuItem.Name = "зберегтиФайлToolStripMenuItem";
            зберегтиФайлToolStripMenuItem.Size = new Size(178, 22);
            зберегтиФайлToolStripMenuItem.Text = "Зберегти файл";
            зберегтиФайлToolStripMenuItem.Click += зберегтиФайлToolStripMenuItem_Click;
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
            редагуватиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { змінитиКолірТекстуToolStripMenuItem });
            редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            редагуватиToolStripMenuItem.Size = new Size(79, 20);
            редагуватиToolStripMenuItem.Text = "Редагувати";
            // 
            // змінитиКолірТекстуToolStripMenuItem
            // 
            змінитиКолірТекстуToolStripMenuItem.Name = "змінитиКолірТекстуToolStripMenuItem";
            змінитиКолірТекстуToolStripMenuItem.Size = new Size(189, 22);
            змінитиКолірТекстуToolStripMenuItem.Text = "Змінити колір тексту";
            змінитиКолірТекстуToolStripMenuItem.Click += змінитиКолірТекстуToolStripMenuItem_Click;
            // 
            // сервісToolStripMenuItem
            // 
            сервісToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { показатиКількістьСлівУТекстіToolStripMenuItem, кількістьЛітерУТекстіToolStripMenuItem, перекластиТекстУВерхнійРегістерToolStripMenuItem, знайтиСловаToolStripMenuItem, скасуватиФорматуванняToolStripMenuItem });
            сервісToolStripMenuItem.Name = "сервісToolStripMenuItem";
            сервісToolStripMenuItem.Size = new Size(55, 20);
            сервісToolStripMenuItem.Text = "Сервіс";
            // 
            // показатиКількістьСлівУТекстіToolStripMenuItem
            // 
            показатиКількістьСлівУТекстіToolStripMenuItem.Name = "показатиКількістьСлівУТекстіToolStripMenuItem";
            показатиКількістьСлівУТекстіToolStripMenuItem.Size = new Size(272, 22);
            показатиКількістьСлівУТекстіToolStripMenuItem.Text = "Кількість слів у тексті";
            показатиКількістьСлівУТекстіToolStripMenuItem.Click += показатиКількістьСлівУТекстіToolStripMenuItem_Click;
            // 
            // кількістьЛітерУТекстіToolStripMenuItem
            // 
            кількістьЛітерУТекстіToolStripMenuItem.Name = "кількістьЛітерУТекстіToolStripMenuItem";
            кількістьЛітерУТекстіToolStripMenuItem.Size = new Size(272, 22);
            кількістьЛітерУТекстіToolStripMenuItem.Text = "Кількість літер у тексті";
            кількістьЛітерУТекстіToolStripMenuItem.Click += кількістьЛітерУТекстіToolStripMenuItem_Click;
            // 
            // перекластиТекстУВерхнійРегістерToolStripMenuItem
            // 
            перекластиТекстУВерхнійРегістерToolStripMenuItem.Name = "перекластиТекстУВерхнійРегістерToolStripMenuItem";
            перекластиТекстУВерхнійРегістерToolStripMenuItem.Size = new Size(272, 22);
            перекластиТекстУВерхнійРегістерToolStripMenuItem.Text = "Перекласти текст у верхній регістер";
            перекластиТекстУВерхнійРегістерToolStripMenuItem.Click += перекластиТекстУВерхнійРегістерToolStripMenuItem_Click;
            // 
            // знайтиСловаToolStripMenuItem
            // 
            знайтиСловаToolStripMenuItem.Name = "знайтиСловаToolStripMenuItem";
            знайтиСловаToolStripMenuItem.Size = new Size(272, 22);
            знайтиСловаToolStripMenuItem.Text = "Знайти слова";
            знайтиСловаToolStripMenuItem.Click += знайтиСловаToolStripMenuItem_Click;
            // 
            // скасуватиФорматуванняToolStripMenuItem
            // 
            скасуватиФорматуванняToolStripMenuItem.Name = "скасуватиФорматуванняToolStripMenuItem";
            скасуватиФорматуванняToolStripMenuItem.Size = new Size(272, 22);
            скасуватиФорматуванняToolStripMenuItem.Text = "Скасувати форматування";
            скасуватиФорматуванняToolStripMenuItem.Click += скасуватиФорматуванняToolStripMenuItem_Click;
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(99, 20);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.GradientInactiveCaption;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(12, 85);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(470, 353);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxFontStyle);
            groupBox1.Controls.Add(comboBoxFontSize);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 52);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Шрифт";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBoxFontStyle
            // 
            comboBoxFontStyle.FormattingEnabled = true;
            comboBoxFontStyle.Location = new Point(6, 22);
            comboBoxFontStyle.Name = "comboBoxFontStyle";
            comboBoxFontStyle.Size = new Size(121, 23);
            comboBoxFontStyle.TabIndex = 1;
            comboBoxFontStyle.SelectedIndexChanged += comboBoxFontStyle_SelectedIndexChanged;
            // 
            // comboBoxFontSize
            // 
            comboBoxFontSize.FormattingEnabled = true;
            comboBoxFontSize.Location = new Point(133, 22);
            comboBoxFontSize.Name = "comboBoxFontSize";
            comboBoxFontSize.Size = new Size(46, 23);
            comboBoxFontSize.TabIndex = 0;
            comboBoxFontSize.SelectedIndexChanged += comboBoxFontSize_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(634, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(634, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(501, 88);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 5;
            label1.Text = "Кількість слів";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 126);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 6;
            label2.Text = "Кількість літер";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(634, 201);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(136, 94);
            listBox1.TabIndex = 7;
            // 
            // editTextBox
            // 
            editTextBox.Location = new Point(634, 161);
            editTextBox.Name = "editTextBox";
            editTextBox.Size = new Size(100, 23);
            editTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 164);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 9;
            label3.Text = "Введіть слово (літеру)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 201);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 10;
            label4.Text = "Знайдені слова";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(editTextBox);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Текстовий редактор (дуже спрощений)";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиФайлToolStripMenuItem;
        private ToolStripMenuItem зберегтиФайлToolStripMenuItem;
        private ToolStripMenuItem завершитиРоботуToolStripMenuItem;
        private ToolStripMenuItem редагуватиToolStripMenuItem;
        private ToolStripMenuItem змінитиКолірТекстуToolStripMenuItem;
        private ToolStripMenuItem сервісToolStripMenuItem;
        private ToolStripMenuItem показатиКількістьСлівУТекстіToolStripMenuItem;
        private ToolStripMenuItem кількістьЛітерУТекстіToolStripMenuItem;
        private ToolStripMenuItem перекластиТекстУВерхнійРегістерToolStripMenuItem;
        private ToolStripMenuItem знайтиСловаToolStripMenuItem;
        private ToolStripMenuItem скасуватиФорматуванняToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
        private GroupBox groupBox1;
        private ComboBox comboBoxFontSize;
        private ComboBox comboBoxFontStyle;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private TextBox editTextBox;
        private Label label3;
        private Label label4;
    }
}