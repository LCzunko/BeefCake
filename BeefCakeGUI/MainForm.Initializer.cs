namespace BeefCakeGUI
{
    public partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // 
            // MainForm
            // 
            // 
            this.components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BeefCake";
            this.Icon = Properties.Resources.CartmanCopHead_Icon;
            //
            //
            // LoginForm
            // 
            // 
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loginUserButton = new System.Windows.Forms.Button();
            this.loginAddUserLabel = new System.Windows.Forms.Label();
            this.loginWelcomeLabel = new System.Windows.Forms.Label();
            this.loginSelectUserLabel = new System.Windows.Forms.Label();
            this.loginUsersComboBox = new System.Windows.Forms.ComboBox();
            this.loginGraphButton = new System.Windows.Forms.Button();
            this.loginWelcomePictureBox = new System.Windows.Forms.PictureBox();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginTableLayoutPanel);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Padding = new System.Windows.Forms.Padding(30);
            this.loginPanel.Size = new System.Drawing.Size(800, 450);
            this.loginPanel.TabIndex = 0;
            // 
            // loginTableLayoutPanel
            // 
            this.loginTableLayoutPanel.ColumnCount = 4;
            this.loginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.loginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginTableLayoutPanel.Controls.Add(this.loginUserButton, 0, 4);
            this.loginTableLayoutPanel.Controls.Add(this.loginAddUserLabel, 0, 3);
            this.loginTableLayoutPanel.Controls.Add(this.loginWelcomeLabel, 0, 0);
            this.loginTableLayoutPanel.Controls.Add(this.loginSelectUserLabel, 0, 1);
            this.loginTableLayoutPanel.Controls.Add(this.loginUsersComboBox, 0, 2);
            this.loginTableLayoutPanel.Controls.Add(this.loginGraphButton, 2, 2);
            this.loginTableLayoutPanel.Controls.Add(this.loginWelcomePictureBox, 3, 1);
            this.loginTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTableLayoutPanel.Location = new System.Drawing.Point(30, 30);
            this.loginTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginTableLayoutPanel.Name = "loginTableLayoutPanel";
            this.loginTableLayoutPanel.RowCount = 5;
            this.loginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.loginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.loginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.loginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.loginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.loginTableLayoutPanel.Size = new System.Drawing.Size(740, 390);
            this.loginTableLayoutPanel.TabIndex = 0;
            // 
            // loginUserButton
            // 
            this.loginUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginUserButton.Image = global::BeefCakeGUI.Properties.Resources.Add_16x;
            this.loginUserButton.Location = new System.Drawing.Point(10, 273);
            this.loginUserButton.Margin = new System.Windows.Forms.Padding(10, 9, 6, 92);
            this.loginUserButton.Name = "loginUserButton";
            this.loginUserButton.Size = new System.Drawing.Size(58, 25);
            this.loginUserButton.TabIndex = 5;
            this.loginUserButton.UseVisualStyleBackColor = true;
            this.loginUserButton.Click += new System.EventHandler(this.userAddButton_Click);
            // 
            // loginAddUserLabel
            // 
            this.loginAddUserLabel.AutoSize = true;
            this.loginTableLayoutPanel.SetColumnSpan(this.loginAddUserLabel, 3);
            this.loginAddUserLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginAddUserLabel.Location = new System.Drawing.Point(0, 249);
            this.loginAddUserLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginAddUserLabel.Name = "loginAddUserLabel";
            this.loginAddUserLabel.Padding = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.loginAddUserLabel.Size = new System.Drawing.Size(370, 15);
            this.loginAddUserLabel.TabIndex = 4;
            this.loginAddUserLabel.Text = "Or register as a new user:";
            // 
            // loginWelcomeLabel
            // 
            this.loginWelcomeLabel.AutoSize = true;
            this.loginWelcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTableLayoutPanel.SetColumnSpan(this.loginWelcomeLabel, 4);
            this.loginWelcomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginWelcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.loginWelcomeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.loginWelcomeLabel.Name = "loginWelcomeLabel";
            this.loginWelcomeLabel.Padding = new System.Windows.Forms.Padding(10);
            this.loginWelcomeLabel.Size = new System.Drawing.Size(740, 97);
            this.loginWelcomeLabel.TabIndex = 0;
            this.loginWelcomeLabel.Text = "Welcome to BEEFCAKE!\r\n\r\nThe best health app. Track your weight and calorie intake" +
    ", calculate your BMI.\r\n\r\nGet in shape FAST. Look your BEST. Use BEEFCAKE!";
            // 
            // loginSelectUserLabel
            // 
            this.loginSelectUserLabel.AutoSize = true;
            this.loginTableLayoutPanel.SetColumnSpan(this.loginSelectUserLabel, 3);
            this.loginSelectUserLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginSelectUserLabel.Location = new System.Drawing.Point(0, 162);
            this.loginSelectUserLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginSelectUserLabel.Name = "loginSelectUserLabel";
            this.loginSelectUserLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.loginSelectUserLabel.Size = new System.Drawing.Size(370, 15);
            this.loginSelectUserLabel.TabIndex = 1;
            this.loginSelectUserLabel.Text = "Log in as an existing user:";
            // 
            // loginUsersComboBox
            // 
            this.loginTableLayoutPanel.SetColumnSpan(this.loginUsersComboBox, 2);
            this.loginUsersComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginUsersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loginUsersComboBox.FormattingEnabled = true;
            this.loginUsersComboBox.Location = new System.Drawing.Point(13, 187);
            this.loginUsersComboBox.Margin = new System.Windows.Forms.Padding(13, 10, 0, 0);
            this.loginUsersComboBox.Name = "loginUsersComboBox";
            this.loginUsersComboBox.Size = new System.Drawing.Size(283, 23);
            this.loginUsersComboBox.TabIndex = 2;
            // 
            // loginGraphButton
            // 
            this.loginGraphButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginGraphButton.Image = global::BeefCakeGUI.Properties.Resources.Checkmark_16x;
            this.loginGraphButton.Location = new System.Drawing.Point(304, 186);
            this.loginGraphButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 24);
            this.loginGraphButton.Name = "loginGraphButton";
            this.loginGraphButton.Size = new System.Drawing.Size(58, 25);
            this.loginGraphButton.TabIndex = 3;
            this.loginGraphButton.UseVisualStyleBackColor = true;
            this.loginGraphButton.Click += new System.EventHandler(this.userConfirmButton_Click);
            // 
            // loginWelcomePictureBox
            // 
            this.loginWelcomePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginWelcomePictureBox.Image = global::BeefCakeGUI.Properties.Resources.Cartman_Beefcake;
            this.loginWelcomePictureBox.Location = new System.Drawing.Point(370, 107);
            this.loginWelcomePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.loginWelcomePictureBox.Name = "loginWelcomePictureBox";
            this.loginTableLayoutPanel.SetRowSpan(this.loginWelcomePictureBox, 4);
            this.loginWelcomePictureBox.Size = new System.Drawing.Size(370, 283);
            this.loginWelcomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginWelcomePictureBox.TabIndex = 6;
            this.loginWelcomePictureBox.TabStop = false;
            // 
            // 
            // GraphForm
            // 
            // 
            this.graphPanel = new System.Windows.Forms.Panel();
            this.graphTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.graphMenuTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.graphToLoginButton = new System.Windows.Forms.Button();
            this.graphToUserButton = new System.Windows.Forms.Button();
            this.graphToMeasurementButton = new System.Windows.Forms.Button();
            this.graphMenuLabel = new System.Windows.Forms.Label();
            // 
            // graphPanel
            // 
            this.graphPanel.Controls.Add(this.graphTableLayoutPanel);
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPanel.Location = new System.Drawing.Point(0, 0);
            this.graphPanel.Margin = new System.Windows.Forms.Padding(0);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Padding = new System.Windows.Forms.Padding(30);
            this.graphPanel.Size = new System.Drawing.Size(800, 450);
            this.graphPanel.TabIndex = 0;
            // 
            // graphTableLayoutPanel
            // 
            this.graphTableLayoutPanel.ColumnCount = 2;
            this.graphTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            this.graphTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.04878F));
            this.graphTableLayoutPanel.Controls.Add(this.graphMenuTableLayoutPanel, 0, 0);
            this.graphTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphTableLayoutPanel.Location = new System.Drawing.Point(30, 30);
            this.graphTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.graphTableLayoutPanel.Name = "graphTableLayoutPanel";
            this.graphTableLayoutPanel.RowCount = 1;
            this.graphTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.graphTableLayoutPanel.Size = new System.Drawing.Size(740, 390);
            this.graphTableLayoutPanel.TabIndex = 0;
            // 
            // graphMenuTableLayoutPanel
            // 
            this.graphMenuTableLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphMenuTableLayoutPanel.ColumnCount = 1;
            this.graphMenuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.graphMenuTableLayoutPanel.Controls.Add(this.graphToLoginButton, 0, 3);
            this.graphMenuTableLayoutPanel.Controls.Add(this.graphToUserButton, 0, 2);
            this.graphMenuTableLayoutPanel.Controls.Add(this.graphToMeasurementButton, 0, 1);
            this.graphMenuTableLayoutPanel.Controls.Add(this.graphMenuLabel, 0, 0);
            this.graphMenuTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphMenuTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.graphMenuTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.graphMenuTableLayoutPanel.Name = "graphMenuTableLayoutPanel";
            this.graphMenuTableLayoutPanel.RowCount = 4;
            this.graphMenuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.graphMenuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.graphMenuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.graphMenuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.graphMenuTableLayoutPanel.Size = new System.Drawing.Size(162, 390);
            this.graphMenuTableLayoutPanel.TabIndex = 1;
            // 
            // graphToLoginButton
            // 
            this.graphToLoginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.graphToLoginButton.Image = global::BeefCakeGUI.Properties.Resources.SignIn_16x;
            this.graphToLoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.graphToLoginButton.Location = new System.Drawing.Point(5, 346);
            this.graphToLoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.graphToLoginButton.Name = "graphToLoginButton";
            this.graphToLoginButton.Padding = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.graphToLoginButton.Size = new System.Drawing.Size(150, 37);
            this.graphToLoginButton.TabIndex = 6;
            this.graphToLoginButton.Text = "Log out";
            this.graphToLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphToLoginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.graphToLoginButton.UseVisualStyleBackColor = true;
            this.graphToLoginButton.Click += new System.EventHandler(this.graphToLoginButton_Click);
            // 
            // graphToUserButton
            // 
            this.graphToUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphToUserButton.Image = global::BeefCakeGUI.Properties.Resources.EditManifest_16x;
            this.graphToUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.graphToUserButton.Location = new System.Drawing.Point(5, 270);
            this.graphToUserButton.Margin = new System.Windows.Forms.Padding(5, 13, 5, 14);
            this.graphToUserButton.Name = "graphToUserButton";
            this.graphToUserButton.Padding = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.graphToUserButton.Size = new System.Drawing.Size(150, 37);
            this.graphToUserButton.TabIndex = 5;
            this.graphToUserButton.Text = "Edit your profile";
            this.graphToUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphToUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.graphToUserButton.UseVisualStyleBackColor = true;
            this.graphToUserButton.Click += new System.EventHandler(this.graphToUserButton_Click);
            // 
            // graphToMeasurementButton
            // 
            this.graphToMeasurementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.graphToMeasurementButton.Image = global::BeefCakeGUI.Properties.Resources.EditDocument_16x;
            this.graphToMeasurementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.graphToMeasurementButton.Location = new System.Drawing.Point(5, 197);
            this.graphToMeasurementButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.graphToMeasurementButton.Name = "graphToMeasurementButton";
            this.graphToMeasurementButton.Padding = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.graphToMeasurementButton.Size = new System.Drawing.Size(150, 37);
            this.graphToMeasurementButton.TabIndex = 4;
            this.graphToMeasurementButton.Text = "Edit measurements";
            this.graphToMeasurementButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphToMeasurementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.graphToMeasurementButton.UseVisualStyleBackColor = true;
            this.graphToMeasurementButton.Click += new System.EventHandler(this.graphToMeasurementButton_Click);
            // 
            // graphMenuLabel
            // 
            this.graphMenuLabel.AutoSize = true;
            this.graphMenuLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphMenuLabel.Location = new System.Drawing.Point(0, 0);
            this.graphMenuLabel.Margin = new System.Windows.Forms.Padding(0);
            this.graphMenuLabel.Name = "graphMenuLabel";
            this.graphMenuLabel.Padding = new System.Windows.Forms.Padding(5);
            this.graphMenuLabel.Size = new System.Drawing.Size(160, 193);
            this.graphMenuLabel.TabIndex = 0;
            this.graphMenuLabel.Text = "Welcome, \r\nPlaceholder!\r\n\r\nYour latest BMI is 18,51.\r\n\r\nYou are a healthy weight." +
    "\r\n\r\nKeep it up!\r\n\r\nBEEFCAKE tip:\r\nMake a goal and stick to it.";
            // 
            // 
            // MeasurementForm
            // 
            //
            this.measurementPanel = new System.Windows.Forms.Panel();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MeasurementPicture = new System.Windows.Forms.PictureBox();
            this.ApplyAddingData = new System.Windows.Forms.Button();
            this.WrongCaloriesLabel = new System.Windows.Forms.Label();
            this.BmiCommentLabel = new System.Windows.Forms.Label();
            this.BmiLabel = new System.Windows.Forms.Label();
            this.CurrentBmiLabel = new System.Windows.Forms.Label();
            this.CancelBmiButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CurrentCaloriesTextBox = new System.Windows.Forms.TextBox();
            this.CurrentWeightTextBox = new System.Windows.Forms.TextBox();
            this.CaloriesLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WrongWeightLabel = new System.Windows.Forms.Label();
            this.MeasurementDateLabel = new System.Windows.Forms.Label();
            // 
            // MeasurementPanel
            // 
            this.measurementPanel.AutoSize = true;
            this.measurementPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.measurementPanel.Controls.Add(this.TableLayoutPanel);
            this.measurementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measurementPanel.Location = new System.Drawing.Point(0, 0);
            this.measurementPanel.Name = "MeasurementPanel";
            this.measurementPanel.Size = new System.Drawing.Size(800, 450);
            this.measurementPanel.TabIndex = 0;
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 5;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.31034F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.68966F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.TableLayoutPanel.Controls.Add(this.MeasurementPicture, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.ApplyAddingData, 4, 6);
            this.TableLayoutPanel.Controls.Add(this.WrongCaloriesLabel, 4, 3);
            this.TableLayoutPanel.Controls.Add(this.BmiCommentLabel, 0, 6);
            this.TableLayoutPanel.Controls.Add(this.BmiLabel, 0, 5);
            this.TableLayoutPanel.Controls.Add(this.CurrentBmiLabel, 1, 5);
            this.TableLayoutPanel.Controls.Add(this.CancelBmiButton, 3, 6);
            this.TableLayoutPanel.Controls.Add(this.dateTimePicker, 3, 0);
            this.TableLayoutPanel.Controls.Add(this.CurrentCaloriesTextBox, 3, 3);
            this.TableLayoutPanel.Controls.Add(this.CurrentWeightTextBox, 3, 2);
            this.TableLayoutPanel.Controls.Add(this.CaloriesLabel, 2, 3);
            this.TableLayoutPanel.Controls.Add(this.WeightLabel, 2, 2);
            this.TableLayoutPanel.Controls.Add(this.WrongWeightLabel, 4, 2);
            this.TableLayoutPanel.Controls.Add(this.MeasurementDateLabel, 3, 1);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.TableLayoutPanel.RowCount = 7;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83871F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.16129F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // MeasurementPicture
            // 
            this.TableLayoutPanel.SetColumnSpan(this.MeasurementPicture, 2);
            this.MeasurementPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasurementPicture.Image = global::BeefCakeGUI.Properties.Resources.Workforce_weight_gain_ad_actor;
            this.MeasurementPicture.Location = new System.Drawing.Point(33, 32);
            this.MeasurementPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MeasurementPicture.Name = "MeasurementPicture";
            this.TableLayoutPanel.SetRowSpan(this.MeasurementPicture, 5);
            this.MeasurementPicture.Size = new System.Drawing.Size(327, 305);
            this.MeasurementPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MeasurementPicture.TabIndex = 3;
            this.MeasurementPicture.TabStop = false;
            // 
            // ApplyAddingData
            // 
            this.ApplyAddingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyAddingData.Location = new System.Drawing.Point(650, 390);
            this.ApplyAddingData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplyAddingData.Name = "ApplyAddingData";
            this.ApplyAddingData.Size = new System.Drawing.Size(117, 28);
            this.ApplyAddingData.TabIndex = 8;
            this.ApplyAddingData.Text = "OK";
            this.ApplyAddingData.UseVisualStyleBackColor = true;
            this.ApplyAddingData.Click += new System.EventHandler(this.ApplyAddingData_Click);
            // 
            // WrongCaloriesLabel
            // 
            this.WrongCaloriesLabel.AutoSize = true;
            this.WrongCaloriesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WrongCaloriesLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongCaloriesLabel.Location = new System.Drawing.Point(650, 137);
            this.WrongCaloriesLabel.Name = "WrongCaloriesLabel";
            this.WrongCaloriesLabel.Size = new System.Drawing.Size(117, 79);
            this.WrongCaloriesLabel.TabIndex = 15;
            this.WrongCaloriesLabel.Text = "Wrong data input";
            this.WrongCaloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BmiCommentLabel
            // 
            this.BmiCommentLabel.AutoSize = true;
            this.TableLayoutPanel.SetColumnSpan(this.BmiCommentLabel, 2);
            this.BmiCommentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BmiCommentLabel.Location = new System.Drawing.Point(80, 388);
            this.BmiCommentLabel.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.BmiCommentLabel.Name = "BmiCommentLabel";
            this.BmiCommentLabel.Size = new System.Drawing.Size(176, 21);
            this.BmiCommentLabel.TabIndex = 6;
            this.BmiCommentLabel.Text = "Keep up the good work!";
            this.BmiCommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BmiLabel
            // 
            this.BmiLabel.AutoSize = true;
            this.BmiLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BmiLabel.Font = new System.Drawing.Font("Verdana", 09.80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BmiLabel.Location = new System.Drawing.Point(95, 339);
            this.BmiLabel.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.BmiLabel.Name = "BmiLabel";
            this.BmiLabel.Size = new System.Drawing.Size(63, 49);
            this.BmiLabel.TabIndex = 4;
            this.BmiLabel.Text = "Your BMI:";
            this.BmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentBmiLabel
            // 
            this.CurrentBmiLabel.AutoSize = true;
            this.CurrentBmiLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CurrentBmiLabel.Font = new System.Drawing.Font("Verdana", 09.80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentBmiLabel.Location = new System.Drawing.Point(164, 339);
            this.CurrentBmiLabel.Name = "CurrentBmiLabel";
            this.CurrentBmiLabel.Size = new System.Drawing.Size(32, 49);
            this.CurrentBmiLabel.TabIndex = 13;
            this.CurrentBmiLabel.Text = "22.5";
            this.CurrentBmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelBmiButton
            // 
            this.CancelBmiButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBmiButton.Location = new System.Drawing.Point(510, 390);
            this.CancelBmiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBmiButton.Name = "CancelBmiButton";
            this.CancelBmiButton.Size = new System.Drawing.Size(134, 28);
            this.CancelBmiButton.TabIndex = 16;
            this.CancelBmiButton.Text = "Cancel";
            this.CancelBmiButton.UseVisualStyleBackColor = true;
            this.CancelBmiButton.Click += new System.EventHandler(this.CancelAddingData_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(455, 32);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.MaxDate = System.DateTime.Now.Date;
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker.TabIndex = 17;
            this.dateTimePicker.Value = System.DateTime.Now.Date;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // CurrentCaloriesTextBox
            // 
            this.CurrentCaloriesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentCaloriesTextBox.Location = new System.Drawing.Point(455, 218);
            this.CurrentCaloriesTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 2);
            this.CurrentCaloriesTextBox.Name = "CurrentCaloriesTextBox";
            this.CurrentCaloriesTextBox.Size = new System.Drawing.Size(189, 23);
            this.CurrentCaloriesTextBox.TabIndex = 12;
            this.CurrentCaloriesTextBox.TextChanged += new System.EventHandler(this.CurrentCaloriesTextBox_TextChanged);
            // 
            // CurrentWeightTextBox
            // 
            this.CurrentWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentWeightTextBox.Location = new System.Drawing.Point(455, 165);
            this.CurrentWeightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentWeightTextBox.Name = "CurrentWeightTextBox";
            this.CurrentWeightTextBox.Size = new System.Drawing.Size(189, 23);
            this.CurrentWeightTextBox.TabIndex = 11;
            this.CurrentWeightTextBox.TextChanged += new System.EventHandler(this.CurrentWeightTextBox_TextChanged);
            // 
            // CaloriesLabel
            // 
            this.CaloriesLabel.AutoSize = true;
            this.CaloriesLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CaloriesLabel.Location = new System.Drawing.Point(397, 216);
            this.CaloriesLabel.Name = "CaloriesLabel";
            this.CaloriesLabel.Size = new System.Drawing.Size(52, 29);
            this.CaloriesLabel.TabIndex = 10;
            this.CaloriesLabel.Text = "Calories:";
            this.CaloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.WeightLabel.Location = new System.Drawing.Point(401, 137);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(48, 79);
            this.WeightLabel.TabIndex = 9;
            this.WeightLabel.Text = "Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WrongWeightLabel
            // 
            this.WrongWeightLabel.AutoSize = true;
            this.WrongWeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WrongWeightLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongWeightLabel.Location = new System.Drawing.Point(650, 216);
            this.WrongWeightLabel.Name = "WrongWeightLabel";
            this.WrongWeightLabel.Size = new System.Drawing.Size(117, 29);
            this.WrongWeightLabel.TabIndex = 14;
            this.WrongWeightLabel.Text = "Wrong data input";
            this.WrongWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MeasurementDateLabel
            // 
            this.MeasurementDateLabel.AutoSize = true;
            this.MeasurementDateLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MeasurementDateLabel.Location = new System.Drawing.Point(455, 122);
            this.MeasurementDateLabel.Name = "MeasurementDateLabel";
            this.MeasurementDateLabel.Size = new System.Drawing.Size(189, 15);
            this.MeasurementDateLabel.TabIndex = 18;
            this.MeasurementDateLabel.Text = "Measurements for [date]:";
            this.MeasurementDateLabel.Font = new System.Drawing.Font("Verdana", 09.80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MeasurementDateLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // 
            // UserForm
            // 
            //
            this.userPanel = new System.Windows.Forms.Panel();
            this.userTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancelCreatingUser = new System.Windows.Forms.Button();
            this.buttonApplyCreatingUser = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelWrongName = new System.Windows.Forms.Label();
            this.labelWrongDate = new System.Windows.Forms.Label();
            this.labelWrongHeight = new System.Windows.Forms.Label();
            this.panelGender = new System.Windows.Forms.Panel();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.pictureBoxCartmanPointing = new System.Windows.Forms.PictureBox();
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.userTableLayoutPanel);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Padding = new System.Windows.Forms.Padding(34, 40, 34, 40);
            this.userPanel.Size = new System.Drawing.Size(914, 600);
            this.userPanel.TabIndex = 0;
            // 
            // userTableLayoutPanel
            // 
            this.userTableLayoutPanel.ColumnCount = 10;
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.Controls.Add(this.buttonCancelCreatingUser, 0, 9);
            this.userTableLayoutPanel.Controls.Add(this.buttonApplyCreatingUser, 8, 9);
            this.userTableLayoutPanel.Controls.Add(this.labelName, 5, 1);
            this.userTableLayoutPanel.Controls.Add(this.labelDateOfBirth, 4, 3);
            this.userTableLayoutPanel.Controls.Add(this.labelGender, 5, 5);
            this.userTableLayoutPanel.Controls.Add(this.labelHeight, 5, 7);
            this.userTableLayoutPanel.Controls.Add(this.dateTimePickerDateOfBirth, 6, 3);
            this.userTableLayoutPanel.Controls.Add(this.textBoxName, 6, 1);
            this.userTableLayoutPanel.Controls.Add(this.textBoxHeight, 6, 7);
            this.userTableLayoutPanel.Controls.Add(this.labelWrongName, 6, 2);
            this.userTableLayoutPanel.Controls.Add(this.labelWrongDate, 6, 4);
            this.userTableLayoutPanel.Controls.Add(this.labelWrongHeight, 6, 8);
            this.userTableLayoutPanel.Controls.Add(this.panelGender, 6, 5);
            this.userTableLayoutPanel.Controls.Add(this.pictureBoxCartmanPointing, 0, 0);
            this.userTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTableLayoutPanel.Location = new System.Drawing.Point(34, 40);
            this.userTableLayoutPanel.Name = "userTableLayoutPanel";
            this.userTableLayoutPanel.RowCount = 10;
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.Size = new System.Drawing.Size(846, 520);
            this.userTableLayoutPanel.TabIndex = 0;
            // 
            // buttonCancelCreatingUser
            // 
            this.buttonCancelCreatingUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTableLayoutPanel.SetColumnSpan(this.buttonCancelCreatingUser, 2);
            this.buttonCancelCreatingUser.Location = new System.Drawing.Point(3, 471);
            this.buttonCancelCreatingUser.Name = "buttonCancelCreatingUser";
            this.buttonCancelCreatingUser.Size = new System.Drawing.Size(162, 46);
            this.buttonCancelCreatingUser.TabIndex = 0;
            this.buttonCancelCreatingUser.Text = "Cancel";
            this.buttonCancelCreatingUser.UseVisualStyleBackColor = true;
            this.buttonCancelCreatingUser.Click += new System.EventHandler(this.buttonCancelCreatingUser_Click);
            // 
            // buttonApplyCreatingUser
            // 
            this.buttonApplyCreatingUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTableLayoutPanel.SetColumnSpan(this.buttonApplyCreatingUser, 2);
            this.buttonApplyCreatingUser.Location = new System.Drawing.Point(675, 471);
            this.buttonApplyCreatingUser.Name = "buttonApplyCreatingUser";
            this.buttonApplyCreatingUser.Size = new System.Drawing.Size(168, 46);
            this.buttonApplyCreatingUser.TabIndex = 1;
            this.buttonApplyCreatingUser.Text = "OK";
            this.buttonApplyCreatingUser.UseVisualStyleBackColor = true;
            this.buttonApplyCreatingUser.Click += new System.EventHandler(this.buttonApplyCreatingUser_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelName.Location = new System.Drawing.Point(449, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 52);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.userTableLayoutPanel.SetColumnSpan(this.labelDateOfBirth, 2);
            this.labelDateOfBirth.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDateOfBirth.Location = new System.Drawing.Point(404, 156);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(97, 52);
            this.labelDateOfBirth.TabIndex = 3;
            this.labelDateOfBirth.Text = "Date of birth:";
            this.labelDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelGender.Location = new System.Drawing.Point(441, 260);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(60, 52);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelHeight.Location = new System.Drawing.Point(444, 364);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(57, 52);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Height:";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userTableLayoutPanel.SetColumnSpan(this.dateTimePickerDateOfBirth, 2);
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(507, 168);
            this.dateTimePickerDateOfBirth.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(162, 27);
            this.dateTimePickerDateOfBirth.TabIndex = 7;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2021, 10, 20, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.ValueChanged += new System.EventHandler(this.dateTimePickerDateOfBirth_ValueChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userTableLayoutPanel.SetColumnSpan(this.textBoxName, 3);
            this.textBoxName.Location = new System.Drawing.Point(507, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(246, 27);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userTableLayoutPanel.SetColumnSpan(this.textBoxHeight, 3);
            this.textBoxHeight.Location = new System.Drawing.Point(507, 376);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(246, 27);
            this.textBoxHeight.TabIndex = 10;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // labelWrongName
            // 
            this.labelWrongName.AutoSize = true;
            this.userTableLayoutPanel.SetColumnSpan(this.labelWrongName, 3);
            this.labelWrongName.ForeColor = System.Drawing.Color.Red;
            this.labelWrongName.Location = new System.Drawing.Point(507, 104);
            this.labelWrongName.Name = "labelWrongName";
            this.labelWrongName.Size = new System.Drawing.Size(0, 20);
            this.labelWrongName.TabIndex = 11;
            this.labelWrongName.Text = "Empty user name";
            // 
            // labelWrongDate
            // 
            this.labelWrongDate.AutoSize = true;
            this.userTableLayoutPanel.SetColumnSpan(this.labelWrongDate, 3);
            this.labelWrongDate.ForeColor = System.Drawing.Color.Red;
            this.labelWrongDate.Location = new System.Drawing.Point(507, 208);
            this.labelWrongDate.Name = "labelWrongDate";
            this.labelWrongDate.Size = new System.Drawing.Size(0, 20);
            this.labelWrongDate.TabIndex = 12;
            // 
            // labelWrongHeight
            // 
            this.labelWrongHeight.AutoSize = true;
            this.userTableLayoutPanel.SetColumnSpan(this.labelWrongHeight, 3);
            this.labelWrongHeight.ForeColor = System.Drawing.Color.Red;
            this.labelWrongHeight.Location = new System.Drawing.Point(507, 416);
            this.labelWrongHeight.Name = "labelWrongHeight";
            this.labelWrongHeight.Size = new System.Drawing.Size(0, 20);
            this.labelWrongHeight.TabIndex = 13;
            // 
            // panelGender
            // 
            this.userTableLayoutPanel.SetColumnSpan(this.panelGender, 3);
            this.panelGender.Controls.Add(this.radioButtonFemale);
            this.panelGender.Controls.Add(this.radioButtonMale);
            this.panelGender.Location = new System.Drawing.Point(507, 263);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(246, 46);
            this.panelGender.TabIndex = 14;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(22, 11);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(78, 24);
            this.radioButtonFemale.TabIndex = 8;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(144, 11);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(63, 24);
            this.radioButtonMale.TabIndex = 9;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCartmanPointing
            // 
            this.userTableLayoutPanel.SetColumnSpan(this.pictureBoxCartmanPointing, 4);
            this.pictureBoxCartmanPointing.Image = global::BeefCakeGUI.Properties.Resources.cartmanPointing;
            this.pictureBoxCartmanPointing.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCartmanPointing.Name = "pictureBoxCartmanPointing";
            this.userTableLayoutPanel.SetRowSpan(this.pictureBoxCartmanPointing, 8);
            this.pictureBoxCartmanPointing.Size = new System.Drawing.Size(330, 410);
            this.pictureBoxCartmanPointing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCartmanPointing.TabIndex = 15;
            this.pictureBoxCartmanPointing.TabStop = false;
            //
            //
            //
            this.ResumeLayout(false);
        }

        // 
        // LoginForm
        // 
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TableLayoutPanel loginTableLayoutPanel;
        private System.Windows.Forms.Label loginWelcomeLabel;
        private System.Windows.Forms.Label loginSelectUserLabel;
        private System.Windows.Forms.ComboBox loginUsersComboBox;
        private System.Windows.Forms.Button loginGraphButton;
        private System.Windows.Forms.Button loginUserButton;
        private System.Windows.Forms.Label loginAddUserLabel;
        private System.Windows.Forms.PictureBox loginWelcomePictureBox;
        //
        // GraphForm
        //
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.TableLayoutPanel graphTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel graphMenuTableLayoutPanel;
        private System.Windows.Forms.Label graphMenuLabel;
        private System.Windows.Forms.Button graphToMeasurementButton;
        private System.Windows.Forms.Button graphToUserButton;
        private System.Windows.Forms.Button graphToLoginButton;
        // 
        // MeasurementForm
        // 
        private System.Windows.Forms.Panel measurementPanel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.PictureBox MeasurementPicture;
        private System.Windows.Forms.Button ApplyAddingData;
        private System.Windows.Forms.Label WrongCaloriesLabel;
        private System.Windows.Forms.Label BmiCommentLabel;
        private System.Windows.Forms.Label BmiLabel;
        private System.Windows.Forms.Label CurrentBmiLabel;
        private System.Windows.Forms.Button CancelBmiButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox CurrentCaloriesTextBox;
        private System.Windows.Forms.TextBox CurrentWeightTextBox;
        private System.Windows.Forms.Label CaloriesLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label WrongWeightLabel;
        private System.Windows.Forms.Label MeasurementDateLabel;
        //
        // UserForm
        //
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.TableLayoutPanel userTableLayoutPanel;
        private System.Windows.Forms.Button buttonCancelCreatingUser;
        private System.Windows.Forms.Button buttonApplyCreatingUser;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelWrongName;
        private System.Windows.Forms.Label labelWrongDate;
        private System.Windows.Forms.Label labelWrongHeight;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.PictureBox pictureBoxCartmanPointing;
    }
}
