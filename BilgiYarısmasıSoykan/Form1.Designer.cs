
namespace BilgiYarısmasıSoykan
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btn_Basla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.BackColor = System.Drawing.Color.Black;
            this.lbl_ad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ad.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.ForeColor = System.Drawing.Color.White;
            this.lbl_ad.Location = new System.Drawing.Point(47, 30);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(209, 37);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "AD VE SOYAD";
            // 
            // txtad
            // 
            this.txtad.BackColor = System.Drawing.Color.Black;
            this.txtad.ForeColor = System.Drawing.Color.White;
            this.txtad.Location = new System.Drawing.Point(69, 70);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(170, 27);
            this.txtad.TabIndex = 2;
            // 
            // btn_Basla
            // 
            this.btn_Basla.BackColor = System.Drawing.Color.Black;
            this.btn_Basla.Enabled = false;
            this.btn_Basla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Basla.ForeColor = System.Drawing.Color.White;
            this.btn_Basla.Location = new System.Drawing.Point(69, 259);
            this.btn_Basla.Name = "btn_Basla";
            this.btn_Basla.Size = new System.Drawing.Size(170, 50);
            this.btn_Basla.TabIndex = 4;
            this.btn_Basla.Text = "Başla";
            this.btn_Basla.UseVisualStyleBackColor = false;
            this.btn_Basla.Click += new System.EventHandler(this.btn_Basla_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(69, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(322, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Basla);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_ad;
        public System.Windows.Forms.TextBox txtad;
        public System.Windows.Forms.Button btn_Basla;
        public System.Windows.Forms.Button button1;
    }
}

