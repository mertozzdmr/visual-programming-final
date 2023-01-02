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
    public partial class hakkimizda : Form
    {
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=gorsel;Uid=root;Pwd='';");
        public hakkimizda()
        {
            InitializeComponent();
        }

        private void hakkimizda_Load(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mysqlbaglan;
            cmd.CommandText = "select * from hakkimizda";
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label3.Text = reader["hakkimizda"].ToString();
            }
        }
    }
}
