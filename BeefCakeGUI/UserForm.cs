using BeefCakeData.DAL;
using BeefCakeData.Model;
using BeefCakeData.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BeefCakeGUI
{
    public partial class MainForm : Form
    {

        private void LoadUserPanelData()
        {
            if (isUserPanelInEditMode)
            {
                textBoxName.Text = activeUser.Name;
                switch (activeUser.Gender)
                {
                    case Gender.F:
                        radioButtonFemale.Select();
                        break;
                    case Gender.M:
                        radioButtonMale.Select();
                        break;
                    default:
                        radioButtonFemale.Select();
                        break;
                }
                dateTimePickerDateOfBirth.Value = activeUser.DateOfBirth;
                textBoxHeight.Text = activeUser.Height.ToString();
            }
            else
            {
                textBoxName.Text = string.Empty;
                radioButtonFemale.Select();
                dateTimePickerDateOfBirth.Value = DateTime.Today;
                textBoxHeight.Text = string.Empty;
            }
        }

        private void buttonCancelCreatingUser_Click(object sender, EventArgs e)
        {
            if (isUserPanelInEditMode)
            {
                this.SuspendLayout();
                LoadGraphPanelData();
                SwitchPanel(graphPanel);
                this.ResumeLayout();
            }
            else
            {
                this.SuspendLayout();
                LoadLoginPanelData();
                SwitchPanel(loginPanel);
                this.ResumeLayout();
            }
        }

        private void buttonApplyCreatingUser_Click(object sender, EventArgs e)
        {
            if (CheckNameValidity() && CheckDateOfBirthValidity() && CheckHeightValidity())
            {
                if (isUserPanelInEditMode)
                {
                    activeUser.Name = textBoxName.Text;
                    activeUser.DateOfBirth = dateTimePickerDateOfBirth.Value;
                    activeUser.Gender = radioButtonFemale.Checked ? BeefCakeData.Utilities.Gender.F : BeefCakeData.Utilities.Gender.M;
                    activeUser.Height = Decimal.Parse(textBoxHeight.Text);

                    userDao.Update(activeUser);
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
                }

                this.SuspendLayout();
                LoadGraphPanelData();
                SwitchPanel(graphPanel);
                this.ResumeLayout();
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
