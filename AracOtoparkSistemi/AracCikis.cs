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
    public partial class AracCikis : Form
    {
        string parkyeri;
        public AracCikis(string parkyeriID)
        {
            parkyeri = parkyeriID;
            InitializeComponent();
        }

        private void AracCikis_Load(object sender, EventArgs e)
        {
            string[] bilgiler = Veritabani.ParkYeriBilgisi(parkyeri).Split('|');
            giristarihi.Text = bilgiler[0];
            sure.Text = bilgiler[1];
            if (bilgiler[1]=="0")
            {
                sure.Text = "1";
            }
            ad.Text = bilgiler[6];
            soyad.Text = bilgiler[7];
            plaka.Text = bilgiler[2];
            marka.Text = bilgiler[3];
            model.Text = bilgiler[4];
            renk.Text = bilgiler[5];
            ucret.Text = Veritabani.Sorgu("SELECT Ucret FROM Ucretler WHERE Sure="+sure.Text);
            if (ucret.Text == "")
            {
                ucret.Text = Veritabani.Sorgu("SELECT MAX(Ucret) FROM Ucretler");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametreler = new List<SqlParameter>();
            parametreler.Add(new SqlParameter("@aracid",Veritabani.Sorgu("SELECT AracID FROM ParkYeri WHERE ID="+parkyeri)));
            parametreler.Add(new SqlParameter("@parkyeriid", parkyeri));
            parametreler.Add(new SqlParameter("@sure", sure.Text));
            parametreler.Add(new SqlParameter("@ucret", ucret.Text));
            Veritabani.KomutCalistir("INSERT INTO Islem(Tarih,AracID,ParkYeriID,ParkSuresi,ToplamUcret) VALUES(GETDATE(),@aracid,@parkyeriid,@sure,@ucret)",parametreler); ;
            parametreler = new List<SqlParameter>();
            parametreler.Add(new SqlParameter("@parkyeriid", parkyeri));
            Veritabani.KomutCalistir("UPDATE ParkYeri SET AracID=NULL, GirisTarihi=NULL WHERE ID=@parkyeriid", parametreler);
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
