using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clockutils;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var datetimenow = DateTime.Now.ToString();
            DecTime.Text = datetimenow;
            Bintime.Text = datetimenow;
            OctTime.Text = datetimenow;
            HexTime.Text = datetimenow;
            ConsoleTextBox.Text = "hello world";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var datetimenow = DateTime.Now.ToString();
            DecTime.Text = DateTimeUtils.getHour().ToString() + ":" + DateTimeUtils.getMinute().ToString() + ":" + DateTimeUtils.getSecond().ToString();
            DecDate.Text = DateTimeUtils.getDay().ToString() + "/" + DateTimeUtils.getMonth().ToString() + "/" + DateTimeUtils.getYear().ToString();
            
            Bintime.Text = DateTimeUtils.getHourbin() + ":" + DateTimeUtils.getMinutebin()+ ":" + DateTimeUtils.getSecondbin();
            BinDate.Text = DateTimeUtils.getDaybin() + "/" + DateTimeUtils.getMonthbin()+ "/" + DateTimeUtils.getYearbin();

            OctTime.Text = DateTimeUtils.getHouroct() + ":" + DateTimeUtils.getMinuteoct() + ":" + DateTimeUtils.getSecondoct();
            OctDate.Text = DateTimeUtils.getDayoct() + "/" + DateTimeUtils.getMonthoct() + "/" + DateTimeUtils.getYearoct();

            HexTime.Text = DateTimeUtils.getHourhex() + ":" + DateTimeUtils.getMinutehex() + ":" + DateTimeUtils.getSecondhex();
            HexDate.Text = DateTimeUtils.getDayhex() + "/" + DateTimeUtils.getMonthhex() + "/" + DateTimeUtils.getYearhex();

            ConsoleTextBox.AppendText(Environment.NewLine + "> Updating clock");
        }
    }
}
