using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsProgram
{
    public partial class CarInfo : Form
    {
        public CarInfo()
        {
            InitializeComponent();
        }

        private void CarInfo_Load(object sender, EventArgs e)
        {
            this.CarsComboBox.Items.AddRange(Gareage.GetCarsinGareage.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarModelLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CarsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car tempCar = (Car)this.CarsComboBox.SelectedItem;
            this.CarIdTextBox.Text = tempCar.Id.ToString();
            this.CarModelTetBox.Text = tempCar.Model.ToString();
            this.CountryTextBox.Text = tempCar.country.ToString();
            this.YearTextBox.Text = tempCar.Year.ToString();
            this.MaxSpeedTextBox.Text = tempCar.MaxSpeed.ToString();
            this.ColorTextBox.Text = tempCar.color.ToString();
        }
    }
}
