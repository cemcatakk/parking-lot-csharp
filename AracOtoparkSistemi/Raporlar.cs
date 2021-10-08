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

namespace AracOtoparkSistemi
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametreler = new List<SqlParameter>();
            parametreler.Add(new SqlParameter("@baslangic", baslangicTarihi.Value));
            parametreler.Add(new SqlParameter("@bitis", bitisTarihi.Value));
            toplamaracgirisi.Text = Veritabani.Sorgu("SELECT COUNT(*) FROM Islem WHERE Tarih BETWEEN @baslangic AND @bitis", parametreler)+" Adet";
            toplamkalissuresi.Text = Veritabani.Sorgu("SELECT SUM(ParkSuresi) FROM Islem WHERE Tarih BETWEEN @baslangic AND @bitis", parametreler)+" Saat";
            toplamalinanucret.Text = Veritabani.Sorgu("SELECT SUM(ToplamUcret) FROM Islem WHERE Tarih BETWEEN @baslangic AND @bitis", parametreler)+" ₺";
            ortalama.Text = Veritabani.Sorgu("SELECT AVG(ParkSuresi) FROM Islem WHERE Tarih BETWEEN @baslangic AND @bitis", parametreler)+" Saat";
            Veritabani.TabloGoruntule("SELECT * FROM Islem WHERE Tarih BETWEEN @baslangic AND @bitis", dataGridView1, parametreler);
        }
    }
}
