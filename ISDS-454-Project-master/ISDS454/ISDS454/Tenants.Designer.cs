namespace ISDS454
{
    partial class Tenants
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
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label apartmentNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenants));
            this.button1 = new System.Windows.Forms.Button();
            this.tENANTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tENANTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMSDataSet = new ISDS454.AMSDataSet();
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
            this.tENANTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tENANTSTableAdapter = new ISDS454.AMSDataSetTableAdapters.TENANTSTableAdapter();
            this.tableAdapterManager = new ISDS454.AMSDataSetTableAdapters.TableAdapterManager();
            this.tENANTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.sSNTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            sSNLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            apartmentNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tENANTSBindingNavigator)).BeginInit();
            this.tENANTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENANTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENANTSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(19, 110);
            fNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(80, 17);
            fNameLabel.TabIndex = 19;
            fNameLabel.Text = "First Name:";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(19, 142);
            lNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(80, 17);
            lNameLabel.TabIndex = 21;
            lNameLabel.Text = "Last Name:";
            // 
            // sSNLabel
            // 
            sSNLabel.AutoSize = true;
            sSNLabel.Location = new System.Drawing.Point(19, 174);
            sSNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(40, 17);
            sSNLabel.TabIndex = 23;
            sSNLabel.Text = "SSN:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(19, 206);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(107, 17);
            phoneNumberLabel.TabIndex = 25;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(19, 238);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email:";
            // 
            // apartmentNumberLabel
            // 
            apartmentNumberLabel.AutoSize = true;
            apartmentNumberLabel.Location = new System.Drawing.Point(19, 270);
            apartmentNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            apartmentNumberLabel.Name = "apartmentNumberLabel";
            apartmentNumberLabel.Size = new System.Drawing.Size(131, 17);
            apartmentNumberLabel.TabIndex = 29;
            apartmentNumberLabel.Text = "Apartment Number:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 476);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tENANTSBindingNavigator
            // 
            this.tENANTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tENANTSBindingNavigator.BindingSource = this.tENANTSBindingSource;
            this.tENANTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tENANTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tENANTSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tENANTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tENANTSBindingNavigatorSaveItem});
            this.tENANTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tENANTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tENANTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tENANTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tENANTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tENANTSBindingNavigator.Name = "tENANTSBindingNavigator";
            this.tENANTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tENANTSBindingNavigator.Size = new System.Drawing.Size(1331, 27);
            this.tENANTSBindingNavigator.TabIndex = 3;
            this.tENANTSBindingNavigator.Text = "bindingNavigator1";
            this.tENANTSBindingNavigator.RefreshItems += new System.EventHandler(this.TENANTSBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // tENANTSBindingSource
            // 
            this.tENANTSBindingSource.DataMember = "TENANTS";
            this.tENANTSBindingSource.DataSource = this.aMSDataSet;
            // 
            // aMSDataSet
            // 
            this.aMSDataSet.DataSetName = "AMSDataSet";
            this.aMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tENANTSBindingNavigatorSaveItem
            // 
            this.tENANTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tENANTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tENANTSBindingNavigatorSaveItem.Image")));
            this.tENANTSBindingNavigatorSaveItem.Name = "tENANTSBindingNavigatorSaveItem";
            this.tENANTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tENANTSBindingNavigatorSaveItem.Text = "Save Data";
            this.tENANTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.TENANTSBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add a New Tenant";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tENANTSTableAdapter
            // 
            this.tENANTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APARTMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MAINTENANCETableAdapter = null;
            this.tableAdapterManager.TENANTSTableAdapter = this.tENANTSTableAdapter;
            this.tableAdapterManager.TRANSACTIONSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ISDS454.AMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tENANTSDataGridView
            // 
            this.tENANTSDataGridView.AutoGenerateColumns = false;
            this.tENANTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tENANTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tENANTSDataGridView.DataSource = this.tENANTSBindingSource;
            this.tENANTSDataGridView.Location = new System.Drawing.Point(313, 97);
            this.tENANTSDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tENANTSDataGridView.Name = "tENANTSDataGridView";
            this.tENANTSDataGridView.Size = new System.Drawing.Size(991, 416);
            this.tENANTSDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenantID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenantID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SSN";
            this.dataGridViewTextBoxColumn4.HeaderText = "SSN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ApartmentNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "ApartmentNumber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tENANTSBindingSource, "FName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(157, 106);
            this.fNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.fNameTextBox.TabIndex = 20;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tENANTSBindingSource, "LName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(157, 138);
            this.lNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.lNameTextBox.TabIndex = 22;
            // 
            // sSNTextBox
            // 
            this.sSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tENANTSBindingSource, "SSN", true));
            this.sSNTextBox.Location = new System.Drawing.Point(157, 170);
            this.sSNTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sSNTextBox.Name = "sSNTextBox";
            this.sSNTextBox.Size = new System.Drawing.Size(132, 22);
            this.sSNTextBox.TabIndex = 24;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tENANTSBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(157, 202);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.phoneNumberTextBox.TabIndex = 26;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tENANTSBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(157, 234);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(132, 22);
            this.emailTextBox.TabIndex = 28;
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tENANTSBindingSource, "ApartmentNumber", true));
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(157, 266);
            this.apartmentNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.apartmentNumberTextBox.TabIndex = 30;
            // 
            // Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 529);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(sSNLabel);
            this.Controls.Add(this.sSNTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(apartmentNumberLabel);
            this.Controls.Add(this.apartmentNumberTextBox);
            this.Controls.Add(this.tENANTSDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tENANTSBindingNavigator);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tenants";
            this.Text = "Tenants";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tenants_FormClosed);
            this.Load += new System.EventHandler(this.Tenants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tENANTSBindingNavigator)).EndInit();
            this.tENANTSBindingNavigator.ResumeLayout(false);
            this.tENANTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENANTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENANTSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AMSDataSet aMSDataSet;
        private System.Windows.Forms.BindingSource tENANTSBindingSource;
        private AMSDataSetTableAdapters.TENANTSTableAdapter tENANTSTableAdapter;
        private AMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tENANTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tENANTSBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tENANTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox sSNTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox apartmentNumberTextBox;
    }
}