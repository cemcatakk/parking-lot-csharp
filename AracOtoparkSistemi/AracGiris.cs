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
    public partial class AracGiris : Form
    {
        string parkyeri;
        public AracGiris(string parkyeriID)
        {
            parkyeri = parkyeriID;
            InitializeComponent();
        }
        void Yenile()
        {
            Veritabani.ComboboxDoldur("SELECT CONCAT(ID,' ',Ad,' ',Soyad) FROM Musteri",cbMusteri);
            if (cbMusteri.SelectedIndex>=0)
            {
                Veritabani.ComboboxDoldur("SELECT CONCAT(ID,' ',Plaka) FROM Arac WHERE MusteriID=" + cbMusteri.Text.Split(' ')[0], cbArac);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new MusteriKaydi().ShowDialog();
            Yenile();
        }

        private void AracGiris_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbMusteri.SelectedIndex >= 0)
            {
                string musteriID = cbMusteri.SelectedItem.ToString().Split(' ')[0];
                new YeniAracKaydi(musteriID).ShowDialog();
                cbArac.Text = "";
                Veritabani.ComboboxDoldur("SELECT CONCAT(ID,' ',Plaka) FROM Arac WHERE MusteriID=" + cbMusteri.Text.Split(' ')[0], cbArac);
            }
            else MessageBox.Show("Bir müşteri seçiniz.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbArac.SelectedIndex >= 0)
            {
                string aracID = cbArac.Text.Split(' ')[0];
                List<SqlParameter> parametreler = new List<SqlParameter>();
                parametreler.Add(new SqlParameter("@aracid", aracID));
                parametreler.Add(new SqlParameter("@id", parkyeri));
                Veritabani.KomutCalistir("UPDATE ParkYeri SET AracID=@aracid,GirisTarihi=GETDATE() WHERE ID=@id",parametreler);
                this.Close();
            }
            else MessageBox.Show("Bir araç seçiniz.");
        }

        private void cbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbArac.Text = "";
            Veritabani.ComboboxDoldur("SELECT CONCAT(ID,' ',Plaka) FROM Arac WHERE MusteriID=" + cbMusteri.Text.Split(' ')[0], cbArac);
        }

        private void cbArac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
