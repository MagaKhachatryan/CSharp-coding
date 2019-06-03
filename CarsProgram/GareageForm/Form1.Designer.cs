namespace GareageForm
{
    partial class GareageForm
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
            this.CarTable = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxSpeedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTheCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByMaxSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByYearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarTable
            // 
            this.CarTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.CarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.ModelColumn,
            this.YearColumn,
            this.CountryColumn,
            this.ColourColumn,
            this.MaxSpeedColumn,
            this.QuantityColumn});
            this.CarTable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.CarTable.Location = new System.Drawing.Point(12, 53);
            this.CarTable.Name = "CarTable";
            this.CarTable.Size = new System.Drawing.Size(749, 333);
            this.CarTable.TabIndex = 0;
            this.CarTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarTable_CellContentClick);
            this.CarTable.DoubleClick += new System.EventHandler(this.CarTable_DoubleClick);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Model";
            this.ModelColumn.Name = "ModelColumn";
            // 
            // YearColumn
            // 
            this.YearColumn.HeaderText = "Year";
            this.YearColumn.Name = "YearColumn";
            // 
            // CountryColumn
            // 
            this.CountryColumn.HeaderText = "Country";
            this.CountryColumn.Name = "CountryColumn";
            // 
            // ColourColumn
            // 
            this.ColourColumn.HeaderText = "Color";
            this.ColourColumn.Name = "ColourColumn";
            // 
            // MaxSpeedColumn
            // 
            this.MaxSpeedColumn.HeaderText = "MaxSpeed";
            this.MaxSpeedColumn.Name = "MaxSpeedColumn";
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRemoveToolStripMenuItem,
            this.sortingToolStripMenuItem,
            this.carInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRemoveToolStripMenuItem
            // 
            this.addRemoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCarToolStripMenuItem,
            this.removeTheCarToolStripMenuItem});
            this.addRemoveToolStripMenuItem.Name = "addRemoveToolStripMenuItem";
            this.addRemoveToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.addRemoveToolStripMenuItem.Text = "Add/Remove";
            // 
            // addNewCarToolStripMenuItem
            // 
            this.addNewCarToolStripMenuItem.Name = "addNewCarToolStripMenuItem";
            this.addNewCarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addNewCarToolStripMenuItem.Text = "Add New Car";
            this.addNewCarToolStripMenuItem.Click += new System.EventHandler(this.addNewCarToolStripMenuItem_Click);
            // 
            // removeTheCarToolStripMenuItem
            // 
            this.removeTheCarToolStripMenuItem.Name = "removeTheCarToolStripMenuItem";
            this.removeTheCarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removeTheCarToolStripMenuItem.Text = "Remove The Car";
            this.removeTheCarToolStripMenuItem.Click += new System.EventHandler(this.removeTheCarToolStripMenuItem_Click);
            // 
            // sortingToolStripMenuItem
            // 
            this.sortingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByYearToolStripMenuItem,
            this.sortByToolStripMenuItem,
            this.sortByMaxSpeedToolStripMenuItem,
            this.sortByYearToolStripMenuItem1,
            this.sortByCountryToolStripMenuItem});
            this.sortingToolStripMenuItem.Name = "sortingToolStripMenuItem";
            this.sortingToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.sortingToolStripMenuItem.Text = "Sorting";
            // 
            // sortByYearToolStripMenuItem
            // 
            this.sortByYearToolStripMenuItem.Name = "sortByYearToolStripMenuItem";
            this.sortByYearToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sortByYearToolStripMenuItem.Text = "Sort By Year";
            this.sortByYearToolStripMenuItem.Click += new System.EventHandler(this.sortByYearToolStripMenuItem_Click);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sortByToolStripMenuItem.Text = "Sort by Model";
            this.sortByToolStripMenuItem.Click += new System.EventHandler(this.sortByToolStripMenuItem_Click);
            // 
            // sortByMaxSpeedToolStripMenuItem
            // 
            this.sortByMaxSpeedToolStripMenuItem.Name = "sortByMaxSpeedToolStripMenuItem";
            this.sortByMaxSpeedToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sortByMaxSpeedToolStripMenuItem.Text = "Sort By Max Speed";
            this.sortByMaxSpeedToolStripMenuItem.Click += new System.EventHandler(this.sortByMaxSpeedToolStripMenuItem_Click);
            // 
            // sortByYearToolStripMenuItem1
            // 
            this.sortByYearToolStripMenuItem1.Name = "sortByYearToolStripMenuItem1";
            this.sortByYearToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.sortByYearToolStripMenuItem1.Text = "Sort By Color";
            this.sortByYearToolStripMenuItem1.Click += new System.EventHandler(this.sortByYearToolStripMenuItem1_Click);
            // 
            // sortByCountryToolStripMenuItem
            // 
            this.sortByCountryToolStripMenuItem.Name = "sortByCountryToolStripMenuItem";
            this.sortByCountryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sortByCountryToolStripMenuItem.Text = "Sort By Country";
            this.sortByCountryToolStripMenuItem.Click += new System.EventHandler(this.sortByCountryToolStripMenuItem_Click);
            // 
            // carInfoToolStripMenuItem
            // 
            this.carInfoToolStripMenuItem.Name = "carInfoToolStripMenuItem";
            this.carInfoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.carInfoToolStripMenuItem.Text = "Car Info";
            this.carInfoToolStripMenuItem.Click += new System.EventHandler(this.carInfoToolStripMenuItem_Click);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(154, 27);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(101, 20);
            this.ModelTextBox.TabIndex = 2;
            this.ModelTextBox.TextChanged += new System.EventHandler(this.ModelTextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(261, 27);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(92, 20);
            this.YearTextBox.TabIndex = 3;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(359, 27);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(94, 20);
            this.CountryTextBox.TabIndex = 4;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(459, 27);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(95, 20);
            this.ColorTextBox.TabIndex = 5;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(560, 27);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(101, 20);
            this.MaxSpeedTextBox.TabIndex = 6;
            this.MaxSpeedTextBox.TextChanged += new System.EventHandler(this.MaxSpeedTextBox_TextChanged);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(667, 27);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(94, 20);
            this.QuantityTextBox.TabIndex = 7;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GareageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 408);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.MaxSpeedTextBox);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.CarTable);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "GareageForm";
            this.Text = "Gareage";
            this.Load += new System.EventHandler(this.GareageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CarTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTheCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByMaxSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByYearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortByCountryToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSpeedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox MaxSpeedTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
    }
}

