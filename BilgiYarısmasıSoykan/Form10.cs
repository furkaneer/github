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
    
    public partial class Form10 : Form
    {
        public static int puan = Form9.puan;
        public static int dogru = Form9.dogru;
        public static int yanlis = Form9.yanlis;
        public static int bos = Form9.bos;
        public Form10()
        {
            InitializeComponent();
        }

        private void s9btn_sonuc_Click(object sender, EventArgs e)
        {
            g9.Enabled = false;
            s9btn_devam.Enabled = true;
            s9btn_joker.Enabled = false;
            s9btnsuperjoker.Enabled = false;
            s9btn_Bos.Enabled = false;
            s9btn_sonuc.Enabled = false;

            if (s9RdnB.Checked == true)
            {
                dogru++;
                puan = puan + 5;
                lblcvp.Text = "Doğru";
                s9RdnB.BackColor = Color.Green;
            }
            else
            {
                lblcvp.Text = "Yanlış Cevap Doğru Şık B";
                s9RdnB.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = lbl_yanlıs.ToString();
        }

        private void s9btn_Bos_Click(object sender, EventArgs e)
        {
            //s2btn_devam.Enabled = true;
            timer1.Enabled = false;
            bos++;
            lbl_bos.Text = bos.ToString();
            Form11 fr = new Form11();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void s9btn_joker_Click(object sender, EventArgs e)
        {
            s9RdnA.Enabled = false;
            s9btnsuperjoker.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void S9btnsuperjoker_Click1(object sender, EventArgs e)
        {
            s9btn_joker.Enabled = false;

            s9lbl.Text = "Bir dönem İskandinav ülkelerinde hüküm sürmüş, yılın büyük kısmını denizlerde geçiren savaşçı halk aşağıdakilerden hangisidir?";
            s9RdnA.Text = "Keltler";
            s9RdnD.Text = "Aztekler";
            s9RdnC.Text = "Anglo-saksonlar";
            s9RdnB.Text = "Vikingler";
        }

        private void s9btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form11 fr = new Form11();
            //ilerde ad yazcan gondermek ıcın unutma
            fr.lbl_dogru.Text = lbl_dogru.Text;
            fr.lbl_puan.Text = lbl_puan.Text;
            fr.lbl_yanlıs.Text = lbl_yanlıs.Text;
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }
    }
}
