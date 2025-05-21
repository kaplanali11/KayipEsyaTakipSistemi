using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayipEsyaTakipSistemi
{
    public partial class bulunmaVeriEkle: Form
    {
        Form previousForm;
        public bulunmaVeriEkle(Form anasayfa)
        {
            InitializeComponent();
            this.previousForm = anasayfa;
        }

        private void Kullanici_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SOYAD_Click(object sender, EventArgs e)
        {

        }

        private void EMAIL_Click(object sender, EventArgs e)
        {

        }

        private void EsyaVeriEkle_Load(object sender, EventArgs e)
        {

        }

        private void bulunma_ekle_btn_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            int maxKullaniciId = 0;
            int maxEsyaId = 0;

            string query = "SELECT MAX(KullaniciID) FROM KullaniciTBL";
            using (SqlDataReader reader = db.readDatathroughReader(query))
            {
                if (reader.Read() && !reader.IsDBNull(0))
                {
                    maxKullaniciId = reader.GetInt32(0);
                }
            }
            string query2 = "SELECT MAX(EsyaID) FROM EsyaTBL";
            using (SqlDataReader reader = db.readDatathroughReader(query2))
            {
                if (reader.Read() && !reader.IsDBNull(0))
                {
                    maxEsyaId = reader.GetInt32(0);
                }
            }


            string bulunma_yeri = bulunmayer.Text;

            if (string.IsNullOrWhiteSpace(bulunma_yeri))
            {
                MessageBox.Show("Bulunma yeri alanı boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Bulunma_Tarih.Text) ||
                !DateTime.TryParse(Bulunma_Tarih.Text, out DateTime bulunma_tarih))
            {
                MessageBox.Show("Lütfen geçerli bir Tarih girin.");
                return;
            }

           

            if (!int.TryParse(TeslimAlanID.Text, out int TeslimalanID))
            {
                MessageBox.Show("Lütfen geçerli bir TeslimalanID girin (sadece sayı).");
                return;
            }

            if (TeslimalanID != maxKullaniciId)
            {
                MessageBox.Show($"TeslimalanID son eklediğiniz kullanıcıya ait olmalı.{maxKullaniciId}");
                return;
            }

            if (!int.TryParse(BulunmaVeriEklemee.Text, out int EsyaID))
            {
                MessageBox.Show("Lütfen geçerli bir EsyaID girin (sadece sayı).");
                return;
            }

            if (EsyaID != maxEsyaId)
            {
                MessageBox.Show($"TeslimalanID son eklediğiniz kullanıcıya ait olmalı.{maxEsyaId}");
                return;
            }

            SqlCommand insertCommand = new SqlCommand("INSERT INTO BulunmaBilgisiTBL(EsyaID,BulunmaTarihi,BulunduguYer,TeslimAlanID) VALUES (@EsyaID,@BulunmaTarihi,@BulunduguYer,@TeslimAlanID)");

            insertCommand.Parameters.AddWithValue("@EsyaID",EsyaID);
            insertCommand.Parameters.AddWithValue("@BulunmaTarihi",bulunma_tarih);
            insertCommand.Parameters.AddWithValue("@BulunduguYer", bulunma_yeri);
            insertCommand.Parameters.AddWithValue("@TeslimAlanID", TeslimalanID);
            

            int row = db.executeQuery(insertCommand);

            if (row == 1)
            {
                MessageBox.Show("Veriler eklendi.");
            }
            else
            {
                MessageBox.Show("Veriler eklenemedi!");
            }
        }

        private void anasayfaya_don_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }
}
