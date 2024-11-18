using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CarsDal carsDal = new CarsDal();
                       
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMethod();
            
        }

        private void LoadMethod()
        {
            dgwcars.DataSource = carsDal.GetAll();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateMarka.Text = dgwcars.CurrentRow.Cells[1].Value.ToString();
            txbUpdateModel.Text = dgwcars.CurrentRow.Cells[2].Value.ToString();
            txbUpdateAractipi.Text = dgwcars.CurrentRow.Cells[3].Value.ToString();
            txbUpdatePlaka.Text = dgwcars.CurrentRow.Cells[4].Value.ToString();
            txbUpdateDurum.Text = dgwcars.CurrentRow.Cells[5].Value.ToString();
                }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            carsDal.AddCar(new Car
            {
                Marka = tbxmarka.Text,
                Model=tbxModel.Text,
                AracTipi=txbAractipi.Text,
                Durum=txbDurum.Text,
                Plaka=txbPlaka.Text,
            });
            LoadMethod();
            MessageBox.Show("Added");

        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {

            carsDal.UpdateCar(new Car {
                Id = Convert.ToInt32(dgwcars.CurrentRow.Cells[0].Value),
            Marka=tbxUpdateMarka.Text,
            Model=txbUpdateModel.Text,
                AracTipi = txbUpdateAractipi.Text,
                Durum = txbUpdateDurum.Text,
                Plaka = txbUpdatePlaka.Text,



            });
            LoadMethod();
            MessageBox.Show("Updated");
        }

        private void bntdelete_Click(object sender, EventArgs e)
        {
            carsDal.DeleteCar(new Car
            {
                Id = Convert.ToInt32(dgwcars.CurrentRow.Cells[0].Value),

            });

            LoadMethod();
            MessageBox.Show("Deleted");
        }

        private void SearchCars(string key)
        {

            var result = carsDal.GetByPlaka(key);
            dgwcars.DataSource = result;
            //var result1=carsDal.GetByMarka(key);
            //dgwcars.DataSource = result1;
            //var result2 = carsDal.GetByModel(key);
            //dgwcars.DataSource = result2;
        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchCars(tbxSearch.Text);
            


        }
    }
}
