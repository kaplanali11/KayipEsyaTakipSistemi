namespace KayipEsyaTakipSistemi
{
    partial class anasayfa
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
            this.Kullanici_veri_ekle = new System.Windows.Forms.Button();
            this.KulaniciTBL = new System.Windows.Forms.Label();
            this.EsyaTBL = new System.Windows.Forms.Label();
            this.Esya_veri_ekle = new System.Windows.Forms.Button();
            this.BulunmaBilgisiTBL = new System.Windows.Forms.Label();
            this.Bulunma_veri_Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kullanici_veri_ekle
            // 
            this.Kullanici_veri_ekle.Location = new System.Drawing.Point(307, 101);
            this.Kullanici_veri_ekle.Name = "Kullanici_veri_ekle";
            this.Kullanici_veri_ekle.Size = new System.Drawing.Size(161, 63);
            this.Kullanici_veri_ekle.TabIndex = 0;
            this.Kullanici_veri_ekle.Text = "VeriEkle";
            this.Kullanici_veri_ekle.UseVisualStyleBackColor = true;
            this.Kullanici_veri_ekle.Click += new System.EventHandler(this.Kullanici_veri_ekle_Click);
            // 
            // KulaniciTBL
            // 
            this.KulaniciTBL.AutoSize = true;
            this.KulaniciTBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KulaniciTBL.Location = new System.Drawing.Point(36, 110);
            this.KulaniciTBL.Name = "KulaniciTBL";
            this.KulaniciTBL.Size = new System.Drawing.Size(190, 33);
            this.KulaniciTBL.TabIndex = 3;
            this.KulaniciTBL.Text = "KullaniciTBL";
            this.KulaniciTBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // EsyaTBL
            // 
            this.EsyaTBL.AutoSize = true;
            this.EsyaTBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EsyaTBL.Location = new System.Drawing.Point(46, 223);
            this.EsyaTBL.Name = "EsyaTBL";
            this.EsyaTBL.Size = new System.Drawing.Size(140, 33);
            this.EsyaTBL.TabIndex = 7;
            this.EsyaTBL.Text = "EsyaTBL";
            this.EsyaTBL.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Esya_veri_ekle
            // 
            this.Esya_veri_ekle.Location = new System.Drawing.Point(307, 214);
            this.Esya_veri_ekle.Name = "Esya_veri_ekle";
            this.Esya_veri_ekle.Size = new System.Drawing.Size(161, 63);
            this.Esya_veri_ekle.TabIndex = 4;
            this.Esya_veri_ekle.Text = "VeriEkle";
            this.Esya_veri_ekle.UseVisualStyleBackColor = true;
            this.Esya_veri_ekle.Click += new System.EventHandler(this.Esya_veri_ekle_Click);
            // 
            // BulunmaBilgisiTBL
            // 
            this.BulunmaBilgisiTBL.AutoSize = true;
            this.BulunmaBilgisiTBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BulunmaBilgisiTBL.Location = new System.Drawing.Point(12, 334);
            this.BulunmaBilgisiTBL.Name = "BulunmaBilgisiTBL";
            this.BulunmaBilgisiTBL.Size = new System.Drawing.Size(278, 33);
            this.BulunmaBilgisiTBL.TabIndex = 11;
            this.BulunmaBilgisiTBL.Text = "BulunmaBilgisiTBL";
            // 
            // Bulunma_veri_Ekle
            // 
            this.Bulunma_veri_Ekle.Location = new System.Drawing.Point(307, 327);
            this.Bulunma_veri_Ekle.Name = "Bulunma_veri_Ekle";
            this.Bulunma_veri_Ekle.Size = new System.Drawing.Size(161, 59);
            this.Bulunma_veri_Ekle.TabIndex = 8;
            this.Bulunma_veri_Ekle.Text = "VeriEkle";
            this.Bulunma_veri_Ekle.UseVisualStyleBackColor = true;
            this.Bulunma_veri_Ekle.Click += new System.EventHandler(this.button9_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 427);
            this.Controls.Add(this.BulunmaBilgisiTBL);
            this.Controls.Add(this.Bulunma_veri_Ekle);
            this.Controls.Add(this.EsyaTBL);
            this.Controls.Add(this.Esya_veri_ekle);
            this.Controls.Add(this.KulaniciTBL);
            this.Controls.Add(this.Kullanici_veri_ekle);
            this.Name = "anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kullanici_veri_ekle;
        private System.Windows.Forms.Label KulaniciTBL;
        private System.Windows.Forms.Label EsyaTBL;
        private System.Windows.Forms.Button Esya_veri_ekle;
        private System.Windows.Forms.Label BulunmaBilgisiTBL;
        private System.Windows.Forms.Button Bulunma_veri_Ekle;
    }
}

