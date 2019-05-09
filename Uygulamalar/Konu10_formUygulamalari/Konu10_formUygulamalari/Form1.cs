using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konu10_formUygulamalari
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public int y = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnKelimeSay_Click(object sender, EventArgs e)
        {
            string[] kelimeler = richTextBox1.Text.Split(' ');
            txtSonuc.Text = kelimeler.Length.ToString();
            foreach(string kelime in kelimeler)
            {
                listBox1.Items.Add(kelime);
            }
        }

        private void btnEposta_Click(object sender, EventArgs e)
        {
            string eposta = richTextBox1.Text;
            if (eposta.IndexOf("@")<0 || eposta.IndexOf(".") < 0)
            {
                MessageBox.Show("Eposta adresi geçerli değil");
            }else
            {
                MessageBox.Show("geçerli. sorun yok.");
            }
        }

        private void btnIlkHarfBuyuk_Click(object sender, EventArgs e)
        {
            string[] kelimeler = richTextBox1.Text.Split(' ');
            string[] degisenKelimeler = new string[kelimeler.Length];

            for (int i=0;i<kelimeler.Length;i++)
            {
                string ilkParca = kelimeler[i].Substring(0, 1);
                ilkParca = ilkParca.ToUpper();
                string sonParca = kelimeler[i].Substring(1,kelimeler[i].Length-1);
                sonParca = sonParca.ToLower();
                string sonKelime = String.Concat(ilkParca, sonParca);
                degisenKelimeler[i] = sonKelime;
            }
            richTextBox1.Text = String.Join(" ", degisenKelimeler);
        }

        private void btnTarihZaman_Click(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            Console.WriteLine("Şuanki zaman: {0}", simdi);

            DateTime ileri = simdi.AddMonths(200);
            Console.WriteLine("İleri zaman: {0}", ileri);

            DateTime dGunu = new DateTime(1997,01,20);

            TimeSpan ts = new TimeSpan();
            ts = simdi - dGunu;
            Console.WriteLine("geçen gün: {0}", ts.TotalDays);
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            int vize = int.Parse(txtVeri1.Text);
            int final = int.Parse(txtVeri2.Text);
            txtSonuc.Text = ortalamaAl(vize, final).ToString();

            if (ortalamaAl(vize, final)<49.5)
            {
                txtSonuc.BackColor = Color.Red;
            }else
            {
                txtSonuc.BackColor = Color.Green;
            }
        }

        public double ortalamaAl(int vize,int final)
        {
            return vize * 0.4 + final * 0.6;
        }

        public double topla(int x,int y)
        {
            return x + y;
        }
        public double cikar(int x, int y)
        {
            return x - y;
        }
        public double kuvvet(int x, int y)
        {
            return Math.Pow(x,y);
        }
        public double karekok(int x)
        {
            return Math.Sqrt(x);
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtVeri1.Text);
            y = int.Parse(txtVeri2.Text);
            txtSonuc.Text = topla(x, y).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtVeri1.Text);
            y = int.Parse(txtVeri2.Text);
            txtSonuc.Text = cikar(x, y).ToString();
        }

        private void btnKuvvet_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtVeri1.Text);
            y = int.Parse(txtVeri2.Text);
            txtSonuc.Text = kuvvet(x, y).ToString();
        }

        private void btnKarekok_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtVeri1.Text);
            y = int.Parse(txtVeri2.Text);
            txtSonuc.Text = karekok(x).ToString();
        }
    }
}
