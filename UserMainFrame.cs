using System;
using System.Drawing;
using System.Windows.Forms;

namespace _12306
{
    public partial class UserMainFrame : Form
    {
        internal int BTN = 0;
        public UserMainFrame()
        {
            InitializeComponent();
        }
        public void ButtonCtrol(int BTN1)
        {//每次按钮按下时，将对应按钮亮起，并调用此函数将另外亮起来的按钮熄灭
            switch (BTN)
            {
                case 0:
                    break;
                case 1:
                    button1.ForeColor = Color.FromArgb(153, 180, 209);
                    button1.Image = Properties.Resources.查询购票0;
                    break;
                case 2:
                    button2.ForeColor = Color.FromArgb(153, 180, 209);
                    button2.Image = Properties.Resources.订单查询0;
                    break;
                case 3:
                    button3.ForeColor = Color.FromArgb(153, 180, 209);
                    button3.Image = Properties.Resources.改票退票0;
                    break;
                case 4:
                    button4.ForeColor = Color.FromArgb(153, 180, 209);
                    button4.Image = Properties.Resources.个人中心0;
                    break;
            }
        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(0, 102, 204);
            button1.Image = Properties.Resources.查询购票1;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (BTN == 1) { }//防止当选中按钮1时鼠标离开熄灭按钮1
            else
            {
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                button1.Image = Properties.Resources.查询购票0;
            }
        }
        private void button1_click(object sender, EventArgs e)
        {
            OrderTicets orderTicets = new OrderTicets
            {
                WindowState = FormWindowState.Maximized,

                //去掉边框
                FormBorderStyle = FormBorderStyle.None,

                MdiParent = this,

                //设置新窗体的Parent
                Parent = panel1
            };
            orderTicets.Show();
            BTN = 1;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonCtrol(BTN);//熄灭对应按钮
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.FromArgb(0, 102, 204);
            button1.Image = Properties.Resources.查询购票1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckOrders checkOrders = new CheckOrders
            {
                WindowState = FormWindowState.Maximized,

                //去掉边框
                FormBorderStyle = FormBorderStyle.None,

                MdiParent = this,

                //设置新窗体的Parent
                Parent = panel1
            };
            checkOrders.Show();
            BTN = 2;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(0, 102, 204);
            button2.Image = Properties.Resources.订单查询1;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (BTN == 2)
            {

            }
            else
            {
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                button2.Image = Properties.Resources.订单查询0;
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonCtrol(BTN);//熄灭对应按钮
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.FromArgb(0, 102, 204);
            button2.Image = Properties.Resources.订单查询1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeOrders changeOrders = new ChangeOrders
            {
                WindowState = FormWindowState.Maximized,

                //去掉边框
                FormBorderStyle = FormBorderStyle.None,

                MdiParent = this,

                //设置新窗体的Parent
                Parent = panel1
            };
            changeOrders.Show();
            BTN = 3;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(0, 102, 204);
            button3.Image = Properties.Resources.改票退票1;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (BTN == 3)
            {

            }
            else
            {
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                button3.Image = Properties.Resources.改票退票0;
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonCtrol(BTN);//熄灭对应按钮
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.FromArgb(0, 102, 204);
            button3.Image = Properties.Resources.改票退票1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonalPage personalPage = new PersonalPage
            {
                WindowState = FormWindowState.Maximized,

                //去掉边框
                FormBorderStyle = FormBorderStyle.None,

                MdiParent = this,

                //设置新窗体的Parent
                Parent = panel1
            };
            personalPage.Show();
            BTN = 4;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(0, 102, 204);
            button4.Image = Properties.Resources.个人中心1;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if (BTN == 4)
            {

            }
            else
            {
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                button4.Image = Properties.Resources.个人中心0;
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonCtrol(BTN);//熄灭之前亮起来的按钮
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.ForeColor = Color.FromArgb(0, 102, 204);
            button4.Image = Properties.Resources.个人中心1;
        }
    }
}
