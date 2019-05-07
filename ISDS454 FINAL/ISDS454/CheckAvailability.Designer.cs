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
            this.aPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMSDataSet = new ISDS454.AMSDataSet();
            this.aPARTMENTSTableAdapter = new ISDS454.AMSDataSetTableAdapters.APARTMENTSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apartmentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfOccupentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfBedroomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingSpaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.smokingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new ISDS454.AMSDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPARTMENTSBindingSource
            // 
            this.aPARTMENTSBindingSource.DataMember = "APARTMENTS";
            this.aPARTMENTSBindingSource.DataSource = this.aMSDataSet;
            // 
            // aMSDataSet
            // 
            this.aMSDataSet.DataSetName = "AMSDataSet";
            this.aMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPARTMENTSTableAdapter
            // 
            this.aPARTMENTSTableAdapter.ClearBeforeFill = true;
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
            this.priceDataGridViewTextBoxColumn,
            this.moveOutDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aPARTMENTSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(943, 322);
            this.dataGridView1.TabIndex = 0;
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moveOutDateDataGridViewTextBoxColumn
            // 
            this.moveOutDateDataGridViewTextBoxColumn.DataPropertyName = "MoveOutDate";
            this.moveOutDateDataGridViewTextBoxColumn.HeaderText = "MoveOutDate";
            this.moveOutDateDataGridViewTextBoxColumn.Name = "moveOutDateDataGridViewTextBoxColumn";
            this.moveOutDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(966, 44);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByToolStripButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(607, 41);
            this.fillByToolStripButton.Text = "Click Here To Check For Available Apartments";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(831, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apartments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APARTMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MAINTENANCETableAdapter = null;
            this.tableAdapterManager.TENANTSTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ISDS454.AMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tenants";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckAvailability";
            this.Text = "CheckAvailability";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckAvailability_FormClosed);
            this.Load += new System.EventHandler(this.CheckAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AMSDataSet aMSDataSet;
        private System.Windows.Forms.BindingSource aPARTMENTSBindingSource;
        private AMSDataSetTableAdapters.APARTMENTSTableAdapter aPARTMENTSTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vacancyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfOccupentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfBedroomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn petsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn smokingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moveOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button button1;
        private AMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
    }
}