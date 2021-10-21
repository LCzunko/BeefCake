using BeefCakeData.DAL;
using BeefCakeData.Model;
using BeefCakeLogic;
using System;
using System.Windows.Forms;

namespace BeefCakeGUI
{
    public partial class MainForm : Form
    {
        private DateTime currentDate;
        private Measurement currentMeasurement;

        private void LoadMeasurementPanelData()
        {
            WrongCaloriesLabel.Text = string.Empty;
            WrongWeightLabel.Text = string.Empty;
            MeasurementDateLabel.Text = SetCurrentDate();
            ApplyAddingData.Enabled = false;
            currentDate = dateTimePicker.Value;
            currentMeasurement = measurementController.GetUserMeasurementForDate(activeUser, currentDate);
            DisplayCurrentMeasurement();
        }

        private void ApplyAddingData_Click(object sender, EventArgs e)
        {
            int userCalories;
            decimal userWeight;

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
        }

        private void CancelAddingData_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            LoadGraphPanelData();
            SwitchPanel(graphPanel);
            this.ResumeLayout();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            currentDate = dateTimePicker.Value;
            var measurement = measurementController.GetUserMeasurementForDate(activeUser, currentDate);
            currentMeasurement = measurement;
            DisplayCurrentMeasurement();
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
                AdjustToInputChanges(weight, validWeightInput);
            }
        }

        private string SetCurrentDate()
        {
            return "Measurements for " + currentDate.ToString("d");
        }

        private void DisplayCurrentMeasurement()
        {
            ClearWrongDataLabels();
            MeasurementDateLabel.Text = SetCurrentDate();
            if (currentMeasurement != null)
            {
                DisplayFilledMeasurement(currentMeasurement);
            }
            else
            {
                DisplayEmptyMeasurement();
            }
        }

        private void DisplayBmiInfo(decimal height, decimal weight)
        {
            var currentBmi = Math.Round(MeasurementController.CalculateBmi(height, weight), 1);
            if (currentBmi != 0)
            {
                CurrentBmiLabel.Text = currentBmi.ToString();
            }
            else
            {
                CurrentBmiLabel.Text = "Unknown";
                currentMeasurement = null;
            }
            DisplayFeedbackAccordingToBmi(currentBmi);
        }

        private void DisplayFilledMeasurement(Measurement measurement)
        {
            DisplayBmiInfo(activeUser.Height, measurement.Weight);
            CurrentCaloriesTextBox.Text = measurement.Calories.ToString();
            CurrentWeightTextBox.Text = measurement.Weight.ToString();
        }

        private void DisplayEmptyMeasurement()
        {
            MeasurementPicture.Image = Properties.Resources.Mysterion;
            BmiCommentLabel.Text = string.Empty;
            CurrentBmiLabel.Text = "Unknown";
            currentMeasurement = null;
        }

        private void DisplayFeedbackAccordingToBmi(decimal bmi)
        {
            if (bmi <= 22 && bmi > 0)
            {
                MeasurementPicture.Image = Properties.Resources.Workforce_weight_gain_ad_actor;
                BmiCommentLabel.Text = "Nice! Keep it lean!";
            }
            else if (bmi <= 25 && bmi > 22)
            {
                MeasurementPicture.Image = Properties.Resources.Cartman_Beefcake;
                BmiCommentLabel.Text = "Keep up the good work!";
            }
            else if (bmi > 25)
            {
                MeasurementPicture.Image = Properties.Resources.CartmanAlterEgoObese;
                BmiCommentLabel.Text = "BEEFCAKE!";
            }
            else
            {
                DisplayEmptyMeasurement();
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
            var bmi = Math.Round(MeasurementController.CalculateBmi(activeUser.Height, userWeight), 1);
            var measurement = MeasurementBuilder.BuildMeasurement(currentDate, userWeight, userCalories, bmi, activeUser.Id);
            measurementController.AddMeasurement(measurement);
            currentMeasurement = measurement;
        }

        private void AdjustToInputChanges(string weight, bool validWeightInput)
        {
            if (weight != string.Empty && validWeightInput)
            {
                DisplayBmiInfo(activeUser.Height, decimal.Parse(weight));
            }
            else if (weight == string.Empty)
            {
                DisplayEmptyMeasurement();
            }
        }
    }
}
