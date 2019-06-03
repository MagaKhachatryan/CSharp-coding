namespace GareageForm
{
    partial class AddWindow
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
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MaxSpeedLabel = new System.Windows.Forms.Label();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(20, 172);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(122, 20);
            this.YearTextBox.TabIndex = 2;
            this.YearTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.YearTextBox_Validating);
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(18, 219);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(102, 20);
            this.MaxSpeedTextBox.TabIndex = 4;
            this.MaxSpeedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MaxSpeedTextBox_Validating);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(17, 9);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Model";
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(18, 25);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(169, 21);
            this.ModelComboBox.TabIndex = 6;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(16, 59);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 7;
            this.CountryLabel.Text = "Country";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(16, 104);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 8;
            this.ColorLabel.Text = "Color";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(16, 156);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 9;
            this.YearLabel.Text = "Year";
            // 
            // MaxSpeedLabel
            // 
            this.MaxSpeedLabel.AutoSize = true;
            this.MaxSpeedLabel.Location = new System.Drawing.Point(16, 203);
            this.MaxSpeedLabel.Name = "MaxSpeedLabel";
            this.MaxSpeedLabel.Size = new System.Drawing.Size(61, 13);
            this.MaxSpeedLabel.TabIndex = 10;
            this.MaxSpeedLabel.Text = "Max Speed";
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(20, 75);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(151, 21);
            this.CountryComboBox.TabIndex = 11;
            this.CountryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(19, 120);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(138, 21);
            this.ColorComboBox.TabIndex = 12;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(110, 263);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(47, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(19, 263);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(48, 23);
            this.OkButton.TabIndex = 15;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddWindow
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 298);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.CountryComboBox);
            this.Controls.Add(this.MaxSpeedLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.ModelComboBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.MaxSpeedTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Name = "AddWindow";
            this.Text = "AddWindow";
            this.Load += new System.EventHandler(this.AddWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox MaxSpeedTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label MaxSpeedLabel;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}