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
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
        }


        private void Maintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet.APARTMENTS' table. You can move, or remove it, as needed.
            this.aPARTMENTSTableAdapter.Fill(this.aMSDataSet.APARTMENTS);
            // TODO: This line of code loads data into the 'aMSDataSet.MAINTENANCE' table. You can move, or remove it, as needed.
            this.mAINTENANCETableAdapter.Fill(this.aMSDataSet.MAINTENANCE);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu();
            MainMenu.Show();
        }

/*        private void BindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            this.Validate();
            this.mAINTENANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMSDataSet);
        }
        */
        private void MAINTENANCEBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Validate();
            this.mAINTENANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMSDataSet);
        }

        private void MAINTENANCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mAINTENANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMSDataSet);

        }
    }
}
