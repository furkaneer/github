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
    public partial class Form14 : Form
    {
        public static int puan = Form13.puan;
        public static int dogru = Form13.dogru;
        public static int yanlis = Form13.yanlis;
        public static int bos = Form13.bos;
        private int saniye = 20;
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }

        private void btn_devam_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form15 fr = new Form15();
            //ilerde ad yazcan gondermek ıcın unutma
            fr.lbl_dogru.Text = lbl_dogru.Text;
            fr.lbl_puan.Text = lbl_puan.Text;
            fr.lbl_yanlıs.Text = lbl_yanlıs.Text;
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void btn_sonuc_Click_1(object sender, EventArgs e)
        {
            g1.Enabled = false;
            btn_devam.Enabled = true;
            Btn_joker.Enabled = false;
            btn_Bos.Enabled = false;
            btn_sonuc.Enabled = false;

            if (s1RdnB.Checked == true)
            {
                lblcvp.Text = "Doğru";
                s1RdnB.BackColor = Color.Green;
                puan = puan + 5;
                dogru++;
            }
            else
            {
                lblcvp.Text = "Yanlış Cevap Doğru Şık B";
                s1RdnB.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();

        }

        private void btn_Bos_Click_1(object sender, EventArgs e)
        {
            //s2btn_devam.Enabled = true;
            timer1.Enabled = false;
            bos++;
            lbl_bos.Text = bos.ToString();
            Form15 fr = new Form15();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void Btn_joker_Click_1(object sender, EventArgs e)
        {
            s1RdnA.Enabled = false;
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