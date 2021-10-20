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

        public Form2(IMeasurementDao measurementDao, IUserDao userDaoo)
        {
            InitializeComponent();
            this.measurementDao = measurementDao;
            this.userDao = userDaoo;
            measurementController = new(measurementDao);
            LoadMeasurementPanelData();
            activeUser = userDao.ReadAll().FirstOrDefault(x => x.Name == "Sylwia");
        }

        private void LoadMeasurementPanelData()
        {
            MeasurementPicture.Image = Properties.Resources.Mysterion;
            CurrentBmiLabel.Text = "Unknown";
            BmiCommentLabel.Text = string.Empty;
            WrongCaloriesLabel.Text = string.Empty;
            WrongWeightLabel.Text = string.Empty;
            MeasurementDateLabel.Text = SetCurrentDate();
            ApplyAddingData.Enabled = false;
            currentDate = dateTimePicker.Value;
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
            if (currentMeasurement == null)
            {
                var calories = CurrentCaloriesTextBox.Text;
                var weight = CurrentWeightTextBox.Text;
                var measurement = MeasurementBuilder.BuildMeasurement(currentDate, weight, calories, activeUser.Id);
                measurementController.AddMeasurement(measurement);
            }
            else
            {
                measurementController.EditMeasurement(currentMeasurement);
            }
            //TODO LoadGraphPanelData();
            //SwitchPanel(graphPanel);
            this.ResumeLayout();
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
            CurrentBmiLabel.Text = MeasurementController.CalculateBmi(activeUser, measurement).ToString();
            currentMeasurement = measurement;
            CurrentCaloriesTextBox.Text = measurement.Calories.ToString();
            CurrentWeightTextBox.Text = measurement.Weight.ToString();
            ChangePictureAccordingToBmi(measurement.Bmi);
        }

        private void DisplayNoMeasurement()
        {
            CurrentBmiLabel.Text = "Unknown";
            currentMeasurement = null;
            CurrentCaloriesTextBox.Text = null;
            CurrentWeightTextBox.Text = null;
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
