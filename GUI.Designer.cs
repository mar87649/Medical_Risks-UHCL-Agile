namespace Medical_Risks_UHCL_Agile
{
    partial class login_Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_Button = new System.Windows.Forms.Button();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.password_Label = new System.Windows.Forms.Label();
            this.username_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_Button
            // 
            this.login_Button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_Button.Location = new System.Drawing.Point(506, 127);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(148, 54);
            this.login_Button.TabIndex = 0;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // username_TextBox
            // 
            this.username_TextBox.Location = new System.Drawing.Point(225, 114);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(231, 23);
            this.username_TextBox.TabIndex = 1;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(225, 168);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(231, 23);
            this.password_TextBox.TabIndex = 2;
            this.password_TextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(162, 171);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(57, 15);
            this.password_Label.TabIndex = 3;
            this.password_Label.Text = "Password";
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Location = new System.Drawing.Point(162, 122);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(60, 15);
            this.username_Label.TabIndex = 4;
            this.username_Label.Text = "Username";
            // 
            // login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username_Label);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.username_TextBox);
            this.Controls.Add(this.login_Button);
            this.Name = "login_Screen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login_Button;
        private TextBox username_TextBox;
        private TextBox password_TextBox;
        private Label password_Label;
        private Label username_Label;
    }
}