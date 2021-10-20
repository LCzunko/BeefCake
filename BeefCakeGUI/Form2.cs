using BeefCakeData.DAL;
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

        public Form2(IMeasurementDao measurementDao)
        {
            InitializeComponent();
            this.measurementDao = measurementDao;
            measurementController = new(measurementDao);
            LoadMeasurementPanelData();
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
                var measurement = MeasurementBuilder.BuildMeasurement(currentDate, weight, calories, 4);
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
                CurrentBmiLabel.Text = "Unknown";
                currentMeasurement = null;
            }
            else
            {
                CurrentBmiLabel.Text = MeasurementController.CalculateBmi(activeUser, measurement).ToString();
                currentMeasurement = measurement;
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
