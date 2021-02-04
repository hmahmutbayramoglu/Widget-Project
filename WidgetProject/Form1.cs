using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Xml;
using Microsoft.Win32;

namespace Masaüstü_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue(ProgramAdi).ToString() == "\"" + Application.ExecutablePath + "\"")
                { // Eğer regeditte varsa, checkbox ı işaretle
                    bunifuCheckbox1.Checked = true;
                }
            }
            catch
            {

            }

        }
     
  

        public string html;
        public Uri url;

        public void Verigun(String Url, String XPath, Label cıkansonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {
            }
            catch (ArgumentNullException)
            {
            }
            WebClient Client = new WebClient();
            Client.Encoding = Encoding.UTF8;
            try
            {
                html = Client.DownloadString(url);
            }
            catch (WebException)
            {


            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                cıkansonuc.Text =doc.DocumentNode.SelectSingleNode(XPath).InnerText;
            }
            catch (NullReferenceException)
            {


            }
        }

        public void tarihte_bugün (String Url, String XPath, TextBox cıkansonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {
            }
            catch (ArgumentNullException)
            {
            }
            WebClient Client = new WebClient();
            Client.Encoding = Encoding.UTF8;
            try
            {
                html = Client.DownloadString(url);
            }
            catch (WebException)
            {


            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                cıkansonuc.Text = doc.DocumentNode.SelectSingleNode(XPath).InnerText;
            }
            catch (NullReferenceException)
            {


            }
        }



        #region  url

        /*   Uri url = new Uri("https://www.youtube.com/");

           WebClient client = new WebClient();
           string html = client.DownloadString(url);
           HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
           dokuman.LoadHtml(html);
               HtmlNodeCollection baslıklar = dokuman.DocumentNode.SelectNodes("//a");

               foreach (var baslık in baslıklar)
               {
                   string link = baslık.Attributes["href"].Value;
           listBox1.Items.Add(baslık.InnerText);
               }
               */
        #endregion

        //...
        public string Sehir;
      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(970,10);
            this.Height = 170;

            //...

            tarihte_bugün("https://www.kursunkalem.com/tarihte-bugun/", "//*[@id='example']/tbody/tr[1]/td[2]", textBox1);


            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/630/istanbul-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[2]", label2);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/630/istanbul-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[5]/b", label3);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/630/istanbul-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[8]/b", label4);

            btn_adana.BackColor = Color.Transparent;
            btn_ankara.BackColor = Color.Transparent;
            btn_antalya.BackColor = Color.Transparent;
            btn_istanbul.BackColor = Color.Transparent;
            btn_izmir.BackColor = Color.Transparent;
            btn_kocaeli.BackColor = Color.Transparent;




        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            label1.Text = DateTime.Now.ToString();
        }



        bool move;
        int mouse_x;
        int mouse_y;

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y -mouse_y);
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }


        string ProgramAdi= "Masaüstü_Uygulaması";
        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            { //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(ProgramAdi);
            }
        }

  

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            btn_adana.BackColor = Color.Transparent;
            btn_ankara.BackColor = Color.Transparent;
            btn_antalya.BackColor = Color.Transparent;
            btn_istanbul.BackColor = Color.Transparent;
            btn_izmir.BackColor = Color.Transparent;
            btn_kocaeli.BackColor = Color.Transparent;

            if (this.Height == 170)
            {
                this.Height = 380;
                   bunifuGradientPanel2.Visible = false;

                bunifuTransition1.ShowSync(bunifuGradientPanel2);
            }
            else
            {
                this.Height = 170;
                      bunifuGradientPanel2.Visible = true;
                bunifuTransition1.ShowSync(bunifuGradientPanel2);
            }
          
        }
        
        private void istanbul()
        {
            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/630/istanbul-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[2]", label2);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/630/istanbul-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[5]/b", label3);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/630/istanbul-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[8]/b", label4);
            
        }

        private void İzmir()
        {
            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/728/izmir-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[2]", label2);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/728/izmir-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[5]/b", label3);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/728/izmir-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[8]/b", label4);

        }

        private void Ankara()
        {

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/90/ankara-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[2]", label2);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/90/ankara-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[5]/b", label3);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/90/ankara-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[8]/b", label4);

        }

        private void Kocaeli()
        {
            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/1400/kocaeli-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[2]", label2);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/1400/kocaeli-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[5]/b", label3);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/1400/kocaeli-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[8]/b", label4);

        }

        private void Adana()
        {
            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/1/adana-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[2]", label2);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/1/adana-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[5]/b", label3);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/1/adana-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[8]/b", label4);

        }

        private void Antalya()
        {
            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/132/antalya-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[2]", label2);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/132/antalya-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[5]/b", label3);

            Verigun("https://www.havadurumu15gunluk.xyz/havadurumu/132/antalya-hava-durumu-15-gunluk.html", "//*[@id='sidebar']/div[1]/div/div/span[8]/b", label4);

        }


        private void btn_istanbul_Click(object sender, EventArgs e)
        {
            label5.Text = "İstanbul";
               backgroundWorker1.RunWorkerAsync();

        }

        private void btn_izmir_Click(object sender, EventArgs e)
        {
            label5.Text = "İzmir";
            backgroundWorker2.RunWorkerAsync();

        }

        private void btn_ankara_Click(object sender, EventArgs e)
        {
            label5.Text = "Ankara";
            backgroundWorker3.RunWorkerAsync();
        }

        private void btn_kocaeli_Click(object sender, EventArgs e)
        {
            label5.Text = "Kocaeli";

            backgroundWorker4.RunWorkerAsync();
        }

        private void btn_adana_Click(object sender, EventArgs e)
        {
            label5.Text = "Adana";
            backgroundWorker5.RunWorkerAsync();


        }

        private void btn_antalya_Click(object sender, EventArgs e)
        {
            label5.Text = "Antalya";
            backgroundWorker6.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            istanbul();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            İzmir();
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            Ankara();
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            Kocaeli();
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            Adana();
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            Antalya();
        }
    }
}
