namespace _1912
{
    partial class Form1
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
            this.user1Lbl = new System.Windows.Forms.Label();
            this.user2Lbl = new System.Windows.Forms.Label();
            this.user1TxtBx = new System.Windows.Forms.TextBox();
            this.user2TxtBx = new System.Windows.Forms.TextBox();
            this.headerLbl = new System.Windows.Forms.Label();
            this.user1Send = new System.Windows.Forms.Button();
            this.user2Send = new System.Windows.Forms.Button();
            this.chatLstBx = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user1Lbl
            // 
            this.user1Lbl.AutoSize = true;
            this.user1Lbl.Location = new System.Drawing.Point(86, 127);
            this.user1Lbl.Name = "user1Lbl";
            this.user1Lbl.Size = new System.Drawing.Size(25, 13);
            this.user1Lbl.TabIndex = 0;
            this.user1Lbl.Text = "Yair";
            // 
            // user2Lbl
            // 
            this.user2Lbl.AutoSize = true;
            this.user2Lbl.Location = new System.Drawing.Point(86, 178);
            this.user2Lbl.Name = "user2Lbl";
            this.user2Lbl.Size = new System.Drawing.Size(29, 13);
            this.user2Lbl.TabIndex = 1;
            this.user2Lbl.Text = "Enat";
            // 
            // user1TxtBx
            // 
            this.user1TxtBx.Location = new System.Drawing.Point(153, 124);
            this.user1TxtBx.Name = "user1TxtBx";
            this.user1TxtBx.Size = new System.Drawing.Size(246, 20);
            this.user1TxtBx.TabIndex = 2;
            this.user1TxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user1TxtBx_KeyDown);
            this.user1TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user1TxtBx_KeyPress);
            this.user1TxtBx.Leave += new System.EventHandler(this.user1TxtBx_Leave);
            // 
            // user2TxtBx
            // 
            this.user2TxtBx.Location = new System.Drawing.Point(153, 178);
            this.user2TxtBx.Name = "user2TxtBx";
            this.user2TxtBx.Size = new System.Drawing.Size(246, 20);
            this.user2TxtBx.TabIndex = 3;
            this.user2TxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user2TxtBx_KeyDown);
            this.user2TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user2TxtBx_KeyPress);
            this.user2TxtBx.Leave += new System.EventHandler(this.user2TxtBx_Leave);
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.Green;
            this.headerLbl.Location = new System.Drawing.Point(86, 75);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(59, 13);
            this.headerLbl.TabIndex = 4;
            this.headerLbl.Text = "Welcome";
            // 
            // user1Send
            // 
            this.user1Send.Location = new System.Drawing.Point(421, 121);
            this.user1Send.Name = "user1Send";
            this.user1Send.Size = new System.Drawing.Size(75, 23);
            this.user1Send.TabIndex = 5;
            this.user1Send.Text = "&Send";
            this.user1Send.UseVisualStyleBackColor = true;
            this.user1Send.Click += new System.EventHandler(this.user1Send_Click);
            // 
            // user2Send
            // 
            this.user2Send.Location = new System.Drawing.Point(421, 178);
            this.user2Send.Name = "user2Send";
            this.user2Send.Size = new System.Drawing.Size(75, 23);
            this.user2Send.TabIndex = 6;
            this.user2Send.Text = "S&end";
            this.user2Send.UseVisualStyleBackColor = true;
            this.user2Send.Click += new System.EventHandler(this.user2Send_Click);
            // 
            // chatLstBx
            // 
            this.chatLstBx.FormattingEnabled = true;
            this.chatLstBx.Location = new System.Drawing.Point(89, 241);
            this.chatLstBx.Name = "chatLstBx";
            this.chatLstBx.Size = new System.Drawing.Size(407, 186);
            this.chatLstBx.TabIndex = 7;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(514, 404);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 466);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.chatLstBx);
            this.Controls.Add(this.user2Send);
            this.Controls.Add(this.user1Send);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.user2TxtBx);
            this.Controls.Add(this.user1TxtBx);
            this.Controls.Add(this.user2Lbl);
            this.Controls.Add(this.user1Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user1Lbl;
        private System.Windows.Forms.Label user2Lbl;
        private System.Windows.Forms.TextBox user1TxtBx;
        private System.Windows.Forms.TextBox user2TxtBx;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Button user1Send;
        private System.Windows.Forms.Button user2Send;
        private System.Windows.Forms.ListBox chatLstBx;
        private System.Windows.Forms.Button clearBtn;
    }
}

