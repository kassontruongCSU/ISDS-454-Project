using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDS454
{
    public partial class Maintenances : Form
    {
        public Maintenances()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu();
            MainMenu.Show();
        }

        private void MAINTENANCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mAINTENANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMSDataSet);

        }

        private void Maintenances_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet.MAINTENANCE' table. You can move, or remove it, as needed.
            this.mAINTENANCETableAdapter.Fill(this.aMSDataSet.MAINTENANCE);

        }

        private void Maintenances_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mAINTENANCEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
 

            string strApartment;
            string strMaintenance;
            string strDescription;
            string strTime;
            bool bCompleteStatus;

            
            strApartment = apartmentNumberTextBox.Text;
            strMaintenance = typeOfMaintenanceTextBox.Text;
            strDescription = descriptionTextBox.Text;
            strTime = dateDateTimePicker.Text;
            bCompleteStatus = isCompletedCheckBox.Checked;


            MessageBox.Show("PRINT FOR TENANT USE" + "\n" + "***************************************************" + "\n" + "Apartment Number: " + strApartment + "\n" 
                + "Maintenance Type: " + strMaintenance + "\n" + "Description : " + strDescription + "\n" +
                "Time and Date Recorded: " + strTime + "\n" + "Is Completed: " + bCompleteStatus + "\n" + "***************************************************", "Recipt");
        }

        private void apartmentNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeOfMaintenanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void isCompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
