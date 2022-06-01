namespace StudentHousingManagementForms
{
    public partial class LogIn : Form
    {
        private UserPanel userPanel;
        private AdminPanel adminPanel;

        public LogIn()
        {
            InitializeComponent();
            userPanel = new UserPanel();
            adminPanel = new AdminPanel();        
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            int password = Convert.ToInt32(tbPassword.Text);

            if (userName == "admin" && password == 1122)
            {
                adminPanel.Show();
                this.Hide();
            }
            else 
            {
                userPanel.Show();
                this.Hide();
            }
        }
    }
}