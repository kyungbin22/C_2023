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
    public partial class memo : Form
    {
        public memo()
        {
            InitializeComponent();
        }

        private void memo_Load(object sender, EventArgs e)
        {
            textBox1.Text = "가게 공지사항입니다~~";
            textBox2.Text = Properties.Settings.Default.MemoText;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.SelectionStart = textBox2.TextLength;
            textBox2.SelectionLength = 0;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MemoText = textBox2.Text;
            Properties.Settings.Default.Save();
        }
    }
}
