using System;
using System.Windows.Forms;
using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;
using BeefCakeLogic;

namespace BeefCakeGUI
{
    public partial class MainForm : Form
    {
        private IUserDao userDao;
        private IMeasurementDao measurementDao;
        private User activeUser;
        private Panel activePanel;
        private InputValidator inputValidator;
        private MeasurementController measurementController;
        private bool isUserPanelInEditMode;

        public MainForm(IUserDao userDao, IMeasurementDao measurementDao, InputValidator inputValidator, MeasurementController measurementController)
        {
            this.userDao = userDao;
            this.measurementDao = measurementDao;
            this.inputValidator = inputValidator;
            this.measurementController = measurementController;
            this.random = new Random();

            InitializeComponent();

            this.SuspendLayout();
            InitializeGraph();
            LoadLoginPanelData();
            InitializePanels();
            this.ResumeLayout();
        }
        private void SwitchPanel(Panel panelToSwitch)
        {
            activePanel.Enabled = false;
            activePanel.Visible = false;
            activePanel = panelToSwitch;
            activePanel.Enabled = true;
            activePanel.Visible = true;
        }

        private void InitializePanels()
        {
            loginPanel.Enabled = true;
            loginPanel.Visible = true;
            graphPanel.Enabled = false;
            graphPanel.Visible = false;
            measurementPanel.Enabled = false;
            measurementPanel.Visible = false;
            userPanel.Enabled = false;
            userPanel.Visible = false;

            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.measurementPanel);
            this.Controls.Add(this.userPanel);

            activePanel = loginPanel;
        }
    }
}
