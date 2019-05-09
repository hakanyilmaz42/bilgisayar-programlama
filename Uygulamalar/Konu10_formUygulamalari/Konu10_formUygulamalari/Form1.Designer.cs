namespace Konu10_formUygulamalari
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKelimeSay = new System.Windows.Forms.Button();
            this.btnEposta = new System.Windows.Forms.Button();
            this.btnIlkHarfBuyuk = new System.Windows.Forms.Button();
            this.btnTarihZaman = new System.Windows.Forms.Button();
            this.txtVeri1 = new System.Windows.Forms.TextBox();
            this.txtVeri2 = new System.Windows.Forms.TextBox();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnKarekok = new System.Windows.Forms.Button();
            this.btnKuvvet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(535, 291);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(365, 318);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(181, 22);
            this.txtSonuc.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(572, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 484);
            this.listBox1.TabIndex = 2;
            // 
            // btnKelimeSay
            // 
            this.btnKelimeSay.Location = new System.Drawing.Point(831, 28);
            this.btnKelimeSay.Name = "btnKelimeSay";
            this.btnKelimeSay.Size = new System.Drawing.Size(144, 35);
            this.btnKelimeSay.TabIndex = 3;
            this.btnKelimeSay.Text = "Kelime Say";
            this.btnKelimeSay.UseVisualStyleBackColor = true;
            this.btnKelimeSay.Click += new System.EventHandler(this.btnKelimeSay_Click);
            // 
            // btnEposta
            // 
            this.btnEposta.Location = new System.Drawing.Point(834, 79);
            this.btnEposta.Name = "btnEposta";
            this.btnEposta.Size = new System.Drawing.Size(140, 35);
            this.btnEposta.TabIndex = 4;
            this.btnEposta.Text = "Eposta kontrol";
            this.btnEposta.UseVisualStyleBackColor = true;
            this.btnEposta.Click += new System.EventHandler(this.btnEposta_Click);
            // 
            // btnIlkHarfBuyuk
            // 
            this.btnIlkHarfBuyuk.Location = new System.Drawing.Point(836, 133);
            this.btnIlkHarfBuyuk.Name = "btnIlkHarfBuyuk";
            this.btnIlkHarfBuyuk.Size = new System.Drawing.Size(138, 36);
            this.btnIlkHarfBuyuk.TabIndex = 5;
            this.btnIlkHarfBuyuk.Text = "İlk harf büyük";
            this.btnIlkHarfBuyuk.UseVisualStyleBackColor = true;
            this.btnIlkHarfBuyuk.Click += new System.EventHandler(this.btnIlkHarfBuyuk_Click);
            // 
            // btnTarihZaman
            // 
            this.btnTarihZaman.Location = new System.Drawing.Point(836, 185);
            this.btnTarihZaman.Name = "btnTarihZaman";
            this.btnTarihZaman.Size = new System.Drawing.Size(137, 39);
            this.btnTarihZaman.TabIndex = 6;
            this.btnTarihZaman.Text = "Tarih Zaman";
            this.btnTarihZaman.UseVisualStyleBackColor = true;
            this.btnTarihZaman.Click += new System.EventHandler(this.btnTarihZaman_Click);
            // 
            // txtVeri1
            // 
            this.txtVeri1.Location = new System.Drawing.Point(12, 318);
            this.txtVeri1.Name = "txtVeri1";
            this.txtVeri1.Size = new System.Drawing.Size(132, 22);
            this.txtVeri1.TabIndex = 7;
            // 
            // txtVeri2
            // 
            this.txtVeri2.Location = new System.Drawing.Point(174, 318);
            this.txtVeri2.Name = "txtVeri2";
            this.txtVeri2.Size = new System.Drawing.Size(132, 22);
            this.txtVeri2.TabIndex = 8;
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Location = new System.Drawing.Point(836, 244);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(137, 39);
            this.btnOrtalama.TabIndex = 9;
            this.btnOrtalama.Text = "Ortalama";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(858, 308);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(66, 31);
            this.btnTopla.TabIndex = 10;
            this.btnTopla.Text = "topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(858, 345);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(66, 31);
            this.btnCikar.TabIndex = 11;
            this.btnCikar.Text = "çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnKarekok
            // 
            this.btnKarekok.Location = new System.Drawing.Point(858, 419);
            this.btnKarekok.Name = "btnKarekok";
            this.btnKarekok.Size = new System.Drawing.Size(66, 31);
            this.btnKarekok.TabIndex = 13;
            this.btnKarekok.Text = "karekök";
            this.btnKarekok.UseVisualStyleBackColor = true;
            this.btnKarekok.Click += new System.EventHandler(this.btnKarekok_Click);
            // 
            // btnKuvvet
            // 
            this.btnKuvvet.Location = new System.Drawing.Point(858, 382);
            this.btnKuvvet.Name = "btnKuvvet";
            this.btnKuvvet.Size = new System.Drawing.Size(66, 31);
            this.btnKuvvet.TabIndex = 12;
            this.btnKuvvet.Text = "kuvvet";
            this.btnKuvvet.UseVisualStyleBackColor = true;
            this.btnKuvvet.Click += new System.EventHandler(this.btnKuvvet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 557);
            this.Controls.Add(this.btnKarekok);
            this.Controls.Add(this.btnKuvvet);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnOrtalama);
            this.Controls.Add(this.txtVeri2);
            this.Controls.Add(this.txtVeri1);
            this.Controls.Add(this.btnTarihZaman);
            this.Controls.Add(this.btnIlkHarfBuyuk);
            this.Controls.Add(this.btnEposta);
            this.Controls.Add(this.btnKelimeSay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Konu10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKelimeSay;
        private System.Windows.Forms.Button btnEposta;
        private System.Windows.Forms.Button btnIlkHarfBuyuk;
        private System.Windows.Forms.Button btnTarihZaman;
        private System.Windows.Forms.TextBox txtVeri1;
        private System.Windows.Forms.TextBox txtVeri2;
        private System.Windows.Forms.Button btnOrtalama;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnKarekok;
        private System.Windows.Forms.Button btnKuvvet;
    }
}

