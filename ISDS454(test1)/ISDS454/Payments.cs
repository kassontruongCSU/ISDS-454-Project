﻿using System;
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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet.APARTMENTS' table. You can move, or remove it, as needed.
            this.aPARTMENTSTableAdapter.Fill(this.aMSDataSet.APARTMENTS);
            // TODO: This line of code loads data into the 'aMSDataSet.TRANSACTIONS' table. You can move, or remove it, as needed.
            this.tRANSACTIONSTableAdapter.Fill(this.aMSDataSet.TRANSACTIONS);

        }

        private void priceCheckToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tRANSACTIONSTableAdapter.PriceCheck(this.aMSDataSet.TRANSACTIONS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void aPARTMENTSBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            
        }

        private void transcationDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void transactionIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountPaidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void transcationDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void apartmentNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string strApartmentNumber;
            int iApartmentPrice;
            string strTransactionDate;
            int iAmountPaid;
            int iAmountDue;
            DateTime now = DateTime.Now;


            strApartmentNumber = apartmentNumberTextBox.Text;
            iApartmentPrice = Convert.ToInt32(priceTextBox.Text);
            strTransactionDate = transcationDateDateTimePicker.Text;
            iAmountPaid = Convert.ToInt32(amountPaidTextBox.Text);
            iAmountDue = iApartmentPrice - iAmountPaid;


            MessageBox.Show("OVERDUE RENT. PAY BY END OF MONTH OR RISK EVICTION" + "\n" + "***************************************************" + "\n" 
                + "Apartment Number: " + strApartmentNumber + "\n"
                + "Apartment Price: " + iApartmentPrice + "\n" + "Last Transaction Date : " + strTransactionDate + "\n" +
                "Amount Paid: " + iAmountPaid + "\n" + "Amount Due: " + iAmountDue + "\n" + "***************************************************" + "\n"
                + now, "LATE PAYMENT NOTICE");
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            priceTextBox.Update();
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
