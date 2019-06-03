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
using System.IO;

namespace GareageForm
{
    public partial class GareageForm : Form
    {
        public GareageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CarTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCars();
        }

        private void GareageForm_Load(object sender, EventArgs e)
        {
            UpdateCars();
         
        }

       public void  UpdateCars()
        {
            
            CarTable.Rows.Clear();
            foreach (var g in Gareage.GetCarsinGareage)
            {
                
                int i = CarTable.Rows.Add();
                CarTable.Rows[i].Cells[0].Value = g.Id;
                CarTable.Rows[i].Cells[1].Value = g.Model;
                CarTable.Rows[i].Cells[2].Value = g.Year.ToString();
                CarTable.Rows[i].Cells[3].Value = g.country;
                CarTable.Rows[i].Cells[4].Value = g.color;
                CarTable.Rows[i].Cells[5].Value = g.MaxSpeed.ToString();
                CarTable.Rows[i].Cells[6].Value = Gareage.GetCarQtyById(g.Id).ToString();

            }
        }
        private void addNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var add = new AddWindow();
            add.Show();
          
        }

        private void removeTheCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveWindow x = new RemoveWindow();
            x.Show();
           
        }

        public void CarTable_DoubleClick(object sender, EventArgs e)
        {
            UpdateCars();
        }

        private void carInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarInfo it = new CarInfo();
            it.Show();
        }

        private void sortByYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTable.Sort(CarTable.Columns[2], ListSortDirection.Ascending);
        }

        private void sortByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTable.Sort(CarTable.Columns[0], ListSortDirection.Ascending);
        }

        private void sortByYearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CarTable.Sort(CarTable.Columns[3], ListSortDirection.Ascending);
        }

        private void sortByCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTable.Sort(CarTable.Columns[5], ListSortDirection.Ascending);
        }

        private void sortByMaxSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTable.Sort(CarTable.Columns[4], ListSortDirection.Ascending);
        }

        private void ModelTextBox_TextChanged(object sender, EventArgs e)
        {
            {
                CarTable.ClearSelection();
                foreach (DataGridViewRow r in CarTable.Rows)
                {
                    if (r.Cells[1].Value != null)
                    {
                        if ((r.Cells[1].Value).ToString().StartsWith(ModelTextBox.Text.Trim()))
                        {
                            CarTable.Rows[r.Index].Selected = true;
                        }
                    }
                }
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {

            CarTable.ClearSelection();
            foreach (DataGridViewRow r in CarTable.Rows)
            {
                if (r.Cells[2].Value != null)
                {
                    if ((r.Cells[2].Value).ToString().StartsWith(YearTextBox.Text.Trim()))
                    {
                        CarTable.Rows[r.Index].Selected = true;
                    }
                }
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {

            CarTable.ClearSelection();
            foreach (DataGridViewRow r in CarTable.Rows)
            {
                if (r.Cells[3].Value != null)
                {
                    if ((r.Cells[3].Value).ToString().StartsWith(CountryTextBox.Text.Trim()))
                    {
                        CarTable.Rows[r.Index].Selected = true;
                    }
                }
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {

            CarTable.ClearSelection();
            foreach (DataGridViewRow r in CarTable.Rows)
            {
                if (r.Cells[4].Value != null)
                {
                    if ((r.Cells[4].Value).ToString().StartsWith(ColorTextBox.Text.Trim()))
                    {
                        CarTable.Rows[r.Index].Selected = true;
                    }
                }
            }
        }

        private void MaxSpeedTextBox_TextChanged(object sender, EventArgs e)
        {

            CarTable.ClearSelection();
            foreach (DataGridViewRow r in CarTable.Rows)
            {
                if (r.Cells[5].Value != null)
                {
                    if ((r.Cells[5].Value).ToString().StartsWith(MaxSpeedTextBox.Text.Trim()))
                    {
                        CarTable.Rows[r.Index].Selected = true;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            CarTable.ClearSelection();
            foreach (DataGridViewRow r in CarTable.Rows)
            {
                if (r.Cells[6].Value != null)
                {
                    if ((r.Cells[6].Value).ToString().StartsWith(QuantityTextBox.Text.Trim()))
                    {
                        CarTable.Rows[r.Index].Selected = true;
                    }
                }
            }
        }
    }
}
