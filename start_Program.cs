using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_Team_Project
{

    public partial class start_Program : Form
    {
        private Timer timer;
        private int secondsElapsed;

        public start_Program()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            secondsElapsed = 0;

            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;


            if (secondsElapsed >= 6)
            {

                timer.Stop();

                login_Program form2 = new login_Program();
                form2.Show();

                this.Close();
            }
        }
        private void start_Program_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
