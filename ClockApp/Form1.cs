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
        public int counter = 0;
        public Form1()
        {
            InitializeComponent();
            updateDec();
            updateBin();
            updateOct();
            updateHex();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 0) {
                ConsoleTextBox.Text = "> Updating dec clock";
                updateDec();
                counter = 1;
                progressBar1.Value = 25;
            }
            else if (counter == 1)
            {
                ConsoleTextBox.AppendText(Environment.NewLine + "> Updating bin clock");
                updateBin();
                counter = 2;
                progressBar1.Value = 50;
            }
            else if (counter == 2)
            {
                ConsoleTextBox.AppendText(Environment.NewLine + "> Updating oct clock");
                updateOct();
                counter = 3;
                progressBar1.Value = 75;
            }
            else if (counter == 3)
            {
                ConsoleTextBox.AppendText(Environment.NewLine + "> Updating hex clock");
                updateHex();
                counter = 4;
                progressBar1.Value = 100;
            }
            else if (counter == 4)
            {
                ConsoleTextBox.Text = "";
                counter = 0;
                progressBar1.Value = 0;
            }
        }

        public void updateDec() {
            DecTime.Text = DateTimeUtils.getHour().ToString() + ":" + DateTimeUtils.getMinute().ToString() + ":" + DateTimeUtils.getSecond().ToString();
            DecDate.Text = DateTimeUtils.getDay().ToString() + "/" + DateTimeUtils.getMonth().ToString() + "/" + DateTimeUtils.getYear().ToString();
        }
        public void updateBin() {
            Bintime.Text = DateTimeUtils.getHourbin() + ":" + DateTimeUtils.getMinutebin() + ":" + DateTimeUtils.getSecondbin();
            BinDate.Text = DateTimeUtils.getDaybin() + "/" + DateTimeUtils.getMonthbin() + "/" + DateTimeUtils.getYearbin();
        }
        public void updateOct() {
            OctTime.Text = DateTimeUtils.getHouroct() + ":" + DateTimeUtils.getMinuteoct() + ":" + DateTimeUtils.getSecondoct();
            OctDate.Text = DateTimeUtils.getDayoct() + "/" + DateTimeUtils.getMonthoct() + "/" + DateTimeUtils.getYearoct();
        }
        public void updateHex() {
            HexTime.Text = DateTimeUtils.getHourhex() + ":" + DateTimeUtils.getMinutehex() + ":" + DateTimeUtils.getSecondhex();
            HexDate.Text = DateTimeUtils.getDayhex() + "/" + DateTimeUtils.getMonthhex() + "/" + DateTimeUtils.getYearhex();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
