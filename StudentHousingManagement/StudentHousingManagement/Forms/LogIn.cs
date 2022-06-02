using StudentHousingManagement;
namespace StudentHousingManagementForms
{
    public partial class LogIn : Form
    {
        UserPanel? userPanel;
        AdminPanel? adminPanel;
        UserController userController;
        BuildingController buildingController;

        public LogIn()
        {
            InitializeComponent();
            buildingController = new BuildingController();
            userController = new UserController(buildingController);
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (userController.LogIn(tbEmail.Text, tbPassword.Text))
            {
                if (userController.CurrentUser.Admin)
                {
                    adminPanel = new AdminPanel(this, userController, buildingController);
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