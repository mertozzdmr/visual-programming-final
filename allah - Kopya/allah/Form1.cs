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

    public partial class Form1 : Form

    {
        Baglanti asd=new Baglanti();
        
       
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asd.uyeekle(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            asd.mysqlbaglan.Open();
            MySqlCommand ekle = new MySqlCommand("select * from login where kadi='"+textBox6.Text+"' and sifre='"+textBox7.Text+"'",asd.mysqlbaglan);
            MySqlDataReader reader=ekle.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("giris süper");
                Form2 form2sec = new Form2();
                form2sec.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("hatali giris");
            }
            asd.mysqlbaglan.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult basilantus;
            basilantus = MessageBox.Show("cıkmak mı istiyorsun?", "çıkış ekranı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (basilantus == DialogResult.Yes) Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 admin1 = new Form9();
            admin1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            Form9 admin1 = new Form9();
            admin1.Show();
        }
    }
}
