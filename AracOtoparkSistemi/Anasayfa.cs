using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracOtoparkSistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        void Yenile()
        {
            kapasite.Text = Veritabani.Sorgu("SELECT COUNT(*) FROM ParkYeri");
            aracsayisi.Text = Veritabani.Sorgu("SELECT COUNT(*) FROM ParkYeri WHERE AracID IS NOT NULL");
            bosyersayisi.Text= Veritabani.Sorgu("SELECT COUNT(*) FROM ParkYeri WHERE AracID IS NULL");
            toplamucret.Text = Veritabani.Sorgu("SELECT SUM(ToplamUcret) FROM Islem")+" ₺";
            toplamparksaati.Text = Veritabani.Sorgu("SELECT SUM(ParkSuresi) FROM Islem")+" Saat";
            string kat = cbKat.SelectedItem.ToString();
            List<string> araclar = Veritabani.KattakiAraclar(kat);
            foreach (string arac in araclar)
            {
                string no = arac.Split(':')[0];
                string plaka = arac.Split(':')[1];
                if (Controls.Find("n"+no,true).Length>0)
                {
                    var btn = Controls.Find("n" + no, true)[0];
                    if (btn is Button)
                    {
                        btn = (Button)btn;
                        if (plaka == "")
                        {
                            btn.Text = "BOŞ";
                            btn.BackColor = Color.Green;
                        }
                        else
                        {
                            btn.BackColor = Color.Red;
                            btn.Text = plaka;
                        }
                    }
                }
            }
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            cbKat.SelectedIndex = 0;
            Yenile();
        }

        private void cbKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Yenile();
        }

        private void n8_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string parkyeriNo = btn.Name[1].ToString();
            string kat = cbKat.SelectedItem.ToString();
            string parkyeriID = Veritabani.Sorgu("SELECT ID FROM ParkYeri WHERE Kat=" + kat + " AND Numara=" + parkyeriNo);
            string durum = Veritabani.Sorgu("SELECT AracID FROM ParkYeri WHERE ID=" + parkyeriID);
            if (durum=="")
            {
                new AracGiris(parkyeriID).ShowDialog();
                Yenile();
            }
            else
            {
                new AracCikis(parkyeriID).ShowDialog();
                Yenile();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Raporlar().ShowDialog();
        }
    }
}
