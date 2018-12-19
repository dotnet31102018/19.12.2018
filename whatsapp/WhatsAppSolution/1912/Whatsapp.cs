using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1912
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void user1TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            headerLbl.Text = $"{user1Lbl.Text} is typing ...";
        }

        private void user2TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            headerLbl.Text = $"{user2Lbl.Text} is typing ...";
        }

        private void user1TxtBx_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void user1TxtBx_Leave(object sender, EventArgs e)
        {
            headerLbl.Text = $"{user1Lbl.Text} last seen at {DateTime.Now}";
        }

        private void user2TxtBx_Leave(object sender, EventArgs e)
        {
            headerLbl.Text = $"{user2Lbl.Text} last seen at {DateTime.Now}";
        }

        private void user1Send_Click(object sender, EventArgs e)
        {
            chatLstBx.Items.Add($"{user1Lbl.Text}: {user1TxtBx.Text}");
            user1TxtBx.Text = "";
        }

        private void user2Send_Click(object sender, EventArgs e)
        {
            chatLstBx.Items.Add($"{user2Lbl.Text}: {user2TxtBx.Text}");
            user2TxtBx.Text = "";
        }
    }
}
