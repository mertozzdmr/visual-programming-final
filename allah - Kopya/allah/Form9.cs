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
    
    public partial class Form9 : Form

    {
        public Form9()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglan;

        private void Form9_Load(object sender, EventArgs e)
        {
            
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "gorsel";
            baglan = new MySqlConnection(build.ToString());
            Listele_Ara("select * from login");
        }
        public DataTable Listele_Ara(string sql)
        {
            DataTable tbl = new DataTable();
            baglan.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from login", baglan);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglan.Close();
            return tbl;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Listele_Ara("select * from login where adi like '" + textBox1.Text + "%'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
