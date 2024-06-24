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
    public partial class Form6 : Form
    {
        public static int puan = Form5.puan;
        public static int dogru = Form5.dogru;
        public static int yanlis = Form5.yanlis;
        public static int bos = Form5.bos;
        private int saniye = 20;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }

        private void s5btn_sonuc_Click(object sender, EventArgs e)
        {
            g5.Enabled = false;
            s5btn_devam.Enabled = true;
            s5Btn_joker.Enabled = false;
            s5btnsuperjoker.Enabled = false;
            s5btn_Bos.Enabled = false;

            if (s5RdnD.Checked == true)
            {
                dogru++;
                puan = puan + 5;
                lblcvp.Text = "Doğru";
                s5RdnD.BackColor = Color.Green;
            }
            else
            {
                lblcvp.Text = "Yanlış Cevap Doğru Şık D";
                s5RdnD.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
        }

        private void s5btn_Bos_Click(object sender, EventArgs e)
        {
            //s2btn_devam.Enabled = true;
            timer1.Enabled = false;
            bos++;
            lbl_bos.Text = bos.ToString();
            Form7 fr = new Form7();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void s5Btn_joker_Click(object sender, EventArgs e)
        {
            s5RdnB.Enabled = false;
            s5btnsuperjoker.Enabled = false;
        }

        private void s5btnsuperjoker_Click(object sender, EventArgs e)
        {
            s5Btn_joker.Enabled = false;

            s5lbl.Text = "Hangi kelime 'kalınca bükülmüş ipek iplik' anlamına gelir?";
            s5RdnA.Text = "İbrik";
            s5RdnB.Text = "İlmik";
            s5RdnC.Text = "Meşin";
            s5RdnD.Text = "İbrişim";
        }

        private void s5btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form7 fr = new Form7();
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
                Form7 fr = new Form7();
                this.Visible = false;
                fr.ShowDialog();
                this.Visible = true;
                this.Close();
            }
        }
    }
}
