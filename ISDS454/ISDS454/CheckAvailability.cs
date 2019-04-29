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
    public partial class CheckAvailability : Form
    {
        public CheckAvailability()
        {
            InitializeComponent();
        }

        private void CheckAvailability_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet.APARTMENTS' table. You can move, or remove it, as needed.
            this.aPARTMENTSTableAdapter.Fill(this.aMSDataSet.APARTMENTS);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aPARTMENTSTableAdapter.FillBy(this.aMSDataSet.APARTMENTS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Apartments apts = new Apartments();
            this.Hide();
            apts.Show();
        }

        private void CheckAvailability_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Tenants tnnts = new Tenants();
            this.Hide();
            tnnts.Show();
        }
    }
}
