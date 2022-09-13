using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProteinDataBankasıSena
{
    public partial class Form1 : Form
    {
        int turkseverSena; //atom sayısı tanımla
        double antalyaXKoordinat; //maksimum x koordinatı tanımla
        String antalyaKonyaalti; //atom adını tanımla
        String sifirYedi; //atom sayısını tanımla
        String maxKordinat; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void senaTurksever(String path)
        {
            antalyaXKoordinat = 0;
            turkseverSena = 0;
            String sena;
            StreamReader streamReader = new StreamReader(path); //dosya yolunu okumak için
            while ((sena = streamReader.ReadLine()) != null) // satırları sonuna kadar oku
            {
                if (sena.StartsWith("ATOM")) //atomla eşleştiyor mu?
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        sena = sena.Replace("  ", " "); //dizede değişiklik yap
                    }
                    double strToDouble = double.Parse(sena.Split(' ')[6]); //6 dize temsili
                    listBox1.Items.Add(sena); //sena değişkenini yazdır
                    if (strToDouble > antalyaXKoordinat)
                    {
                        maxKordinat = sena.Split(' ')[6]; //kodu böl
                        antalyaXKoordinat = strToDouble;
                        sifirYedi = sena.Split(' ')[1];
                        antalyaKonyaalti = sena.Split(' ')[2];

                    }
                    turkseverSena++; //atom sayısı arttır

                    label1.Text = turkseverSena.ToString();
                    label2.Text = "Atom Adı: " + antalyaKonyaalti + " Atom No: " + sifirYedi + " X Koordinat: " + maxKordinat;
                }

            }


            streamReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text)) //null veya boş dize mi? değilse senaTurkseveri yazdır.
            {
                senaTurksever(textBox1.Text);

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}


