using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.DashboardForm;

namespace WindowsFormsApp1
{
    public partial class ParkInForm : Form
    {
        private DashboardForm dashboardForm;
        public ParkInForm(DashboardForm dashboardForm)
        {
            InitializeComponent();

            TypeComboBox.Items.Add("Motorbike");
            TypeComboBox.Items.Add("SUV/Van");
            TypeComboBox.Items.Add("Sedan");
            this.dashboardForm = dashboardForm;
        }

        private void UpdateDetailsLabel()
        {
            string plateNumber = PNtextBox.Text;
            string selectedType = TypeComboBox.SelectedItem?.ToString();
            string selectedBrand = BrandComboBox.SelectedItem?.ToString();

            int flagDown = 0;
            int additionalAmountPerHour = 0;

            switch (selectedType)
            {
                case "Motorbike":
                    flagDown = 20;
                    additionalAmountPerHour = 5;
                    break;
                case "SUV/Van":
                    flagDown = 40;
                    additionalAmountPerHour = 20;
                    break;
                case "Sedan":
                    flagDown = 30;
                    additionalAmountPerHour = 15;
                    break;
            }

            detailsLabel.Text = $"Plate Number: {plateNumber}\nType: {selectedType}\nBrand: {selectedBrand}";
            detailsLabel2.Text = $"Flag down amount: {flagDown}\nAdditional amount per hour: {additionalAmountPerHour}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            dashboardForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PNtextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDetailsLabel();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrandComboBox.Items.Clear();

            if (TypeComboBox.SelectedItem.ToString() == "Motorbike")
            {
                BrandComboBox.Items.Add("Honda");
                BrandComboBox.Items.Add("Yamaha");
                BrandComboBox.Items.Add("Suzuki");
                BrandComboBox.Items.Add("Kawasaki");
                BrandComboBox.Items.Add("BMW");
            }

            else if (TypeComboBox.SelectedItem.ToString() == "SUV/Van")
            {
                BrandComboBox.Items.Add("Kia");
                BrandComboBox.Items.Add("Toyota");
                BrandComboBox.Items.Add("Honda");
                BrandComboBox.Items.Add("Mitsubishi");
                BrandComboBox.Items.Add("Isuzu");
            }

            else if (TypeComboBox.SelectedItem.ToString() == "Sedan")
            {
                BrandComboBox.Items.Add("Nissan");
                BrandComboBox.Items.Add("Toyota");
                BrandComboBox.Items.Add("Honda");
                BrandComboBox.Items.Add("Hyundai");
                BrandComboBox.Items.Add("Mazda");
            }

            UpdateDetailsLabel();
        }

        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDetailsLabel();
        }

        private void Typelabel_Click(object sender, EventArgs e)
        {

        }

        private void ParkInButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PNtextBox.Text))
            {
                MessageBox.Show("Please enter the plate number.", "Plate Number Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TypeComboBox.SelectedItem == null || BrandComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select both vehicle type and brand.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string plateNumber = PNtextBox.Text;
            string vehicleType = TypeComboBox.SelectedItem.ToString();
            string vehicleBrand = BrandComboBox.SelectedItem.ToString();
            string parkingInDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            DashboardForm dashboardForm = new DashboardForm(this);
            dashboardForm.AddParkedVehicle(plateNumber, vehicleType, vehicleBrand, parkingInDateTime);
            dashboardForm.UpdateListView();


            this.Close();
            dashboardForm.Show();

            //MessageBox.Show("Vehicle parked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //string details = GetDetailsString();
            //string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //string vehicleType = TypeComboBox.SelectedItem.ToString();

            //ParkOutForm parkOutForm = new ParkOutForm(details, dateTime, vehicleType, this);
            //parkOutForm.ShowDialog();
        }

        private void detailsLabel_Click(object sender, EventArgs e)
        {

        }

        public string GetDetailsString()
        {
            string plateNumber = PNtextBox.Text;
            string selectedType = TypeComboBox.SelectedItem?.ToString();
            string selectedBrand = BrandComboBox.SelectedItem?.ToString();

            int flagDown = 0;
            int additionalAmountPerHour = 0;

            switch (selectedType)
            {
                case "Motorbike":
                    flagDown = 20;
                    additionalAmountPerHour = 5;
                    break;
                case "SUV/Van":
                    flagDown = 40;
                    additionalAmountPerHour = 20;
                    break;
                case "Sedan":
                    flagDown = 30;
                    additionalAmountPerHour = 15;
                    break;
            }

            return $"Plate Number: {plateNumber}\n" +
                   $"Type: {selectedType}\n" +
                   $"Brand: {selectedBrand}\n" +
                   $"Flag Down: {flagDown}\n" +
                   $"Additional Amount per Hour: {additionalAmountPerHour}";
        }

        private void Brandlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
