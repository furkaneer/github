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
    public partial class Form4 : Form
    {
        public static int puan = Form3.puan;
        int saniye = 20;
        public static int dogru = Form3.dogru;
        public static int yanlis = Form3.yanlis;
        public static int bos = Form3.bos;
        public Form4()
        {
            InitializeComponent();
        }

        private void s3btn_sonuc_Click(object sender, EventArgs e)
        {
            g3.Enabled = false;
            s3btn_devam.Enabled = true;

            if (s3RdnA.Checked == true)
            {
                dogru++;
                puan = puan + 5;
                s3lblcvp.Text = "Doğru";
                s3RdnA.BackColor = Color.Green;
            }
            else
            {
                s3lblcvp.Text = "Yanlış Cevap Doğru Şık A";
                s3RdnA.BackColor = Color.Green;
                yanlis++;

            }
            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();

        }

        private void s3btn_Bos_Click(object sender, EventArgs e)
        {
            //s3btn_devam.Enabled = true;
            bos++;
            lbl_bos.Text = bos.ToString();
            timer1.Enabled = false;
            Form5 fr = new Form5();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void s3Btn_joker_Click(object sender, EventArgs e)
        {
            s3RdnC.Enabled = false;
            s3btnsuperjoker.Enabled = false;
        }

        private void s3btnsuperjoker_Click(object sender, EventArgs e)
        {
            s3lbl.Text = "Antalya'nın Plakası hangisidir ? ";
            s3RdnC.Text = "35";
            s3RdnB.Text = "20";
            s3RdnA.Text = "07";
            s3RdnD.Text = "52";
        }

        private void s3btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form5 fr = new Form5();
            fr.lbl_puan.Text = lbl_puan.Text;
            fr.lbl_dogru.Text = lbl_dogru.Text;
            fr.lbl_yanlıs.Text = lbl_yanlıs.Text;
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            saniye = saniye - 1;
            lbl_sure.Text = saniye.ToString();

            if (saniye == 0)
            {
                bos++;
                timer1.Enabled = false;
                Form5 fr = new Form5();
                this.Visible = false;
                fr.ShowDialog();
                this.Visible = true;
                this.Close();
            }
        }
    }
}
