namespace LAB_PI
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
            this.lstAbonati = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenereaza = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNotifyForSelectedConsumer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxConsum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnShowUptoMaxConsumer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGenerateRestantConsumer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAbonati
            // 
            this.lstAbonati.FormattingEnabled = true;
            this.lstAbonati.Location = new System.Drawing.Point(6, 19);
            this.lstAbonati.Name = "lstAbonati";
            this.lstAbonati.Size = new System.Drawing.Size(272, 303);
            this.lstAbonati.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Generare fisier cu toti abonatii";
            // 
            // btnGenereaza
            // 
            this.btnGenereaza.Location = new System.Drawing.Point(164, 40);
            this.btnGenereaza.Name = "btnGenereaza";
            this.btnGenereaza.Size = new System.Drawing.Size(95, 37);
            this.btnGenereaza.TabIndex = 4;
            this.btnGenereaza.Text = "Genereaza";
            this.btnGenereaza.UseVisualStyleBackColor = true;
            this.btnGenereaza.Click += new System.EventHandler(this.btnGenereaza_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "si suma totala de plata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Afiseaza instiintare de plata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "pentru abonatul selectat";
            // 
            // btnNotifyForSelectedConsumer
            // 
            this.btnNotifyForSelectedConsumer.Location = new System.Drawing.Point(164, 100);
            this.btnNotifyForSelectedConsumer.Name = "btnNotifyForSelectedConsumer";
            this.btnNotifyForSelectedConsumer.Size = new System.Drawing.Size(95, 26);
            this.btnNotifyForSelectedConsumer.TabIndex = 8;
            this.btnNotifyForSelectedConsumer.Text = "Afiseaza";
            this.btnNotifyForSelectedConsumer.UseVisualStyleBackColor = true;
            this.btnNotifyForSelectedConsumer.Click += new System.EventHandler(this.btnNotifyForSelectedConsumer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Afiseaza tabel cu abonatii care";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "au depasit";
            // 
            // txtMaxConsum
            // 
            this.txtMaxConsum.Location = new System.Drawing.Point(68, 160);
            this.txtMaxConsum.Name = "txtMaxConsum";
            this.txtMaxConsum.Size = new System.Drawing.Size(53, 20);
            this.txtMaxConsum.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "kWh";
            // 
            // btnShowUptoMaxConsumer
            // 
            this.btnShowUptoMaxConsumer.Location = new System.Drawing.Point(164, 143);
            this.btnShowUptoMaxConsumer.Name = "btnShowUptoMaxConsumer";
            this.btnShowUptoMaxConsumer.Size = new System.Drawing.Size(95, 33);
            this.btnShowUptoMaxConsumer.TabIndex = 13;
            this.btnShowUptoMaxConsumer.Text = "Afiseaza";
            this.btnShowUptoMaxConsumer.UseVisualStyleBackColor = true;
            this.btnShowUptoMaxConsumer.Click += new System.EventHandler(this.btnShowUptoMaxConsumer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Generare fisier abonatii restanti";
            // 
            // btnGenerateRestantConsumer
            // 
            this.btnGenerateRestantConsumer.Location = new System.Drawing.Point(164, 197);
            this.btnGenerateRestantConsumer.Name = "btnGenerateRestantConsumer";
            this.btnGenerateRestantConsumer.Size = new System.Drawing.Size(95, 23);
            this.btnGenerateRestantConsumer.TabIndex = 15;
            this.btnGenerateRestantConsumer.Text = "Genereaza";
            this.btnGenerateRestantConsumer.UseVisualStyleBackColor = true;
            this.btnGenerateRestantConsumer.Click += new System.EventHandler(this.btnGenerateRestantConsumer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btnGenerateRestantConsumer);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTarif);
            this.groupBox1.Controls.Add(this.btnShowUptoMaxConsumer);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMaxConsum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnNotifyForSelectedConsumer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGenereaza);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(351, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 231);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EVIDENTA SISTEMULUI";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "lei/kWh";
            // 
            // txtTarif
            // 
            this.txtTarif.Location = new System.Drawing.Point(41, 61);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(64, 20);
            this.txtTarif.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tarif:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.lstAbonati);
            this.groupBox2.Location = new System.Drawing.Point(29, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 328);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abonatii Sistemului de Energie Electrica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAbonati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenereaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNotifyForSelectedConsumer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaxConsum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnShowUptoMaxConsumer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGenerateRestantConsumer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

