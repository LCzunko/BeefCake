
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
            this.BmiLabel = new System.Windows.Forms.Label();
            this.BmiCommentLabel = new System.Windows.Forms.Label();
            this.CancelAddingData = new System.Windows.Forms.Button();
            this.ApplyAddingData = new System.Windows.Forms.Button();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CaloriesLabel = new System.Windows.Forms.Label();
            this.CurrentWeightTextBox = new System.Windows.Forms.TextBox();
            this.CurrentCaloriesTextBox = new System.Windows.Forms.TextBox();
            this.CurrentBmiLabel = new System.Windows.Forms.Label();
            this.WrongWeightLabel = new System.Windows.Forms.Label();
            this.WrongCaloriesLabel = new System.Windows.Forms.Label();
            this.MeasurementPanel.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurementPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.MeasurementPanel.AutoSize = true;
            this.MeasurementPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MeasurementPanel.Controls.Add(this.TableLayoutPanel);
            this.MeasurementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasurementPanel.Location = new System.Drawing.Point(0, 0);
            this.MeasurementPanel.Name = "panel1";
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
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.TableLayoutPanel.Controls.Add(this.MeasurementPicture, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.BmiLabel, 0, 4);
            this.TableLayoutPanel.Controls.Add(this.BmiCommentLabel, 0, 5);
            this.TableLayoutPanel.Controls.Add(this.CancelAddingData, 0, 6);
            this.TableLayoutPanel.Controls.Add(this.ApplyAddingData, 4, 6);
            this.TableLayoutPanel.Controls.Add(this.WeightLabel, 2, 1);
            this.TableLayoutPanel.Controls.Add(this.CaloriesLabel, 2, 2);
            this.TableLayoutPanel.Controls.Add(this.CurrentWeightTextBox, 3, 1);
            this.TableLayoutPanel.Controls.Add(this.CurrentCaloriesTextBox, 3, 2);
            this.TableLayoutPanel.Controls.Add(this.CurrentBmiLabel, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.WrongWeightLabel, 4, 1);
            this.TableLayoutPanel.Controls.Add(this.WrongCaloriesLabel, 4, 2);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(30);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.Padding = new System.Windows.Forms.Padding(30);
            this.TableLayoutPanel.RowCount = 7;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.21212F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.78788F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.TableLayoutPanel.TabIndex = 0;
            this.TableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // MeasurementPicture
            // 
            this.TableLayoutPanel.SetColumnSpan(this.MeasurementPicture, 2);
            this.MeasurementPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasurementPicture.Image = global::BeefCakeGUI.Properties.Resources.CartmanAlterEgoObese;
            this.MeasurementPicture.Location = new System.Drawing.Point(33, 33);
            this.MeasurementPicture.Name = "MeasurementPicture";
            this.TableLayoutPanel.SetRowSpan(this.MeasurementPicture, 4);
            this.MeasurementPicture.Size = new System.Drawing.Size(284, 290);
            this.MeasurementPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MeasurementPicture.TabIndex = 3;
            this.MeasurementPicture.TabStop = false;
            // 
            // BmiLabel
            // 
            this.BmiLabel.AutoSize = true;
            this.BmiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BmiLabel.Location = new System.Drawing.Point(80, 326);
            this.BmiLabel.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.BmiLabel.Name = "BmiLabel";
            this.BmiLabel.Size = new System.Drawing.Size(61, 31);
            this.BmiLabel.TabIndex = 4;
            this.BmiLabel.Text = "BMI:";
            this.BmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BmiCommentLabel
            // 
            this.BmiCommentLabel.AutoSize = true;
            this.TableLayoutPanel.SetColumnSpan(this.BmiCommentLabel, 2);
            this.BmiCommentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BmiCommentLabel.Location = new System.Drawing.Point(80, 357);
            this.BmiCommentLabel.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.BmiCommentLabel.Name = "BmiCommentLabel";
            this.BmiCommentLabel.Size = new System.Drawing.Size(237, 30);
            this.BmiCommentLabel.TabIndex = 6;
            this.BmiCommentLabel.Text = "Keep up the good work!";
            this.BmiCommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelAddingData
            // 
            this.CancelAddingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelAddingData.Location = new System.Drawing.Point(33, 390);
            this.CancelAddingData.Name = "CancelAddingData";
            this.CancelAddingData.Size = new System.Drawing.Size(108, 27);
            this.CancelAddingData.TabIndex = 7;
            this.CancelAddingData.Text = "Cancel";
            this.CancelAddingData.UseVisualStyleBackColor = true;
            // 
            // ApplyAddingData
            // 
            this.ApplyAddingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyAddingData.Location = new System.Drawing.Point(648, 390);
            this.ApplyAddingData.Name = "ApplyAddingData";
            this.ApplyAddingData.Size = new System.Drawing.Size(119, 27);
            this.ApplyAddingData.TabIndex = 8;
            this.ApplyAddingData.Text = "OK";
            this.ApplyAddingData.UseVisualStyleBackColor = true;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeightLabel.Location = new System.Drawing.Point(323, 141);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(96, 44);
            this.WeightLabel.TabIndex = 9;
            this.WeightLabel.Text = "Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CaloriesLabel
            // 
            this.CaloriesLabel.AutoSize = true;
            this.CaloriesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaloriesLabel.Location = new System.Drawing.Point(323, 185);
            this.CaloriesLabel.Name = "CaloriesLabel";
            this.CaloriesLabel.Size = new System.Drawing.Size(96, 60);
            this.CaloriesLabel.TabIndex = 10;
            this.CaloriesLabel.Text = "Calories:";
            this.CaloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentWeightTextBox
            // 
            this.CurrentWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentWeightTextBox.Location = new System.Drawing.Point(425, 151);
            this.CurrentWeightTextBox.Name = "CurrentWeightTextBox";
            this.CurrentWeightTextBox.Size = new System.Drawing.Size(217, 23);
            this.CurrentWeightTextBox.TabIndex = 11;
            // 
            // CurrentCaloriesTextBox
            // 
            this.CurrentCaloriesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentCaloriesTextBox.Location = new System.Drawing.Point(425, 203);
            this.CurrentCaloriesTextBox.Name = "CurrentCaloriesTextBox";
            this.CurrentCaloriesTextBox.Size = new System.Drawing.Size(217, 23);
            this.CurrentCaloriesTextBox.TabIndex = 12;
            // 
            // CurrentBmiLabel
            // 
            this.CurrentBmiLabel.AutoSize = true;
            this.CurrentBmiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentBmiLabel.Location = new System.Drawing.Point(147, 326);
            this.CurrentBmiLabel.Name = "CurrentBmiLabel";
            this.CurrentBmiLabel.Size = new System.Drawing.Size(170, 31);
            this.CurrentBmiLabel.TabIndex = 13;
            this.CurrentBmiLabel.Text = "22.5";
            this.CurrentBmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WrongWeightLabel
            // 
            this.WrongWeightLabel.AutoSize = true;
            this.WrongWeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WrongWeightLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongWeightLabel.Location = new System.Drawing.Point(648, 141);
            this.WrongWeightLabel.Name = "WrongWeightLabel";
            this.WrongWeightLabel.Size = new System.Drawing.Size(119, 44);
            this.WrongWeightLabel.TabIndex = 14;
            this.WrongWeightLabel.Text = "Wrong data input";
            this.WrongWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WrongCaloriesLabel
            // 
            this.WrongCaloriesLabel.AutoSize = true;
            this.WrongCaloriesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WrongCaloriesLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongCaloriesLabel.Location = new System.Drawing.Point(648, 185);
            this.WrongCaloriesLabel.Name = "WrongCaloriesLabel";
            this.WrongCaloriesLabel.Size = new System.Drawing.Size(119, 60);
            this.WrongCaloriesLabel.TabIndex = 15;
            this.WrongCaloriesLabel.Text = "Wrong data input";
            this.WrongCaloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
        private System.Windows.Forms.Label BmiLabel;
        private System.Windows.Forms.Label BmiCommentLabel;
        private System.Windows.Forms.Button CancelAddingData;
        private System.Windows.Forms.Button ApplyAddingData;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label CaloriesLabel;
        private System.Windows.Forms.TextBox CurrentWeightTextBox;
        private System.Windows.Forms.TextBox CurrentCaloriesTextBox;
        private System.Windows.Forms.Label CurrentBmiLabel;
        private System.Windows.Forms.Label WrongWeightLabel;
        private System.Windows.Forms.Label WrongCaloriesLabel;
    }
}