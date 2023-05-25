namespace Merkle_Hellman
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.EBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.PBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LogsBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1, 2, 4, 9";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "15";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "17";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(319, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(38, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Private Key (S)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(204, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Multiplier (W)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modulus (N)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Siz(M)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Public Key (H)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Plain text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Encrypted";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(204, 174);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 234);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(345, 59);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "0100101110100101";
            // 
            // EBox
            // 
            this.EBox.Location = new System.Drawing.Point(12, 328);
            this.EBox.Multiline = true;
            this.EBox.Name = "EBox";
            this.EBox.Size = new System.Drawing.Size(344, 86);
            this.EBox.TabIndex = 15;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(12, 586);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(110, 44);
            this.encryptButton.TabIndex = 17;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(128, 586);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(116, 44);
            this.decryptButton.TabIndex = 18;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Muliplier inverse (W-1)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 174);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(117, 20);
            this.textBox8.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(135, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "W-1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(250, 586);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 44);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Plain text";
            // 
            // PBox
            // 
            this.PBox.Location = new System.Drawing.Point(12, 453);
            this.PBox.Multiline = true;
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(344, 127);
            this.PBox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 35);
            this.label10.TabIndex = 26;
            this.label10.Text = "Merkle-Hellman";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // LogsBox
            // 
            this.LogsBox.Location = new System.Drawing.Point(363, 9);
            this.LogsBox.Name = "LogsBox";
            this.LogsBox.Size = new System.Drawing.Size(308, 621);
            this.LogsBox.TabIndex = 27;
            this.LogsBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 26);
            this.button2.TabIndex = 28;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 26);
            this.button3.TabIndex = 29;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 642);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LogsBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.EBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "MerkleHellmanSimulation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox EBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox LogsBox;
    }
}