using Microsoft.VisualBasic.ApplicationServices;

namespace LiniaProdukcyjna
{
    public partial class LoginMenu : Form
    {
        
        public LoginMenu()

        {
            users.Add( new User("Kate", "sharp"));
            users.Add(new User("Alex", "c"));
            InitializeComponent();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

            //przycisk logowania dostêpny tylko gdy coœ jest wpisane w polu "login"
            if (loginTextBox.Text.Equals("")) loginButton.Enabled = false;
            else loginButton.Enabled = true;


        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            foreach (User u in User.Users)
            {
                if (u.login.Equals(loginTextBox.Text))
                {
                    if (u.password.Equals(passwordTextBox.Text)) 
                    {
                        wrongDataLabel.Visible = false;
                        new ProductionControlPanel().Show();
                        this.Dispose(false); 
                    }
                    else
                    {
                        wrongDataLabel.Text = "B³êdne has³o";
                        wrongDataLabel.Visible = true;
                    }

                }
                else 
                {
                    wrongDataLabel.Text = "Brak u¿ytkownika w bazie";
                    wrongDataLabel.Visible = true;
                    
                }

            }
        }

   
    }
}