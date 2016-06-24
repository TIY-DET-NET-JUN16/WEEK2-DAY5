using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2Day5
{
    public partial class Form1 : Form
    {
        public const string something = "7";

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = something;

            comboBox1.DataSource = Enum.GetValues(typeof(DayOfTheWeek));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DayOfTheWeek.Friday.ToString();
            int selectedIndex = comboBox1.SelectedIndex;

            DayOfTheWeek today = DayOfTheWeek.Friday;
            int day = Convert.ToInt32(DayOfTheWeek.Tuesday);

            Months month = Months.June;

            if (today == DayOfTheWeek.Friday)
                textBox1.Text = "Almost There!";

            textBox1.Text = string.Format("{0}/{1}/{2} The month is {3}", 
                Convert.ToInt32(month), DateTime.Now.Day, DateTime.Now.Year, month);


        }

    }

    public enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public enum DayOfTheWeek
    {
        Monday = 1,
        Tuesday = 3,
        Wednesday = 5,
        Thursday = 7,
        Friday = 9,
        Saturday = 11,
        Sunday = 13
    }
}
