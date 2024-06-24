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
    public partial class Form1 : Form
    {
        public static string Gidenad = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Basla_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            Gidenad = txtad.Text;
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_Basla.Enabled = true;

        }
    }
}
