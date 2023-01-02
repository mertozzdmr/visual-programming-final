using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace allah
{
    public partial class muzik_aletleri : Form
    {
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=gorsel;Uid=root;Pwd='';");
        //MySqlDataReader reader1;
        //MySqlDataReader reader2;

        public muzik_aletleri()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void muzik_aletleri_Load(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mysqlbaglan;
            cmd.CommandText = "select * from aletler";
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label3.Text = reader["isim"].ToString();
                label5.Text= reader["yapı"].ToString() ;
                label6.Text = reader["isim1"].ToString();
                label8.Text = reader["yapı1"].ToString();
                label7.Text = reader["isim2"].ToString();
                label9.Text = reader["yapı2"].ToString();
               
            }
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult basilantus;
            basilantus = MessageBox.Show("cıkmak mı istiyorsun?", "çıkış ekranı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (basilantus == DialogResult.Yes) Application.Exit();
        }
    }
}
