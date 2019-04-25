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
    }
}
