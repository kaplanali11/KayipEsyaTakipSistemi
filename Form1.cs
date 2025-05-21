using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayipEsyaTakipSistemi
{
    public partial class anasayfa: Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            bulunmaVeriEkle Bulunma_veri_ekleme_form = new bulunmaVeriEkle(this);
            this.Hide();
            Bulunma_veri_ekleme_form.Show();
            Bulunma_veri_ekleme_form.FormClosed += (s, args) => this.Show();
        }

        private void Kullanici_veri_ekle_Click(object sender, EventArgs e)
        {
            KullaniciVeriEkle Kullanici_veri_ekleme_form = new KullaniciVeriEkle(this);
            this.Hide();
            Kullanici_veri_ekleme_form.Show();
            Kullanici_veri_ekleme_form.FormClosed += (s, args) => this.Show();
        }

       

       

        private void Esya_veri_ekle_Click(object sender, EventArgs e)
        {
            esyaVeriEkle Esya_veri_ekleme_form = new esyaVeriEkle(this);
            this.Hide();
            Esya_veri_ekleme_form.Show();
            Esya_veri_ekleme_form.FormClosed += (s, args) => this.Show();
        }

     

      

        

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
