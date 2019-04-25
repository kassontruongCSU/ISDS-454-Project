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
    }
}
