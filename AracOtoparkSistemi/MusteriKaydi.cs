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
    public partial class MusteriKaydi : Form
    {
        public MusteriKaydi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&textBox2.Text!="")
            {
                List<SqlParameter> parametreler = new List<SqlParameter>();
                parametreler.Add(new SqlParameter("@ad", textBox1.Text));
                parametreler.Add(new SqlParameter("@soyad", textBox2.Text));
                Veritabani.KomutCalistir("INSERT INTO Musteri(Ad,Soyad) VALUES(@ad,@soyad)", parametreler);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tüm bilgileri doldurunuz.");
            }
        }
    }
}
