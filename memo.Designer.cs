namespace winform_Team_Project
{
    partial class memo
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.CausesValidation = false;
            this.textBox2.Location = new System.Drawing.Point(0, 81);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(630, 300);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(259, 423);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 34);
            this.save.TabIndex = 3;
            this.save.Text = "저장";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.MaximumSize = new System.Drawing.Size(630, 21);
            this.textBox1.MinimumSize = new System.Drawing.Size(630, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(630, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "가게 공지사항~~";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // memo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("휴먼모음T", 9F);
            this.MaximumSize = new System.Drawing.Size(650, 593);
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "memo";
            this.Text = "메모장";
            this.Load += new System.EventHandler(this.memo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox1;
    }
}