namespace ISDS454
{
    partial class AddPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPayment));
            System.Windows.Forms.Label transactionIDLabel;
            System.Windows.Forms.Label amountPaidLabel;
            System.Windows.Forms.Label transcationDateLabel;
            System.Windows.Forms.Label apartmentNumberLabel;
            this.aMSDataSet = new ISDS454.AMSDataSet();
            this.tRANSACTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANSACTIONSTableAdapter = new ISDS454.AMSDataSetTableAdapters.TRANSACTIONSTableAdapter();
            this.tableAdapterManager = new ISDS454.AMSDataSetTableAdapters.TableAdapterManager();
            this.tRANSACTIONSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tRANSACTIONSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.transactionIDTextBox = new System.Windows.Forms.TextBox();
            this.amountPaidTextBox = new System.Windows.Forms.TextBox();
            this.transcationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            transactionIDLabel = new System.Windows.Forms.Label();
            amountPaidLabel = new System.Windows.Forms.Label();
            transcationDateLabel = new System.Windows.Forms.Label();
            apartmentNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONSBindingNavigator)).BeginInit();
            this.tRANSACTIONSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // tRANSACTIONSTableAdapter
            // 
            this.tRANSACTIONSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APARTMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MAINTENANCETableAdapter = null;
            this.tableAdapterManager.TENANTSTableAdapter = null;
            this.tableAdapterManager.TRANSACTIONSTableAdapter = this.tRANSACTIONSTableAdapter;
            this.tableAdapterManager.UpdateOrder = ISDS454.AMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tRANSACTIONSBindingNavigator
            // 
            this.tRANSACTIONSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tRANSACTIONSBindingNavigator.BindingSource = this.tRANSACTIONSBindingSource;
            this.tRANSACTIONSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tRANSACTIONSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tRANSACTIONSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tRANSACTIONSBindingNavigatorSaveItem});
            this.tRANSACTIONSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tRANSACTIONSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tRANSACTIONSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tRANSACTIONSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tRANSACTIONSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tRANSACTIONSBindingNavigator.Name = "tRANSACTIONSBindingNavigator";
            this.tRANSACTIONSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tRANSACTIONSBindingNavigator.Size = new System.Drawing.Size(333, 25);
            this.tRANSACTIONSBindingNavigator.TabIndex = 0;
            this.tRANSACTIONSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tRANSACTIONSBindingNavigatorSaveItem
            // 
            this.tRANSACTIONSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tRANSACTIONSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tRANSACTIONSBindingNavigatorSaveItem.Image")));
            this.tRANSACTIONSBindingNavigatorSaveItem.Name = "tRANSACTIONSBindingNavigatorSaveItem";
            this.tRANSACTIONSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tRANSACTIONSBindingNavigatorSaveItem.Text = "Save Data";
            this.tRANSACTIONSBindingNavigatorSaveItem.Click += new System.EventHandler(this.TRANSACTIONSBindingNavigatorSaveItem_Click);
            // 
            // transactionIDLabel
            // 
            transactionIDLabel.AutoSize = true;
            transactionIDLabel.Location = new System.Drawing.Point(15, 83);
            transactionIDLabel.Name = "transactionIDLabel";
            transactionIDLabel.Size = new System.Drawing.Size(80, 13);
            transactionIDLabel.TabIndex = 1;
            transactionIDLabel.Text = "Transaction ID:";
            // 
            // transactionIDTextBox
            // 
            this.transactionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONSBindingSource, "TransactionID", true));
            this.transactionIDTextBox.Location = new System.Drawing.Point(119, 80);
            this.transactionIDTextBox.Name = "transactionIDTextBox";
            this.transactionIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.transactionIDTextBox.TabIndex = 2;
            // 
            // amountPaidLabel
            // 
            amountPaidLabel.AutoSize = true;
            amountPaidLabel.Location = new System.Drawing.Point(15, 109);
            amountPaidLabel.Name = "amountPaidLabel";
            amountPaidLabel.Size = new System.Drawing.Size(70, 13);
            amountPaidLabel.TabIndex = 3;
            amountPaidLabel.Text = "Amount Paid:";
            // 
            // amountPaidTextBox
            // 
            this.amountPaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONSBindingSource, "AmountPaid", true));
            this.amountPaidTextBox.Location = new System.Drawing.Point(119, 106);
            this.amountPaidTextBox.Name = "amountPaidTextBox";
            this.amountPaidTextBox.Size = new System.Drawing.Size(200, 20);
            this.amountPaidTextBox.TabIndex = 4;
            // 
            // transcationDateLabel
            // 
            transcationDateLabel.AutoSize = true;
            transcationDateLabel.Location = new System.Drawing.Point(15, 136);
            transcationDateLabel.Name = "transcationDateLabel";
            transcationDateLabel.Size = new System.Drawing.Size(92, 13);
            transcationDateLabel.TabIndex = 5;
            transcationDateLabel.Text = "Transcation Date:";
            // 
            // transcationDateDateTimePicker
            // 
            this.transcationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tRANSACTIONSBindingSource, "TranscationDate", true));
            this.transcationDateDateTimePicker.Location = new System.Drawing.Point(119, 132);
            this.transcationDateDateTimePicker.Name = "transcationDateDateTimePicker";
            this.transcationDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.transcationDateDateTimePicker.TabIndex = 6;
            // 
            // apartmentNumberLabel
            // 
            apartmentNumberLabel.AutoSize = true;
            apartmentNumberLabel.Location = new System.Drawing.Point(15, 161);
            apartmentNumberLabel.Name = "apartmentNumberLabel";
            apartmentNumberLabel.Size = new System.Drawing.Size(98, 13);
            apartmentNumberLabel.TabIndex = 7;
            apartmentNumberLabel.Text = "Apartment Number:";
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSACTIONSBindingSource, "ApartmentNumber", true));
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(119, 158);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.apartmentNumberTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add a New Transaction";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(195, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(transactionIDLabel);
            this.Controls.Add(this.transactionIDTextBox);
            this.Controls.Add(amountPaidLabel);
            this.Controls.Add(this.amountPaidTextBox);
            this.Controls.Add(transcationDateLabel);
            this.Controls.Add(this.transcationDateDateTimePicker);
            this.Controls.Add(apartmentNumberLabel);
            this.Controls.Add(this.apartmentNumberTextBox);
            this.Controls.Add(this.tRANSACTIONSBindingNavigator);
            this.Name = "AddPayment";
            this.Text = "AddPayment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPayment_FormClosed);
            this.Load += new System.EventHandler(this.AddPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONSBindingNavigator)).EndInit();
            this.tRANSACTIONSBindingNavigator.ResumeLayout(false);
            this.tRANSACTIONSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AMSDataSet aMSDataSet;
        private System.Windows.Forms.BindingSource tRANSACTIONSBindingSource;
        private AMSDataSetTableAdapters.TRANSACTIONSTableAdapter tRANSACTIONSTableAdapter;
        private AMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tRANSACTIONSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tRANSACTIONSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox transactionIDTextBox;
        private System.Windows.Forms.TextBox amountPaidTextBox;
        private System.Windows.Forms.DateTimePicker transcationDateDateTimePicker;
        private System.Windows.Forms.TextBox apartmentNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}