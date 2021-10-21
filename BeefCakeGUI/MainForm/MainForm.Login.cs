using System;
using System.Windows.Forms;
using BeefCakeData.Model;

namespace BeefCakeGUI
{
    public partial class MainForm : Form
    {
        private void userAddButton_Click(object sender, EventArgs e)
        {
            isUserPanelInEditMode = false;
            this.SuspendLayout();
            LoadUserPanelData();
            SwitchPanel(userPanel);
            this.ResumeLayout();
        }

        private void userConfirmButton_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            activeUser = (User)loginUsersComboBox.SelectedItem;
            LoadGraphPanelData();
            SwitchPanel(graphPanel);
            this.ResumeLayout();
        }

        private void LoadLoginPanelData()
        {
            loginUsersComboBox.DataSource = userDao.ReadAll();
            loginUsersComboBox.DisplayMember = "Name";
            if (activeUser != null)
            {
                loginUsersComboBox.SelectedIndex = loginUsersComboBox.FindString(activeUser.Name);
            }
        }
    }
}
