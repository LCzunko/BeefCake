
namespace BeefCakeGUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loginUserButton = new System.Windows.Forms.Button();
            this.loginAddUserLabel = new System.Windows.Forms.Label();
            this.loginWelcomeLabel = new System.Windows.Forms.Label();
            this.loginSelectUserLabel = new System.Windows.Forms.Label();
            this.loginUsersComboBox = new System.Windows.Forms.ComboBox();
            this.loginGraphButton = new System.Windows.Forms.Button();
            this.loginWelcomePictureBox = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            this.loginTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginWelcomePictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.loginTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LoginForm";
            this.loginPanel.ResumeLayout(false);
            this.loginTableLayoutPanel.ResumeLayout(false);
            this.loginTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginWelcomePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TableLayoutPanel loginTableLayoutPanel;
        private System.Windows.Forms.Label loginWelcomeLabel;
        private System.Windows.Forms.Label loginSelectUserLabel;
        private System.Windows.Forms.ComboBox loginUsersComboBox;
        private System.Windows.Forms.Button loginGraphButton;
        private System.Windows.Forms.Button loginUserButton;
        private System.Windows.Forms.Label loginAddUserLabel;
        private System.Windows.Forms.PictureBox loginWelcomePictureBox;
    }
}