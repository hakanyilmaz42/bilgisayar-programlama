using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konu11_formUygulamalari
{
    public partial class Form1 : Form
    {
        List<int> sayilar = new List<int>();
        int nSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayiAl_Click(object sender, EventArgs e)
        {
            if (nSayisi==0)
            {
                nSayisi = int.Parse(txtSayi.Text);
            }
            else
            {
                if (sayilar.Count < nSayisi)
                {
                    btnSayiAl.Text = (sayilar.Count+2).ToString()+" .sayıyı giriniz.";
                    sayilar.Add(int.Parse(txtSayi.Text));
                    
                }else
                {
                    btnSayiAl.Enabled = false;
                    foreach (int sayi in sayilar)
                    {
                        listBox1.Items.Add(sayi);
                    }
                }
            }
        }

        public double toplamAl()
        {
            double toplam = 0;
            foreach(int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(toplamAl());
            double ortalama = toplamAl() / nSayisi;
            listBox1.Items.Add(ortalama);

            sayilar.Sort();
            string medyan = "";
            if (sayilar.Count%2==0)
            {
                medyan = sayilar[sayilar.Count / 2].ToString() + ";" + sayilar[(sayilar.Count / 2) - 1].ToString();
                listBox1.Items.Add(medyan);
            }
            else
            {
                int orta = (sayilar.Count / 2);
                listBox1.Items.Add(sayilar[orta]);
            }
            double karelerToplami = 0;
            foreach(int sayi in sayilar)
            {
                karelerToplami += Math.Pow((sayi - ortalama), 2);
            }

            double sp = Math.Sqrt(karelerToplami / (nSayisi - 1));
            listBox1.Items.Add(sp);
        }

        private void btnUzaklik_Click(object sender, EventArgs e)
        {
            string[] noktalar1 = txtVeri1.Text.Split(';');
            string[] noktalar2 = txtVeri2.Text.Split(';');
            int x1 = int.Parse(noktalar1[0]);
            int y1 = int.Parse(noktalar1[1]);
            int x2 = int.Parse(noktalar2[0]);
            int y2 = int.Parse(noktalar2[1]);

            double uzaklik = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            listBox1.Items.Add(uzaklik);
        }

        private void btnMaasHesapla_Click(object sender, EventArgs e)
        {
            double maas = Convert.ToDouble(txtSayi.Text);
            double artisOrani = Convert.ToDouble(txtVeri1.Text);
            double yil = Convert.ToDouble(txtVeri2.Text);

            for (int i=1;i<=yil;i++)
            {
                maas += (maas * artisOrani) / 100;
                listBox1.Items.Add(i + ". yıl sonunda" + maas);
            }
        }
    }
}
