using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static WindowsFormsApp1.DashboardForm;

namespace WindowsFormsApp1
{
    public partial class ParkOutForm : Form
    {
        private Form ParkInForm;
        private string vehicleType;
        private ParkedVehicle selectedVehicle;
        private DashboardForm dashboardForm;
        public ParkOutForm(string details, string dateTime, string vehicleType, Form parkInForm, DashboardForm dashboardForm, ParkedVehicle parkedVehicle)
        {
            InitializeComponent();
            detailsLabel.Text = details;
            dateTimeLabel.Text = $"Date and Time of Parking In: {dateTime}";
            this.vehicleType = vehicleType;
            ParkInForm = parkInForm;
            this.dashboardForm = dashboardForm;
            this.selectedVehicle = parkedVehicle;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DateTime parkOut = dateTimePicker1.Value;

            string parkInDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // DateTime parkOut = DateTime.Parse(parkOutDateTime);
            DateTime parkIn = DateTime.Parse(parkInDateTime);

            // Calculate duration
            TimeSpan duration = parkOut - parkIn;

            // Calculate total amount based on vehicle type
            double flagDownRate = 0; // Flag down rate for the vehicle type
            double additionalRatePerHour = 0; // Additional amount per hour for the vehicle type

            // Adjust rates based on vehicle type (motorbike, sedan, SUV, etc.)
            switch (vehicleType)
            {
                case "Motorbike":
                    flagDownRate = 20; // Flag down rate for motorbike
                    additionalRatePerHour = 5; // Additional amount per hour for motorbike
                    break;
                case "SUV/Van":
                    flagDownRate = 40; // Flag down rate for SUV
                    additionalRatePerHour = 20; // Additional amount per hour for SUV/Van
                    break;
                case "Sedan":
                    flagDownRate = 30; // Flag down rate for sedan
                    additionalRatePerHour = 15; // Additional amount per hour for sedan
                    break;
            }

            double totalAmount = flagDownRate;
            double totalHours = Math.Floor(duration.TotalHours);
            double excessMinutes = duration.Minutes - (totalHours * 60);

            // Calculate total hours including the excess minutes
            if (duration.Minutes > 30)
            {
                totalHours += 1;
            }

            totalAmount += totalHours * additionalRatePerHour;

            // Calculate days, hours, minutes, and seconds
            int days = duration.Days;
            int hours = duration.Hours;
            int minutes = duration.Minutes;
            int seconds = duration.Seconds;


            // Display the duration
            durationLabel.Text = $"Duration: {days} day/s, {hours} hours, {minutes} minutes, {seconds} seconds";
            totalAmountLabel.Text = $"Total Amount: {totalAmount:C2}";
            parkOutLabel.Text = $"Park Out Date and Time: {parkOut}";

            if (parkOut == null)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void dateTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ParkInForm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardForm.RemoveParkedVehicle(selectedVehicle);
            dashboardForm.UpdateListView();
            dashboardForm.ClearPlateNumberComboBox();
            MessageBox.Show($"Vehicle with plate number {selectedVehicle.PlateNumber} parked out successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
