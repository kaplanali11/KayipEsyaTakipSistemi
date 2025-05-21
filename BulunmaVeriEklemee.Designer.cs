namespace KayipEsyaTakipSistemi
{
    partial class bulunmaVeriEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.anasayfaya_don = new System.Windows.Forms.Button();
            this.bulunma_ekle_btn = new System.Windows.Forms.Button();
            this.Bulunma_Tarih = new System.Windows.Forms.TextBox();
            this.Bulunmatarih = new System.Windows.Forms.Label();
            this.bulunmayer = new System.Windows.Forms.TextBox();
            this.BulunmaYeri = new System.Windows.Forms.Label();
            this.BulunmaVeriEklemee = new System.Windows.Forms.TextBox();
            this.KullaniciID = new System.Windows.Forms.Label();
            this.TeslimAlanID = new System.Windows.Forms.TextBox();
            this.TeslimID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anasayfaya_don
            // 
            this.anasayfaya_don.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.anasayfaya_don.Location = new System.Drawing.Point(74, 283);
            this.anasayfaya_don.Name = "anasayfaya_don";
            this.anasayfaya_don.Size = new System.Drawing.Size(101, 33);
            this.anasayfaya_don.TabIndex = 19;
            this.anasayfaya_don.Text = "Anasayfa";
            this.anasayfaya_don.UseVisualStyleBackColor = true;
            this.anasayfaya_don.Click += new System.EventHandler(this.anasayfaya_don_Click);
            // 
            // bulunma_ekle_btn
            // 
            this.bulunma_ekle_btn.ForeColor = System.Drawing.Color.Red;
            this.bulunma_ekle_btn.Location = new System.Drawing.Point(498, 51);
            this.bulunma_ekle_btn.Name = "bulunma_ekle_btn";
            this.bulunma_ekle_btn.Size = new System.Drawing.Size(111, 221);
            this.bulunma_ekle_btn.TabIndex = 18;
            this.bulunma_ekle_btn.Text = "VerileriEkle";
            this.bulunma_ekle_btn.UseVisualStyleBackColor = true;
            this.bulunma_ekle_btn.Click += new System.EventHandler(this.bulunma_ekle_btn_Click);
            // 
            // Bulunma_Tarih
            // 
            this.Bulunma_Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bulunma_Tarih.Location = new System.Drawing.Point(203, 51);
            this.Bulunma_Tarih.Name = "Bulunma_Tarih";
            this.Bulunma_Tarih.Size = new System.Drawing.Size(261, 29);
            this.Bulunma_Tarih.TabIndex = 17;
            // 
            // Bulunmatarih
            // 
            this.Bulunmatarih.AutoSize = true;
            this.Bulunmatarih.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bulunmatarih.Location = new System.Drawing.Point(12, 49);
            this.Bulunmatarih.Name = "Bulunmatarih";
            this.Bulunmatarih.Size = new System.Drawing.Size(181, 31);
            this.Bulunmatarih.TabIndex = 16;
            this.Bulunmatarih.Text = "BulunmaTarih:";
            this.Bulunmatarih.Click += new System.EventHandler(this.SOYAD_Click);
            // 
            // bulunmayer
            // 
            this.bulunmayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulunmayer.Location = new System.Drawing.Point(203, 113);
            this.bulunmayer.Name = "bulunmayer";
            this.bulunmayer.Size = new System.Drawing.Size(261, 29);
            this.bulunmayer.TabIndex = 15;
            // 
            // BulunmaYeri
            // 
            this.BulunmaYeri.AutoSize = true;
            this.BulunmaYeri.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulunmaYeri.Location = new System.Drawing.Point(21, 113);
            this.BulunmaYeri.Name = "BulunmaYeri";
            this.BulunmaYeri.Size = new System.Drawing.Size(168, 31);
            this.BulunmaYeri.TabIndex = 14;
            this.BulunmaYeri.Text = "BulunmaYeri:";
            // 
            // BulunmaVeriEklemee
            // 
            this.BulunmaVeriEklemee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BulunmaVeriEklemee.Location = new System.Drawing.Point(203, 178);
            this.BulunmaVeriEklemee.Name = "BulunmaVeriEklemee";
            this.BulunmaVeriEklemee.Size = new System.Drawing.Size(88, 29);
            this.BulunmaVeriEklemee.TabIndex = 13;
            // 
            // KullaniciID
            // 
            this.KullaniciID.AutoSize = true;
            this.KullaniciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciID.Location = new System.Drawing.Point(74, 178);
            this.KullaniciID.Name = "KullaniciID";
            this.KullaniciID.Size = new System.Drawing.Size(101, 29);
            this.KullaniciID.TabIndex = 12;
            this.KullaniciID.Text = "EsyaID:";
            this.KullaniciID.Click += new System.EventHandler(this.EMAIL_Click);
            // 
            // TeslimAlanID
            // 
            this.TeslimAlanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeslimAlanID.Location = new System.Drawing.Point(203, 229);
            this.TeslimAlanID.Name = "TeslimAlanID";
            this.TeslimAlanID.Size = new System.Drawing.Size(88, 29);
            this.TeslimAlanID.TabIndex = 21;
            // 
            // TeslimID
            // 
            this.TeslimID.AutoSize = true;
            this.TeslimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeslimID.Location = new System.Drawing.Point(13, 229);
            this.TeslimID.Name = "TeslimID";
            this.TeslimID.Size = new System.Drawing.Size(176, 29);
            this.TeslimID.TabIndex = 20;
            this.TeslimID.Text = "TeslimAlanID:";
            // 
            // bulunmaVeriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 413);
            this.Controls.Add(this.TeslimAlanID);
            this.Controls.Add(this.TeslimID);
            this.Controls.Add(this.anasayfaya_don);
            this.Controls.Add(this.bulunma_ekle_btn);
            this.Controls.Add(this.Bulunma_Tarih);
            this.Controls.Add(this.Bulunmatarih);
            this.Controls.Add(this.bulunmayer);
            this.Controls.Add(this.BulunmaYeri);
            this.Controls.Add(this.BulunmaVeriEklemee);
            this.Controls.Add(this.KullaniciID);
            this.Name = "bulunmaVeriEkle";
            this.Text = "BulunmaVeriEkle";
            this.Load += new System.EventHandler(this.EsyaVeriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anasayfaya_don;
        private System.Windows.Forms.Button bulunma_ekle_btn;
        private System.Windows.Forms.TextBox Bulunma_Tarih;
        private System.Windows.Forms.Label Bulunmatarih;
        private System.Windows.Forms.TextBox bulunmayer;
        private System.Windows.Forms.Label BulunmaYeri;
        private System.Windows.Forms.TextBox BulunmaVeriEklemee;
        private System.Windows.Forms.Label KullaniciID;
        private System.Windows.Forms.TextBox TeslimAlanID;
        private System.Windows.Forms.Label TeslimID;
    }
}