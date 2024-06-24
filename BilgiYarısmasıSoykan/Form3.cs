using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarısmasıSoykan
{
    public partial class Form3 : Form
    {
        public static int puan = Form2.puan;
        public static int dogru = Form2.dogru;
        public static int yanlis = Form2.yanlis;
        public static int bos = Form2.bos;
        private int saniye = 20;
        public Form3()
        {
            InitializeComponent();
        }

        private void s2btn_sonuc_Click(object sender, EventArgs e)
        {
            g2.Enabled = false;
            s2btn_devam.Enabled = true;
            s2Btn_joker.Enabled = false;
            s2btnsuperjoker.Enabled = false;
            s2btn_Bos.Enabled = false;
            s2btn_sonuc.Enabled = false;

            if (s2RdnC.Checked == true)
            {
                dogru++;
                puan = puan + 5;
                s2lblcvp.Text = "Doğru";
                s2RdnC.BackColor = Color.Green;
            }
            else
            {
                s2lblcvp.Text = "Yanlış Cevap Doğru Şık C";
                s2RdnC.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();

        }

        private void s2btn_Bos_Click(object sender, EventArgs e)
        {

            //s2btn_devam.Enabled = true;
            timer1.Enabled = false;
            bos++;
            lbl_bos.Text = bos.ToString();
            Form4 fr = new Form4();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void s2Btn_joker_Click(object sender, EventArgs e)
        {
            s2RdnA.Enabled = false;
            s2btnsuperjoker.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }

        private void s2btnsuperjoker_Click(object sender, EventArgs e)
        {
            s2Btn_joker.Enabled = false;

            s2lbl.Text = "Trafikte hangi araçların arkasında 'Dolu' ya da 'Boş' yazar?";
            s2RdnC.Text = "Akaryakıt Tankeri";
            s2RdnB.Text = "Öğrenci Servisi";
            s2RdnA.Text = "Harfiyat Kanyonu";
            s2RdnD.Text = "Yolcu Otobüsü";
        }

        private void s2btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form4 fr = new Form4();
            //ilerde ad yazcan gondermek ıcın unutma
            fr.lbl_dogru.Text = lbl_dogru.Text;
            fr.lbl_puan.Text = lbl_puan.Text;
            fr.lbl_yanlıs.Text = lbl_yanlıs.Text;
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            saniye = saniye - 1;
            lbl_sure.Text = saniye.ToString();

            if (saniye == 0)
            {
                bos++;
                lbl_bos.Text = bos.ToString();
                timer1.Enabled = false;
                Form4 fr = new Form4();
                this.Visible = false;
                fr.ShowDialog();
                this.Visible = true;
                this.Close();
            }
        }
    }
}