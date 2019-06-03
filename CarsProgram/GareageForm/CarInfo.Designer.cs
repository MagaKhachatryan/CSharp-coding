namespace CarsProgram
{
    partial class CarInfo
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
            this.CarsLabel = new System.Windows.Forms.Label();
            this.CarsComboBox = new System.Windows.Forms.ComboBox();
            this.CarModelLabel = new System.Windows.Forms.Label();
            this.CarIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarModelTetBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MaxSpeedLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CarsLabel
            // 
            this.CarsLabel.AutoSize = true;
            this.CarsLabel.Location = new System.Drawing.Point(12, 18);
            this.CarsLabel.Name = "CarsLabel";
            this.CarsLabel.Size = new System.Drawing.Size(28, 13);
            this.CarsLabel.TabIndex = 0;
            this.CarsLabel.Text = "Cars";
            // 
            // CarsComboBox
            // 
            this.CarsComboBox.FormattingEnabled = true;
            this.CarsComboBox.Location = new System.Drawing.Point(12, 34);
            this.CarsComboBox.Name = "CarsComboBox";
            this.CarsComboBox.Size = new System.Drawing.Size(176, 21);
            this.CarsComboBox.TabIndex = 1;
            this.CarsComboBox.SelectedIndexChanged += new System.EventHandler(this.CarsComboBox_SelectedIndexChanged);
            // 
            // CarModelLabel
            // 
            this.CarModelLabel.AutoSize = true;
            this.CarModelLabel.Location = new System.Drawing.Point(12, 118);
            this.CarModelLabel.Name = "CarModelLabel";
            this.CarModelLabel.Size = new System.Drawing.Size(36, 13);
            this.CarModelLabel.TabIndex = 2;
            this.CarModelLabel.Text = "Model";
            this.CarModelLabel.Click += new System.EventHandler(this.CarModelLabel_Click);
            // 
            // CarIdTextBox
            // 
            this.CarIdTextBox.Location = new System.Drawing.Point(15, 84);
            this.CarIdTextBox.Name = "CarIdTextBox";
            this.CarIdTextBox.Size = new System.Drawing.Size(157, 20);
            this.CarIdTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarModelTetBox
            // 
            this.CarModelTetBox.Location = new System.Drawing.Point(15, 134);
            this.CarModelTetBox.Name = "CarModelTetBox";
            this.CarModelTetBox.Size = new System.Drawing.Size(143, 20);
            this.CarModelTetBox.TabIndex = 5;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(13, 169);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 6;
            this.CountryLabel.Text = "Country";
            this.CountryLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(13, 221);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color";
            this.ColorLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(9, 273);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 8;
            this.YearLabel.Text = "Year";
            // 
            // MaxSpeedLabel
            // 
            this.MaxSpeedLabel.AutoSize = true;
            this.MaxSpeedLabel.Location = new System.Drawing.Point(73, 273);
            this.MaxSpeedLabel.Name = "MaxSpeedLabel";
            this.MaxSpeedLabel.Size = new System.Drawing.Size(61, 13);
            this.MaxSpeedLabel.TabIndex = 9;
            this.MaxSpeedLabel.Text = "Max Speed";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(15, 185);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(126, 20);
            this.CountryTextBox.TabIndex = 10;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(12, 238);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(111, 20);
            this.ColorTextBox.TabIndex = 11;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(12, 289);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(44, 20);
            this.YearTextBox.TabIndex = 12;
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(76, 289);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(47, 20);
            this.MaxSpeedTextBox.TabIndex = 13;
            // 
            // CarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 326);
            this.Controls.Add(this.MaxSpeedTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.MaxSpeedLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.CarModelTetBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarIdTextBox);
            this.Controls.Add(this.CarModelLabel);
            this.Controls.Add(this.CarsComboBox);
            this.Controls.Add(this.CarsLabel);
            this.Name = "CarInfo";
            this.Text = "CarInfo";
            this.Load += new System.EventHandler(this.CarInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarsLabel;
        private System.Windows.Forms.ComboBox CarsComboBox;
        private System.Windows.Forms.Label CarModelLabel;
        private System.Windows.Forms.TextBox CarIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CarModelTetBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label MaxSpeedLabel;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox MaxSpeedTextBox;
    }
}