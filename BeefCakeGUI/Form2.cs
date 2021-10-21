using BeefCakeData.DAL;
using BeefCakeData.DAL.DAOImpl;
using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;
using BeefCakeLogic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BeefCakeGUI
{
    public partial class Form2 : Form
    {
        private User activeUser;
        private Panel activePanel;
        private IUserDao userDao;
        private IMeasurementDao measurementDao;
        private MeasurementController measurementController;
        private DateTime currentDate;
        private Measurement currentMeasurement;
        private InputValidator inputValidator;

        public Form2(IMeasurementDao measurementDao, IUserDao userDaoo)
        {
            InitializeComponent();
            this.measurementDao = measurementDao;
            this.userDao = userDaoo;
            measurementController = new(measurementDao);
            activeUser = userDao.ReadAll().FirstOrDefault(x => x.Name == "Sylwia");
            currentDate = dateTimePicker.Value;
            currentMeasurement = GetUserMeasurementForDate(activeUser, currentDate);
            inputValidator = new(userDao);
            LoadMeasurementPanelData();
        }

        private void LoadMeasurementPanelData()
        {
            ClearWrongDataLabels();
            DisplayCurrentMeasurement(currentMeasurement);
        }

        private void SwitchPanel(Panel panelToSwitch)
        {
            activePanel.Enabled = false;
            activePanel.Visible = false;
            activePanel = panelToSwitch;
            activePanel.Enabled = true;
            activePanel.Visible = true;
        }

        private void CancelAddingData_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            //TODO LoadGraphPanelData();
            //SwitchPanel(graphPanel);
            this.ResumeLayout();
        }
        private void ApplyAddingData_Click(object sender, EventArgs e)
        {
            int userCalories;
            decimal userWeight;
            //this.SuspendLayout();
            if (CurrentCaloriesTextBox.Text == string.Empty)
            {
                userCalories = 0;
            }
            else userCalories = int.Parse(CurrentCaloriesTextBox.Text);
            if (CurrentWeightTextBox.Text == string.Empty)
            {
                userWeight = 0;
            }
            else userWeight = decimal.Parse(CurrentWeightTextBox.Text);

            if (currentMeasurement == null)
            {
                AddNewMeasurement(userWeight, userCalories);
                MessageBox.Show("Successfully added new data");
            }
            else
            {
                UpdateMeasurement(userWeight, userCalories);
                MessageBox.Show("Successfully updated the data");
            }
            ////TODO LoadGraphPanelData();
            ////SwitchPanel(graphPanel);
            //this.ResumeLayout();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ClearWrongDataLabels();
            currentDate = dateTimePicker.Value;
            var measurement = GetUserMeasurementForDate(activeUser, currentDate);
            DisplayCurrentMeasurement(measurement);
        }

        private void CurrentWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearWrongDataLabels();
            ValidateInputs();
        }

        private void CurrentCaloriesTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearWrongDataLabels();
            ValidateInputs();
        }

        private void ValidateInputs()
        {
            if (CurrentWeightTextBox.Text != string.Empty || CurrentCaloriesTextBox.Text != string.Empty)
            {
                var weight = CurrentWeightTextBox.Text;
                var calories = CurrentCaloriesTextBox.Text;
                var validWeightInput = inputValidator.IsWeightValid(weight, out string weightMessage);
                var validCaloryInput = inputValidator.IsCaloriesValid(calories, out string caloriesMessage);
                WrongWeightLabel.Text = weightMessage;
                WrongCaloriesLabel.Text = caloriesMessage;
                if (!validWeightInput || !validCaloryInput) ApplyAddingData.Enabled = false;
                else ApplyAddingData.Enabled = true;
                AdjustToInputChanges(weight, calories, validWeightInput, validCaloryInput);
            }
        }

        private string SetCurrentDate()
        {
            return "Measurements for " + currentDate.ToString("d");
        }

        private void DisplayCurrentMeasurement(Measurement measurement)
        {
            ClearWrongDataLabels();
            MeasurementDateLabel.Text = SetCurrentDate();
            if (measurement == null)
            {
                DisplayNoMeasurement();
                ClearInputBoxes();
            }
            else DisplayFilledMeasurement(measurement);
        }

        private void DisplayBmiInfo(Measurement measurement)
        {
            var currentBmi = Math.Round(MeasurementController.CalculateBmi(activeUser, measurement), 1);
            CurrentBmiLabel.Text = currentBmi.ToString();
            DisplayFeedbackAccordingToBmi(currentBmi);
        }

        private void DisplayFilledMeasurement(Measurement measurement)
        {
            DisplayBmiInfo(measurement);
            currentMeasurement = measurement;
            CurrentCaloriesTextBox.Text = measurement.Calories.ToString();
            CurrentWeightTextBox.Text = measurement.Weight.ToString();
        }

        private void DisplayNoMeasurement()
        {
            currentMeasurement = null;
            CurrentBmiLabel.Text = "Unknown";
            BmiCommentLabel.Text = string.Empty;
            MeasurementPicture.Image = Properties.Resources.Mysterion;
        }

        private void DisplayFeedbackAccordingToBmi(decimal bmi)
        {
            if (bmi <= 22)
            {
                MeasurementPicture.Image = Properties.Resources.Workforce_weight_gain_ad_actor;
                BmiCommentLabel.Text = "Nice! Keep it lean!";
            }
            else if (bmi <= 25 && bmi > 22)
            {
                MeasurementPicture.Image = Properties.Resources.Cartman_Beefcake;
                BmiCommentLabel.Text = "Keep up the good work!";
            }
            else
            {
                MeasurementPicture.Image = Properties.Resources.CartmanAlterEgoObese;
                BmiCommentLabel.Text = "BEEFCAKE!";
            }
        }

        private void ClearWrongDataLabels()
        {
            WrongCaloriesLabel.Text = string.Empty;
            WrongWeightLabel.Text = string.Empty;
        }

        private void ClearInputBoxes()
        {
            CurrentCaloriesTextBox.Text = null;
            CurrentWeightTextBox.Text = null;
        }
        
        private void UpdateMeasurement(decimal userWeight, int userCalories)
        {
            currentMeasurement.Weight = userWeight;
            currentMeasurement.Calories = userCalories;
            measurementController.EditMeasurement(currentMeasurement);
        }

        private void AddNewMeasurement(decimal userWeight, int userCalories)
        {
            var measurement = MeasurementBuilder.BuildMeasurement(currentDate, userWeight, userCalories, activeUser.Id);
            measurement.Bmi = Math.Round(MeasurementController.CalculateBmi(activeUser, measurement), 1);
            measurementController.AddMeasurement(measurement);
            currentMeasurement = measurement;
        }

        private Measurement GetUserMeasurementForDate(User current, DateTime dateTime)
        {
            //move to controller
            return measurementDao.ReadAll().FirstOrDefault(x => x.Date == dateTime && x.UserId == current.Id);
        }

        private void AdjustToInputChanges(string weight, string calories, bool validWeightInput, bool validCaloryInput)
        {
            if (currentMeasurement == null)
            {
                DisplayNoMeasurement();
            }
            else
            {
                if (weight != string.Empty && validWeightInput && validCaloryInput)
                {
                    currentMeasurement.Weight = decimal.Parse(weight);
                }
                if (calories != string.Empty && validWeightInput && validCaloryInput)
                {
                    currentMeasurement.Calories = int.Parse(calories);
                }
                DisplayBmiInfo(currentMeasurement);
            }
        }
    }
}
