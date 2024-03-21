using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTool
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        const int maxSideWidth = 279;
        const int minSideWidth = 50;
        const int speedSide = 30;
        int initSide = 80;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerNowtime.Interval = 100;
            timerNowtime.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        { 
            metroLabel1.Text = DateTime.Now.ToString("t");
        }

        private void timerSideTime_Tick(object sender, EventArgs e)
        {
            if (checkclose.Checked == false)
            {
                initSide -= speedSide;
                if (initSide <= minSideWidth)
                    timerSideTime.Stop();
            }
            else
            {
                initSide += speedSide;
                if (initSide >= maxSideWidth)
                    timerSideTime.Stop();
            }

            panelside.Width = initSide;
        }

        private void checkclose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkclose.Checked == true) {
                checkclose.Text = "<";
            }
            else
            {
                checkclose.Text = ">";
            }
            timerSideTime.Start();
        }
    }
}
