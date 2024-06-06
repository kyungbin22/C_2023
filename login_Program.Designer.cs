namespace winform_Team_Project
{
    partial class login_Program
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
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_PW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("휴먼모음T", 12F);
            this.button1.Location = new System.Drawing.Point(418, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_ID
            // 
            this.text_ID.Font = new System.Drawing.Font("휴먼모음T", 12F);
            this.text_ID.Location = new System.Drawing.Point(166, 268);
            this.text_ID.Multiline = true;
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(187, 33);
            this.text_ID.TabIndex = 1;
            // 
            // text_PW
            // 
            this.text_PW.Font = new System.Drawing.Font("휴먼모음T", 12F);
            this.text_PW.Location = new System.Drawing.Point(166, 329);
            this.text_PW.Multiline = true;
            this.text_PW.Name = "text_PW";
            this.text_PW.Size = new System.Drawing.Size(187, 33);
            this.text_PW.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F);
            this.label1.Location = new System.Drawing.Point(163, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 129);
            this.label1.TabIndex = 3;
            this.label1.Text = "삼육 떡볶이 로그인 시스템 입니다\r\n현재 개발 버전이므로 아이디와 패스워드를 제공합니다\r\n<ID: syucom>\r\n<PW: 3636>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_PW);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("휴먼모음T", 9F);
            this.MaximumSize = new System.Drawing.Size(650, 550);
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "login_Program";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.login_Program_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_PW;
        private System.Windows.Forms.Label label1;
    }
}