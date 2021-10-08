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
    public partial class YeniAracKaydi : Form
    {
        string musteri;
        public YeniAracKaydi(string musteriID)
        {
            musteri = musteriID;
            InitializeComponent();
        }

        private void YeniAracKaydi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (Veritabani.Sorgu("SELECT ID From Arac WHERE Plaka='" + textBox1.Text + "'") == "")
                {
                    List<SqlParameter> parametreler = new List<SqlParameter>();
                    parametreler.Add(new SqlParameter("@id", musteri));
                    parametreler.Add(new SqlParameter("@plaka", textBox4.Text));
                    parametreler.Add(new SqlParameter("@marka", textBox1.Text));
                    parametreler.Add(new SqlParameter("@model", textBox2.Text));
                    parametreler.Add(new SqlParameter("@renk", textBox3.Text));
                    Veritabani.KomutCalistir("INSERT INTO Arac(MusteriID,Plaka,Marka,Model,Renk) VALUES(@id,@plaka,@marka,@model,@renk)", parametreler);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu Plakaya ait bir araç kaydı zaten mevcut.");
                }
            }
            else MessageBox.Show("Tüm alanları doldurunuz.");
        }
    }
}
