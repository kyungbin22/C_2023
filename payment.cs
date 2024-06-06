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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void order_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int judge = 0;
        int cashcard = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            judge = 1;
            this.button3.BackColor = Color.LightYellow;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            judge=2;
            this.button4.BackColor = Color.LightYellow;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cashcard = 1;
            this.button5.BackColor = Color.LightYellow;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cashcard = 2;
            this.button6.BackColor = Color.LightYellow;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((judge==1 || judge==2)&&(cashcard==1 || cashcard == 2))
            {
                MessageBox.Show("결제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("포장 여부와 결제수단을 정해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
