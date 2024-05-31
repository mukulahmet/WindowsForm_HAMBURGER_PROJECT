using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HamburgerProject.Concrete;
using HamburgerProject.Enums;
using HamburgerProject.Utilities;

namespace HamburgerProject
{
    public partial class EkstraMalzemeEklemeEkrani : Form
    {
        public EkstraMalzemeEklemeEkrani()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string malzemeAdi = txtAd.Text;
            decimal malzemeFiyat=nudFiyat.Value;

            if(string.IsNullOrEmpty(malzemeAdi) || malzemeFiyat<=0)
            {
                MessageBox.Show("Malzeme adı boş olamaz\nFiyat 0 ya da daha az olamaz");
                return;
            }

            EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            ekstraMalzeme.Ad=malzemeAdi;
            ekstraMalzeme.Fiyat=malzemeFiyat;

            AnaEkran.EkstraMalzemeler.Add(ekstraMalzeme);
            Helper.Temizle(this.Controls);


        }
    }
}
