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
    public partial class Form22 : Form
    {
        public static int puan = Form13.puan;
        public static int dogru = Form13.dogru;
        public static int yanlis = Form13.yanlis;
        public static int bos = Form13.bos;
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            lbl_adyazısı.Text = Form1.Gidenad.ToString();
            lbl_dogru.Text = dogru.ToString();
            lbl_yanlıs.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();
            lbl_puan.Text = puan.ToString();
        }
    }
}
