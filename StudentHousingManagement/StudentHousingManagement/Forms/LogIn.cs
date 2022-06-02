using StudentHousingManagement;
namespace StudentHousingManagementForms
{
    public partial class LogIn : Form
    {
        private UserPanel? userPanel;
        private AdminPanel? adminPanel;
        public UserController userController;

        public LogIn()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (userController.LogIn(tbUserName.Text, tbPassword.Text))
            {
                if (userController.CurrentUser.Admin)
                {
                    adminPanel = new AdminPanel(this);
                    adminPanel.Show();
                    this.Hide();
                }
                else
                {
                    userPanel = new UserPanel(this);
                    userPanel.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Invalid username or password");
        }
    }
}