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
    public partial class RemoveWindow : Form
    {
        public RemoveWindow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveWindow_Load(object sender, EventArgs e)
        {
            this.CarsRemoveComboBox.Items.AddRange(Gareage.GetCarsinGareage.ToArray());
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Car removeCar = (Car)this.CarsRemoveComboBox.SelectedItem;
            try
            {
               
                Gareage.RemoveCar(removeCar);
                
            }
            catch(CarDoesNotExistException)
            {
                MessageBox.Show("You are trying to remove unexisting car", "Error");
                
            }
            catch(ThereIsNoCarException)
            {
                MessageBox.Show("There are no these types of cars left", "Error");
            }
           
           
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
