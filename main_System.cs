using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_Team_Project
{
    public partial class main_System : Form
    {
        payment paymentForm;
        public main_System()
        {
            InitializeComponent();
            paymentForm = new payment();

        }
        private void main_System_Load(object sender, EventArgs e)
        {
            menuPage.Visible = false;
            seatPage.Visible = true;
            seat_Table.Visible = false;
            manage.Visible = false;
        }
        private void time_label_Click(object sender, EventArgs e)
        {

        }
        //종료버튼
        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        //메모장
        private void memo_Click(object sender, EventArgs e)
        {
            // 새 창을 생성합니다.
            memo page = new memo();

            // 텍스트 박스를 표시합니다.
            page.Controls["textBox1"].Visible = true;

            // 창을 표시합니다.
            page.ShowDialog();
        }
        //금일 매출현황
        private void sale_Status_Click(object sender, EventArgs e)
        {
            MessageBox.Show("매진 처리 페이지 입니다\n<주의! 메뉴 버튼 클릭시 해당 메뉴는 매진 처리됩니다>\n프로그램 재실행시 재고가 보충됩니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            menuPage.Visible = false;
            seatPage.Visible = false;
            seat_Table.Visible = false;
            manage.Visible = true;
        }
        //시간
        private void date_Timer_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString();
        }

        //주문 페이지
        private void menu_Click(object sender, EventArgs e)
        {
            menuPage.Visible = true;
            seatPage.Visible = false;
            seat_Table.Visible = false;
            manage.Visible = false;
        }
        //좌석페이지
        private void seat_Click(object sender, EventArgs e)
        {
            menuPage.Visible = false;
            seatPage.Visible = true;
            seat_Table.Visible = true;
            manage.Visible = false;
        }
        //좌석
        private void door_Click(object sender, EventArgs e)
        {

        }
        //결제
        private void Button_Purchase_Click(object sender, EventArgs e)
        {
            payment pay = new payment();

            // 창을 표시합니다.
            pay.ShowDialog();
        }
        //주문 전체 취소
        private void button_Del_Click(object sender, EventArgs e)
        {
            order_List.Items.Clear();
            menuInfoInstance.tteok1.Quantity = 1;
            menuInfoInstance.tteok2.Quantity = 1;
            menuInfoInstance.tteok3.Quantity = 1;
            menuInfoInstance.tteok4.Quantity = 1;
            menuInfoInstance.tteok5.Quantity = 1;
            menuInfoInstance.cup1.Quantity = 1;
            menuInfoInstance.cup2.Quantity = 1;
            menuInfoInstance.kim1.Quantity = 1;
            menuInfoInstance.kim2.Quantity = 1;
            menuInfoInstance.set1.Quantity = 1;
            menuInfoInstance.set2.Quantity = 1;
            menuInfoInstance.set3.Quantity = 1;
            menuInfoInstance.fry1.Quantity = 1;
            menuInfoInstance.fry2.Quantity = 1;
            menuInfoInstance.fry3.Quantity = 1;
            menuInfoInstance.fry4.Quantity = 1;
            menuInfoInstance.fry5.Quantity = 1;
            menuInfoInstance.fry6.Quantity = 1;
            menuInfoInstance.des1.Quantity = 1;
            menuInfoInstance.des2.Quantity = 1;
            menuInfoInstance.f_set1.Quantity = 1;
            menuInfoInstance.f_set2.Quantity = 1;
            menuInfoInstance.top1.Quantity = 1;
            menuInfoInstance.top2.Quantity = 1;
            menuInfoInstance.top3.Quantity = 1;
            menuInfoInstance.top4.Quantity = 1;
            menuInfoInstance.drink1.Quantity = 1;
            menuInfoInstance.drink2.Quantity = 1;
            menuInfoInstance.drink3.Quantity = 1;
            menuInfoInstance.drink4.Quantity = 1;
            menuInfoInstance.dan.Quantity = 1;

            count = 0;
        }
        //주문 코드
        private ListViewItem FindItemByKey(string key)
        {
            foreach (ListViewItem item in this.order_List.Items)
            {
                if (item.Text == key)
                {
                    return item;
                }
            }
            return null;
        }
        menu_info menuInfoInstance = new menu_info();
        int count = 0;
        int payval = 0;
        private void UpdatePayval()
        {
            payval = 0;

            foreach (ListViewItem item in order_List.Items)
            {
                int quantity = int.Parse(item.SubItems[1].Text);
                int totalPrice = int.Parse(item.SubItems[2].Text);
                payval += totalPrice;
            }
            labelPayVal.Text = $"총 금액: {payval:C}";

        }
        //버튼1
        private void button1_Click(object sender, EventArgs e)
        {
            string itemKey1 = this.button1.Text;

            ListViewItem existingItem = FindItemByKey(itemKey1);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.tteok1.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.tteok1.Price * menuInfoInstance.tteok1.Quantity);
                menuInfoInstance.tteok1.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey1, Convert.ToString(menuInfoInstance.tteok1.Quantity), Convert.ToString(menuInfoInstance.tteok1.Price * menuInfoInstance.tteok1.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.tteok1.Quantity++;
                count++;
            }
            UpdatePayval();
        }
        //버튼2
        private void button2_Click(object sender, EventArgs e)
        {
            string itemKey2 = this.button2.Text;

            ListViewItem existingItem = FindItemByKey(itemKey2);

            if (existingItem != null)
            {
                
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.tteok2.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.tteok2.Price * menuInfoInstance.tteok2.Quantity);
                menuInfoInstance.tteok2.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey2, Convert.ToString(menuInfoInstance.tteok2.Quantity), Convert.ToString(menuInfoInstance.tteok2.Price * menuInfoInstance.tteok2.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.tteok2.Quantity++;
                count++;
            }
            UpdatePayval();
        }
        //버튼3
        private void button3_Click(object sender, EventArgs e)
        {
            string itemKey3 = this.button3.Text;

            ListViewItem existingItem = FindItemByKey(itemKey3);

            if (existingItem != null)
            {

                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.tteok3.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.tteok3.Price * menuInfoInstance.tteok3.Quantity);
                menuInfoInstance.tteok3.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey3, Convert.ToString(menuInfoInstance.tteok3.Quantity), Convert.ToString(menuInfoInstance.tteok3.Price * menuInfoInstance.tteok3.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.tteok3.Quantity++;
                count++;
            }
            UpdatePayval();
        }
        //버튼4
        private void button4_Click(object sender, EventArgs e)
        {
            string itemKey4 = this.button4.Text;

            ListViewItem existingItem = FindItemByKey(itemKey4);

            if (existingItem != null)
            {

                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.tteok4.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.tteok4.Price * menuInfoInstance.tteok4.Quantity);
                menuInfoInstance.tteok4.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey4, Convert.ToString(menuInfoInstance.tteok4.Quantity), Convert.ToString(menuInfoInstance.tteok4.Price * menuInfoInstance.tteok4.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.tteok4.Quantity++;
                count++;
            }
            UpdatePayval();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string itemKey = this.button5.Text;

            ListViewItem existingItem = FindItemByKey(itemKey);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.tteok5.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.tteok5.Price * menuInfoInstance.tteok5.Quantity);
                menuInfoInstance.tteok5.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey, Convert.ToString(menuInfoInstance.tteok5.Quantity), Convert.ToString(menuInfoInstance.tteok5.Price * menuInfoInstance.tteok5.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.tteok5.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string itemKey = this.button6.Text;

            ListViewItem existingItem = FindItemByKey(itemKey);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.cup1.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.cup1.Price * menuInfoInstance.cup1.Quantity);
                menuInfoInstance.cup1.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey, Convert.ToString(menuInfoInstance.cup1.Quantity), Convert.ToString(menuInfoInstance.cup1.Price * menuInfoInstance.cup1.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.cup1.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string itemKey7 = this.button7.Text;

            ListViewItem existingItem = FindItemByKey(itemKey7);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.cup2.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.cup2.Price * menuInfoInstance.cup2.Quantity);
                menuInfoInstance.cup2.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey7, Convert.ToString(menuInfoInstance.cup2.Quantity), Convert.ToString(menuInfoInstance.cup2.Price * menuInfoInstance.cup2.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.cup2.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string itemKey8 = this.button8.Text;

            ListViewItem existingItem = FindItemByKey(itemKey8);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.kim1.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.kim1.Price * menuInfoInstance.kim1.Quantity);
                menuInfoInstance.kim1.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey8, Convert.ToString(menuInfoInstance.kim1.Quantity), Convert.ToString(menuInfoInstance.kim1.Price * menuInfoInstance.kim1.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.kim1.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 9
        private void button9_Click(object sender, EventArgs e)
        {
            string itemKey9 = this.button9.Text;

            ListViewItem existingItem = FindItemByKey(itemKey9);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.kim2.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.kim2.Price * menuInfoInstance.kim2.Quantity);
                menuInfoInstance.kim2.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey9, Convert.ToString(menuInfoInstance.kim2.Quantity), Convert.ToString(menuInfoInstance.kim2.Price * menuInfoInstance.kim2.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.kim2.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 10
        private void button10_Click(object sender, EventArgs e)
        {
            string itemKey10 = this.button10.Text;

            ListViewItem existingItem = FindItemByKey(itemKey10);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.set1.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.set1.Price * menuInfoInstance.set1.Quantity);
                menuInfoInstance.set1.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey10, Convert.ToString(menuInfoInstance.set1.Quantity), Convert.ToString(menuInfoInstance.set1.Price * menuInfoInstance.set1.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.set1.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 11
        private void button11_Click(object sender, EventArgs e)
        {
            string itemKey11 = this.button11.Text;

            ListViewItem existingItem = FindItemByKey(itemKey11);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.set2.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.set2.Price * menuInfoInstance.set2.Quantity);
                menuInfoInstance.set2.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey11, Convert.ToString(menuInfoInstance.set2.Quantity), Convert.ToString(menuInfoInstance.set2.Price * menuInfoInstance.set2.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.set2.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string itemKey12 = this.button12.Text;

            ListViewItem existingItem = FindItemByKey(itemKey12);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.set3.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.set3.Price * menuInfoInstance.set3.Quantity);
                menuInfoInstance.set3.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey12, Convert.ToString(menuInfoInstance.set3.Quantity), Convert.ToString(menuInfoInstance.set3.Price * menuInfoInstance.set3.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.set3.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 13
        private void button13_Click(object sender, EventArgs e)
        {
            string itemKey13 = this.button13.Text;

            ListViewItem existingItem = FindItemByKey(itemKey13);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.fry1.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.fry1.Price * menuInfoInstance.fry1.Quantity);
                menuInfoInstance.fry1.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey13, Convert.ToString(menuInfoInstance.fry1.Quantity), Convert.ToString(menuInfoInstance.fry1.Price * menuInfoInstance.fry1.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.fry1.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 14
        private void button14_Click(object sender, EventArgs e)
        {
            string itemKey14 = this.button14.Text;

            ListViewItem existingItem = FindItemByKey(itemKey14);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.fry2.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.fry2.Price * menuInfoInstance.fry2.Quantity);
                menuInfoInstance.fry2.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey14, Convert.ToString(menuInfoInstance.fry2.Quantity), Convert.ToString(menuInfoInstance.fry2.Price * menuInfoInstance.fry2.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.fry2.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 15
        private void button15_Click(object sender, EventArgs e)
        {
            string itemKey15 = this.button15.Text;

            ListViewItem existingItem = FindItemByKey(itemKey15);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.fry3.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.fry3.Price * menuInfoInstance.fry3.Quantity);
                menuInfoInstance.fry3.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey15, Convert.ToString(menuInfoInstance.fry3.Quantity), Convert.ToString(menuInfoInstance.fry3.Price * menuInfoInstance.fry3.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.fry3.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 16
        private void button16_Click(object sender, EventArgs e)
        {
            string itemKey16 = this.button16.Text;

            ListViewItem existingItem = FindItemByKey(itemKey16);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.fry4.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.fry4.Price * menuInfoInstance.fry4.Quantity);
                menuInfoInstance.fry4.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey16, Convert.ToString(menuInfoInstance.fry4.Quantity), Convert.ToString(menuInfoInstance.fry4.Price * menuInfoInstance.fry4.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.fry4.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 17
        private void button17_Click(object sender, EventArgs e)
        {
            string itemKey17 = this.button17.Text;

            ListViewItem existingItem = FindItemByKey(itemKey17);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.fry5.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.fry5.Price * menuInfoInstance.fry5.Quantity);
                menuInfoInstance.fry5.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey17, Convert.ToString(menuInfoInstance.fry5.Quantity), Convert.ToString(menuInfoInstance.fry5.Price * menuInfoInstance.fry5.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.fry5.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 18
        private void button18_Click(object sender, EventArgs e)
        {
            string itemKey18 = this.button18.Text;

            ListViewItem existingItem = FindItemByKey(itemKey18);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.fry6.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.fry6.Price * menuInfoInstance.fry6.Quantity);
                menuInfoInstance.fry6.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey18, Convert.ToString(menuInfoInstance.fry6.Quantity), Convert.ToString(menuInfoInstance.fry6.Price * menuInfoInstance.fry6.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.fry6.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 19
        private void button19_Click(object sender, EventArgs e)
        {
            string itemKey19 = this.button19.Text;

            ListViewItem existingItem = FindItemByKey(itemKey19);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.des1.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.des1.Price * menuInfoInstance.des1.Quantity);
                menuInfoInstance.des1.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey19, Convert.ToString(menuInfoInstance.des1.Quantity), Convert.ToString(menuInfoInstance.des1.Price * menuInfoInstance.des1.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.des1.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 20
        private void button20_Click(object sender, EventArgs e)
        {
            string itemKey20 = this.button20.Text;

            ListViewItem existingItem = FindItemByKey(itemKey20);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.des2.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.des2.Price * menuInfoInstance.des2.Quantity);
                menuInfoInstance.des2.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey20, Convert.ToString(menuInfoInstance.des2.Quantity), Convert.ToString(menuInfoInstance.des2.Price * menuInfoInstance.des2.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.des2.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 21
        private void button21_Click(object sender, EventArgs e)
        {
            string itemKey21 = this.button21.Text;

            ListViewItem existingItem = FindItemByKey(itemKey21);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.f_set1.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.f_set1.Price * menuInfoInstance.f_set1.Quantity);
                menuInfoInstance.f_set1.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey21, Convert.ToString(menuInfoInstance.f_set1.Quantity), Convert.ToString(menuInfoInstance.f_set1.Price * menuInfoInstance.f_set1.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.f_set1.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 22
        private void button22_Click(object sender, EventArgs e)
        {
            string itemKey22 = this.button22.Text;

            ListViewItem existingItem = FindItemByKey(itemKey22);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.f_set2.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.f_set2.Price * menuInfoInstance.f_set2.Quantity);
                menuInfoInstance.f_set2.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey22, Convert.ToString(menuInfoInstance.f_set2.Quantity), Convert.ToString(menuInfoInstance.f_set2.Price * menuInfoInstance.f_set2.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.f_set2.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 23
        private void button23_Click(object sender, EventArgs e)
        {
            string itemKey23 = this.button23.Text;

            ListViewItem existingItem = FindItemByKey(itemKey23);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.top1.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.top1.Price * menuInfoInstance.top1.Quantity);
                menuInfoInstance.top1.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey23, Convert.ToString(menuInfoInstance.top1.Quantity), Convert.ToString(menuInfoInstance.top1.Price * menuInfoInstance.top1.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.top1.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 24
        private void button24_Click(object sender, EventArgs e)
        {
            string itemKey24 = this.button24.Text;

            ListViewItem existingItem = FindItemByKey(itemKey24);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.top2.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.top2.Price * menuInfoInstance.top2.Quantity);
                menuInfoInstance.top2.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey24, Convert.ToString(menuInfoInstance.top2.Quantity), Convert.ToString(menuInfoInstance.top2.Price * menuInfoInstance.top2.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.top2.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 25
        private void button25_Click(object sender, EventArgs e)
        {
            string itemKey25 = this.button25.Text;

            ListViewItem existingItem = FindItemByKey(itemKey25);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.top3.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.top3.Price * menuInfoInstance.top3.Quantity);
                menuInfoInstance.top3.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey25, Convert.ToString(menuInfoInstance.top3.Quantity), Convert.ToString(menuInfoInstance.top3.Price * menuInfoInstance.top3.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.top3.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 26
        private void button26_Click(object sender, EventArgs e)
        {
            string itemKey26 = this.button26.Text;

            ListViewItem existingItem = FindItemByKey(itemKey26);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.top4.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.top4.Price * menuInfoInstance.top4.Quantity);
                menuInfoInstance.top4.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey26, Convert.ToString(menuInfoInstance.top4.Quantity), Convert.ToString(menuInfoInstance.top4.Price * menuInfoInstance.top4.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.top4.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 27
        private void button27_Click(object sender, EventArgs e)
        {
            string itemKey27 = this.button27.Text;

            ListViewItem existingItem = FindItemByKey(itemKey27);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.drink1.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.drink1.Price * menuInfoInstance.drink1.Quantity);
                menuInfoInstance.drink1.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey27, Convert.ToString(menuInfoInstance.drink1.Quantity), Convert.ToString(menuInfoInstance.drink1.Price * menuInfoInstance.drink1.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.drink1.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 28
        private void button28_Click(object sender, EventArgs e)
        {
            string itemKey28 = this.button28.Text;

            ListViewItem existingItem = FindItemByKey(itemKey28);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.drink2.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.drink2.Price * menuInfoInstance.drink2.Quantity);
                menuInfoInstance.drink2.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey28, Convert.ToString(menuInfoInstance.drink2.Quantity), Convert.ToString(menuInfoInstance.drink2.Price * menuInfoInstance.drink2.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.drink2.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 29
        private void button29_Click(object sender, EventArgs e)
        {
            string itemKey29 = this.button29.Text;

            ListViewItem existingItem = FindItemByKey(itemKey29);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.drink3.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.drink3.Price * menuInfoInstance.drink3.Quantity);
                menuInfoInstance.drink3.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey29, Convert.ToString(menuInfoInstance.drink3.Quantity), Convert.ToString(menuInfoInstance.drink3.Price * menuInfoInstance.drink3.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.drink3.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 30
        private void button30_Click(object sender, EventArgs e)
        {
            string itemKey30 = this.button30.Text;

            ListViewItem existingItem = FindItemByKey(itemKey30);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.drink4.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.drink4.Price * menuInfoInstance.drink4.Quantity);
                menuInfoInstance.drink4.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey30, Convert.ToString(menuInfoInstance.drink4.Quantity), Convert.ToString(menuInfoInstance.drink4.Price * menuInfoInstance.drink4.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.drink4.Quantity++;
                count++;
            }
            UpdatePayval();
        }

        // 버튼 31
        private void button31_Click(object sender, EventArgs e)
        {
            string itemKey31 = this.button31.Text;

            ListViewItem existingItem = FindItemByKey(itemKey31);

            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = Convert.ToString(menuInfoInstance.dan.Quantity);
                existingItem.SubItems[2].Text = Convert.ToString(menuInfoInstance.dan.Price * menuInfoInstance.dan.Quantity);
                menuInfoInstance.dan.Quantity++;
            }
            else
            {
                var con = new string[] { itemKey31, Convert.ToString(menuInfoInstance.dan.Quantity), Convert.ToString(menuInfoInstance.dan.Price * menuInfoInstance.dan.Quantity) };
                var item = new ListViewItem(con);
                this.order_List.Items.Add(item);
                menuInfoInstance.dan.Quantity++;
                count++;
            }
            UpdatePayval();
        }
        //좌석 클릭
        int click1 = 0;
        int click2 = 0;
        int click3 = 0;
        int click4 = 0;
        int click5 = 0;
        int click6 = 0;
        int click7 = 0;
        int click8 = 0;
        int click9 = 0;
        int click10 = 0;
        private void table1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                this.table1.BackColor = Color.Red;
                this.table1.Text = "착석";
                click1 = 1;
            }
            else
            {
                this.table1.BackColor = Color.PaleGreen;
                this.table1.Text = "1번 테이블\r\n(빈자리)";
                click1 = 0;
            }
        }
        private void table2_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                this.table2.BackColor = Color.Red;
                this.table2.Text = "착석";
                click2 = 1;
            }
            else
            {
                this.table2.BackColor = Color.PaleGreen;
                this.table2.Text = "2번 테이블\r\n(빈자리)";
                click2 = 0;
            }
        }

        private void table3_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                this.table3.BackColor = Color.Red;
                this.table3.Text = "착석";
                click3 = 1;
            }
            else
            {
                this.table3.BackColor = Color.PaleGreen;
                this.table3.Text = "3번 테이블\r\n(빈자리)";
                click3= 0;
            }
        }

        private void table4_Click(object sender, EventArgs e)
        {
            if (click4== 0)
            {
                this.table4.BackColor = Color.Red;
                this.table4.Text = "착석";
                click4= 1;
            }
            else
            {
                this.table4.BackColor = Color.PaleGreen;
                this.table4.Text = "4번 테이블\r\n(빈자리)";
                click4 = 0;
            }
        }

        private void table5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                this.table5.BackColor = Color.Red;
                this.table5.Text = "착석";
                click5 = 1;
            }
            else
            {
                this.table5.BackColor = Color.PaleGreen;
                this.table5.Text = "5번 테이블\r\n(빈자리)";
                click5 = 0;
            }
        }

        private void wait1_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                this.wait1.BackColor = Color.Blue;
                this.wait1.Text = "포장(배달)대기1";
                click6 = 1;
            }
            else
            {
                this.wait1.BackColor = Color.Aquamarine;
                this.wait1.Text = "음식 대기1";
                click6 = 0;
            }
        }

        private void wait2_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                this.wait2.BackColor = Color.Blue;
                this.wait2.Text = "포장(배달)대기2";
                click7 = 1;
            }
            else
            {
                this.wait2.BackColor = Color.Aquamarine;
                this.wait2.Text = "음식 대기2";
                click7 = 0;
            }
        }

        private void wait3_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                this.wait3.BackColor = Color.Blue;
                this.wait3.Text = "포장(배달)대기3";
                click8 = 1;
            }
            else
            {
                this.wait3.BackColor = Color.Aquamarine;
                this.wait3.Text = "음식 대기3";
                click8 = 0;
            }
        }

        private void wait4_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                this.wait4.BackColor = Color.Blue;
                this.wait4.Text = "포장(배달)대기4";
                click9 = 1;
            }
            else
            {
                this.wait4.BackColor = Color.Aquamarine;
                this.wait4.Text = "음식 대기4";
                click9 = 0;
            }
        }

        private void wait5_Click(object sender, EventArgs e)
        {
            if (click10 == 0)
            {
                this.wait5.BackColor = Color.Blue;
                this.wait5.Text = "포장(배달)대기5";
                click10 = 1;
            }
            else
            {
                this.wait5.BackColor = Color.Aquamarine;
                this.wait5.Text = "음식 대기5";
                click10 = 0;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            seat_Table.Visible = true;
        }

        private void break_time_Click(object sender, EventArgs e)
        {
            seat_Table.Visible = false;
        }

        private void end_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("영업 종료시 자동으로 포스 프로그램이 종료됩니다", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void hallEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("홀영업 마감합니다\n(영업 재시작시 프로그램을 재실행 해야 합니다)", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.table1.Enabled = false;
                this.table2.Enabled = false;
                this.table3.Enabled = false;
                this.table4.Enabled = false;
                this.table5.Enabled = false;
                this.table1.BackColor = Color.Gray;
                this.table1.Text = "마감";
                this.table2.BackColor = Color.Gray;
                this.table2.Text = "마감";
                this.table3.BackColor = Color.Gray;
                this.table3.Text = "마감";
                this.table4.BackColor = Color.Gray;
                this.table4.Text = "마감";
                this.table5.BackColor = Color.Gray;
                this.table5.Text = "마감";
            }
        }

        private void delEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("포장(배달) 마감합니다\n(영업 재시작시 프로그램을 재실행 해야 합니다)", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.wait1.Enabled = false;
                this.wait2.Enabled = false;
                this.wait3.Enabled = false;
                this.wait4.Enabled = false;
                this.wait5.Enabled = false;
                this.wait1.BackColor = Color.Gray;
                this.wait1.Text = "마감";
                this.wait2.BackColor = Color.Gray;
                this.wait2.Text = "마감";
                this.wait3.BackColor = Color.Gray;
                this.wait3.Text = "마감";
                this.wait4.BackColor = Color.Gray;
                this.wait4.Text = "마감";
                this.wait5.BackColor = Color.Gray;
                this.wait5.Text = "마감";
            }
        }
        //메뉴관리
        private void button32_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Gray;
            this.button1.Text = "매진된 메뉴입니다";
            this.button1.Enabled = false;
            this.button32.Enabled = false;
            this.button32.BackColor = Color.Gray;
            this.button32.Text = "마감처리되었습니다";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Gray;
            this.button2.Text = "매진된 메뉴입니다";
            this.button2.Enabled = false;
            this.button33.Enabled = false;
            this.button33.BackColor = Color.Gray;
            this.button33.Text = "마감처리되었습니다";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Gray;
            this.button3.Text = "매진된 메뉴입니다";
            this.button3.Enabled = false;
            this.button34.Enabled = false;
            this.button34.BackColor = Color.Gray;
            this.button34.Text = "마감처리되었습니다";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.button4.BackColor = Color.Gray;
            this.button4.Text = "매진된 메뉴입니다";
            this.button4.Enabled = false;
            this.button35.Enabled = false;
            this.button35.BackColor = Color.Gray;
            this.button35.Text = "마감처리되었습니다";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.button5.BackColor = Color.Gray;
            this.button5.Text = "매진된 메뉴입니다";
            this.button5.Enabled = false;
            this.button36.Enabled = false;
            this.button36.BackColor = Color.Gray;
            this.button36.Text = "마감처리되었습니다";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.button6.BackColor = Color.Gray;
            this.button6.Text = "매진된 메뉴입니다";
            this.button6.Enabled = false;
            this.button37.Enabled = false;
            this.button37.BackColor = Color.Gray;
            this.button37.Text = "마감처리되었습니다";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.button7.BackColor = Color.Gray;
            this.button7.Text = "매진된 메뉴입니다";
            this.button7.Enabled = false;
            this.button38.Enabled = false;
            this.button38.BackColor = Color.Gray;
            this.button38.Text = "마감처리되었습니다";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.button8.BackColor = Color.Gray;
            this.button8.Text = "매진된 메뉴입니다";
            this.button8.Enabled = false;
            this.button39.Enabled = false;
            this.button39.BackColor = Color.Gray;
            this.button39.Text = "마감처리되었습니다";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.button9.BackColor = Color.Gray;
            this.button9.Text = "매진된 메뉴입니다";
            this.button9.Enabled = false;
            this.button40.Enabled = false;
            this.button40.BackColor = Color.Gray;
            this.button40.Text = "마감처리되었습니다";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.button10.BackColor = Color.Gray;
            this.button10.Text = "매진된 메뉴입니다";
            this.button10.Enabled = false;
            this.button41.Enabled = false;
            this.button41.BackColor = Color.Gray;
            this.button41.Text = "마감처리되었습니다";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.button11.BackColor = Color.Gray;
            this.button11.Text = "매진된 메뉴입니다";
            this.button11.Enabled = false;
            this.button42.Enabled = false;
            this.button42.BackColor = Color.Gray;
            this.button42.Text = "마감처리되었습니다";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.button12.BackColor = Color.Gray;
            this.button12.Text = "매진된 메뉴입니다";
            this.button12.Enabled = false;
            this.button43.Enabled = false;
            this.button43.BackColor = Color.Gray;
            this.button43.Text = "마감처리되었습니다";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            this.button13.BackColor = Color.Gray;
            this.button13.Text = "매진된 메뉴입니다";
            this.button13.Enabled = false;
            this.button44.Enabled = false;
            this.button44.BackColor = Color.Gray;
            this.button44.Text = "마감처리되었습니다";
        }

        private void button45_Click(object sender, EventArgs e)
        {
            this.button14.BackColor = Color.Gray;
            this.button14.Text = "매진된 메뉴입니다";
            this.button14.Enabled = false;
            this.button45.Enabled = false;
            this.button45.BackColor = Color.Gray;
            this.button45.Text = "마감처리되었습니다";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            this.button15.BackColor = Color.Gray;
            this.button15.Text = "매진된 메뉴입니다";
            this.button15.Enabled = false;
            this.button46.Enabled = false;
            this.button46.BackColor = Color.Gray;
            this.button46.Text = "마감처리되었습니다";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            this.button16.BackColor = Color.Gray;
            this.button16.Text = "매진된 메뉴입니다";
            this.button16.Enabled = false;
            this.button47.Enabled = false;
            this.button47.BackColor = Color.Gray;
            this.button47.Text = "마감처리되었습니다";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            this.button17.BackColor = Color.Gray;
            this.button17.Text = "매진된 메뉴입니다";
            this.button17.Enabled = false;
            this.button48.Enabled = false;
            this.button48.BackColor = Color.Gray;
            this.button48.Text = "마감처리되었습니다";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            this.button18.BackColor = Color.Gray;
            this.button18.Text = "매진된 메뉴입니다";
            this.button18.Enabled = false;
            this.button49.Enabled = false;
            this.button49.BackColor = Color.Gray;
            this.button49.Text = "마감처리되었습니다";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            this.button19.BackColor = Color.Gray;
            this.button19.Text = "매진된 메뉴입니다";
            this.button19.Enabled = false;
            this.button50.Enabled = false;
            this.button50.BackColor = Color.Gray;
            this.button50.Text = "마감처리되었습니다";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            this.button20.BackColor = Color.Gray;
            this.button20.Text = "매진된 메뉴입니다";
            this.button20.Enabled = false;
            this.button51.Enabled = false;
            this.button51.BackColor = Color.Gray;
            this.button51.Text = "마감처리되었습니다";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            this.button21.BackColor = Color.Gray;
            this.button21.Text = "매진된 메뉴입니다";
            this.button21.Enabled = false;
            this.button52.Enabled = false;
            this.button52.BackColor = Color.Gray;
            this.button52.Text = "마감처리되었습니다";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            this.button22.BackColor = Color.Gray;
            this.button22.Text = "매진된 메뉴입니다";
            this.button22.Enabled = false;
            this.button53.Enabled = false;
            this.button53.BackColor = Color.Gray;
            this.button53.Text = "마감처리되었습니다";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            this.button23.BackColor = Color.Gray;
            this.button23.Text = "매진된 메뉴입니다";
            this.button23.Enabled = false;
            this.button54.Enabled = false;
            this.button54.BackColor = Color.Gray;
            this.button54.Text = "마감처리되었습니다";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.button24.BackColor = Color.Gray;
            this.button24.Text = "매진된 메뉴입니다";
            this.button24.Enabled = false;
            this.button55.Enabled = false;
            this.button55.BackColor = Color.Gray;
            this.button55.Text = "마감처리되었습니다";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            this.button25.BackColor = Color.Gray;
            this.button25.Text = "매진된 메뉴입니다";
            this.button25.Enabled = false;
            this.button56.Enabled = false;
            this.button56.BackColor = Color.Gray;
            this.button56.Text = "마감처리되었습니다";
        }

        private void button57_Click(object sender, EventArgs e)
        {
            this.button26.BackColor = Color.Gray;
            this.button26.Text = "매진된 메뉴입니다";
            this.button26.Enabled = false;
            this.button57.Enabled = false;
            this.button57.BackColor = Color.Gray;
            this.button57.Text = "마감처리되었습니다";
        }

        private void button58_Click(object sender, EventArgs e)
        {
            this.button27.BackColor = Color.Gray;
            this.button27.Text = "매진된 메뉴입니다";
            this.button27.Enabled = false;
            this.button58.Enabled = false;
            this.button58.BackColor = Color.Gray;
            this.button58.Text = "마감처리되었습니다";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            this.button28.BackColor = Color.Gray;
            this.button28.Text = "매진된 메뉴입니다";
            this.button28.Enabled = false;
            this.button59.Enabled = false;
            this.button59.BackColor = Color.Gray;
            this.button59.Text = "마감처리되었습니다";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            this.button29.BackColor = Color.Gray;
            this.button29.Text = "매진된 메뉴입니다";
            this.button29.Enabled = false;
            this.button60.Enabled = false;
            this.button60.BackColor = Color.Gray;
            this.button60.Text = "마감처리되었습니다";
        }

        private void button61_Click(object sender, EventArgs e)
        {
            this.button30.BackColor = Color.Gray;
            this.button30.Text = "매진된 메뉴입니다";
            this.button30.Enabled = false;
            this.button61.Enabled = false;
            this.button61.BackColor = Color.Gray;
            this.button61.Text = "마감처리되었습니다";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            this.button31.BackColor = Color.Gray;
            this.button31.Text = "매진된 메뉴입니다";
            this.button31.Enabled = false;
            this.button62.Enabled = false;
            this.button62.BackColor = Color.Gray;
            this.button62.Text = "마감처리되었습니다";
        }
    }
}