namespace ISDS454
{
    partial class CheckAvailability
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aMSDataSet = new ISDS454.AMSDataSet();
            this.aPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPARTMENTSTableAdapter = new ISDS454.AMSDataSetTableAdapters.APARTMENTSTableAdapter();
            this.apartmentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfOccupentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfBedroomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingSpaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.smokingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vacancyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apartmentNumberDataGridViewTextBoxColumn,
            this.numberOfOccupentsDataGridViewTextBoxColumn,
            this.apartmentSizeDataGridViewTextBoxColumn,
            this.numberOfBedroomsDataGridViewTextBoxColumn,
            this.parkingSpaceDataGridViewTextBoxColumn,
            this.petsDataGridViewCheckBoxColumn,
            this.smokingDataGridViewCheckBoxColumn,
            this.vacancyDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.aPARTMENTSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // aMSDataSet
            // 
            this.aMSDataSet.DataSetName = "AMSDataSet";
            this.aMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPARTMENTSBindingSource
            // 
            this.aPARTMENTSBindingSource.DataMember = "APARTMENTS";
            this.aPARTMENTSBindingSource.DataSource = this.aMSDataSet;
            // 
            // aPARTMENTSTableAdapter
            // 
            this.aPARTMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // apartmentNumberDataGridViewTextBoxColumn
            // 
            this.apartmentNumberDataGridViewTextBoxColumn.DataPropertyName = "ApartmentNumber";
            this.apartmentNumberDataGridViewTextBoxColumn.HeaderText = "ApartmentNumber";
            this.apartmentNumberDataGridViewTextBoxColumn.Name = "apartmentNumberDataGridViewTextBoxColumn";
            this.apartmentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfOccupentsDataGridViewTextBoxColumn
            // 
            this.numberOfOccupentsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfOccupents";
            this.numberOfOccupentsDataGridViewTextBoxColumn.HeaderText = "NumberOfOccupents";
            this.numberOfOccupentsDataGridViewTextBoxColumn.Name = "numberOfOccupentsDataGridViewTextBoxColumn";
            this.numberOfOccupentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apartmentSizeDataGridViewTextBoxColumn
            // 
            this.apartmentSizeDataGridViewTextBoxColumn.DataPropertyName = "ApartmentSize";
            this.apartmentSizeDataGridViewTextBoxColumn.HeaderText = "ApartmentSize";
            this.apartmentSizeDataGridViewTextBoxColumn.Name = "apartmentSizeDataGridViewTextBoxColumn";
            this.apartmentSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfBedroomsDataGridViewTextBoxColumn
            // 
            this.numberOfBedroomsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfBedrooms";
            this.numberOfBedroomsDataGridViewTextBoxColumn.HeaderText = "NumberOfBedrooms";
            this.numberOfBedroomsDataGridViewTextBoxColumn.Name = "numberOfBedroomsDataGridViewTextBoxColumn";
            this.numberOfBedroomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parkingSpaceDataGridViewTextBoxColumn
            // 
            this.parkingSpaceDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpace";
            this.parkingSpaceDataGridViewTextBoxColumn.HeaderText = "ParkingSpace";
            this.parkingSpaceDataGridViewTextBoxColumn.Name = "parkingSpaceDataGridViewTextBoxColumn";
            this.parkingSpaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petsDataGridViewCheckBoxColumn
            // 
            this.petsDataGridViewCheckBoxColumn.DataPropertyName = "Pets";
            this.petsDataGridViewCheckBoxColumn.HeaderText = "Pets";
            this.petsDataGridViewCheckBoxColumn.Name = "petsDataGridViewCheckBoxColumn";
            this.petsDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // smokingDataGridViewCheckBoxColumn
            // 
            this.smokingDataGridViewCheckBoxColumn.DataPropertyName = "Smoking";
            this.smokingDataGridViewCheckBoxColumn.HeaderText = "Smoking";
            this.smokingDataGridViewCheckBoxColumn.Name = "smokingDataGridViewCheckBoxColumn";
            this.smokingDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // vacancyDataGridViewCheckBoxColumn
            // 
            this.vacancyDataGridViewCheckBoxColumn.DataPropertyName = "Vacancy";
            this.vacancyDataGridViewCheckBoxColumn.HeaderText = "Vacancy";
            this.vacancyDataGridViewCheckBoxColumn.Name = "vacancyDataGridViewCheckBoxColumn";
            this.vacancyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // CheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 563);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckAvailability";
            this.Text = "CheckAvailability";
            this.Load += new System.EventHandler(this.CheckAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AMSDataSet aMSDataSet;
        private System.Windows.Forms.BindingSource aPARTMENTSBindingSource;
        private AMSDataSetTableAdapters.APARTMENTSTableAdapter aPARTMENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfOccupentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfBedroomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn petsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn smokingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vacancyDataGridViewCheckBoxColumn;
    }
}