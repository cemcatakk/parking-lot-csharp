using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//veri tabanı kütüphanem
using System.Data;
using System.Windows.Forms;

namespace AracOtoparkSistemi
{
    class Veritabani
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AracOtoparkSistemiVt.mdf;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter da = new SqlDataAdapter();
        static SqlDataReader dr;
        static DataSet ds = new DataSet();
        public static bool GirisYap(string kadi, string sifre) //Verilen kullanıcı adı ve şifre ile giriş işlemi
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Kullanici WHERE Kullaniciadi=@kadi AND Sifre=@sifre", con); //SQL kodu ile yetkili tablosunda ad ve şifre aranıyor
            cmd.Parameters.AddWithValue("@kadi", kadi);
            cmd.Parameters.AddWithValue("@sifre", sifre); //Parametre olarak kadı ve şifre ekleniyor
            dr = cmd.ExecuteReader();
            bool sonuc = false;
            if (dr.Read()) //Eğer sorgu 1 sonuç bulmuşsa
            {
                sonuc = true; //Sonuç true olur
            }
            con.Close();
            return sonuc;//Eğer sonuc TRUE döndürürse giriş yapılır, FALSE döndürürse giriş yapılamaz.
        }
        public static List<string> KattakiAraclar(string kat) //Kategorileri bir liste olarak döndüren metot
        {
            con.Open();
            List<string> araclar = new List<string>();
            cmd = new SqlCommand("SELECT Numara,Plaka FROM Arac RIGHT JOIN ParkYeri ON Arac.ID=ParkYeri.AracID WHERE ParkYeri.Kat=@kat", con); //Kategoriler tablosundaki tüm veriler seçilir
            cmd.Parameters.AddWithValue("@kat", kat);
            dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                araclar.Add(dr[0].ToString()+":"+dr[1].ToString());
            }
            con.Close();
            return araclar; //Plaka listesi döndürülür
        }
        public static void KomutCalistir(string sql, List<SqlParameter> parametre)
        {
            con.Open();
            cmd = new SqlCommand(sql, con); //Verilen parametre ve SQL komutu ile bir SqlCommand oluşturulur
            cmd.Parameters.AddRange(parametre.ToArray());
            cmd.ExecuteNonQuery(); //Ve çalıştırılır
            con.Close();
        }
        public static string Sorgu(string sorgu)
        {
            con.Open();
            cmd = new SqlCommand(sorgu, con);
            dr = cmd.ExecuteReader();
            string sonuc = "";
            if (dr.Read())
            {
                sonuc = dr[0].ToString();
            }
            con.Close();
            return sonuc;
        }
        public static string Sorgu(string sorgu,List<SqlParameter> parametreler)
        {
            con.Open();
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddRange(parametreler.ToArray());
            dr = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            string sonuc = "";
            if (dr.Read())
            {
                sonuc = dr[0].ToString();
            }
            con.Close();
            return sonuc;
        }
        public static void TabloGoruntule(string sql, DataGridView tablo,List<SqlParameter> parametreler)
        {
            con.Open();
            ds = new DataSet();
            da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddRange(parametreler.ToArray());
            da.Fill(ds); 
            tablo.DataSource = ds.Tables[0];
            con.Close();
        }
        public static string ParkYeriBilgisi(string parkyeriID)
        {
            con.Open();
            cmd = new SqlCommand("SELECT GirisTarihi,DATEPART(HOUR, GirisTarihi)-DATEPART(HOUR, GETDATE()) AS 'Kalis Suresi',Plaka,Marka,Model,Renk,Ad,Soyad FROM ParkYeri " +
                "INNER JOIN Arac ON Arac.ID=ParkYeri.AracID INNER JOIN Musteri ON Musteri.ID=Arac.MusteriID WHERE ParkYeri.ID="+parkyeriID, con);
            dr = cmd.ExecuteReader();
            string sonuc = "";
            if (dr.Read())
            {
                sonuc = dr[0].ToString() + "|" + dr[1].ToString() + "|" + dr[2].ToString() + "|" + dr[3].ToString() + "|"
                    + dr[4].ToString() + "|" + dr[5].ToString() + "|" + dr[6].ToString() + "|" + dr[7].ToString();
            }
            con.Close();
            return sonuc;
        }
        public static void ComboboxDoldur(string sorgu,ComboBox cb)
        {
            con.Open();
            cb.Items.Clear();
            cmd = new SqlCommand(sorgu, con); 
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
    }
}
