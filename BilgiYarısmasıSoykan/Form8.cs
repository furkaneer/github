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
    public partial class Form23 : Form
    {
        public static int puan = Form7.puan;
        public static int dogru = Form7.dogru;
        public static int yanlis = Form7.yanlis;
        public static int bos = Form7.bos;
        private int saniye = 20;
        public Form23()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }

        private void s7btn_sonuc_Click(object sender, EventArgs e)
        {
            g7.Enabled = false;
            s7btn_devam.Enabled = true;
            s7Btn_joker.Enabled = false;
            s7btnsuperjoker.Enabled = false;
            s7btn_Bos.Enabled = false;

            if (s7RdnA.Checked == true)
            {
                dogru++;
                puan = puan + 5;
                lblcvp.Text = "Doğru";
                s7RdnA.BackColor = Color.Green;
            }
            else
            {
                lblcvp.Text = "Yanlış Cevap Doğru Şık A";
                s7RdnA.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
        }

        private void s7btn_Bos_Click(object sender, EventArgs e)
        {
            //s2btn_devam.Enabled = true;
            timer1.Enabled = false;
            bos++;
            lbl_bos.Text = bos.ToString();
            Form9 fr = new Form9();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void s7Btn_joker_Click(object sender, EventArgs e)
        {
            s7RdnB.Enabled = false;
            s7btnsuperjoker.Enabled = false;
        }

        private void s7btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form9 fr = new Form9();
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
                Form9 fr = new Form9();
                this.Visible = false;
                fr.ShowDialog();
                this.Visible = true;
                this.Close();
            }
        }

        private void s7btnsuperjoker_Click(object sender, EventArgs e)
        {
            s7Btn_joker.Enabled = false;

            s7lbl.Text = "Bilimkurgunun babası sayılan Fransız yazar aşağıdakilerden hangisidir?";
            s7RdnB.Text = "Victor Hugo";
            s7RdnC.Text = "Balzac";
            s7RdnA.Text = "Jules Verne";
            s7RdnD.Text = "Montaigne";
        }
    }
}