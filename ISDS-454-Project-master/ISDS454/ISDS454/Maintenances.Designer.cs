namespace ISDS454
{
    partial class Maintenances
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
            System.Windows.Forms.Label apartmentNumberLabel;
            System.Windows.Forms.Label typeOfMaintenanceLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenances));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aMSDataSet = new ISDS454.AMSDataSet();
            this.mAINTENANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAINTENANCETableAdapter = new ISDS454.AMSDataSetTableAdapters.MAINTENANCETableAdapter();
            this.tableAdapterManager = new ISDS454.AMSDataSetTableAdapters.TableAdapterManager();
            this.mAINTENANCEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mAINTENANCEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mAINTENANCEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.typeOfMaintenanceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isCompletedCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            apartmentNumberLabel = new System.Windows.Forms.Label();
            typeOfMaintenanceLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingNavigator)).BeginInit();
            this.mAINTENANCEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // apartmentNumberLabel
            // 
            apartmentNumberLabel.AutoSize = true;
            apartmentNumberLabel.Location = new System.Drawing.Point(21, 96);
            apartmentNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            apartmentNumberLabel.Name = "apartmentNumberLabel";
            apartmentNumberLabel.Size = new System.Drawing.Size(131, 17);
            apartmentNumberLabel.TabIndex = 23;
            apartmentNumberLabel.Text = "Apartment Number:";
            // 
            // typeOfMaintenanceLabel
            // 
            typeOfMaintenanceLabel.AutoSize = true;
            typeOfMaintenanceLabel.Location = new System.Drawing.Point(21, 128);
            typeOfMaintenanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeOfMaintenanceLabel.Name = "typeOfMaintenanceLabel";
            typeOfMaintenanceLabel.Size = new System.Drawing.Size(148, 17);
            typeOfMaintenanceLabel.TabIndex = 25;
            typeOfMaintenanceLabel.Text = "Type Of Maintenance:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(21, 160);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 27;
            descriptionLabel.Text = "Description:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(21, 250);
            dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 17);
            dateLabel.TabIndex = 29;
            dateLabel.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add a New Maintenance Request";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // aMSDataSet
            // 
            this.aMSDataSet.DataSetName = "AMSDataSet";
            this.aMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAINTENANCEBindingSource
            // 
            this.mAINTENANCEBindingSource.DataMember = "MAINTENANCE";
            this.mAINTENANCEBindingSource.DataSource = this.aMSDataSet;
            // 
            // mAINTENANCETableAdapter
            // 
            this.mAINTENANCETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APARTMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MAINTENANCETableAdapter = this.mAINTENANCETableAdapter;
            this.tableAdapterManager.TENANTSTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ISDS454.AMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mAINTENANCEBindingNavigator
            // 
            this.mAINTENANCEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mAINTENANCEBindingNavigator.BindingSource = this.mAINTENANCEBindingSource;
            this.mAINTENANCEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mAINTENANCEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mAINTENANCEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mAINTENANCEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mAINTENANCEBindingNavigatorSaveItem});
            this.mAINTENANCEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mAINTENANCEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mAINTENANCEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mAINTENANCEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mAINTENANCEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mAINTENANCEBindingNavigator.Name = "mAINTENANCEBindingNavigator";
            this.mAINTENANCEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mAINTENANCEBindingNavigator.Size = new System.Drawing.Size(1347, 27);
            this.mAINTENANCEBindingNavigator.TabIndex = 21;
            this.mAINTENANCEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // mAINTENANCEBindingNavigatorSaveItem
            // 
            this.mAINTENANCEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mAINTENANCEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mAINTENANCEBindingNavigatorSaveItem.Image")));
            this.mAINTENANCEBindingNavigatorSaveItem.Name = "mAINTENANCEBindingNavigatorSaveItem";
            this.mAINTENANCEBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.mAINTENANCEBindingNavigatorSaveItem.Text = "Save Data";
            this.mAINTENANCEBindingNavigatorSaveItem.Click += new System.EventHandler(this.MAINTENANCEBindingNavigatorSaveItem_Click);
            // 
            // mAINTENANCEDataGridView
            // 
            this.mAINTENANCEDataGridView.AutoGenerateColumns = false;
            this.mAINTENANCEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mAINTENANCEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.mAINTENANCEDataGridView.DataSource = this.mAINTENANCEBindingSource;
            this.mAINTENANCEDataGridView.Location = new System.Drawing.Point(473, 91);
            this.mAINTENANCEDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mAINTENANCEDataGridView.Name = "mAINTENANCEDataGridView";
            this.mAINTENANCEDataGridView.Size = new System.Drawing.Size(857, 430);
            this.mAINTENANCEDataGridView.TabIndex = 21;
            this.mAINTENANCEDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mAINTENANCEDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaintenanceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaintenanceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ApartmentNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "ApartmentNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeOfMaintenance";
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeOfMaintenance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsCompleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsCompleted";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "ApartmentNumber", true));
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(180, 92);
            this.apartmentNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(265, 22);
            this.apartmentNumberTextBox.TabIndex = 24;
            this.apartmentNumberTextBox.TextChanged += new System.EventHandler(this.apartmentNumberTextBox_TextChanged);
            // 
            // typeOfMaintenanceTextBox
            // 
            this.typeOfMaintenanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "TypeOfMaintenance", true));
            this.typeOfMaintenanceTextBox.Location = new System.Drawing.Point(180, 124);
            this.typeOfMaintenanceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeOfMaintenanceTextBox.Name = "typeOfMaintenanceTextBox";
            this.typeOfMaintenanceTextBox.Size = new System.Drawing.Size(265, 22);
            this.typeOfMaintenanceTextBox.TabIndex = 26;
            this.typeOfMaintenanceTextBox.TextChanged += new System.EventHandler(this.typeOfMaintenanceTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(180, 156);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(265, 80);
            this.descriptionTextBox.TabIndex = 28;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mAINTENANCEBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(180, 245);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateDateTimePicker.TabIndex = 30;
            this.dateDateTimePicker.ValueChanged += new System.EventHandler(this.dateDateTimePicker_ValueChanged);
            // 
            // isCompletedCheckBox
            // 
            this.isCompletedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mAINTENANCEBindingSource, "IsCompleted", true));
            this.isCompletedCheckBox.Location = new System.Drawing.Point(180, 277);
            this.isCompletedCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isCompletedCheckBox.Name = "isCompletedCheckBox";
            this.isCompletedCheckBox.Size = new System.Drawing.Size(267, 30);
            this.isCompletedCheckBox.TabIndex = 32;
            this.isCompletedCheckBox.Text = "Completed";
            this.isCompletedCheckBox.UseVisualStyleBackColor = true;
            this.isCompletedCheckBox.CheckedChanged += new System.EventHandler(this.isCompletedCheckBox_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button2.Location = new System.Drawing.Point(271, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 37);
            this.button2.TabIndex = 33;
            this.button2.Text = "Receipt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Maintenances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(apartmentNumberLabel);
            this.Controls.Add(this.apartmentNumberTextBox);
            this.Controls.Add(typeOfMaintenanceLabel);
            this.Controls.Add(this.typeOfMaintenanceTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.isCompletedCheckBox);
            this.Controls.Add(this.mAINTENANCEDataGridView);
            this.Controls.Add(this.mAINTENANCEBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Maintenances";
            this.Text = "Maintenances";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Maintenances_FormClosed);
            this.Load += new System.EventHandler(this.Maintenances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingNavigator)).EndInit();
            this.mAINTENANCEBindingNavigator.ResumeLayout(false);
            this.mAINTENANCEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private AMSDataSet aMSDataSet;
        private System.Windows.Forms.BindingSource mAINTENANCEBindingSource;
        private AMSDataSetTableAdapters.MAINTENANCETableAdapter mAINTENANCETableAdapter;
        private AMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mAINTENANCEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mAINTENANCEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mAINTENANCEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox apartmentNumberTextBox;
        private System.Windows.Forms.TextBox typeOfMaintenanceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.CheckBox isCompletedCheckBox;
        private System.Windows.Forms.Button button2;
    }
}