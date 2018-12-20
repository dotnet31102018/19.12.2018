namespace _1912Summary
{
    partial class myForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.user1NameLbl = new System.Windows.Forms.Label();
            this.user2NameLbl = new System.Windows.Forms.Label();
            this.user1Txt = new System.Windows.Forms.TextBox();
            this.user2txt = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.chatLstBx = new System.Windows.Forms.ListBox();
            this.user1SendBtn = new System.Windows.Forms.Button();
            this.user2SendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user1NameLbl
            // 
            this.user1NameLbl.AutoSize = true;
            this.user1NameLbl.Location = new System.Drawing.Point(53, 115);
            this.user1NameLbl.Name = "user1NameLbl";
            this.user1NameLbl.Size = new System.Drawing.Size(26, 17);
            this.user1NameLbl.TabIndex = 0;
            this.user1NameLbl.Text = "Bill";
            // 
            // user2NameLbl
            // 
            this.user2NameLbl.AutoSize = true;
            this.user2NameLbl.Location = new System.Drawing.Point(53, 175);
            this.user2NameLbl.Name = "user2NameLbl";
            this.user2NameLbl.Size = new System.Drawing.Size(72, 17);
            this.user2NameLbl.TabIndex = 1;
            this.user2NameLbl.Text = "Samantha";
            // 
            // user1Txt
            // 
            this.user1Txt.Location = new System.Drawing.Point(157, 112);
            this.user1Txt.Name = "user1Txt";
            this.user1Txt.Size = new System.Drawing.Size(349, 22);
            this.user1Txt.TabIndex = 2;
            this.user1Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user1Txt_KeyDown);
            this.user1Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user1Txt_KeyPress);
            // 
            // user2txt
            // 
            this.user2txt.Location = new System.Drawing.Point(157, 172);
            this.user2txt.Name = "user2txt";
            this.user2txt.Size = new System.Drawing.Size(349, 22);
            this.user2txt.TabIndex = 3;
            this.user2txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user2txt_KeyDown);
            this.user2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user2Txt_KeyPress);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statusLbl.Location = new System.Drawing.Point(56, 56);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(150, 17);
            this.statusLbl.TabIndex = 4;
            this.statusLbl.Text = "Welcome to Whatsapp";
            // 
            // chatLstBx
            // 
            this.chatLstBx.FormattingEnabled = true;
            this.chatLstBx.ItemHeight = 16;
            this.chatLstBx.Location = new System.Drawing.Point(59, 242);
            this.chatLstBx.Name = "chatLstBx";
            this.chatLstBx.Size = new System.Drawing.Size(447, 132);
            this.chatLstBx.TabIndex = 5;
            // 
            // user1SendBtn
            // 
            this.user1SendBtn.Location = new System.Drawing.Point(534, 111);
            this.user1SendBtn.Name = "user1SendBtn";
            this.user1SendBtn.Size = new System.Drawing.Size(75, 23);
            this.user1SendBtn.TabIndex = 6;
            this.user1SendBtn.Text = "&Send";
            this.user1SendBtn.UseVisualStyleBackColor = true;
            this.user1SendBtn.Click += new System.EventHandler(this.user1SendBtn_Click);
            // 
            // user2SendBtn
            // 
            this.user2SendBtn.Location = new System.Drawing.Point(534, 169);
            this.user2SendBtn.Name = "user2SendBtn";
            this.user2SendBtn.Size = new System.Drawing.Size(75, 23);
            this.user2SendBtn.TabIndex = 7;
            this.user2SendBtn.Text = "S&end";
            this.user2SendBtn.UseVisualStyleBackColor = true;
            this.user2SendBtn.Click += new System.EventHandler(this.user2SendBtn_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 433);
            this.Controls.Add(this.user2SendBtn);
            this.Controls.Add(this.user1SendBtn);
            this.Controls.Add(this.chatLstBx);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.user2txt);
            this.Controls.Add(this.user1Txt);
            this.Controls.Add(this.user2NameLbl);
            this.Controls.Add(this.user1NameLbl);
            this.Name = "myForm";
            this.Text = "Whatsapp Application";
            this.Load += new System.EventHandler(this.myForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user1NameLbl;
        private System.Windows.Forms.Label user2NameLbl;
        private System.Windows.Forms.TextBox user1Txt;
        private System.Windows.Forms.TextBox user2txt;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ListBox chatLstBx;
        private System.Windows.Forms.Button user1SendBtn;
        private System.Windows.Forms.Button user2SendBtn;
    }
}

