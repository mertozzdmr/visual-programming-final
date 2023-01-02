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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                webBrowser1.Navigate("https://www.repertuarim.com/akor-tab/duman/");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                webBrowser1.Navigate("https://www.repertuarim.com/akor-tab/pinhani/");
            }
             if (comboBox1.SelectedIndex == 2)
            {
                webBrowser1.Navigate("https://www.repertuarim.com/akor-tab/onur-can--ozcan/");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                webBrowser1.Navigate("https://www.repertuarim.com/akor-tab/mor-ve-otesi/");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {          
            comboBox1.Items.Add("Duman");
            comboBox1.Items.Add("Pinhani");
            comboBox1.Items.Add("Onurcan Özcan");
            comboBox1.Items.Add("Mor ve Ötesi");

        }
    }
}
