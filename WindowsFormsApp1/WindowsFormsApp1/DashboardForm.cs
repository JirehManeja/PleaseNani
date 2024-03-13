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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static WindowsFormsApp1.DashboardForm;

namespace WindowsFormsApp1
{
    public partial class DashboardForm : Form
    {
        private Form LoginForm;
        private List<ParkedVehicle> parkedVehicles;
        public DashboardForm(Form LoginForm)
        {
            InitializeComponent();
            InitializeListView();
            parkedVehicles = new List<ParkedVehicle>();
            this.LoginForm = LoginForm;
        }
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Plate Number", 125);
            listView1.Columns.Add("Type", 100);
            listView1.Columns.Add("Brand", 100);
            listView1.Columns.Add("Parked In", 175);
        }

        public void AddParkedVehicle(string plateNumber, string vehicleType, string vehicleBrand, string parkingInDateTime)
        {
            if (parkedVehicles.Count > 0)
            {
                parkedVehicles.RemoveAt(0);
            }

            ParkedVehicle vehicle = new ParkedVehicle(plateNumber, vehicleType, vehicleBrand, parkingInDateTime);
            parkedVehicles.Add(vehicle);
            UpdateListView();
            UpdatePlateNumberComboBox();
        }

        public void UpdateListView()
        {
            listView1.Items.Clear();
            foreach (ParkedVehicle vehicle in parkedVehicles)
            {
                ListViewItem item = new ListViewItem(new[] { vehicle.PlateNumber, vehicle.VehicleType, vehicle.VehicleBrand, vehicle.ParkingInDateTime });
                listView1.Items.Add(item);
            }
        }

        public void UpdatePlateNumberComboBox()
        {
            PlateNumberComboBox.Items.Clear();
            foreach (ParkedVehicle vehicle in parkedVehicles)
            {
                PlateNumberComboBox.Items.Add(vehicle.PlateNumber);
            }
        }

        public void RemoveParkedVehicle(ParkedVehicle vehicle)
        {
            parkedVehicles.Remove(vehicle);
        }

        public class ParkedVehicle
        {
            public string PlateNumber { get; set; }
            public string VehicleType { get; set; }
            public string VehicleBrand { get; set; }
            public string ParkingInDateTime { get; set; }

            public ParkedVehicle(string plateNumber, string vehicleType, string vehicleBrand, string parkingInDateTime)
            {
                PlateNumber = plateNumber;
                VehicleType = vehicleType;
                VehicleBrand = vehicleBrand;
                ParkingInDateTime = parkingInDateTime;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void ParkInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkInForm parkInForm = new ParkInForm(this);
            parkInForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ParkOutButton_Click(object sender, EventArgs e)
        {
            string selectedPlateNumber = PlateNumberComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPlateNumber))
            {
                MessageBox.Show("Please select a plate number.", "Plate Number Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Find the parked vehicle based on the selected plate number
            ParkedVehicle selectedVehicle = parkedVehicles.FirstOrDefault(vehicle => vehicle.PlateNumber == selectedPlateNumber);
            if (selectedVehicle == null)
            {
                MessageBox.Show("Selected vehicle not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the details, dateTime, and vehicleType
            string details = GetDetailsString(selectedVehicle.PlateNumber, selectedVehicle.VehicleType, selectedVehicle.VehicleBrand);
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string vehicleType = selectedVehicle.VehicleType;

            // Pass the details to the ParkOutForm
            ParkOutForm parkOutForm = new ParkOutForm(details, dateTime, vehicleType, this, this, selectedVehicle);
            parkOutForm.ShowDialog();
        }

        public static string GetDetailsString(string plateNumber, string vehicleType, string vehicleBrand)
        {
            int flagDown = 0;
            int additionalAmountPerHour = 0;

            switch (vehicleType)
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
                   $"Type: {vehicleType}\n" +
                   $"Brand: {vehicleBrand}\n" +
                   $"Flag Down: {flagDown}\n" +
                   $"Additional Amount per Hour: {additionalAmountPerHour}";
        }

        public void PlateNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ClearPlateNumberComboBox()
        {
            PlateNumberComboBox.Items.Clear();
        }
    }
}
