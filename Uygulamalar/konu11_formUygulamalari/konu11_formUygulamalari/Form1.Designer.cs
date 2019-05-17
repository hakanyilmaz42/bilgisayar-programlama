namespace konu11_formUygulamalari
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnSayiAl = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.txtVeri1 = new System.Windows.Forms.TextBox();
            this.txtVeri2 = new System.Windows.Forms.TextBox();
            this.btnUzaklik = new System.Windows.Forms.Button();
            this.btnMaasHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(12, 12);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(122, 22);
            this.txtSayi.TabIndex = 0;
            // 
            // btnSayiAl
            // 
            this.btnSayiAl.Location = new System.Drawing.Point(154, 12);
            this.btnSayiAl.Name = "btnSayiAl";
            this.btnSayiAl.Size = new System.Drawing.Size(116, 44);
            this.btnSayiAl.TabIndex = 1;
            this.btnSayiAl.Text = "Sayı Al";
            this.btnSayiAl.UseVisualStyleBackColor = true;
            this.btnSayiAl.Click += new System.EventHandler(this.btnSayiAl_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(370, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 340);
            this.listBox1.TabIndex = 2;
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.Location = new System.Drawing.Point(154, 74);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(116, 44);
            this.btnIslemYap.TabIndex = 3;
            this.btnIslemYap.Text = "İşlem Yap";
            this.btnIslemYap.UseVisualStyleBackColor = true;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // txtVeri1
            // 
            this.txtVeri1.Location = new System.Drawing.Point(650, 12);
            this.txtVeri1.Name = "txtVeri1";
            this.txtVeri1.Size = new System.Drawing.Size(122, 22);
            this.txtVeri1.TabIndex = 4;
            // 
            // txtVeri2
            // 
            this.txtVeri2.Location = new System.Drawing.Point(796, 12);
            this.txtVeri2.Name = "txtVeri2";
            this.txtVeri2.Size = new System.Drawing.Size(122, 22);
            this.txtVeri2.TabIndex = 5;
            // 
            // btnUzaklik
            // 
            this.btnUzaklik.Location = new System.Drawing.Point(650, 54);
            this.btnUzaklik.Name = "btnUzaklik";
            this.btnUzaklik.Size = new System.Drawing.Size(116, 44);
            this.btnUzaklik.TabIndex = 6;
            this.btnUzaklik.Text = "İşlem Yap";
            this.btnUzaklik.UseVisualStyleBackColor = true;
            this.btnUzaklik.Click += new System.EventHandler(this.btnUzaklik_Click);
            // 
            // btnMaasHesapla
            // 
            this.btnMaasHesapla.Location = new System.Drawing.Point(796, 54);
            this.btnMaasHesapla.Name = "btnMaasHesapla";
            this.btnMaasHesapla.Size = new System.Drawing.Size(116, 44);
            this.btnMaasHesapla.TabIndex = 7;
            this.btnMaasHesapla.Text = "İşlem Yap";
            this.btnMaasHesapla.UseVisualStyleBackColor = true;
            this.btnMaasHesapla.Click += new System.EventHandler(this.btnMaasHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 574);
            this.Controls.Add(this.btnMaasHesapla);
            this.Controls.Add(this.btnUzaklik);
            this.Controls.Add(this.txtVeri2);
            this.Controls.Add(this.txtVeri1);
            this.Controls.Add(this.btnIslemYap);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSayiAl);
            this.Controls.Add(this.txtSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnSayiAl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnIslemYap;
        private System.Windows.Forms.TextBox txtVeri1;
        private System.Windows.Forms.TextBox txtVeri2;
        private System.Windows.Forms.Button btnUzaklik;
        private System.Windows.Forms.Button btnMaasHesapla;
    }
}

