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
    public partial class KullaniciVeriEkle: Form
    {
        DBAccess objdbAccess = new DBAccess();
        Form previousForm;
        public KullaniciVeriEkle(Form anasayfa)
        {
            InitializeComponent();
            
            this.previousForm = anasayfa;
        }

        private void KullaniciVeriEkle_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TELEFON_Click(object sender, EventArgs e)
        {

        }

        private void Kullanici_ekle_btn_Click(object sender, EventArgs e)
        {
            
        
        


        string ad = Kullanici_ad.Text;
            string soyad = Kullanici_soyad.Text;
            string telefon = Kullanici_telefon.Text;
            string email = Kullanici_email.Text;
            int yas = int.Parse(Kullanici_yas.Text);
            if (string.IsNullOrWhiteSpace(ad))
            {
                MessageBox.Show("Ad alanı boş bırakılamaz.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Soyad alanı boş bırakılamaz.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(telefon))
            {
                MessageBox.Show("Telefon alanı boş bırakılamaz.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email alanı boş bırakılamaz.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(Kullanici_yas.Text))
            {
                MessageBox.Show("Yaş alanı boş bırakılamaz.");
                return;
            }

            else if (!int.TryParse(Kullanici_yas.Text, out yas))
            {
                MessageBox.Show("Lütfen geçerli bir yaş girin (sadece sayı).");
                return;
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into KullaniciTBL(Ad,Soyad,Telefon,Email,Yas) values(@ad,@soyad,@telefon,@email,@yas)");

                insertCommand.Parameters.AddWithValue("@ad", ad);
                insertCommand.Parameters.AddWithValue("@soyad", soyad);
                insertCommand.Parameters.AddWithValue("@telefon",telefon);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@yas", yas);

                int row =objdbAccess.executeQuery(insertCommand);
                if (row == 1)
                { MessageBox.Show("Veriler eklendi.");
                
                }

                else
                {
                    MessageBox.Show("Veriler eklenemedi!");
                }
            }
        }

        private void anasayfaya_don_Click(object sender, EventArgs e)
        {
            this.Close(); 
            previousForm.Show(); 
        }
    }
}
