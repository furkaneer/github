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
    public partial class Form11 : Form
    {
        public static int puan = Form10.puan;
        public static int dogru = Form10.dogru;
        public static int yanlis = Form10.yanlis;
        public static int bos = Form10.bos;
        private int saniye = 20;
        public Form11()
        {
            InitializeComponent();
        }

        private void s10btn_sonuc_Click(object sender, EventArgs e)
        {
            g10.Enabled = false;
            s10btn_devam.Enabled = true;
            s10Btn_joker.Enabled = false;
            s10btnsuperjoker.Enabled = false;
            s10btn_Bos.Enabled = false;
            s10btn_sonuc.Enabled = false;

            if (s10RdnB.Checked == true)
            {
                dogru++;
                puan = puan + 5;
                lblcvp.Text = "Doğru";
                s10RdnB.BackColor = Color.Green;
            }
            else
            {
                lblcvp.Text = "Yanlış Cevap Doğru Şık B";
                s10RdnB.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();

        }

        private void s10btn_Bos_Click(object sender, EventArgs e)
        {
            //s2btn_devam.Enabled = true;
            timer1.Enabled = false;
            bos++;
            lbl_bos.Text = bos.ToString();
            Form22 fr = new Form22();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }

        private void s10Btn_joker_Click(object sender, EventArgs e)
        {
            s10RdnA.Enabled = false;
            s10btnsuperjoker.Enabled = false;
        }

        private void s10btnsuperjoker_Click(object sender, EventArgs e)
        {
            s10Btn_joker.Enabled = false;

            s10lbl.Text = "Ünlü Fransız romanı “Notre Dame’ın Kamburu” aşağıdaki yazarların hangisi tarafından yazılmıştır ?";
            s10RdnB.Text = "Victor Hugo";
            s10RdnA.Text = "Jean Jarcques Rousseau";
            s10RdnC.Text = "Honore de Balzac";
            s10RdnD.Text = "Voltaire";
        }

        private void s10btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form22 fr = new Form22();
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