using StudentHousingManagement;
namespace StudentHousingManagementForms
{
    public partial class LogIn : Form
    {
        UserController userController;
        BuildingController buildingController;

        public LogIn()
        {
            InitializeComponent();
            buildingController = new BuildingController();
            userController = new UserController(buildingController);
            tbEmail.Focus();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (userController.LogIn(tbEmail.Text, tbPassword.Text))
            {
                if (userController.CurrentUser.Admin)
                {
                    AdminPanel adminPanel = new AdminPanel(this, userController, buildingController);
                    adminPanel.Show();
                    this.Hide();
                }
                else
                {
                    UserPanel userPanel = new UserPanel(this, userController);
                    userPanel.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Invalid username or password");
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (userController.LogIn(tbEmail.Text, tbPassword.Text))
                {
                    if (userController.CurrentUser.Admin)
                    {
                        AdminPanel adminPanel = new AdminPanel(this, userController, buildingController);
                        adminPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserPanel userPanel = new UserPanel(this, userController);
                        userPanel.Show();
                        this.Hide();
                    }
                }
                else MessageBox.Show("Invalid username or password");
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (userController.LogIn(tbEmail.Text, tbPassword.Text))
                {
                    if (userController.CurrentUser.Admin)
                    {
                        AdminPanel adminPanel = new AdminPanel(this, userController, buildingController);
                        adminPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserPanel userPanel = new UserPanel(this, userController);
                        userPanel.Show();
                        this.Hide();
                    }
                }
                else MessageBox.Show("Invalid username or password");
            }
        }
    }
}