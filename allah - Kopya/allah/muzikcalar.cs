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
    public partial class muzikcalar : Form
    {
        public muzikcalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "Dosya Seç";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            

            axWindowsMediaPlayer1.URL = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void muzikcalar_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Duman-Melankoli");
            comboBox1.Items.Add("Duman-Melek");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.Text = "Özledim seni harbiden " +
                    "Aklıma da düşüverir aniden" +
                    "İçince, açılınca" +
                    "Bekledin, sana gelmedim" +
                    "Geceleri gönlüme eğledim" +
                    "Uçunca, uyuşunca";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox2.Text = "Kendisi bir garip melek" +
                    "Ardına düşmeniz gerek" +
                    "Kendisi bir garip melek" +
                    "Ardına düşmeniz gerek" +
                    "Öyle bir an gelir melek" +
                    "Farkına varmanız gerek" +
                    "Öyle bir an gider melek" +
                    "Farkına varmanız gerek";
            }
        }
    }
}
