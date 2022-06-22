using StudentHousingManagement;
namespace StudentHousingManagementForms
{
    public partial class LogIn : Form
    {
        UserController userController;

        public LogIn()
        {
            InitializeComponent();
            tbEmail.Focus();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            userController = new UserController();
            LogInHandler();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LogInHandler();
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LogInHandler();
            }
        }

        public void LogInHandler() 
        {
            if (rbUser.Checked)
            {
                User? user = userController.LogInUser(tbEmail.Text, tbPassword.Text);
                if (user != null)
                {
                    UserPanel userPanel = new UserPanel(this, user);
                    userPanel.Show();
                    this.Hide();
                }
                else MessageBox.Show("Invalid username or password");
            }

            else if (rbAdmin.Checked)
            {
                Admin? admin = userController.LogInAdmin(tbEmail.Text, tbPassword.Text);
                if (admin != null)
                {
                    AdminPanel adminPanel = new AdminPanel(this, admin);
                    adminPanel.Show();
                    this.Hide();
                }
                else MessageBox.Show("Invalid username or password");
            }
        }
    }
}