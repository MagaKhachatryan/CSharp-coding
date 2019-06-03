using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarsProgram;

namespace GareageForm
{
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void AddWindow_Load(object sender, EventArgs e)
        {
            
            this.ModelComboBox.Items.AddRange(typeof(CarModel).GetEnumNames());
            this.CountryComboBox.Items.AddRange(typeof(Country).GetEnumNames());
            this.ColorComboBox.Items.AddRange(typeof(Colors).GetEnumNames());

            ModelComboBox.SelectedIndex = 0;
            CountryComboBox.SelectedIndex = 0;
            ColorComboBox.SelectedIndex = 0;


        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
        private void YearTextBox_Validating(object sender, CancelEventArgs e)
        {
            UInt32 r=0;
                if (!UInt32.TryParse(this.YearTextBox.Text, out r))
                {
                    MessageBox.Show("Please enter unsigned integer value for year", "Error");
                    YearTextBox.SelectAll();
                    YearTextBox.Focus();
                }
            
        }

        private void MaxSpeedTextBox_Validating(object sender, CancelEventArgs e)
        {
            UInt32 r=0;
            
             if (!UInt32.TryParse(this.MaxSpeedTextBox.Text, out r))
                {
                    MessageBox.Show("Please enter unsigned integer value for Max Speed", "Error");
                    this.MaxSpeedTextBox.SelectAll();
                    this.MaxSpeedTextBox.Focus();
                }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (this.YearTextBox.Text == "" )
            {

                MessageBox.Show("Please, enter proper car's year", "Error");
                YearTextBox.SelectAll();
                YearTextBox.Focus();
                return;
            }

            if ( this.MaxSpeedTextBox.Text == "0")
            {
                MessageBox.Show("Please,enter the car's correct  max speed", "Error");
                YearTextBox.SelectAll();
                MaxSpeedTextBox.Focus();
                return;
            }

           
            CarModel car =(CarModel) Enum.Parse(typeof(CarModel), this.ModelComboBox.Text);
            Country country = (Country)Enum.Parse(typeof(Country), this.CountryComboBox.Text);
            Colors color = (Colors)Enum.Parse(typeof(Colors), this.ColorComboBox.Text);
            Car NewCar = new Car(car, Int32.Parse(this.YearTextBox.Text),country, color,
                long.Parse(this.MaxSpeedTextBox.Text));
         
            try
            {
                Gareage.AddCar(NewCar);
                
                
            }
            finally
            {
                YearTextBox.Clear();
                //YearTextBox.Focus();
                MaxSpeedTextBox.Clear();
                ModelComboBox.SelectedIndex = 0;
                CountryComboBox.SelectedIndex = 0;
                ColorComboBox.SelectedIndex = 0;
                this.Close();
                
            }
            
        }
    }
}
