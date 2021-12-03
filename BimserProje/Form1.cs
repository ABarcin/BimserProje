using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BimserProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NumberFormatInfo provider = new NumberFormatInfo();
            //for string to double format
            provider.NumberDecimalSeparator = ".";

            label1.Text = "Today";
            XElement xelement = XElement.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
            IEnumerable<XElement> foreignCurrency = xelement.Elements();
            foreach (var item in foreignCurrency)
            {
                dataGridView1.Rows.Add(item.LastAttribute.Value, item.Element("Isim").Value, item.Element("ForexBuying").Value, item.Element("ForexSelling").Value, item.Element("BanknoteBuying").Value, item.Element("BanknoteSelling").Value);
            }
            
            double doubleMaxBuying = foreignCurrency.Select(i => Convert.ToDouble(i.Element("ForexBuying").Value,provider)).Max();
            double doubleMinBuying = foreignCurrency.Select(i => Convert.ToDouble(i.Element("ForexBuying").Value, provider)).Min();
            string stMaxBuying = (doubleMaxBuying.ToString()).Replace(',', '.');
            string stMinBuying = (doubleMinBuying.ToString()).Replace(',', '.');
            var nameMax = from x in foreignCurrency where x.Element("ForexBuying").Value.Contains(stMaxBuying) select x.Element("Isim").Value;
            var nameMin= from x in foreignCurrency where x.Element("ForexBuying").Value.Contains(stMinBuying) select x.Element("Isim").Value;
            todayMaxBuying.Text =stMaxBuying;
            todayMinBuying.Text = stMinBuying;
            lblMaxName.Text= nameMax.FirstOrDefault();
            lblMinName.Text= nameMin.FirstOrDefault();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string formatDateTime = dateTimePicker1.Value.ToString("yyyy")+ dateTimePicker1.Value.ToString("MM")+"/"+ dateTimePicker1.Value.ToString("dd")+ dateTimePicker1.Value.ToString("MM")+ dateTimePicker1.Value.ToString("yyyy");
            string tcmb = "https://www.tcmb.gov.tr/kurlar/" + formatDateTime+".xml";
            XElement xelement = XElement.Load(tcmb);
            IEnumerable<XElement> foreignCurrency = xelement.Elements();
            foreach (var item in foreignCurrency)
            {
                dataGridView2.Rows.Add(item.LastAttribute.Value,item.Element("Isim").Value,item.Element("ForexBuying").Value,item.Element("ForexSelling").Value, item.Element("BanknoteBuying").Value, item.Element("BanknoteSelling").Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            //for string to double format
            provider.NumberDecimalSeparator = ".";

            double result = Convert.ToDouble(lblPrice.Text,provider) * int.Parse(lblQuentity.Text);
            lblResult.Text = result.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbCurrencyName.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void tbQuentity_TextChanged(object sender, EventArgs e)
        {
            lblQuentity.Text = tbQuentity.Text;
        }
    }
}
