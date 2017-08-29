namespace BD2_demaOkien
{
    partial class PatientsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_2DataSet = new BD2_demaOkien.BD_2DataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorItemData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorItemVisits = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorItemAddVisit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorItemTests = new System.Windows.Forms.ToolStripButton();
            this.patientTableAdapter = new BD2_demaOkien.BD_2DataSetTableAdapters.PatientTableAdapter();
            this.fKVisitPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitTableAdapter = new BD2_demaOkien.BD_2DataSetTableAdapters.VisitTableAdapter();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKVisitPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 92);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(429, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Wyczyść";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(429, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(81, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(342, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(81, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(81, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię             ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nazwisko     ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "PESEL          ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.bindingNavigator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 269);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.Address});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 240);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.bD_2DataSet;
            // 
            // bD_2DataSet
            // 
            this.bD_2DataSet.DataSetName = "BD_2DataSet";
            this.bD_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.patientBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorEditItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.bindingNavigatorItemData,
            this.toolStripSeparator4,
            this.bindingNavigatorItemVisits,
            this.bindingNavigatorItemAddVisit,
            this.toolStripSeparator2,
            this.bindingNavigatorItemTests});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 240);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(539, 25);
            this.bindingNavigator1.Stretch = true;
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorEditItem.Text = "Edytuj";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorItemData
            // 
            this.bindingNavigatorItemData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorItemData.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorItemData.Image")));
            this.bindingNavigatorItemData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorItemData.Name = "bindingNavigatorItemData";
            this.bindingNavigatorItemData.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorItemData.Text = "Dane";
            this.bindingNavigatorItemData.Click += new System.EventHandler(this.bindingNavigatorItemData_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorItemVisits
            // 
            this.bindingNavigatorItemVisits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorItemVisits.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorItemVisits.Image")));
            this.bindingNavigatorItemVisits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorItemVisits.Name = "bindingNavigatorItemVisits";
            this.bindingNavigatorItemVisits.Size = new System.Drawing.Size(46, 22);
            this.bindingNavigatorItemVisits.Text = "Wizyty";
            this.bindingNavigatorItemVisits.Click += new System.EventHandler(this.bindingNavigatorItemVisits_Click);
            // 
            // bindingNavigatorItemAddVisit
            // 
            this.bindingNavigatorItemAddVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorItemAddVisit.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorItemAddVisit.Image")));
            this.bindingNavigatorItemAddVisit.Name = "bindingNavigatorItemAddVisit";
            this.bindingNavigatorItemAddVisit.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorItemAddVisit.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorItemAddVisit.Text = "Dodaj wizytę";
            this.bindingNavigatorItemAddVisit.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorItemTests
            // 
            this.bindingNavigatorItemTests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorItemTests.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorItemTests.Image")));
            this.bindingNavigatorItemTests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorItemTests.Name = "bindingNavigatorItemTests";
            this.bindingNavigatorItemTests.Size = new System.Drawing.Size(53, 22);
            this.bindingNavigatorItemTests.Text = "Badania";
            this.bindingNavigatorItemTests.Click += new System.EventHandler(this.bindingNavigatorItemTests_Click);
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // fKVisitPatientBindingSource
            // 
            this.fKVisitPatientBindingSource.DataMember = "FK_Visit_Patient";
            this.fKVisitPatientBindingSource.DataSource = this.patientBindingSource;
            // 
            // visitTableAdapter
            // 
            this.visitTableAdapter.ClearBeforeFill = true;
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "Patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            this.patientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientidDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "First_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Nr telefonu";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Adres";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // PatientsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PatientsWindow";
            this.Text = "Pacjenci";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Patients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKVisitPatientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorItemData;
        private System.Windows.Forms.ToolStripButton bindingNavigatorItemVisits;
        private System.Windows.Forms.ToolStripButton bindingNavigatorItemTests;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD_2DataSet bD_2DataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private BD_2DataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorItemAddVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKVisitPatientBindingSource;
        private BD_2DataSetTableAdapters.VisitTableAdapter visitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}