using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;
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
    public partial class Form2 : Form
    {
        private User activeUser;
        private Panel activePanel;
        private IUserDao userDao;
        private IMeasurementDao measurementDao;

        public Form2(IMeasurementDao measurementDao)
        {
            InitializeComponent();
            this.measurementDao = measurementDao;
            LoadMeasurementPanelData();
        }

        private void LoadMeasurementPanelData()
        {
            MeasurementPicture.Image = Properties.Resources.Mysterion;
            CurrentBmiLabel.Text = "Unknown";
            BmiCommentLabel.Text = string.Empty;
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

        private void ApplyAddingData_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            //SaveData();
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

        private void SubmitBmiData_Click(object sender, EventArgs e)
        {
            //if today's data is not in measurement:
            //CalculateBmi();
            //switch picture
            //switch message
            //else show messagebox: data already added today
        }
    }
}
