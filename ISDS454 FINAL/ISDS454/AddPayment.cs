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
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void TRANSACTIONSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRANSACTIONSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMSDataSet);

        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet.TRANSACTIONS' table. You can move, or remove it, as needed.
            this.tRANSACTIONSTableAdapter.Fill(this.aMSDataSet.TRANSACTIONS);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu();
            MainMenu.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payments pymnt = new Payments();
            pymnt.Show();
        }

        private void AddPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
