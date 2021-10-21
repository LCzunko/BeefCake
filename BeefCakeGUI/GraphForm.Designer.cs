
namespace BeefCakeGUI
{
    partial class GraphForm
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
            this.graphPanel = new System.Windows.Forms.Panel();
            this.graphTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.graphMenuTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.graphToLoginButton = new System.Windows.Forms.Button();
            this.graphToUserButton = new System.Windows.Forms.Button();
            this.graphToMeasurementButton = new System.Windows.Forms.Button();
            this.graphMenuLabel = new System.Windows.Forms.Label();
            this.graphPanel.SuspendLayout();
            this.graphTableLayoutPanel.SuspendLayout();
            this.graphMenuTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graphPanel);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.graphPanel.ResumeLayout(false);
            this.graphTableLayoutPanel.ResumeLayout(false);
            this.graphMenuTableLayoutPanel.ResumeLayout(false);
            this.graphMenuTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.TableLayoutPanel graphTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel graphMenuTableLayoutPanel;
        private System.Windows.Forms.Label graphMenuLabel;
        private System.Windows.Forms.Button graphToMeasurementButton;
        private System.Windows.Forms.Button graphToUserButton;
        private System.Windows.Forms.Button graphToLoginButton;
    }
}