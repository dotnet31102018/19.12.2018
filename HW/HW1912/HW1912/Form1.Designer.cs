namespace HW1912
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lowerLimitTxtBx = new System.Windows.Forms.TextBox();
            this.upperLimitTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zerofyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ranodm Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.my_click);
            // 
            // lowerLimitTxtBx
            // 
            this.lowerLimitTxtBx.Location = new System.Drawing.Point(132, 205);
            this.lowerLimitTxtBx.Name = "lowerLimitTxtBx";
            this.lowerLimitTxtBx.Size = new System.Drawing.Size(100, 20);
            this.lowerLimitTxtBx.TabIndex = 2;
            this.lowerLimitTxtBx.Text = "0";
            this.lowerLimitTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // upperLimitTxtBx
            // 
            this.upperLimitTxtBx.Location = new System.Drawing.Point(132, 255);
            this.upperLimitTxtBx.Name = "upperLimitTxtBx";
            this.upperLimitTxtBx.Size = new System.Drawing.Size(100, 20);
            this.upperLimitTxtBx.TabIndex = 3;
            this.upperLimitTxtBx.Text = "0";
            this.upperLimitTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lower limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Upper limit";
            // 
            // zerofyBtn
            // 
            this.zerofyBtn.Location = new System.Drawing.Point(240, 149);
            this.zerofyBtn.Name = "zerofyBtn";
            this.zerofyBtn.Size = new System.Drawing.Size(75, 23);
            this.zerofyBtn.TabIndex = 6;
            this.zerofyBtn.Text = "Zerofy";
            this.zerofyBtn.UseVisualStyleBackColor = true;
            this.zerofyBtn.Click += new System.EventHandler(this.zerofyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 334);
            this.Controls.Add(this.zerofyBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upperLimitTxtBx);
            this.Controls.Add(this.lowerLimitTxtBx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lowerLimitTxtBx;
        private System.Windows.Forms.TextBox upperLimitTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button zerofyBtn;
    }
}

