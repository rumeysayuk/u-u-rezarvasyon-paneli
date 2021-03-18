using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uçuş_rezarvasyon_paneli.Nesne;
using uçuş_rezarvasyon_paneli.Report;

namespace uçuş_rezarvasyon_paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota : " + comboBox1.Text + " - " + comboBox2.Text+" Tarih : "+dateTimePicker1.Value
                +" Saat : "+maskedTextBox1.Text+" Yolcu bilgileri ~ Ad : "+textBox1.Text+" Tc : "+maskedTextBox2.Text
                +" telefon : "+maskedTextBox3.Text);

            // dün gece gelmedi aklımda normalde web de oluyorduda denicem burdada olucakmı bakalım

            BiletReport biletReport = new BiletReport();



            biletReport.Parameters["adSoyad"].Value = textBox1.Text;
            biletReport.Parameters["saat"].Value = maskedTextBox1.Text;
            biletReport.Parameters["tc"].Value = maskedTextBox2.Text;
            biletReport.Parameters["telefon"].Value = maskedTextBox3.Text;
            biletReport.Parameters["nereden"].Value = comboBox1.Text;
            biletReport.Parameters["nereye"].Value = comboBox2.Text;
            //bak böylede kullanabilirsin direk diğer parametrelere burdan değer basarsın
            //biletraporu2 yede aşşağıdaki önce yaptığım gibi çoklu veri basmak için liste kullanabilirsin
            //tek bilet vereceksin sen burda onun için bu şekilde liste oluşturmadan
            //yapabilirisn pşt ordamısınburdayımm anladım hadi bakalım o zaman bekliyorum senden
            //şöyle afilli şeyler şimdi mıı
            // niye uykunmu geldi :D yoo 
            // müsait olunca bakarsın artık o zaman bitane bişey daha sorayım saat listeye geldi ama ben o tabloya ekleyemedim o nasıl oalcak
            // önce parametre eklemen gerekiyo anladım ben label aldım koydum ondan olmamış hemde burdan ona veri göndermen gerek
            // buna yap yapacaklarını biletraporu2 yi sonra öğrenirsin dün gece uçmuşum biraz :D bende de kalmamışlar kim nerden geliyo kattım karıştırdım
            // olu röyle bundan başla ona geçirriz seni sonra :D  bunları yapmaya çalışayım şimdi anladım dün pek anlamsızlardı
            // çünkü dün bunun ilerisini anlattım işte uzun zamandır kullanmayınca hemen gelmiyo akla 1 yıl olcak nerdeyse düşün 
            //maşallah :) tamam barmı sormak istediğin bişi şimdiilik yok tamamdır kolaygeslin 

            biletReport.CreateDocument();
            biletReport.Print();
            //List<biletRaporNesne> brnl = new List<biletRaporNesne>();

            //for (int i = 0; i < 3; i++)
            //{
            //    biletRaporNesne brn = new biletRaporNesne();
            //    brn.AdSoyad = textBox1.Text +"  no:"+ i.ToString() ;
            //    brn.Tc = maskedTextBox2.Text + "  no:" + i.ToString();
            //    brn.Phone = maskedTextBox3.Text + "  no:" + i.ToString();
            //    brnl.Add(brn);
            //}



            //BiletRaporu2 br = new BiletRaporu2();

            //br.DataSource = brnl;
            //br.CreateDocument();
            //br.Print();

           MessageBox.Show("yolcu kaydı başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label9.Text  = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text; 

        }
    }
}

