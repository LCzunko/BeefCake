
namespace BeefCakeGUI
{
    partial class Form2
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
            this.MeasurementPanel = new System.Windows.Forms.Panel();
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
            this.MeasurementPanel.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurementPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MeasurementPanel
            // 
            this.MeasurementPanel.AutoSize = true;
            this.MeasurementPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MeasurementPanel.Controls.Add(this.TableLayoutPanel);
            this.MeasurementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasurementPanel.Location = new System.Drawing.Point(0, 0);
            this.MeasurementPanel.Name = "MeasurementPanel";
            this.MeasurementPanel.Size = new System.Drawing.Size(800, 450);
            this.MeasurementPanel.TabIndex = 0;
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 5;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.31034F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.68966F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.TableLayoutPanel.Controls.Add(this.MeasurementPicture, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.ApplyAddingData, 4, 6);
            this.TableLayoutPanel.Controls.Add(this.WrongCaloriesLabel, 4, 2);
            this.TableLayoutPanel.Controls.Add(this.BmiCommentLabel, 0, 6);
            this.TableLayoutPanel.Controls.Add(this.BmiLabel, 0, 5);
            this.TableLayoutPanel.Controls.Add(this.CurrentBmiLabel, 1, 5);
            this.TableLayoutPanel.Controls.Add(this.CancelBmiButton, 3, 6);
            this.TableLayoutPanel.Controls.Add(this.dateTimePicker, 3, 0);
            this.TableLayoutPanel.Controls.Add(this.CurrentCaloriesTextBox, 3, 3);
            this.TableLayoutPanel.Controls.Add(this.CurrentWeightTextBox, 3, 2);
            this.TableLayoutPanel.Controls.Add(this.CaloriesLabel, 2, 3);
            this.TableLayoutPanel.Controls.Add(this.WeightLabel, 2, 2);
            this.TableLayoutPanel.Controls.Add(this.WrongWeightLabel, 4, 3);
            this.TableLayoutPanel.Controls.Add(this.MeasurementDateLabel, 3, 1);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(30);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.Padding = new System.Windows.Forms.Padding(30);
            this.TableLayoutPanel.RowCount = 7;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83871F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.16129F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
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
            this.MeasurementPicture.Location = new System.Drawing.Point(33, 33);
            this.MeasurementPicture.Name = "MeasurementPicture";
            this.TableLayoutPanel.SetRowSpan(this.MeasurementPicture, 5);
            this.MeasurementPicture.Size = new System.Drawing.Size(271, 303);
            this.MeasurementPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MeasurementPicture.TabIndex = 3;
            this.MeasurementPicture.TabStop = false;
            // 
            // ApplyAddingData
            // 
            this.ApplyAddingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyAddingData.Location = new System.Drawing.Point(635, 391);
            this.ApplyAddingData.Name = "ApplyAddingData";
            this.ApplyAddingData.Size = new System.Drawing.Size(132, 26);
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
            this.WrongCaloriesLabel.Location = new System.Drawing.Point(635, 137);
            this.WrongCaloriesLabel.Name = "WrongCaloriesLabel";
            this.WrongCaloriesLabel.Size = new System.Drawing.Size(132, 79);
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
            this.BmiLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BmiLabel.Location = new System.Drawing.Point(73, 339);
            this.BmiLabel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
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
            this.CurrentBmiLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentBmiLabel.Location = new System.Drawing.Point(142, 339);
            this.CurrentBmiLabel.Name = "CurrentBmiLabel";
            this.CurrentBmiLabel.Size = new System.Drawing.Size(32, 49);
            this.CurrentBmiLabel.TabIndex = 13;
            this.CurrentBmiLabel.Text = "22.5";
            this.CurrentBmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelBmiButton
            // 
            this.CancelBmiButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBmiButton.Location = new System.Drawing.Point(495, 391);
            this.CancelBmiButton.Name = "CancelBmiButton";
            this.CancelBmiButton.Size = new System.Drawing.Size(134, 26);
            this.CancelBmiButton.TabIndex = 16;
            this.CancelBmiButton.Text = "Cancel";
            this.CancelBmiButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(412, 33);
            this.dateTimePicker.MaxDate = new System.DateTime(2021, 10, 20, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(217, 23);
            this.dateTimePicker.TabIndex = 17;
            this.dateTimePicker.Value = new System.DateTime(2021, 10, 20, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // CurrentCaloriesTextBox
            // 
            this.CurrentCaloriesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentCaloriesTextBox.Location = new System.Drawing.Point(412, 219);
            this.CurrentCaloriesTextBox.Name = "CurrentCaloriesTextBox";
            this.CurrentCaloriesTextBox.Size = new System.Drawing.Size(217, 23);
            this.CurrentCaloriesTextBox.TabIndex = 12;
            this.CurrentCaloriesTextBox.TextChanged += new System.EventHandler(this.CurrentCaloriesTextBox_TextChanged);
            // 
            // CurrentWeightTextBox
            // 
            this.CurrentWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentWeightTextBox.Location = new System.Drawing.Point(412, 165);
            this.CurrentWeightTextBox.Name = "CurrentWeightTextBox";
            this.CurrentWeightTextBox.Size = new System.Drawing.Size(217, 23);
            this.CurrentWeightTextBox.TabIndex = 11;
            this.CurrentWeightTextBox.TextChanged += new System.EventHandler(this.CurrentWeightTextBox_TextChanged);
            // 
            // CaloriesLabel
            // 
            this.CaloriesLabel.AutoSize = true;
            this.CaloriesLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CaloriesLabel.Location = new System.Drawing.Point(354, 216);
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
            this.WeightLabel.Location = new System.Drawing.Point(358, 137);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(48, 79);
            this.WeightLabel.TabIndex = 9;
            this.WeightLabel.Text = "Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WrongWeightLabel
            // 
            this.WrongWeightLabel.AutoSize = true;
            this.WrongWeightLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.WrongWeightLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongWeightLabel.Location = new System.Drawing.Point(635, 216);
            this.WrongWeightLabel.Name = "WrongWeightLabel";
            this.WrongWeightLabel.Size = new System.Drawing.Size(100, 29);
            this.WrongWeightLabel.TabIndex = 14;
            this.WrongWeightLabel.Text = "Wrong data input";
            this.WrongWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MeasurementDateLabel
            // 
            this.MeasurementDateLabel.AutoSize = true;
            this.MeasurementDateLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MeasurementDateLabel.Location = new System.Drawing.Point(412, 122);
            this.MeasurementDateLabel.Name = "MeasurementDateLabel";
            this.MeasurementDateLabel.Size = new System.Drawing.Size(217, 15);
            this.MeasurementDateLabel.TabIndex = 18;
            this.MeasurementDateLabel.Text = "Measurements for [date]:";
            this.MeasurementDateLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MeasurementPanel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MeasurementPanel.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurementPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MeasurementPanel;
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
    }
}