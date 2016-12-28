using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=1; i<=31; i++)
            {
                cmbDay.Items.Add(i);
            }
            List<string> Months = new List<string>();
            Months.Add("January");
            Months.Add("February");
            Months.Add("March");
            Months.Add("April");
            Months.Add("May");
            Months.Add("June");
            Months.Add("July");
            Months.Add("August");
            Months.Add("September");
            Months.Add("October");
            Months.Add("November");
            Months.Add("December");

            int Lenght = Months.Count;
            for(int monthIndex=0; monthIndex<Lenght; monthIndex++)
            {
                cmbMonth.Items.Add(Months[monthIndex]);
            }
            int year = DateTime.Today.Year;
            for (int yearIndex=1930; yearIndex<=year; yearIndex+=4)
            {
                cmbYear.Items.Add(yearIndex);
            }

        }
    }
}
