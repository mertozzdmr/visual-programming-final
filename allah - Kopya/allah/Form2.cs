using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allah
{
    public partial class Form2 : Form
    {
        muzik_aletleri alet = new muzik_aletleri();
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 radyo = new Form3();
            radyo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 akor = new Form4();
            akor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            muzik_aletleri alet = new muzik_aletleri();
            alet.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            muzikcalar muzik = new muzikcalar();
            muzik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 sozler = new Form5();
            sozler.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult basilantus;
            basilantus = MessageBox.Show("cıkmak mı istiyorsun?", "çıkış ekranı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (basilantus == DialogResult.Yes) Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 video = new Form6();
            video.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 frekans = new Form7();
            frekans.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form8 iletisim = new Form8();
            iletisim.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hakkimizda hakkimizda = new hakkimizda();
            hakkimizda.Show();
        }
    }
}
