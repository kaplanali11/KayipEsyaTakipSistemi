using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayipEsyaTakipSistemi
{
    public partial class esyaVeriEkle: Form
    { DBAccess objdbAccess = new DBAccess();
        Form previousForm;
        public esyaVeriEkle(Form anasayfa)
        {
            InitializeComponent();
            this.previousForm = anasayfa;
        }

        private void OnemDerecesi_Click(object sender, EventArgs e)
        {

        }

        private void Kullanici_ekle_btn_Click(object sender, EventArgs e)

        {
            DBAccess db = new DBAccess();
            int maxKullaniciId = 0;

            string query = "SELECT MAX(KullaniciID) FROM KullaniciTBL";
            using (SqlDataReader reader = db.readDatathroughReader(query))
            {
                if (reader.Read() && !reader.IsDBNull(0))
                {
                    maxKullaniciId = reader.GetInt32(0);
                }
            }

            string esya_ad = esya_ad_txt.Text;
            string kayip_yeri = EsyaKayipYeri.Text;

            if (string.IsNullOrWhiteSpace(esya_ad))
            {
                MessageBox.Show("EsyaAd alanı boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Esya_Kayip_Tarih.Text) ||
                !DateTime.TryParse(Esya_Kayip_Tarih.Text, out DateTime kayip_tarih))
            {
                MessageBox.Show("Lütfen geçerli bir Tarih girin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(kayip_yeri))
            {
                MessageBox.Show("KayipYer alanı boş bırakılamaz.");
                return;
            }

            if (!int.TryParse(Esya_Kullanici_id.Text, out int KullaniciID))
            {
                MessageBox.Show("Lütfen geçerli bir ID girin (sadece sayı).");
                return;
            }

            if (KullaniciID != maxKullaniciId)
            {
                MessageBox.Show($"KullaniciID son eklediğiniz kullanıcıya ait olmalı.{maxKullaniciId}");
                return;
            }

            if (!int.TryParse(Esya_OnemDerecesi.Text, out int OnemDerecesi))
            {
                MessageBox.Show("Lütfen geçerli bir OnemDerecesi girin (sadece sayı).");
                return;
            }

            SqlCommand insertCommand = new SqlCommand("INSERT INTO EsyaTBL(EsyaAdi, KayipTarihi, KayipYeri, KullaniciID, OnemDerecesi) VALUES (@EsyaAdi, @KayipTarihi, @KayipYeri, @KullaniciID, @OnemDerecesi)");

            insertCommand.Parameters.AddWithValue("@EsyaAdi", esya_ad);
            insertCommand.Parameters.AddWithValue("@KayipTarihi", kayip_tarih);
            insertCommand.Parameters.AddWithValue("@KayipYeri", kayip_yeri);
            insertCommand.Parameters.AddWithValue("@KullaniciID", KullaniciID);
            insertCommand.Parameters.AddWithValue("@OnemDerecesi", OnemDerecesi);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void anasayfaya_don_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void esyaVeriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
