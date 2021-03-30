using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace pbkk_dynamic_currency_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Double rateCurrency(string From, string To)
        {
            var json = "";
            Double rate;
            try
            {
                string url = string.Format("https://free.currconv.com/api/v7/convert?q={0}_{1}&compact=ultra&apiKey=81c1aa76d91126db6819", From, To);
                string key = string.Format("{0}_{1}", From, To);

                json = new WebClient().DownloadString(url);
                dynamic stuff = JsonConvert.DeserializeObject(json);
                rate = Convert.ToDouble(stuff[key]);
            }
            catch
            {
                rate = 0;
            }

            return rate;
        }

        private void convertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string From = frombox.SelectedItem.ToString();
                string To = tobox.SelectedItem.ToString();
                Double rate = rateCurrency(From, To);
                Double result = Double.Parse(amountbox.Text) * rate;
                resultbox.Text = result.ToString();
            }
            catch(FormatException ex)
            {
                resultbox.Text = "Inputan harus benar diisi!";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                resultbox.Text = "Jenis currency harus dipilih!";
            }
        }
    }
}
