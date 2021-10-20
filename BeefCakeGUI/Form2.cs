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
            CleanWrongDataLabels();
            DisplayCurrentMeasurement(currentMeasurement);
        }

        private void CleanWrongDataLabels()
        {
            WrongCaloriesLabel.Text = string.Empty;
            WrongWeightLabel.Text = string.Empty;
        }

        private void SwitchPanel(Panel panelToSwitch)
        {
            activePanel.Enabled = false;
            activePanel.Visible = false;
            activePanel = panelToSwitch;
            activePanel.Enabled = true;
            activePanel.Visible = true;
        }

        private string SetCurrentDate()
        {
            return "Measurements for " + currentDate.ToString("d");
        }

        private bool ValidateMeasurement(string calories, string weight)
        {
            bool caloriesOk = inputValidator.IsCaloriesValid(calories, out string caloriesMessage);
            bool weightOk = inputValidator.IsWeightValid(weight, out string weightMessage);
            WrongWeightLabel.Text = weightMessage;
            WrongCaloriesLabel.Text = caloriesMessage;

            return caloriesOk && weightOk;
        }

        private void CancelAddingData_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            //TODO LoadGraphPanelData();
            //SwitchPanel(graphPanel);
            this.ResumeLayout();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CleanWrongDataLabels();
            currentDate = dateTimePicker.Value;
            var measurement = GetUserMeasurementForDate(activeUser, currentDate);
            DisplayCurrentMeasurement(measurement);
        }

        private void DisplayCurrentMeasurement(Measurement measurement)
        {
            CleanWrongDataLabels();
            MeasurementDateLabel.Text = SetCurrentDate();
            if (measurement == null) DisplayNoMeasurement();
            else DisplayFilledMeasurement(measurement);
        }

        private void DisplayFilledMeasurement(Measurement measurement)
        {
            var currentBmi = Math.Round(MeasurementController.CalculateBmi(activeUser, measurement), 1);
            CurrentBmiLabel.Text = currentBmi.ToString();
            currentMeasurement = measurement;
            CurrentCaloriesTextBox.Text = measurement.Calories.ToString();
            CurrentWeightTextBox.Text = measurement.Weight.ToString();
            ChangeFeedbackAccordingToBmi(currentBmi);
        }

        private void DisplayNoMeasurement()
        {
            currentMeasurement = null;
            CurrentBmiLabel.Text = "Unknown";
            CurrentCaloriesTextBox.Text = null;
            CurrentWeightTextBox.Text = null;
            BmiCommentLabel.Text = string.Empty;
            MeasurementPicture.Image = Properties.Resources.Mysterion;
        }

        private void ChangeFeedbackAccordingToBmi(decimal bmi)
        {
            if (bmi <= 22)
            {
                MeasurementPicture.Image = Properties.Resources.Workforce_weight_gain_ad_actor;
                BmiCommentLabel.Text = "Nice! Keep it lean!";
            }
            else if (bmi <= 24 && bmi > 22)
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

        private void ApplyAddingData_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            var calories = CurrentCaloriesTextBox.Text;
            var weight = CurrentWeightTextBox.Text;
            if (ValidateMeasurement(calories, weight))
            {
                var userCalories = int.Parse(calories);
                var userWeight = decimal.Parse(weight);
                if (currentMeasurement == null)
                {
                    AddNewMeasurement(userWeight, userCalories);
                }
                else
                {
                    UpdateMeasurement(userWeight, userCalories);
                }
                DisplayCurrentMeasurement(currentMeasurement);
            }
            //TODO LoadGraphPanelData();
            //SwitchPanel(graphPanel);
            this.ResumeLayout();
        }

        private void UpdateMeasurement(decimal userWeight, int userCalories)
        {
            currentMeasurement.Weight = userWeight;
            currentMeasurement.Calories = userCalories;
            measurementController.EditMeasurement(currentMeasurement);
            MessageBox.Show("Successfully updated the data");
        }

        private void AddNewMeasurement(decimal userWeight, int userCalories)
        {
            var measurement = MeasurementBuilder.BuildMeasurement(currentDate, userWeight, userCalories, activeUser.Id);
            measurement.Bmi = Math.Round(MeasurementController.CalculateBmi(activeUser, measurement), 1);
            measurementController.AddMeasurement(measurement);
            MessageBox.Show("Successfully added new data");
            currentMeasurement = measurement;
        }

        private Measurement GetUserMeasurementForDate(User current, DateTime dateTime)
        {
            //move to controller
            return measurementDao.ReadAll().FirstOrDefault(x => x.Date == dateTime && x.UserId == current.Id);
        }
    }
}
