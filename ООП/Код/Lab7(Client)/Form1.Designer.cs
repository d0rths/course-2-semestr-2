namespace Lab7_Client_
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
            this.buttonClientConnect = new System.Windows.Forms.Button();
            this.Edit1 = new System.Windows.Forms.TextBox();
            this.Edit2 = new System.Windows.Forms.TextBox();
            this.Edit3 = new System.Windows.Forms.TextBox();
            this.Edit4 = new System.Windows.Forms.TextBox();
            this.Edit5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClientConnect
            // 
            this.buttonClientConnect.Location = new System.Drawing.Point(144, 210);
            this.buttonClientConnect.Name = "buttonClientConnect";
            this.buttonClientConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonClientConnect.TabIndex = 0;
            this.buttonClientConnect.Text = "Connect";
            this.buttonClientConnect.UseVisualStyleBackColor = true;
            this.buttonClientConnect.Click += new System.EventHandler(this.buttonClientConnect_Click);
            // 
            // Edit1
            // 
            this.Edit1.Location = new System.Drawing.Point(100, 37);
            this.Edit1.Name = "Edit1";
            this.Edit1.Size = new System.Drawing.Size(164, 20);
            this.Edit1.TabIndex = 1;
            // 
            // Edit2
            // 
            this.Edit2.Location = new System.Drawing.Point(100, 85);
            this.Edit2.Name = "Edit2";
            this.Edit2.Size = new System.Drawing.Size(164, 20);
            this.Edit2.TabIndex = 2;
            // 
            // Edit3
            // 
            this.Edit3.Location = new System.Drawing.Point(100, 268);
            this.Edit3.Name = "Edit3";
            this.Edit3.Size = new System.Drawing.Size(164, 20);
            this.Edit3.TabIndex = 3;
            // 
            // Edit4
            // 
            this.Edit4.Location = new System.Drawing.Point(100, 135);
            this.Edit4.Name = "Edit4";
            this.Edit4.Size = new System.Drawing.Size(164, 20);
            this.Edit4.TabIndex = 4;
            // 
            // Edit5
            // 
            this.Edit5.Location = new System.Drawing.Point(100, 184);
            this.Edit5.Name = "Edit5";
            this.Edit5.Size = new System.Drawing.Size(164, 20);
            this.Edit5.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Порт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP-адреса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Логін";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Пароль";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(12, 347);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(16, 13);
            this.labelConnectionStatus.TabIndex = 11;
            this.labelConnectionStatus.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 379);
            this.Controls.Add(this.labelConnectionStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Edit5);
            this.Controls.Add(this.Edit4);
            this.Controls.Add(this.Edit3);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.buttonClientConnect);
            this.Name = "Form1";
            this.Text = "Клієнт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClientConnect;
        private System.Windows.Forms.TextBox Edit1;
        private System.Windows.Forms.TextBox Edit2;
        private System.Windows.Forms.TextBox Edit3;
        private System.Windows.Forms.TextBox Edit4;
        private System.Windows.Forms.TextBox Edit5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConnectionStatus;
    }
}

