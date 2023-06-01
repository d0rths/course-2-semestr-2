namespace Lab4
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
            створитиToolStripMenuItem = new ToolStripMenuItem();
            завершитиРоботуToolStripMenuItem = new ToolStripMenuItem();
            вікноToolStripMenuItem = new ToolStripMenuItem();
            мозаїкаToolStripMenuItem = new ToolStripMenuItem();
            каскадомToolStripMenuItem = new ToolStripMenuItem();
            закритиВсеToolStripMenuItem = new ToolStripMenuItem();
            сервісToolStripMenuItem = new ToolStripMenuItem();
            пронумеруватиФормиToolStripMenuItem = new ToolStripMenuItem();
            отриматиПершуToolStripMenuItem = new ToolStripMenuItem();
            отриматиОстаннюToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, вікноToolStripMenuItem, сервісToolStripMenuItem, проПрограмуToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { створитиToolStripMenuItem, завершитиРоботуToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // створитиToolStripMenuItem
            // 
            створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            створитиToolStripMenuItem.Size = new Size(178, 22);
            створитиToolStripMenuItem.Text = "Створити";
            створитиToolStripMenuItem.Click += створитиToolStripMenuItem_Click;
            // 
            // завершитиРоботуToolStripMenuItem
            // 
            завершитиРоботуToolStripMenuItem.Name = "завершитиРоботуToolStripMenuItem";
            завершитиРоботуToolStripMenuItem.Size = new Size(178, 22);
            завершитиРоботуToolStripMenuItem.Text = "Завершити роботу";
            завершитиРоботуToolStripMenuItem.Click += завершитиРоботуToolStripMenuItem_Click;
            // 
            // вікноToolStripMenuItem
            // 
            вікноToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { мозаїкаToolStripMenuItem, каскадомToolStripMenuItem, закритиВсеToolStripMenuItem });
            вікноToolStripMenuItem.Name = "вікноToolStripMenuItem";
            вікноToolStripMenuItem.Size = new Size(49, 20);
            вікноToolStripMenuItem.Text = "Вікно";
            // 
            // мозаїкаToolStripMenuItem
            // 
            мозаїкаToolStripMenuItem.Name = "мозаїкаToolStripMenuItem";
            мозаїкаToolStripMenuItem.Size = new Size(140, 22);
            мозаїкаToolStripMenuItem.Text = "Мозаїка";
            мозаїкаToolStripMenuItem.Click += мозаїкаToolStripMenuItem_Click;
            // 
            // каскадомToolStripMenuItem
            // 
            каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            каскадомToolStripMenuItem.Size = new Size(140, 22);
            каскадомToolStripMenuItem.Text = "Каскадом";
            каскадомToolStripMenuItem.Click += каскадомToolStripMenuItem_Click;
            // 
            // закритиВсеToolStripMenuItem
            // 
            закритиВсеToolStripMenuItem.Name = "закритиВсеToolStripMenuItem";
            закритиВсеToolStripMenuItem.Size = new Size(140, 22);
            закритиВсеToolStripMenuItem.Text = "Закрити все";
            закритиВсеToolStripMenuItem.Click += закритиВсеToolStripMenuItem_Click;
            // 
            // сервісToolStripMenuItem
            // 
            сервісToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пронумеруватиФормиToolStripMenuItem, отриматиПершуToolStripMenuItem, отриматиОстаннюToolStripMenuItem });
            сервісToolStripMenuItem.Name = "сервісToolStripMenuItem";
            сервісToolStripMenuItem.Size = new Size(55, 20);
            сервісToolStripMenuItem.Text = "Сервіс";
            // 
            // пронумеруватиФормиToolStripMenuItem
            // 
            пронумеруватиФормиToolStripMenuItem.Name = "пронумеруватиФормиToolStripMenuItem";
            пронумеруватиФормиToolStripMenuItem.Size = new Size(204, 22);
            пронумеруватиФормиToolStripMenuItem.Text = "Пронумерувати форми";
            пронумеруватиФормиToolStripMenuItem.Click += пронумеруватиФормиToolStripMenuItem_Click;
            // 
            // отриматиПершуToolStripMenuItem
            // 
            отриматиПершуToolStripMenuItem.Name = "отриматиПершуToolStripMenuItem";
            отриматиПершуToolStripMenuItem.Size = new Size(204, 22);
            отриматиПершуToolStripMenuItem.Text = "Отримати першу";
            отриматиПершуToolStripMenuItem.Click += отриматиПершуToolStripMenuItem_Click;
            // 
            // отриматиОстаннюToolStripMenuItem
            // 
            отриматиОстаннюToolStripMenuItem.Name = "отриматиОстаннюToolStripMenuItem";
            отриматиОстаннюToolStripMenuItem.Size = new Size(204, 22);
            отриматиОстаннюToolStripMenuItem.Text = "Отримати останню";
            отриматиОстаннюToolStripMenuItem.Click += отриматиОстаннюToolStripMenuItem_Click;
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(99, 20);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Лабораторна робота 4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem створитиToolStripMenuItem;
        private ToolStripMenuItem завершитиРоботуToolStripMenuItem;
        private ToolStripMenuItem вікноToolStripMenuItem;
        private ToolStripMenuItem мозаїкаToolStripMenuItem;
        private ToolStripMenuItem каскадомToolStripMenuItem;
        private ToolStripMenuItem закритиВсеToolStripMenuItem;
        private ToolStripMenuItem сервісToolStripMenuItem;
        private ToolStripMenuItem пронумеруватиФормиToolStripMenuItem;
        private ToolStripMenuItem отриматиПершуToolStripMenuItem;
        private ToolStripMenuItem отриматиОстаннюToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
    }
}