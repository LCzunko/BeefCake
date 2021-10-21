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
            inputValidator = new(userDao);
            LoadMeasurementPanelData();
        }

        private void LoadMeasurementPanelData()
        {
            WrongCaloriesLabel.Text = string.Empty;
            WrongWeightLabel.Text = string.Empty;
            MeasurementDateLabel.Text = SetCurrentDate();
            ApplyAddingData.Enabled = false;
            currentDate = dateTimePicker.Value;
            currentMeasurement = GetUserMeasurementForDate(activeUser, currentDate);
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

        private string SetCurrentDate()
        {
            var currentDate = dateTimePicker.Value.ToString("d");
            return $"Measurements for " + currentDate;
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
                    var measurement = MeasurementBuilder.BuildMeasurement(currentDate, userWeight, userCalories, activeUser.Id);
                    measurementController.AddMeasurement(measurement);
                    MessageBox.Show("Successfully added new data");
                }
                else
                {
                    currentMeasurement.Weight = userWeight;
                    currentMeasurement.Calories = userCalories;
                    measurementController.EditMeasurement(currentMeasurement);
                    MessageBox.Show("Successfully updated the data");
                }
                WrongCaloriesLabel.Text = null;
                WrongWeightLabel.Text = null;
            }
            else ApplyAddingData.Enabled = false;
            //TODO LoadGraphPanelData();
            //SwitchPanel(graphPanel);
            this.ResumeLayout();
        }

        private bool ValidateMeasurement(string calories, string weight)
        {
            string weightMessage;
            string caloriesMessage;
            bool caloriesOk = false;
            bool weightOk = false;
            
            if (inputValidator.IsWeightValid(weight, out weightMessage))
            {
                weightOk = true;
            }
            else WrongWeightLabel.Text = weightMessage;
            if (inputValidator.IsCaloriesValid(calories, out caloriesMessage))
            {
                caloriesOk = true;
            }
            else WrongCaloriesLabel.Text = caloriesMessage;

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
            MeasurementDateLabel.Text = SetCurrentDate();
            currentDate = dateTimePicker.Value;
            var measurement = GetCurrentMeasurement();
            if (measurement == null)
            {
                DisplayNoMeasurement();
            }
            else
            {
                DisplayCurrentMeasurement(measurement);
            }
        }

        private void DisplayCurrentMeasurement(Measurement measurement)
        {
            if (measurement == null) DisplayNoMeasurement();
            else
            {
                CurrentBmiLabel.Text = MeasurementController.CalculateBmi(activeUser, measurement).ToString();
                currentMeasurement = measurement;
                CurrentCaloriesTextBox.Text = measurement.Calories.ToString();
                CurrentWeightTextBox.Text = measurement.Weight.ToString();
                ChangePictureAccordingToBmi(measurement.Bmi);
            }
        }

        private void DisplayNoMeasurement()
        {
            CurrentBmiLabel.Text = "Unknown";
            CurrentCaloriesTextBox.Text = null;
            CurrentWeightTextBox.Text = null;
            BmiCommentLabel.Text = string.Empty;
            MeasurementPicture.Image = Properties.Resources.Mysterion;
        }

        private void ChangePictureAccordingToBmi(decimal bmi)
        {
            if (bmi <= 22)
            {
                MeasurementPicture.Image = Properties.Resources.Workforce_weight_gain_ad_actor;
            }
            else if (bmi <= 25 && bmi > 22)
            {
                MeasurementPicture.Image = Properties.Resources.Cartman_Beefcake;
            }
            else
            {
                MeasurementPicture.Image = Properties.Resources.CartmanAlterEgoObese;
            }
        }

        private Measurement GetUserMeasurementForDate(User current, DateTime dateTime)
        {
            return measurementDao.ReadAll().FirstOrDefault(x => x.Date == dateTime && x.UserId == current.Id);
        }

        private void CurrentWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyAddingData.Enabled = true;
        }

        private void CurrentCaloriesTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyAddingData.Enabled = true;
        }

        private Measurement GetCurrentMeasurement() => GetUserMeasurementForDate(activeUser, currentDate);
    }
}
