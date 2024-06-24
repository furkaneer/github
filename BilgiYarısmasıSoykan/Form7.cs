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
    public partial class Form7 : Form
    {
        public static int puan = Form6.puan;
        public static int dogru = Form6.dogru;
        public static int yanlis = Form6.yanlis;
        public static int bos = Form6.bos;
        private int saniye = 20;
        public Form7()
        {
            InitializeComponent();
        }

        private void s6btn_sonuc_Click(object sender, EventArgs e)
        {
            g6.Enabled = false;
            s6btn_devam.Enabled = true;
            s6Btn_joker.Enabled = false;
            s6btnsuperjoker.Enabled = false;
            s6btn_Bos.Enabled = false;

            if (s6RdnD.Checked == true)
            {
                dogru++;
                puan = puan + 5;
                lblcvp.Text = "Doğru";
                s6RdnD.BackColor = Color.Green;
            }
            else
            {
                lblcvp.Text = "Yanlış Cevap Doğru Şık D";
                s6RdnD.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
        }

        private void s6btn_Bos_Click(object sender, EventArgs e)
        {
            //s2btn_devam.Enabled = true;
            timer1.Enabled = false;
            bos++;
            lbl_bos.Text = bos.ToString();
            Form23 fr = new Form23();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void s6Btn_joker_Click(object sender, EventArgs e)
        {
            s6RdnC.Enabled = false;
            s6btnsuperjoker.Enabled = false;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }

        private void s6btnsuperjoker_Click(object sender, EventArgs e)
        {
            s6Btn_joker.Enabled = false;

            s6lbl.Text = "Hangisi video izlerken 'görüntü modlarından' biri değildir?";
            s6RdnA.Text = "360p";
            s6RdnB.Text = "480p";
            s6RdnD.Text = "640p";
            s6RdnC.Text = "720p";
        }

        private void s6btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form23 fr = new Form23();
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
                timer1.Enabled = false;
                Form23 fr = new Form23();
                this.Visible = false;
                fr.ShowDialog();
                this.Visible = true;
                this.Close();
            }
        }
    }
}
