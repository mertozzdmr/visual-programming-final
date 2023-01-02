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
    public partial class Form5 : Form
    {
       
        MySqlDataReader dr2;
        public Form5()
        {
            InitializeComponent();
        }
        
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=gorsel;Uid=root;Pwd='';");

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            baglanti.Open();
          comboBox1.Items.Clear();
            MySqlCommand cmd = new MySqlCommand();
           
            cmd.CommandText = "select * from tbl_sozler";
            cmd.Connection = baglanti;

            MySqlDataReader dr1;
            dr1= cmd.ExecuteReader();
            while (dr1.Read())
            {
                if (true)
                {
                    comboBox1.Items.Add(dr1["sozler"]);
                }

            }

            baglanti.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
            //MySqlCommand komut1 = new MySqlCommand();
            //baglanti.Open();
            //komut1.CommandText = "select * from tbl_sozler";
            //komut1.Connection = baglanti;
            //komut1.CommandType = CommandType.Text;

            //if (comboBox1.SelectedIndex==0)
            //{

            //}
            //if (comboBox1.SelectedIndex == 1)
            //{

            //}
            //baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
