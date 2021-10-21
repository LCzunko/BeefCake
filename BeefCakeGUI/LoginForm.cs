using System;
using System.Windows.Forms;
using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;

namespace BeefCakeGUI
{
    public partial class LoginForm : Form
    {
        private User activeUser;
        private Panel activePanel;
        private IUserDao userDao;

        public LoginForm(IUserDao userDao)
        {
            InitializeComponent();
            this.userDao = userDao;
            LoadLoginPanelData();
        }
        private void userAddButton_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            //TODO LoadUserPanelData();
            //SwitchPanel(userPanel);
            this.ResumeLayout();
        }

        private void userConfirmButton_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            activeUser = (User)loginUsersComboBox.SelectedItem;
            //TODO LoadGraphPanelData();
            //SwitchPanel(graphPanel);
            this.ResumeLayout();
        }

        private void LoadLoginPanelData()
        {
            loginUsersComboBox.DataSource = userDao.ReadAll();
            loginUsersComboBox.DisplayMember = "Name";
            if (activeUser != null)
            {
                loginUsersComboBox.SelectedItem = activeUser;
            }
        }

        private void SwitchPanel(Panel panelToSwitch)
        {
            activePanel.Enabled = false;
            activePanel.Visible = false;
            activePanel = panelToSwitch;
            activePanel.Enabled = true;
            activePanel.Visible = true;
        }

    }
}
