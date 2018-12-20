using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1912Summary
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void user1Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            statusLbl.Text = $"{user1NameLbl.Text} is typing...";
        }

        private void user2Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            statusLbl.Text = $"{user2NameLbl.Text} is typing...";
        }

        private void user1SendBtn_Click(object sender, EventArgs e)
        {
            chatLstBx.Items.Add($"{user1NameLbl.Text}: {user1Txt.Text} [{DateTime.Now}]");
        }

        private void user2SendBtn_Click(object sender, EventArgs e)
        {
            chatLstBx.Items.Add($"{user2NameLbl.Text}: {user2txt.Text} [{DateTime.Now}]");
        }

        private void user1Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                chatLstBx.Items.Add($"{user1NameLbl.Text}: {user1Txt.Text} [{DateTime.Now}]");
                user1Txt.Text = "";
            }
        }

        private void user2txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                chatLstBx.Items.Add($"{user2NameLbl.Text}: {user2txt.Text} [{DateTime.Now}]");
                user2txt.Text = "";
            }
        }

        private void myForm_Load(object sender, EventArgs e)
        {
            statusLbl.Text = $"Welcome to my Whatsapp!! {DateTime.Now}";
        }
    }
}
