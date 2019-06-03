namespace GareageForm
{
    partial class RemoveWindow
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
            this.CarsRemoveComboBox = new System.Windows.Forms.ComboBox();
            this.CarsRemoveLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarsRemoveComboBox
            // 
            this.CarsRemoveComboBox.FormattingEnabled = true;
            this.CarsRemoveComboBox.Location = new System.Drawing.Point(12, 52);
            this.CarsRemoveComboBox.Name = "CarsRemoveComboBox";
            this.CarsRemoveComboBox.Size = new System.Drawing.Size(121, 21);
            this.CarsRemoveComboBox.TabIndex = 0;
            // 
            // CarsRemoveLabel
            // 
            this.CarsRemoveLabel.AutoSize = true;
            this.CarsRemoveLabel.Location = new System.Drawing.Point(12, 25);
            this.CarsRemoveLabel.Name = "CarsRemoveLabel";
            this.CarsRemoveLabel.Size = new System.Drawing.Size(42, 13);
            this.CarsRemoveLabel.TabIndex = 1;
            this.CarsRemoveLabel.Text = "All Cars";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 89);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(51, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(83, 89);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(50, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RemoveWindow
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(158, 124);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CarsRemoveLabel);
            this.Controls.Add(this.CarsRemoveComboBox);
            this.Name = "RemoveWindow";
            this.Text = "RemoveWindow";
            this.Load += new System.EventHandler(this.RemoveWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CarsRemoveComboBox;
        private System.Windows.Forms.Label CarsRemoveLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}