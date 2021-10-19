
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
            this.userAddButton = new System.Windows.Forms.Button();
            this.addUserLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.selectUserLabel = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.userConfirmButton = new System.Windows.Forms.Button();
            this.welcomePictureBox = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            this.loginTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).BeginInit();
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
            this.loginTableLayoutPanel.Controls.Add(this.userAddButton, 0, 4);
            this.loginTableLayoutPanel.Controls.Add(this.addUserLabel, 0, 3);
            this.loginTableLayoutPanel.Controls.Add(this.welcomeLabel, 0, 0);
            this.loginTableLayoutPanel.Controls.Add(this.selectUserLabel, 0, 1);
            this.loginTableLayoutPanel.Controls.Add(this.usersComboBox, 0, 2);
            this.loginTableLayoutPanel.Controls.Add(this.userConfirmButton, 2, 2);
            this.loginTableLayoutPanel.Controls.Add(this.welcomePictureBox, 3, 1);
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
            // userAddButton
            // 
            this.userAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAddButton.Image = global::BeefCakeGUI.Properties.Resources.Add_16x;
            this.userAddButton.Location = new System.Drawing.Point(10, 273);
            this.userAddButton.Margin = new System.Windows.Forms.Padding(10, 9, 6, 92);
            this.userAddButton.Name = "userAddButton";
            this.userAddButton.Size = new System.Drawing.Size(58, 25);
            this.userAddButton.TabIndex = 5;
            this.userAddButton.UseVisualStyleBackColor = true;
            this.userAddButton.Click += new System.EventHandler(this.userAddButton_Click);
            // 
            // addUserLabel
            // 
            this.addUserLabel.AutoSize = true;
            this.loginTableLayoutPanel.SetColumnSpan(this.addUserLabel, 3);
            this.addUserLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addUserLabel.Location = new System.Drawing.Point(0, 249);
            this.addUserLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Padding = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.addUserLabel.Size = new System.Drawing.Size(370, 15);
            this.addUserLabel.TabIndex = 4;
            this.addUserLabel.Text = "Or register as a new user:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTableLayoutPanel.SetColumnSpan(this.welcomeLabel, 4);
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Padding = new System.Windows.Forms.Padding(10, 10, 13, 10);
            this.welcomeLabel.Size = new System.Drawing.Size(740, 95);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to BEEFCAKE!\r\n\r\nThe best health app. Track your weight and calorie intake" +
    ", calculate your BMI.\r\n\r\nGet in shape FAST. Look your BEST. Use BEEFCAKE!";
            // 
            // selectUserLabel
            // 
            this.selectUserLabel.AutoSize = true;
            this.loginTableLayoutPanel.SetColumnSpan(this.selectUserLabel, 3);
            this.selectUserLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectUserLabel.Location = new System.Drawing.Point(0, 162);
            this.selectUserLabel.Margin = new System.Windows.Forms.Padding(0);
            this.selectUserLabel.Name = "selectUserLabel";
            this.selectUserLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.selectUserLabel.Size = new System.Drawing.Size(370, 15);
            this.selectUserLabel.TabIndex = 1;
            this.selectUserLabel.Text = "Log in as an existing user:";
            // 
            // usersComboBox
            // 
            this.loginTableLayoutPanel.SetColumnSpan(this.usersComboBox, 2);
            this.usersComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(13, 187);
            this.usersComboBox.Margin = new System.Windows.Forms.Padding(13, 10, 0, 0);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(283, 23);
            this.usersComboBox.TabIndex = 2;
            // 
            // userConfirmButton
            // 
            this.userConfirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userConfirmButton.Image = global::BeefCakeGUI.Properties.Resources.Checkmark_16x;
            this.userConfirmButton.Location = new System.Drawing.Point(304, 186);
            this.userConfirmButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 24);
            this.userConfirmButton.Name = "userConfirmButton";
            this.userConfirmButton.Size = new System.Drawing.Size(58, 25);
            this.userConfirmButton.TabIndex = 3;
            this.userConfirmButton.UseVisualStyleBackColor = true;
            this.userConfirmButton.Click += new System.EventHandler(this.userConfirmButton_Click);
            // 
            // welcomePictureBox
            // 
            this.welcomePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePictureBox.Image = global::BeefCakeGUI.Properties.Resources.Cartman_Beefcake;
            this.welcomePictureBox.Location = new System.Drawing.Point(370, 107);
            this.welcomePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.welcomePictureBox.Name = "welcomePictureBox";
            this.loginTableLayoutPanel.SetRowSpan(this.welcomePictureBox, 4);
            this.welcomePictureBox.Size = new System.Drawing.Size(370, 283);
            this.welcomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.welcomePictureBox.TabIndex = 6;
            this.welcomePictureBox.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TableLayoutPanel loginTableLayoutPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label selectUserLabel;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Button userConfirmButton;
        private System.Windows.Forms.Button userAddButton;
        private System.Windows.Forms.Label addUserLabel;
        private System.Windows.Forms.PictureBox welcomePictureBox;
    }
}