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
    public partial class Form2 : Form
    {
        public static int puan = 0;
        int saniye = 20;
        public static int dogru =0;
        public static int yanlis = 0;
        public static int bos = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_joker_Click(object sender, EventArgs e)
        {
            s1RdnB.Enabled = false;
            s1btnsuperjoker.Enabled = false;
        }

        private void btn_sonuc_Click(object sender, EventArgs e)
        {

            g1.Enabled = false;
            btn_devam.Enabled = true;
            Btn_joker.Enabled = false;
            s1btnsuperjoker.Enabled = false;
            btn_Bos.Enabled = false;
            btn_sonuc.Enabled = false;

            if (s1RdnD.Checked == true)
            {
                lblcvp.Text = "Doğru";
                s1RdnD.BackColor = Color.Green;
                puan = puan + 5;
                dogru++;
            }
            else
            {
                lblcvp.Text = "Yanlış Cevap Doğru Şık D";
                s1RdnD.BackColor = Color.Green;
                yanlis++;
            }

            lbl_puan.Text = puan.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();

        }

        private void btn_Bos_Click(object sender, EventArgs e)
        {
            //btn_devam.Enabled = true;
            bos++;
            timer1.Enabled = false;
            lbl_bos.Text = bos.ToString();
            Form3 fr = new Form3();
            fr.lbl_bos.Text = lbl_bos.Text;
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
        }

        private void btn_devam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form3 fr = new Form3();
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

        private void g1_Enter(object sender, EventArgs e)
        {

        }

        private void s1RdnA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void s1btnsuperjoker_Click(object sender, EventArgs e)
        {
            Btn_joker.Enabled = false;

            s1lbl.Text = "Cumhuriyet Kaç Yıllında İlan Edilmiştir";
            s1RdnA.Text = "1920";
            s1RdnB.Text = "1921";
            s1RdnC.Text = "1922";
            s1RdnD.Text = "1923";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            saniye = saniye - 1;
            lbl_sure.Text = saniye.ToString();

            if (saniye==0)
            {
                bos++;
                timer1.Enabled = false;
                Form3 fr = new Form3();
                this.Visible = false;
                fr.ShowDialog();
                this.Visible = true;
                this.Close();
           }

        }
    }
}