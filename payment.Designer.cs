namespace winform_Team_Project
{
    partial class payment
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pay_option = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.notbut2 = new System.Windows.Forms.Button();
            this.notbut1 = new System.Windows.Forms.Button();
            this.pay_option.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 62);
            this.button1.TabIndex = 13;
            this.button1.Text = "결제";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(255, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 62);
            this.button2.TabIndex = 14;
            this.button2.Text = "결제취소";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pay_option
            // 
            this.pay_option.BackColor = System.Drawing.Color.White;
            this.pay_option.Controls.Add(this.button6);
            this.pay_option.Controls.Add(this.button5);
            this.pay_option.Controls.Add(this.button4);
            this.pay_option.Controls.Add(this.button3);
            this.pay_option.Controls.Add(this.notbut2);
            this.pay_option.Controls.Add(this.notbut1);
            this.pay_option.Location = new System.Drawing.Point(12, 12);
            this.pay_option.Name = "pay_option";
            this.pay_option.Size = new System.Drawing.Size(421, 484);
            this.pay_option.TabIndex = 15;
            this.pay_option.TabStop = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(216, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 104);
            this.button6.TabIndex = 5;
            this.button6.Text = "현금";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(22, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 104);
            this.button5.TabIndex = 4;
            this.button5.Text = "카드";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(216, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 104);
            this.button4.TabIndex = 3;
            this.button4.Text = "포장";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(22, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 104);
            this.button3.TabIndex = 2;
            this.button3.Text = "매장";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // notbut2
            // 
            this.notbut2.BackColor = System.Drawing.Color.Red;
            this.notbut2.Enabled = false;
            this.notbut2.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.notbut2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notbut2.Location = new System.Drawing.Point(22, 225);
            this.notbut2.Name = "notbut2";
            this.notbut2.Size = new System.Drawing.Size(376, 60);
            this.notbut2.TabIndex = 1;
            this.notbut2.Text = "STEP 2";
            this.notbut2.UseVisualStyleBackColor = false;
            // 
            // notbut1
            // 
            this.notbut1.BackColor = System.Drawing.Color.Red;
            this.notbut1.Enabled = false;
            this.notbut1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.notbut1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notbut1.Location = new System.Drawing.Point(18, 17);
            this.notbut1.Name = "notbut1";
            this.notbut1.Size = new System.Drawing.Size(376, 60);
            this.notbut1.TabIndex = 0;
            this.notbut1.Text = "STEP 1";
            this.notbut1.UseVisualStyleBackColor = false;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(454, 611);
            this.Controls.Add(this.pay_option);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(470, 650);
            this.MinimumSize = new System.Drawing.Size(470, 650);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            this.pay_option.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox pay_option;
        private System.Windows.Forms.Button notbut1;
        private System.Windows.Forms.Button notbut2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}