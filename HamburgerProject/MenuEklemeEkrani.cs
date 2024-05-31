using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HamburgerProject.Concrete;
using HamburgerProject.Utilities;

namespace HamburgerProject
{
    public partial class MenuEklemeEkrani : Form
    {
        public MenuEklemeEkrani()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string menuAdi=txtAd.Text;
            decimal menuFiyat=nudFiyat.Value;

            if(string.IsNullOrEmpty(menuAdi) || menuFiyat<=0) 
            {
                MessageBox.Show("Menu adı boş olamaz\nFiyat 0 ya da daha az olamaz");
                return;
            }
            Menu menu = new Menu();
            menu.Ad=menuAdi;
            menu.Fiyat= menuFiyat;

            AnaEkran.Menuler.Add(menu);

            Helper.Temizle(this.Controls);

        }
    }
}
