using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BeefCakeGUI
{
    public partial class MainForm : Form
    {
        private Chart dateWeightChart;

        private void graphToMeasurementButton_Click(object sender, System.EventArgs e)
        {
            this.SuspendLayout();
            LoadMeasurementPanelData();
            SwitchPanel(measurementPanel);
            this.ResumeLayout();
        }

        private void graphToUserButton_Click(object sender, System.EventArgs e)
        {
            isUserPanelInEditMode = true;
            this.SuspendLayout();
            LoadUserPanelData();
            SwitchPanel(userPanel);
            this.ResumeLayout();
        }

        private void graphToLoginButton_Click(object sender, System.EventArgs e)
        {
            this.SuspendLayout();
            LoadLoginPanelData();
            SwitchPanel(loginPanel);
            this.ResumeLayout();
        }

        private void LoadGraphPanelData()
        {
            var userMeasurements = measurementDao.ReadAll().Where(x => x.UserId == activeUser.Id).OrderBy(x => x.Date);
            var latestBmi = userMeasurements.Select(x => x.Bmi).LastOrDefault();

            this.graphMenuLabel.Text = GetGraphMenuText(latestBmi);
            this.dateWeightChart.DataSource = userMeasurements;
            this.dateWeightChart.Refresh();
        }

        private string GetGraphMenuText(decimal latestBmi)
        {
            var menuText = new StringBuilder();

            menuText.Append($"Welcome, \r\n{activeUser.Name}!\r\n\r\n");

            if (latestBmi != 0.0M)
            {
                menuText.Append($"Your latest BMI is {latestBmi:N2}.\r\n\r\n");
                switch (latestBmi)
                {
                    case < 18.5M:
                        menuText.Append("You are underweight.\r\n\r\nTry to bring it down!");
                        break;
                    case < 25M:
                        menuText.Append("You are a healthy weight.\r\n\r\nKeep it up!");
                        break;
                    case < 30M:
                        menuText.Append("You are overweight.\r\n\r\nTry to bring it down!");
                        break;
                    case >= 30M:
                        menuText.Append("You are obese.\r\n\r\nWork on your lifestyle and see a doctor!");
                        break;
                }
                menuText.Append("\r\n\r\n");
            }

            menuText.Append("BEEFCAKE tip:\r\n");
            string randomTipName = "Tip" + new System.Random().Next(1, 21);
            menuText.Append((string)Properties.Resources.ResourceManager.GetObject(randomTipName, Properties.Resources.Culture));

            return menuText.ToString();
        }

        private void InitializeGraph()
        {
            this.dateWeightChart = new NonSelectableChart();
            ChartArea dateWeightchartArea = new ChartArea();
            Series dateWeightSeries = new Series();
            dateWeightChart.BackColor = SystemColors.Control;
            dateWeightchartArea.AxisX.MajorGrid.Enabled = false;
            dateWeightchartArea.AxisX.MajorTickMark.Size = 2F;
            dateWeightchartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular);
            dateWeightchartArea.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.StaggeredLabels | LabelAutoFitStyles.LabelsAngleStep30 | LabelAutoFitStyles.WordWrap;
            dateWeightchartArea.AxisX2.Enabled = AxisEnabled.False;
            dateWeightchartArea.AxisX2.MajorGrid.Enabled = false;
            dateWeightchartArea.AxisY.IsStartedFromZero = false;
            dateWeightchartArea.AxisY.LineDashStyle = ChartDashStyle.Dot;
            dateWeightchartArea.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            dateWeightchartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular);
            dateWeightchartArea.AxisY.LabelAutoFitStyle = LabelAutoFitStyles.StaggeredLabels | LabelAutoFitStyles.LabelsAngleStep30 | LabelAutoFitStyles.WordWrap;
            dateWeightchartArea.AxisY2.Enabled = AxisEnabled.False;
            dateWeightchartArea.AxisY2.MajorGrid.Enabled = false;
            dateWeightchartArea.Name = "dateWeightchartArea";
            dateWeightchartArea.Position.X = 0;
            dateWeightchartArea.Position.Width = 100;
            dateWeightchartArea.Position.Height = 100;
            dateWeightchartArea.Position.Y = 0;
            this.dateWeightChart.ChartAreas.Add(dateWeightchartArea);
            this.dateWeightChart.Dock = DockStyle.Fill;
            this.dateWeightChart.Name = "dateWeightChart";
            dateWeightSeries.BorderWidth = 2;
            dateWeightSeries.ChartArea = "dateWeightchartArea";
            dateWeightSeries.ChartType = SeriesChartType.Line;
            dateWeightSeries.Color = SystemColors.MenuHighlight;
            dateWeightSeries.CustomProperties = "IsXAxisQuantitative=True";
            dateWeightSeries.IsValueShownAsLabel = true;
            dateWeightSeries.MarkerBorderWidth = 0;
            dateWeightSeries.MarkerColor = SystemColors.HotTrack;
            dateWeightSeries.MarkerSize = 7;
            dateWeightSeries.MarkerStyle = MarkerStyle.Square;
            dateWeightSeries.Name = "lineSeries";
            dateWeightSeries.ToolTip = "#VALX";
            dateWeightSeries.XValueType = ChartValueType.Date;
            dateWeightSeries.YValueType = ChartValueType.Auto;
            dateWeightSeries.XValueMember = "Date";
            dateWeightSeries.YValueMembers = "Weight";
            dateWeightSeries.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic);
            dateWeightSeries.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.No;
            this.dateWeightChart.Series.Add(dateWeightSeries);
            this.dateWeightChart.Text = "dateWeightChart";
            this.dateWeightChart.TabStop = false;

            this.graphTableLayoutPanel.Controls.Add(this.dateWeightChart, 1, 0);
        }
    }
}
