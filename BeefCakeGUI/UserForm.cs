using BeefCakeData.DAL;
using BeefCakeData.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BeefCakeGUI
{
    public partial class MainForm : Form
    {

        private void LoadUserPanelData()
        {
            radioButtonFemale.Select();
        }

        private void buttonCancelCreatingUser_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            LoadUserPanelData();
            SwitchPanel(loginPanel);
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
                activeUser = userDao.ReadAll().First(x => x.Name == newUser.Name);

                this.SuspendLayout();
                LoadGraphPanelData();
                SwitchPanel(graphPanel);
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
