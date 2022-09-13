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

namespace SenaTurksever
{
    public partial class Form1 : Form
    {
        
        int sayı;
        int sayac = 0;
        bool turksever = true;
        int a = 0;
        int b = 0;
     
     

        
   
        public Form1()
        {
            InitializeComponent();
        }
        private int birlerBasamagi(int sena) //birler basamağını tanımladık
        {
            int birler = sena % 10;
            return birler;
        }

        private int onlarBasamagi(int sena) //onlar basamağını tanımladık
        {
            int birler = sena % 10;
            sena = sena / 10;
            int onlar = sena % 10;
            return onlar;
        }

        private int yuzlerBasamagi(int sena) //yuzler basamağını tanımladık
        {
            int birler = sena % 10;
            sena = sena / 10;
            int onlar = sena % 10;
            sena = sena / 10;
            int yuzler = sena % 10;
            return yuzler;
        }

        private int binlerBasamagi(int sena) //binler basamağını tanımladık
        {
            int birler = sena % 10;
            sena = sena / 10;
            int onlar = sena % 10;
            sena = sena / 10;
            int yuzler = sena % 10;
            sena = sena / 10;
            int binler = sena % 10;
            return binler;
        }
       
        private bool basamaklarFarkli(int sena) //basamakları birbirinden farklı sayı ürettik
        {
            // birler, onlar,yuzler,binler olarak int değişken atadık
            int birler = birlerBasamagi(sena);
            int onlar = onlarBasamagi(sena);
            int yuzler = yuzlerBasamagi(sena);
            int binler = binlerBasamagi(sena);
            if (birler == onlar || birler == yuzler || birler == binler)
            {
                return true;
            }

            if (onlar == yuzler || onlar == binler)
            {
                return true;
            }

            if (yuzler == binler)
            {
                return true;
            }

            return false;
        }
       
            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonBASLAT_Click(object sender, EventArgs e)
        {
            listboxTahminler.Items.Clear();  //listboxa yazı düşmemesi için başlat butonuna basana kadar
            textSAYI.Text = ""; //değer gir


            Random r = new Random(); //random sayı atadık
            sayı = r.Next(1000, 9999);
            while (turksever) //bool tanımlı değişkeni döndür
            {
                turksever = basamaklarFarkli(sayı);
            }
           
           
            listboxTahminler.Items.Add("Bir Sayı Giriniz");
            textSAYI.Enabled = true; //baslatınca sayı girisi yap

        }

        private void buttonBITIR_Click(object sender, EventArgs e)
        {
            listboxTahminler.Items.Add("Random Sayı:" + sayı); //programı bitire tıklayınca random sayıyı gösteriyor
            textSAYI.Enabled = false; //textboxa veri girişi false döndür
        }
        
        private void buttonBUL_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            
            int tahmin = 0;
            tahmin = int.Parse(textSAYI.Text); //tahmini textboxa yaz
            textSAYI.Clear(); //tahminden sonra textbox temizle
            sayac++; //sayacı arttır

            if (binlerBasamagi(tahmin) == binlerBasamagi(sayı)) //binler basamakları eşitse a değerini arttır
            {
                a++;
            }
            else if(binlerBasamagi(tahmin) == birlerBasamagi(sayı) || binlerBasamagi(tahmin) == onlarBasamagi(sayı) || binlerBasamagi(tahmin)== yuzlerBasamagi(sayı)) 
            {
                b++; //binler basamak tahmini diğerleri ile eşitse byi arttır
            }

            if(yuzlerBasamagi(tahmin) ==yuzlerBasamagi(sayı)) //yuzler basamakları eşitşe a arttır
            {
                a++;
            }
            else if(yuzlerBasamagi(tahmin) == binlerBasamagi(sayı) || yuzlerBasamagi(tahmin) == onlarBasamagi(sayı) || yuzlerBasamagi(tahmin) == birlerBasamagi(sayı))
            {
                b++; //diğer basamaklara eşitse b yi arttır
            }
            if(onlarBasamagi(tahmin) == onlarBasamagi(sayı)) //onlar basamakları eşitse a arttır
            {
                a++;
            }
            else if(onlarBasamagi(tahmin) == binlerBasamagi(sayı) || onlarBasamagi(tahmin) == yuzlerBasamagi(sayı) || onlarBasamagi(tahmin) == birlerBasamagi(sayı))
            {
                b++; //diğer basamaklar eşitse b arttır
            }
            if(birlerBasamagi(tahmin) == birlerBasamagi(sayı)) //birler basamakları eşitse a arttır
            {
                a++;
            }
            else if(birlerBasamagi(tahmin) == onlarBasamagi(sayı) || birlerBasamagi(tahmin) == yuzlerBasamagi(sayı) || birlerBasamagi(tahmin) == binlerBasamagi(sayı) )
            {
                b++; //diğer basamaklar eşitse b arttır
            } 
            
            
            listboxTahminler.Items.Add("(+" + a.ToString() + ",-" + b.ToString() + ")");
            //sayının yeri doğruysa + a yazdır, sayı doğru yeri değilse -b yazdır
            if(tahmin == sayı)
            {
                listboxTahminler.Items.Add("\nTebrikler" + sayac + "tahminde buldunuz");
                //ne kadar oyunda bulduğunu yazdır
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textSAYI.Enabled = false; //textbox kapalı
        }
    }
}

