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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Apartments apts = new Apartments();
            this.Hide();
            apts.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Tenants tnnts = new Tenants();
            this.Hide();
            tnnts.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Payments pymnts = new Payments();
            this.Hide();
            pymnts.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Maintenances mnt = new Maintenances();
            this.Hide();
            mnt.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
