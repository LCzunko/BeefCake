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
            LoadLoginPanelData();
            SwitchPanel(loginPanel);
            this.ResumeLayout();
        }

        private void buttonApplyCreatingUser_Click(object sender, EventArgs e)
        {
            string errorMessage;
            
            if (CheckNameValidity() && CheckDateOfBirthValidity() && CheckHeightValidity())
            {
                if (isUserPanelInEditMode)
                {
                    activeUser.Name = textBoxName.Text;
                    activeUser.DateOfBirth = dateTimePickerDateOfBirth.Value;
                    activeUser.Gender = radioButtonFemale.Checked ? BeefCakeData.Utilities.Gender.F : BeefCakeData.Utilities.Gender.M;
                    activeUser.Height = Decimal.Parse(textBoxHeight.Text);

                    userDao.Update(activeUser);

                    this.SuspendLayout();
                    LoadGraphPanelData();
                    SwitchPanel(graphPanel);
                    this.ResumeLayout();
                }
                else
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
                    LoadLoginPanelData();
                    SwitchPanel(loginPanel);
                    this.ResumeLayout();
                }
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            CheckNameValidity();
        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            CheckDateOfBirthValidity();
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            CheckHeightValidity();
        }

        private bool CheckNameValidity()
        {
            string errorMessage;
            bool result = inputValidator.IsUserNameNotEmpty(textBoxName.Text, out errorMessage);
            labelWrongName.Text = errorMessage;
            if (result == false)
            {
                return result;
            }

            if (!isUserPanelInEditMode)
            {
                result &= inputValidator.IsUserNameAvailable(textBoxName.Text, out errorMessage);
                labelWrongName.Text = errorMessage;
            }
            return result;
        }

        private bool CheckDateOfBirthValidity()
        {
            string errorMessage;
            bool result = inputValidator.IsDateOfBirthInThePast(dateTimePickerDateOfBirth.Value, out errorMessage);
            labelWrongDate.Text = errorMessage;
            return result;
        }

        private bool CheckHeightValidity()
        {
            string errorMessage;
            bool result = inputValidator.IsHeightValid(textBoxHeight.Text, out errorMessage);
            labelWrongHeight.Text = errorMessage;
            return result;
        }
    }
}
