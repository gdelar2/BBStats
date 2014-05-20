namespace BBStats
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
            this.Games_Screen_Button = new System.Windows.Forms.Button();
            this.password_Box = new System.Windows.Forms.TextBox();
            this.Go_Button = new System.Windows.Forms.Button();
            this.userName_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Games_Screen_Button
            // 
            this.Games_Screen_Button.Location = new System.Drawing.Point(3, 435);
            this.Games_Screen_Button.Name = "Games_Screen_Button";
            this.Games_Screen_Button.Size = new System.Drawing.Size(75, 23);
            this.Games_Screen_Button.TabIndex = 0;
            this.Games_Screen_Button.Text = "Games";
            this.Games_Screen_Button.UseVisualStyleBackColor = true;
            this.Games_Screen_Button.Click += new System.EventHandler(this.Games_Screen_Button_Click);
            // 
            // password_Box
            // 
            this.password_Box.Location = new System.Drawing.Point(3, 51);
            this.password_Box.Name = "password_Box";
            this.password_Box.PasswordChar = '*';
            this.password_Box.Size = new System.Drawing.Size(100, 20);
            this.password_Box.TabIndex = 1;
            // 
            // Go_Button
            // 
            this.Go_Button.Location = new System.Drawing.Point(283, 51);
            this.Go_Button.Name = "Go_Button";
            this.Go_Button.Size = new System.Drawing.Size(75, 23);
            this.Go_Button.TabIndex = 2;
            this.Go_Button.Text = "Go";
            this.Go_Button.UseVisualStyleBackColor = true;
            this.Go_Button.Click += new System.EventHandler(this.Go_Button_Click);
            // 
            // userName_box
            // 
            this.userName_box.Location = new System.Drawing.Point(3, 12);
            this.userName_box.Name = "userName_box";
            this.userName_box.Size = new System.Drawing.Size(100, 20);
            this.userName_box.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 470);
            this.Controls.Add(this.userName_box);
            this.Controls.Add(this.Go_Button);
            this.Controls.Add(this.password_Box);
            this.Controls.Add(this.Games_Screen_Button);
            this.Name = "Form1";
            this.Text = "BBStats";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Games_Screen_Button;
        private System.Windows.Forms.TextBox password_Box;
        private System.Windows.Forms.Button Go_Button;
        private System.Windows.Forms.TextBox userName_box;
    }
}

