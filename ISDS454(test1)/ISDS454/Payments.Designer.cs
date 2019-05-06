namespace ISDS454
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            System.Windows.Forms.Label transactionIDLabel;
            System.Windows.Forms.Label amountPaidLabel;
            System.Windows.Forms.Label transcationDateLabel;
            System.Windows.Forms.Label apartmentNumberLabel;
            System.Windows.Forms.Label priceLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AmountDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCheckToolStrip = new System.Windows.Forms.ToolStrip();
            this.priceCheckToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aPARTMENTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aPARTMENTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.transactionIDTextBox = new System.Windows.Forms.TextBox();
            this.amountPaidTextBox = new System.Windows.Forms.TextBox();
            this.transcationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMSDataSet = new ISDS454.AMSDataSet();
            this.tRANSACTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transcationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANSACTIONSTableAdapter = new ISDS454.AMSDataSetTableAdapters.TRANSACTIONSTableAdapter();
            this.tableAdapterManager = new ISDS454.AMSDataSetTableAdapters.TableAdapterManager();
            this.aPARTMENTSTableAdapter = new ISDS454.AMSDataSetTableAdapters.APARTMENTSTableAdapter();
            transactionIDLabel = new System.Windows.Forms.Label();
            amountPaidLabel = new System.Windows.Forms.Label();
            transcationDateLabel = new System.Windows.Forms.Label();
            apartmentNumberLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.priceCheckToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTSBindingNavigator)).BeginInit();
            this.aPARTMENTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.transcationDateDataGridViewTextBoxColumn,
            this.apartmentNumberDataGridViewTextBoxColumn,
            this.AmountDueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tRANSACTIONSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(413, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(756, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AmountDueDataGridViewTextBoxColumn
            // 
            this.AmountDueDataGridViewTextBoxColumn.DataPropertyName = "AmountDue";
            this.AmountDueDataGridViewTextBoxColumn.HeaderText = "AmountDue";
            this.AmountDueDataGridViewTextBoxColumn.Name = "AmountDueDataGridViewTextBoxColumn";
            this.AmountDueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceCheckToolStrip
            // 
            this.priceCheckToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.priceCheckToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceCheckToolStripButton});
            this.priceCheckToolStrip.Location = new System.Drawing.Point(0, 0);
            this.priceCheckToolStrip.Name = "priceCheckToolStrip";
            this.priceCheckToolStrip.Size = new System.Drawing.Size(1189, 27);
            this.priceCheckToolStrip.TabIndex = 1;
            this.priceCheckToolStrip.Text = "priceCheckToolStrip";
            // 
            // priceCheckToolStripButton
            // 
            this.priceCheckToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.priceCheckToolStripButton.Name = "priceCheckToolStripButton";
            this.priceCheckToolStripButton.Size = new System.Drawing.Size(84, 24);
            this.priceCheckToolStripButton.Text = "PriceCheck";
            this.priceCheckToolStripButton.Click += new System.EventHandler(this.priceCheckToolStripButton_Click);
            // 
            // aPARTMENTSBindingNavigator
            // 
            this.aPARTMENTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aPARTMENTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aPARTMENTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aPARTMENTSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aPARTMENTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aPARTMENTSBindingNavigatorSaveItem});
            this.aPARTMENTSBindingNavigator.Location = new System.Drawing.Point(0, 27);
            this.aPARTMENTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aPARTMENTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aPARTMENTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aPARTMENTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aPARTMENTSBindingNavigator.Name = "aPARTMENTSBindingNavigator";
            this.aPARTMENTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aPARTMENTSBindingNavigator.Size = new System.Drawing.Size(1189, 27);
            this.aPARTMENTSBindingNavigator.TabIndex = 3;
            this.aPARTMENTSBindingNavigator.Text = "bindingNavigator1";
            this.aPARTMENTSBindingNavigator.RefreshItems += new System.EventHandler(this.aPARTMENTSBindingNavigator_RefreshItems);
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
            // aPARTMENTSBindingNavigatorSaveItem
            // 
            this.aPARTMENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aPARTMENTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aPARTMENTSBindingNavigatorSaveItem.Image")));
            this.aPARTMENTSBindingNavigatorSaveItem.Name = "aPARTMENTSBindingNavigatorSaveItem";
            this.aPARTMENTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.aPARTMENTSBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // transactionIDLabel
            // 
            transactionIDLabel.AutoSize = true;
            transactionIDLabel.Location = new System.Drawing.Point(24, 102);
            transactionIDLabel.Name = "transactionIDLabel";
            transactionIDLabel.Size = new System.Drawing.Size(104, 17);
            transactionIDLabel.TabIndex = 3;
            transactionIDLabel.Text = "Transaction ID:";
            // 
            // transactionIDTextBox
            // 
            this.transactionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONSBindingSource, "TransactionID", true));
            this.transactionIDTextBox.Location = new System.Drawing.Point(161, 102);
            this.transactionIDTextBox.Name = "transactionIDTextBox";
            this.transactionIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.transactionIDTextBox.TabIndex = 4;
            this.transactionIDTextBox.TextChanged += new System.EventHandler(this.transactionIDTextBox_TextChanged);
            // 
            // amountPaidLabel
            // 
            amountPaidLabel.AutoSize = true;
            amountPaidLabel.Location = new System.Drawing.Point(24, 246);
            amountPaidLabel.Name = "amountPaidLabel";
            amountPaidLabel.Size = new System.Drawing.Size(92, 17);
            amountPaidLabel.TabIndex = 5;
            amountPaidLabel.Text = "Amount Paid:";
            // 
            // amountPaidTextBox
            // 
            this.amountPaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONSBindingSource, "AmountPaid", true));
            this.amountPaidTextBox.Location = new System.Drawing.Point(161, 246);
            this.amountPaidTextBox.Name = "amountPaidTextBox";
            this.amountPaidTextBox.Size = new System.Drawing.Size(100, 22);
            this.amountPaidTextBox.TabIndex = 6;
            this.amountPaidTextBox.TextChanged += new System.EventHandler(this.amountPaidTextBox_TextChanged);
            // 
            // transcationDateLabel
            // 
            transcationDateLabel.AutoSize = true;
            transcationDateLabel.Location = new System.Drawing.Point(24, 211);
            transcationDateLabel.Name = "transcationDateLabel";
            transcationDateLabel.Size = new System.Drawing.Size(121, 17);
            transcationDateLabel.TabIndex = 7;
            transcationDateLabel.Text = "Transcation Date:";
            transcationDateLabel.Click += new System.EventHandler(this.transcationDateLabel_Click);
            // 
            // transcationDateDateTimePicker
            // 
            this.transcationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tRANSACTIONSBindingSource, "TranscationDate", true));
            this.transcationDateDateTimePicker.Location = new System.Drawing.Point(161, 211);
            this.transcationDateDateTimePicker.Name = "transcationDateDateTimePicker";
            this.transcationDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.transcationDateDateTimePicker.TabIndex = 8;
            this.transcationDateDateTimePicker.ValueChanged += new System.EventHandler(this.transcationDateDateTimePicker_ValueChanged);
            // 
            // apartmentNumberLabel
            // 
            apartmentNumberLabel.AutoSize = true;
            apartmentNumberLabel.Location = new System.Drawing.Point(24, 142);
            apartmentNumberLabel.Name = "apartmentNumberLabel";
            apartmentNumberLabel.Size = new System.Drawing.Size(131, 17);
            apartmentNumberLabel.TabIndex = 9;
            apartmentNumberLabel.Text = "Apartment Number:";
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONSBindingSource, "ApartmentNumber", true));
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(161, 137);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.apartmentNumberTextBox.TabIndex = 10;
            this.apartmentNumberTextBox.TextChanged += new System.EventHandler(this.apartmentNumberTextBox_TextChanged);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(24, 177);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(44, 17);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price:";
            priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPARTMENTSBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(161, 174);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 12;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create Late Notice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // tRANSACTIONSBindingSource
            // 
            this.tRANSACTIONSBindingSource.DataMember = "TRANSACTIONS";
            this.tRANSACTIONSBindingSource.DataSource = this.aMSDataSet;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transcationDateDataGridViewTextBoxColumn
            // 
            this.transcationDateDataGridViewTextBoxColumn.DataPropertyName = "TranscationDate";
            this.transcationDateDataGridViewTextBoxColumn.HeaderText = "TranscationDate";
            this.transcationDateDataGridViewTextBoxColumn.Name = "transcationDateDataGridViewTextBoxColumn";
            this.transcationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apartmentNumberDataGridViewTextBoxColumn
            // 
            this.apartmentNumberDataGridViewTextBoxColumn.DataPropertyName = "ApartmentNumber";
            this.apartmentNumberDataGridViewTextBoxColumn.HeaderText = "ApartmentNumber";
            this.apartmentNumberDataGridViewTextBoxColumn.Name = "apartmentNumberDataGridViewTextBoxColumn";
            this.apartmentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRANSACTIONSTableAdapter
            // 
            this.tRANSACTIONSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APARTMENTSTableAdapter = this.aPARTMENTSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MAINTENANCETableAdapter = null;
            this.tableAdapterManager.TENANTSTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONSTableAdapter = this.tRANSACTIONSTableAdapter;
            this.tableAdapterManager.UpdateOrder = ISDS454.AMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aPARTMENTSTableAdapter
            // 
            this.aPARTMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(apartmentNumberLabel);
            this.Controls.Add(this.apartmentNumberTextBox);
            this.Controls.Add(transcationDateLabel);
            this.Controls.Add(this.transcationDateDateTimePicker);
            this.Controls.Add(amountPaidLabel);
            this.Controls.Add(this.amountPaidTextBox);
            this.Controls.Add(transactionIDLabel);
            this.Controls.Add(this.transactionIDTextBox);
            this.Controls.Add(this.aPARTMENTSBindingNavigator);
            this.Controls.Add(this.priceCheckToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.priceCheckToolStrip.ResumeLayout(false);
            this.priceCheckToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTSBindingNavigator)).EndInit();
            this.aPARTMENTSBindingNavigator.ResumeLayout(false);
            this.aPARTMENTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AMSDataSet aMSDataSet;
        private System.Windows.Forms.BindingSource tRANSACTIONSBindingSource;
        private AMSDataSetTableAdapters.TRANSACTIONSTableAdapter tRANSACTIONSTableAdapter;
        private System.Windows.Forms.ToolStrip priceCheckToolStrip;
        private System.Windows.Forms.ToolStripButton priceCheckToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transcationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator aPARTMENTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aPARTMENTSBindingNavigatorSaveItem;
        private AMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AMSDataSetTableAdapters.APARTMENTSTableAdapter aPARTMENTSTableAdapter;
        private System.Windows.Forms.TextBox transactionIDTextBox;
        private System.Windows.Forms.TextBox amountPaidTextBox;
        private System.Windows.Forms.DateTimePicker transcationDateDateTimePicker;
        private System.Windows.Forms.TextBox apartmentNumberTextBox;
        private System.Windows.Forms.BindingSource aPARTMENTSBindingSource;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button button1;
    }
}