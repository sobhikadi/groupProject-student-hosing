using StudentHousingManagement;
namespace StudentHousingManagementForms
{
    public partial class LogIn : Form
    {
        UserController userController;
        UserManager userManager;

        public LogIn()
        {
            InitializeComponent();
            userManager = new UserManager();
            userController = new UserController();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
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
            else MessageBox.Show("Please select if you are a user or admin.");        
        }
    }
}