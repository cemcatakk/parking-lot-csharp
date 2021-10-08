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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Veritabani.GirisYap(textBox1.Text,textBox2.Text))
            {
                new Anasayfa().ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı/şifre.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&textBox2.Text!="")
            {
                List<SqlParameter> parametreler = new List<SqlParameter>();
                parametreler.Add(new SqlParameter("@kadi", textBox1.Text));
                parametreler.Add(new SqlParameter("@sifre", textBox2.Text));
                Veritabani.KomutCalistir("INSERT INTO Kullanici(Kullaniciadi,Sifre) VALUES(@kadi,@sifre)", parametreler);
                MessageBox.Show("Kayıt başarılı.");
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurunuz.");
            }
        }
    }
}
