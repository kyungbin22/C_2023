using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_Team_Project
{

    public partial class login_Program : Form
    {
        public login_Program()
        {
            InitializeComponent();
        }

        private void login_Program_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = text_ID.Text;
            string PW = text_PW.Text;

            if (EmptyCheck())
            {

                if (ID == "syucom" && PW == "3636")
                {
                    main_System sys = new main_System();
                    sys.Show();
                    sys.FormClosed += (s, args) => this.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("죄송합니다. 사용자명과 비밀번호가 올바르지 않습니다.");
                }
            }
        }

        private bool EmptyCheck()
        {
            if (String.IsNullOrEmpty(text_ID.Text))
            {
                MessageBox.Show("사용자명을 입력해 주세요");
                text_ID.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(text_PW.Text))
            {
                MessageBox.Show("비밀번호를 입력해 주세요");
                text_PW.Focus();
                return false;
            }
            return true;
        }
    }
}