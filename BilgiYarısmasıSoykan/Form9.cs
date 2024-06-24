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
    public partial class Form9 : Form
    {
        public static int puan = Form23.puan;
        public static int dogru = Form23.dogru;
        public static int yanlis = Form23.yanlis;
        public static int bos = Form23.bos;
        private int saniye = 20;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }

        private void s8btn_sonuc_Click(object sender, EventArgs e)
        {
            g8.Enabled = false;
            s8btn_devam.Enabled = true;
            s8Btn_joker.Enabled = false;
            s8btnsuperjoker.Enabled = false;
            s8btn_Bos.Enabled = false;

            if (s8RdnA.Checked == true)
            {
                dogru++;
                puan = puan + 5;
                lblcvp.Text = "Doğru";
                s8RdnA.BackColor = Color.Green;
            }
            else
            {
                lblcvp.Text = "Yanlış Cevap Doğru Şık A";
                s8RdnA.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
        }

        private void s8btn_Bos_Click(object sender, EventArgs e)
        {
            //s2btn_devam.Enabled = true;
            timer1.Enabled = false;
            bos++;
            lbl_bos.Text = bos.ToString();
            Form10 fr = new Form10();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void s8Btn_joker_Click(object sender, EventArgs e)
        {
            s8RdnD.Enabled = false;
            s8btnsuperjoker.Enabled = false;
        }

        private void s8btnsuperjoker_Click(object sender, EventArgs e)
        {
            s8Btn_joker.Enabled = true;

            s8lbl.Text = "Türkiye Eurovision şarkı yarışmasına ilk kez hangi sanatçı ve şarkıyla ile katılmıştır?";
            s8RdnA.Text = "Semiha Yankı – Seninle Bir Dakika";
            s8RdnB.Text = "Kayahan – Gözlerinin Hapsindeyim";
            s8RdnC.Text = "Sertab Erener- Everyway That I Can";
            s8RdnD.Text = "MFÖ – Sufi";

        }

        private void s8btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form10 fr = new Form10();
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
                Form22 fr = new Form22();
                this.Visible = false;
                fr.ShowDialog();
                this.Visible = true;
                this.Close();
            }
        }
    }
}
