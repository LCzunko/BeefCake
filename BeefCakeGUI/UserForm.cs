using BeefCakeData.DAL;
using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;
using BeefCakeLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeefCakeGUI
{
    public partial class UserForm : Form
    {
        private InputValidator inputValidator;
        private User activeUser;
        private Panel activePanel;
        private IUserDao userDao;
        public UserForm(IUserDao userDao, InputValidator givenInputValidator)
        {
            InitializeComponent();
            this.userDao = userDao;
            inputValidator = givenInputValidator;
            LoadLoginPanelData();
        }

        private void LoadLoginPanelData()
        {
            radioButtonFemale.Select();
        }

        private void SwitchPanel(Panel panelToSwitch)
        {
            activePanel.Enabled = false;
            activePanel.Visible = false;
            activePanel = panelToSwitch;
            activePanel.Enabled = true;
            activePanel.Visible = true;
        }

        private void buttonCancelCreatingUser_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            //TODO LoadUserPanelData();
            //SwitchPanel(loginPanel);
            this.ResumeLayout();
        }

        private void buttonApplyCreatingUser_Click(object sender, EventArgs e)
        {
            string errorMessage;
            if (inputValidator.IsUserNameAvailable(textBoxName.Text, out errorMessage)
                && inputValidator.IsDateOfBirthInThePast(dateTimePickerDateOfBirth.Value, out errorMessage)
                && inputValidator.IsHeightValid(textBoxHeight.Text, out errorMessage))
            {
                User newUser = UserBuilder.BuildUser(
                    textBoxName.Text,
                    dateTimePickerDateOfBirth.Value,
                    radioButtonFemale.Checked ? BeefCakeData.Utilities.Gender.F : BeefCakeData.Utilities.Gender.M,
                    textBoxHeight.Text
                    );

                userDao.Add(newUser);
                activeUser = newUser;

                this.SuspendLayout();
                //TODO LoadUserPanelData();
                //SwitchPanel(graphPanel);
                this.ResumeLayout();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            string errorMessage;
            inputValidator.IsUserNameAvailable(textBoxName.Text, out errorMessage);
            labelWrongName.Text = errorMessage;
        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            string errorMessage;
            inputValidator.IsDateOfBirthInThePast(dateTimePickerDateOfBirth.Value, out errorMessage);
            labelWrongDate.Text = errorMessage;
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            string errorMessage;
            inputValidator.IsHeightValid(textBoxHeight.Text, out errorMessage);
            labelWrongHeight.Text = errorMessage;
        }
    }
}
