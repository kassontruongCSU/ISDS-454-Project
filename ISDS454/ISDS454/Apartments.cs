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
    public partial class Apartments : Form
    {
        public Apartments()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu();
            MainMenu.Show();
        }

        private void APARTMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPARTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMSDataSet);

        }

        private void Apartments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet.APARTMENTS' table. You can move, or remove it, as needed.
            this.aPARTMENTSTableAdapter.Fill(this.aMSDataSet.APARTMENTS);

        }

        private void Apartments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void APARTMENTSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void APARTMENTSDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
