namespace LiniaProdukcyjna
{
    partial class LoginMenu
    {
        /// <summary>
        ///  Required designer variable.\
        private static List<User> Users = new List<User>();
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
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginLabel = new Label();
            passwordLabel = new Label();
            zalogujLabel = new Label();
            loginButton = new Button();
            wrongDataLabel = new Label();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.None;
            loginTextBox.Location = new Point(166, 168);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(496, 23);
            loginTextBox.TabIndex = 0;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(166, 277);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(496, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(166, 140);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(43, 15);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Login: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(166, 249);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(43, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Hasło: ";
            // 
            // zalogujLabel
            // 
            zalogujLabel.AutoSize = true;
            zalogujLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            zalogujLabel.Location = new Point(166, 56);
            zalogujLabel.Name = "zalogujLabel";
            zalogujLabel.Size = new Size(458, 37);
            zalogujLabel.TabIndex = 4;
            zalogujLabel.Text = "Zaloguj się do panelu produkcyjnego";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(255, 192, 255);
            loginButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(335, 321);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(160, 71);
            loginButton.TabIndex = 5;
            loginButton.Text = "Zaloguj się";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // wrongDataLabel
            // 
            wrongDataLabel.AutoSize = true;
            wrongDataLabel.Location = new Point(173, 364);
            wrongDataLabel.Name = "wrongDataLabel";
            wrongDataLabel.Size = new Size(76, 15);
            wrongDataLabel.TabIndex = 6;
            wrongDataLabel.Text = "Błędne Hasło";
            wrongDataLabel.Visible = false;
            // 
            // LoginMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(wrongDataLabel);
            Controls.Add(loginButton);
            Controls.Add(zalogujLabel);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Name = "LoginMenu";
            Text = "Panel produkcyjny-logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Label loginLabel;
        private Label passwordLabel;
        private Label zalogujLabel;
        private Button loginButton;
        private Label wrongDataLabel;
    }
}