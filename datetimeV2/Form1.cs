using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimeV2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime DOB = new DateTime(int.Parse(textBox3.Text), int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            DateTime today = DateTime.Now;
            TimeSpan diffResult = today.Subtract(DOB);
            textBox5.Text = diffResult.ToString();
            int years = (int)(diffResult.Days / 365.25);
            int months = diffResult.Days / 31;
            textBox6.Text = years.ToString();
            textBox7.Text = months.ToString();
        }

        

    }
}
