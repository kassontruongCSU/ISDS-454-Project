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
    public partial class Tenants : Form
    {
        public Tenants()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu();
            MainMenu.Show();
        }

        private void TENANTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tENANTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMSDataSet);

        }

        private void Tenants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet.TENANTS' table. You can move, or remove it, as needed.
            this.tENANTSTableAdapter.Fill(this.aMSDataSet.TENANTS);

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void TENANTSBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Tenants_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
