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
    public partial class Form5 : Form
    {
        public static int puan = Form4.puan;
        public static int dogru = Form4.dogru;
        public static int yanlis = Form4.yanlis;
        public static int bos = Form4.bos;
        private int saniye = 20;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
        }

        private void s4btn_sonuc_Click(object sender, EventArgs e)
        {
            g4.Enabled = false;
            s4btn_devam.Enabled = true;
            s4Btn_joker.Enabled = false;
            s4btnsuperjoker.Enabled = false;
            s4btn_Bos.Enabled = false;

            if (s4RdnD.Checked == true)
            {
                lblcvp.Text = "Doğru";
                s4RdnD.BackColor = Color.Green;
                puan = puan + 5;
                dogru++;
            }
            else
            {
                lblcvp.Text = "Yanlış Cevap Doğru Şık D";
                s4RdnD.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
        }

        private void s4Btn_joker_Click(object sender, EventArgs e)
        {
            s4RdnB.Enabled = false;
            s4btnsuperjoker.Enabled = false;
        }

        private void s4btn_Bos_Click(object sender, EventArgs e)
        {
            //btn_devam.Enabled = true;
            timer1.Enabled = false;
            bos++;
            lbl_bos.Text = bos.ToString();
            Form6 fr = new Form6();
            fr.lbl_bos.Text = lbl_bos.Text;
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void s4btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form6 fr = new Form6();
            //ilerde ad yazcan gondermek ıcın unutma
            fr.lbl_puan.Text = lbl_puan.Text;
            fr.lbl_dogru.Text = lbl_dogru.Text;
            fr.lbl_yanlıs.Text = lbl_yanlıs.Text;
            fr.lbl_bos.Text = lbl_bos.Text;
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void s4btnsuperjoker_Click(object sender, EventArgs e)
        {
            s4Btn_joker.Enabled = false;

            s4lbl.Text = "Son Kuşlar Hangi Yazarımıza Aittir";
            s4RdnD.Text = "Sait Faik";
            s4RdnA.Text = "Cemal Süreya";
            s4RdnB.Text = "Attila İlhan";
            s4RdnC.Text = "Reşat Nuri";
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
                Form6 fr = new Form6();
                this.Visible = false;
                fr.ShowDialog();
                this.Visible = true;
                this.Close();
            }
        }
    }
}
