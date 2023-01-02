using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allah
{
    internal class Baglanti
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=gorsel;Uid=root;Pwd='';"); 



        public void uyeekle(string kadi,string sifre,string isim,string soyisim, string telefon)
        {
            mysqlbaglan.Open();
            MySqlCommand ekle =new MySqlCommand("insert into login(kadi,sifre,isim,soyisim,telefon)values('" + kadi + "','" + sifre + "','" + isim + "','" + soyisim + "','" + telefon + "')", mysqlbaglan);
            ekle.ExecuteNonQuery();
            mysqlbaglan.Close();
        
        
        }


    }
}
