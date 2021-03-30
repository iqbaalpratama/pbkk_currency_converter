using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBKK_static_currency_converter
{
    public partial class Form1 : Form
    {
        double[] fromRupiah = { 1, 0.000069, 0.00058, 0.0075 };
        double[] fromUSD = { 14446.25, 1, 0.84, 108.49 };
        double[] fromEuro = { 17114.54, 1.18, 1, 128.51 };
        double[] fromYen = { 133.07, 0.0092, 0.0078, 1 };
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboBox1.SelectedIndex;
                int index2 = comboBox2.SelectedIndex;
                double fromValue = double.Parse(textBox2.Text);
                if (fromValue == null || index == null || index2 == null)
                {
                    textBox1.Text = "Harap mengisi data yang diperlukan";
                    return;
                }
                double toValue = 0.0;
                if (index == 0)
                {
                    toValue = fromValue * fromRupiah[index2];
                }
                if (index == 1)
                {
                    toValue = fromValue * fromUSD[index2];
                }
                if (index == 2)
                {
                    toValue = fromValue * fromEuro[index2];
                }
                if (index == 3)
                {
                    toValue = fromValue * fromYen[index2];
                }
                textBox1.Text = toValue.ToString();
            }
            catch (FormatException ex)
            {
                textBox1.Text = "Masukkan nilai yang akan dikonversi!";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                textBox1.Text = "Isikan inputan dengan benar";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
