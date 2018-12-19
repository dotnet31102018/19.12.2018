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

        // next modules
        private void user1TxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (user1TxtBx.Text != String.Empty) // same as: if (user1TxtBx.Text != "")
                {
                    chatLstBx.Items.Add($"{user1Lbl.Text}: {user1TxtBx.Text}");
                    user1TxtBx.Text = "";

                    chatLstBx.SelectedIndex = chatLstBx.Items.Count - 1;

                    headerLbl.Text = $"{user1Lbl.Text} last seen at {DateTime.Now}";
                }
            }
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
            if (user1TxtBx.Text != String.Empty) // same as: if (user1TxtBx.Text != "")
            {
                chatLstBx.Items.Add($"{user1Lbl.Text}: {user1TxtBx.Text}");
                user1TxtBx.Text = "";

                chatLstBx.SelectedIndex = chatLstBx.Items.Count - 1;

            }
        }

        private void user2Send_Click(object sender, EventArgs e)
        {
            if (user2TxtBx.Text != "")
            {
                chatLstBx.Items.Add($"{user2Lbl.Text}: {user2TxtBx.Text}");
                user2TxtBx.Text = "";

                chatLstBx.SelectedIndex = chatLstBx.Items.Count - 1;
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            chatLstBx.Items.Clear();
            user1TxtBx.Text = "";
            user2TxtBx.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            headerLbl.Text = $"Starting chat at: {DateTime.Now}";
        }

        // next modules
        private void user2TxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (user2TxtBx.Text != String.Empty) // same as: if (user1TxtBx.Text != "")
                {
                    chatLstBx.Items.Add($"{user2Lbl.Text}: {user2TxtBx.Text}");
                    user2TxtBx.Text = "";

                    chatLstBx.SelectedIndex = chatLstBx.Items.Count - 1;

                    headerLbl.Text = $"{user2Lbl.Text} last seen at {DateTime.Now}";
                }
            }
        }
    }
}
