namespace RCPSystem.Forms
{
    partial class Dict
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
            this.tbDict = new System.Windows.Forms.TabControl();
            this.tpStruct = new System.Windows.Forms.TabPage();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.txtBranchLow = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.tvStruct = new System.Windows.Forms.TreeView();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddElemnt = new System.Windows.Forms.Button();
            this.dgvElem = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProdDescript = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.tpProdTask = new System.Windows.Forms.TabPage();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.lp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.tpElement = new System.Windows.Forms.TabPage();
            this.dgvElemList = new System.Windows.Forms.DataGridView();
            this.lpElem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElemIdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbElem = new System.Windows.Forms.ComboBox();
            this.txtElemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDuty = new System.Windows.Forms.TabPage();
            this.dgvDuty = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDutyName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbProd = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDutyTypes = new System.Windows.Forms.ComboBox();
            this.tvDuty = new System.Windows.Forms.TreeView();
            this.btnDeleteStruct = new System.Windows.Forms.Button();
            this.btnAddBranchLow = new System.Windows.Forms.Button();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.btnProdDel = new System.Windows.Forms.Button();
            this.btnSaveProdData = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnElemAdd = new System.Windows.Forms.Button();
            this.btnElemDel = new System.Windows.Forms.Button();
            this.btnDutyDelete = new System.Windows.Forms.Button();
            this.btnDutySave = new System.Windows.Forms.Button();
            this.btnAddTypeDuty = new System.Windows.Forms.Button();
            this.btnDutyTypeDelete = new System.Windows.Forms.Button();
            this.dgvDutyList = new System.Windows.Forms.DataGridView();
            this.btnDictManage = new System.Windows.Forms.Button();
            this.tbDict.SuspendLayout();
            this.tpStruct.SuspendLayout();
            this.tpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tpProdTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tpElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElemList)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tpDuty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDutyList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDict
            // 
            this.tbDict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDict.Controls.Add(this.tpStruct);
            this.tbDict.Controls.Add(this.tpProduct);
            this.tbDict.Controls.Add(this.tpProdTask);
            this.tbDict.Controls.Add(this.tpElement);
            this.tbDict.Controls.Add(this.tpDuty);
            this.tbDict.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDict.Location = new System.Drawing.Point(12, 12);
            this.tbDict.Name = "tbDict";
            this.tbDict.SelectedIndex = 0;
            this.tbDict.Size = new System.Drawing.Size(1878, 837);
            this.tbDict.TabIndex = 0;
            // 
            // tpStruct
            // 
            this.tpStruct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpStruct.Controls.Add(this.btnDeleteStruct);
            this.tpStruct.Controls.Add(this.btnAddBranchLow);
            this.tpStruct.Controls.Add(this.cmbBranch);
            this.tpStruct.Controls.Add(this.txtBranchLow);
            this.tpStruct.Controls.Add(this.txtBranch);
            this.tpStruct.Controls.Add(this.btnAddBranch);
            this.tpStruct.Controls.Add(this.tvStruct);
            this.tpStruct.Location = new System.Drawing.Point(4, 37);
            this.tpStruct.Name = "tpStruct";
            this.tpStruct.Padding = new System.Windows.Forms.Padding(3);
            this.tpStruct.Size = new System.Drawing.Size(1870, 796);
            this.tpStruct.TabIndex = 0;
            this.tpStruct.Text = "Struktura przedsiębiorstwa";
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(576, 144);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(199, 36);
            this.cmbBranch.TabIndex = 18;
            // 
            // txtBranchLow
            // 
            this.txtBranchLow.Location = new System.Drawing.Point(297, 144);
            this.txtBranchLow.Name = "txtBranchLow";
            this.txtBranchLow.Size = new System.Drawing.Size(235, 34);
            this.txtBranchLow.TabIndex = 17;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(297, 53);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(235, 34);
            this.txtBranch.TabIndex = 16;
            // 
            // tvStruct
            // 
            this.tvStruct.Location = new System.Drawing.Point(6, 6);
            this.tvStruct.Name = "tvStruct";
            this.tvStruct.Size = new System.Drawing.Size(267, 784);
            this.tvStruct.TabIndex = 0;
            this.tvStruct.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStruct_AfterSelect);
            // 
            // tpProduct
            // 
            this.tpProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpProduct.Controls.Add(this.label9);
            this.tpProduct.Controls.Add(this.label8);
            this.tpProduct.Controls.Add(this.btnAddElemnt);
            this.tpProduct.Controls.Add(this.dgvElem);
            this.tpProduct.Controls.Add(this.dgvProducts);
            this.tpProduct.Controls.Add(this.groupBox3);
            this.tpProduct.Controls.Add(this.btnSaveProdData);
            this.tpProduct.Location = new System.Drawing.Point(4, 37);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduct.Size = new System.Drawing.Size(1870, 796);
            this.tpProduct.TabIndex = 3;
            this.tpProduct.Text = "Produkty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(785, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 28);
            this.label9.TabIndex = 39;
            this.label9.Text = "Składniki produktu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 28);
            this.label8.TabIndex = 35;
            this.label8.Text = "Lista produktów";
            // 
            // btnAddElemnt
            // 
            this.btnAddElemnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddElemnt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddElemnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddElemnt.Location = new System.Drawing.Point(1083, 241);
            this.btnAddElemnt.Name = "btnAddElemnt";
            this.btnAddElemnt.Size = new System.Drawing.Size(213, 51);
            this.btnAddElemnt.TabIndex = 35;
            this.btnAddElemnt.Text = "Zarządzaj składnikami";
            this.btnAddElemnt.UseVisualStyleBackColor = true;
            this.btnAddElemnt.Click += new System.EventHandler(this.btnAddElemnt_Click);
            // 
            // dgvElem
            // 
            this.dgvElem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElem.Location = new System.Drawing.Point(790, 334);
            this.dgvElem.Name = "dgvElem";
            this.dgvElem.RowTemplate.Height = 24;
            this.dgvElem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElem.Size = new System.Drawing.Size(506, 456);
            this.dgvElem.TabIndex = 32;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(14, 334);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(521, 456);
            this.dgvProducts.TabIndex = 38;
            this.dgvProducts.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvProducts_RowStateChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnProdAdd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnProdDel);
            this.groupBox3.Controls.Add(this.txtProdDescript);
            this.groupBox3.Controls.Add(this.txtProdName);
            this.groupBox3.Location = new System.Drawing.Point(14, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 264);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodaj produkt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 28);
            this.label12.TabIndex = 31;
            this.label12.Text = "Wprowadź nazwę produktu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "Opis produktu";
            // 
            // txtProdDescript
            // 
            this.txtProdDescript.Location = new System.Drawing.Point(409, 68);
            this.txtProdDescript.Multiline = true;
            this.txtProdDescript.Name = "txtProdDescript";
            this.txtProdDescript.Size = new System.Drawing.Size(307, 155);
            this.txtProdDescript.TabIndex = 33;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(22, 81);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(327, 34);
            this.txtProdName.TabIndex = 30;
            // 
            // tpProdTask
            // 
            this.tpProdTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpProdTask.Controls.Add(this.dgvProd);
            this.tpProdTask.Controls.Add(this.groupBox5);
            this.tpProdTask.Controls.Add(this.btnDeleteType);
            this.tpProdTask.Location = new System.Drawing.Point(4, 37);
            this.tpProdTask.Name = "tpProdTask";
            this.tpProdTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpProdTask.Size = new System.Drawing.Size(1870, 796);
            this.tpProdTask.TabIndex = 2;
            this.tpProdTask.Text = "Słownik zadań produkcyjnych";
            // 
            // dgvProd
            // 
            this.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lp,
            this.TypeName,
            this.IdType});
            this.dgvProd.Location = new System.Drawing.Point(26, 269);
            this.dgvProd.MultiSelect = false;
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowTemplate.Height = 24;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(1201, 511);
            this.dgvProd.TabIndex = 19;
            this.dgvProd.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProd_RowPostPaint);
            this.dgvProd.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvProd_RowStateChanged);
            // 
            // lp
            // 
            this.lp.HeaderText = "Lp";
            this.lp.Name = "lp";
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "Nazwa zadania";
            this.TypeName.Name = "TypeName";
            // 
            // IdType
            // 
            this.IdType.DataPropertyName = "IdType";
            this.IdType.HeaderText = "Id";
            this.IdType.Name = "IdType";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddType);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtTypeName);
            this.groupBox5.Location = new System.Drawing.Point(26, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(623, 169);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodaj nowe zadanie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Wprowadź nazwę zadania";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(18, 97);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(315, 34);
            this.txtTypeName.TabIndex = 3;
            // 
            // tpElement
            // 
            this.tpElement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpElement.Controls.Add(this.dgvElemList);
            this.tpElement.Controls.Add(this.groupBox6);
            this.tpElement.Controls.Add(this.btnElemDel);
            this.tpElement.Location = new System.Drawing.Point(4, 37);
            this.tpElement.Name = "tpElement";
            this.tpElement.Padding = new System.Windows.Forms.Padding(3);
            this.tpElement.Size = new System.Drawing.Size(1870, 796);
            this.tpElement.TabIndex = 4;
            this.tpElement.Text = "Elementy";
            // 
            // dgvElemList
            // 
            this.dgvElemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lpElem,
            this.ElemName,
            this.IdElement,
            this.ElemIdType});
            this.dgvElemList.Location = new System.Drawing.Point(42, 323);
            this.dgvElemList.MultiSelect = false;
            this.dgvElemList.Name = "dgvElemList";
            this.dgvElemList.RowTemplate.Height = 24;
            this.dgvElemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElemList.Size = new System.Drawing.Size(1055, 370);
            this.dgvElemList.TabIndex = 26;
            this.dgvElemList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvElemList_RowPostPaint);
            this.dgvElemList.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvElemList_RowStateChanged);
            // 
            // lpElem
            // 
            this.lpElem.HeaderText = "Lp";
            this.lpElem.Name = "lpElem";
            // 
            // ElemName
            // 
            this.ElemName.DataPropertyName = "Name";
            this.ElemName.HeaderText = "Nazwa";
            this.ElemName.Name = "ElemName";
            // 
            // IdElement
            // 
            this.IdElement.DataPropertyName = "IdElement";
            this.IdElement.HeaderText = "IdElement";
            this.IdElement.Name = "IdElement";
            // 
            // ElemIdType
            // 
            this.ElemIdType.DataPropertyName = "IdType";
            this.ElemIdType.HeaderText = "IdType";
            this.ElemIdType.Name = "ElemIdType";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnElemAdd);
            this.groupBox6.Controls.Add(this.cmbElem);
            this.groupBox6.Controls.Add(this.txtElemName);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(22, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1072, 191);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dodaj nowy element";
            // 
            // cmbElem
            // 
            this.cmbElem.FormattingEnabled = true;
            this.cmbElem.Location = new System.Drawing.Point(367, 99);
            this.cmbElem.Name = "cmbElem";
            this.cmbElem.Size = new System.Drawing.Size(360, 36);
            this.cmbElem.TabIndex = 24;
            // 
            // txtElemName
            // 
            this.txtElemName.Location = new System.Drawing.Point(20, 98);
            this.txtElemName.Name = "txtElemName";
            this.txtElemName.Size = new System.Drawing.Size(315, 34);
            this.txtElemName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Wprowadź wybierz zadanie produkcyjne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Wprowadź nazwę elementu";
            // 
            // tpDuty
            // 
            this.tpDuty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpDuty.Controls.Add(this.btnDictManage);
            this.tpDuty.Controls.Add(this.dgvDutyList);
            this.tpDuty.Controls.Add(this.dgvDuty);
            this.tpDuty.Controls.Add(this.groupBox2);
            this.tpDuty.Controls.Add(this.groupBox1);
            this.tpDuty.Controls.Add(this.tvDuty);
            this.tpDuty.Controls.Add(this.btnDutyTypeDelete);
            this.tpDuty.Location = new System.Drawing.Point(4, 37);
            this.tpDuty.Name = "tpDuty";
            this.tpDuty.Padding = new System.Windows.Forms.Padding(3);
            this.tpDuty.Size = new System.Drawing.Size(1870, 796);
            this.tpDuty.TabIndex = 1;
            this.tpDuty.Text = "Słownik obowiązków";
            // 
            // dgvDuty
            // 
            this.dgvDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuty.Location = new System.Drawing.Point(21, 309);
            this.dgvDuty.Name = "dgvDuty";
            this.dgvDuty.RowTemplate.Height = 24;
            this.dgvDuty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDuty.Size = new System.Drawing.Size(515, 439);
            this.dgvDuty.TabIndex = 24;
            this.dgvDuty.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvDuty_RowStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDutyDelete);
            this.groupBox2.Controls.Add(this.txtDutyName);
            this.groupBox2.Controls.Add(this.btnDutySave);
            this.groupBox2.Location = new System.Drawing.Point(21, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 254);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wprowadź nowy obowiązek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wpisz nazwę";
            // 
            // txtDutyName
            // 
            this.txtDutyName.Location = new System.Drawing.Point(25, 102);
            this.txtDutyName.Name = "txtDutyName";
            this.txtDutyName.Size = new System.Drawing.Size(414, 34);
            this.txtDutyName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbProd);
            this.groupBox1.Controls.Add(this.btnAddTypeDuty);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbDutyTypes);
            this.groupBox1.Location = new System.Drawing.Point(1206, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 437);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj zadania do wybranego obowiązku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lista zadań";
            // 
            // lbProd
            // 
            this.lbProd.FormattingEnabled = true;
            this.lbProd.ItemHeight = 28;
            this.lbProd.Location = new System.Drawing.Point(25, 85);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(262, 340);
            this.lbProd.TabIndex = 21;
            this.lbProd.SelectedIndexChanged += new System.EventHandler(this.lbProd_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dodaj do listy zadań";
            // 
            // cmbDutyTypes
            // 
            this.cmbDutyTypes.FormattingEnabled = true;
            this.cmbDutyTypes.Location = new System.Drawing.Point(405, 74);
            this.cmbDutyTypes.Name = "cmbDutyTypes";
            this.cmbDutyTypes.Size = new System.Drawing.Size(267, 36);
            this.cmbDutyTypes.TabIndex = 18;
            // 
            // tvDuty
            // 
            this.tvDuty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDuty.Location = new System.Drawing.Point(1426, 502);
            this.tvDuty.Name = "tvDuty";
            this.tvDuty.Size = new System.Drawing.Size(279, 288);
            this.tvDuty.TabIndex = 1;
            this.tvDuty.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDuty_AfterSelect);
            // 
            // btnDeleteStruct
            // 
            this.btnDeleteStruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStruct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteStruct.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnDeleteStruct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStruct.Location = new System.Drawing.Point(297, 754);
            this.btnDeleteStruct.Name = "btnDeleteStruct";
            this.btnDeleteStruct.Size = new System.Drawing.Size(122, 36);
            this.btnDeleteStruct.TabIndex = 20;
            this.btnDeleteStruct.Text = "Usuń ";
            this.btnDeleteStruct.UseVisualStyleBackColor = true;
            this.btnDeleteStruct.Click += new System.EventHandler(this.btnDeleteStruct_Click);
            // 
            // btnAddBranchLow
            // 
            this.btnAddBranchLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBranchLow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddBranchLow.Image = global::RCPSystem.Properties.Resources.Add1;
            this.btnAddBranchLow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBranchLow.Location = new System.Drawing.Point(841, 144);
            this.btnAddBranchLow.Name = "btnAddBranchLow";
            this.btnAddBranchLow.Size = new System.Drawing.Size(199, 36);
            this.btnAddBranchLow.TabIndex = 19;
            this.btnAddBranchLow.Text = "Dodaj";
            this.btnAddBranchLow.UseVisualStyleBackColor = true;
            this.btnAddBranchLow.Click += new System.EventHandler(this.btnAddBranchLow_Click);
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBranch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddBranch.Image = global::RCPSystem.Properties.Resources.Add1;
            this.btnAddBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBranch.Location = new System.Drawing.Point(576, 54);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(199, 36);
            this.btnAddBranch.TabIndex = 15;
            this.btnAddBranch.Text = "Dodaj";
            this.btnAddBranch.UseVisualStyleBackColor = true;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // btnProdAdd
            // 
            this.btnProdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProdAdd.Image = global::RCPSystem.Properties.Resources.Add1;
            this.btnProdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdAdd.Location = new System.Drawing.Point(22, 134);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(147, 36);
            this.btnProdAdd.TabIndex = 19;
            this.btnProdAdd.Text = "Dodaj";
            this.btnProdAdd.UseVisualStyleBackColor = true;
            this.btnProdAdd.Click += new System.EventHandler(this.btnProdAdd_Click);
            // 
            // btnProdDel
            // 
            this.btnProdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProdDel.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnProdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdDel.Location = new System.Drawing.Point(202, 134);
            this.btnProdDel.Name = "btnProdDel";
            this.btnProdDel.Size = new System.Drawing.Size(147, 36);
            this.btnProdDel.TabIndex = 21;
            this.btnProdDel.Text = "Usuń ";
            this.btnProdDel.UseVisualStyleBackColor = true;
            // 
            // btnSaveProdData
            // 
            this.btnSaveProdData.Image = global::RCPSystem.Properties.Resources.Floppy2;
            this.btnSaveProdData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProdData.Location = new System.Drawing.Point(839, 36);
            this.btnSaveProdData.Name = "btnSaveProdData";
            this.btnSaveProdData.Size = new System.Drawing.Size(201, 71);
            this.btnSaveProdData.TabIndex = 35;
            this.btnSaveProdData.Text = "Aktualizuj dane";
            this.btnSaveProdData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveProdData.UseVisualStyleBackColor = true;
            // 
            // btnAddType
            // 
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddType.Image = global::RCPSystem.Properties.Resources.Add1;
            this.btnAddType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddType.Location = new System.Drawing.Point(384, 95);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(173, 36);
            this.btnAddType.TabIndex = 14;
            this.btnAddType.Text = "Dodaj";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteType.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnDeleteType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteType.Location = new System.Drawing.Point(1054, 215);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(173, 36);
            this.btnDeleteType.TabIndex = 16;
            this.btnDeleteType.Text = "Usuń ";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // btnElemAdd
            // 
            this.btnElemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElemAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElemAdd.Image = global::RCPSystem.Properties.Resources.Add1;
            this.btnElemAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElemAdd.Location = new System.Drawing.Point(824, 98);
            this.btnElemAdd.Name = "btnElemAdd";
            this.btnElemAdd.Size = new System.Drawing.Size(173, 36);
            this.btnElemAdd.TabIndex = 20;
            this.btnElemAdd.Text = "Dodaj";
            this.btnElemAdd.UseVisualStyleBackColor = true;
            this.btnElemAdd.Click += new System.EventHandler(this.btnElemAdd_Click);
            // 
            // btnElemDel
            // 
            this.btnElemDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElemDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElemDel.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnElemDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElemDel.Location = new System.Drawing.Point(924, 267);
            this.btnElemDel.Name = "btnElemDel";
            this.btnElemDel.Size = new System.Drawing.Size(173, 36);
            this.btnElemDel.TabIndex = 21;
            this.btnElemDel.Text = "Usuń ";
            this.btnElemDel.UseVisualStyleBackColor = true;
            this.btnElemDel.Click += new System.EventHandler(this.btnElemDel_Click);
            // 
            // btnDutyDelete
            // 
            this.btnDutyDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDutyDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDutyDelete.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnDutyDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDutyDelete.Location = new System.Drawing.Point(263, 172);
            this.btnDutyDelete.Name = "btnDutyDelete";
            this.btnDutyDelete.Size = new System.Drawing.Size(176, 36);
            this.btnDutyDelete.TabIndex = 15;
            this.btnDutyDelete.Text = "Usuń ";
            this.btnDutyDelete.UseVisualStyleBackColor = true;
            this.btnDutyDelete.Click += new System.EventHandler(this.btnDutyDelete_Click);
            // 
            // btnDutySave
            // 
            this.btnDutySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDutySave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDutySave.Image = global::RCPSystem.Properties.Resources.Edit;
            this.btnDutySave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDutySave.Location = new System.Drawing.Point(25, 172);
            this.btnDutySave.Name = "btnDutySave";
            this.btnDutySave.Size = new System.Drawing.Size(173, 36);
            this.btnDutySave.TabIndex = 17;
            this.btnDutySave.Text = "Zapisz";
            this.btnDutySave.UseVisualStyleBackColor = true;
            this.btnDutySave.Click += new System.EventHandler(this.btnDutySave_Click);
            // 
            // btnAddTypeDuty
            // 
            this.btnAddTypeDuty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTypeDuty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddTypeDuty.Image = global::RCPSystem.Properties.Resources.Add1;
            this.btnAddTypeDuty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTypeDuty.Location = new System.Drawing.Point(691, 74);
            this.btnAddTypeDuty.Name = "btnAddTypeDuty";
            this.btnAddTypeDuty.Size = new System.Drawing.Size(117, 36);
            this.btnAddTypeDuty.TabIndex = 14;
            this.btnAddTypeDuty.Text = "Dodaj";
            this.btnAddTypeDuty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTypeDuty.UseVisualStyleBackColor = true;
            this.btnAddTypeDuty.Click += new System.EventHandler(this.btnAddTypeDuty_Click);
            // 
            // btnDutyTypeDelete
            // 
            this.btnDutyTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDutyTypeDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDutyTypeDelete.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnDutyTypeDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDutyTypeDelete.Location = new System.Drawing.Point(1246, 535);
            this.btnDutyTypeDelete.Name = "btnDutyTypeDelete";
            this.btnDutyTypeDelete.Size = new System.Drawing.Size(133, 36);
            this.btnDutyTypeDelete.TabIndex = 20;
            this.btnDutyTypeDelete.Text = "Usuń ";
            this.btnDutyTypeDelete.UseVisualStyleBackColor = true;
            this.btnDutyTypeDelete.Click += new System.EventHandler(this.btnDutyTypeDelete_Click);
            // 
            // dgvDutyList
            // 
            this.dgvDutyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDutyList.Location = new System.Drawing.Point(749, 38);
            this.dgvDutyList.Name = "dgvDutyList";
            this.dgvDutyList.RowTemplate.Height = 24;
            this.dgvDutyList.Size = new System.Drawing.Size(256, 313);
            this.dgvDutyList.TabIndex = 25;
            // 
            // btnDictManage
            // 
            this.btnDictManage.Location = new System.Drawing.Point(840, 394);
            this.btnDictManage.Name = "btnDictManage";
            this.btnDictManage.Size = new System.Drawing.Size(165, 69);
            this.btnDictManage.TabIndex = 26;
            this.btnDictManage.Text = "Zarządzaj obowiązkami";
            this.btnDictManage.UseVisualStyleBackColor = true;
            this.btnDictManage.Click += new System.EventHandler(this.btnDictManage_Click);
            // 
            // Dict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 861);
            this.Controls.Add(this.tbDict);
            this.Name = "Dict";
            this.Text = "Słowniki";
            this.tbDict.ResumeLayout(false);
            this.tpStruct.ResumeLayout(false);
            this.tpStruct.PerformLayout();
            this.tpProduct.ResumeLayout(false);
            this.tpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpProdTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tpElement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElemList)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpDuty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDutyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbDict;
        private System.Windows.Forms.TabPage tpStruct;
        private System.Windows.Forms.TabPage tpDuty;
        private System.Windows.Forms.TabPage tpProdTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDutyDelete;
        private System.Windows.Forms.Button btnAddTypeDuty;
        private System.Windows.Forms.TextBox txtDutyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView tvDuty;
        private System.Windows.Forms.Button btnDutySave;
        private System.Windows.Forms.ComboBox cmbDutyTypes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Button btnProdDel;
        private System.Windows.Forms.Button btnProdAdd;
        private System.Windows.Forms.TabPage tpElement;
        private System.Windows.Forms.Button btnAddBranchLow;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.TextBox txtBranchLow;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.TreeView tvStruct;
        private System.Windows.Forms.Button btnDeleteStruct;
        private System.Windows.Forms.Button btnDutyTypeDelete;
        private System.Windows.Forms.ListBox lbProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElemName;
        private System.Windows.Forms.Button btnElemDel;
        private System.Windows.Forms.Button btnElemAdd;
        private System.Windows.Forms.ComboBox cmbElem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvElem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProdDescript;
        private System.Windows.Forms.Button btnSaveProdData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.DataGridView dgvElemList;
        private System.Windows.Forms.DataGridView dgvDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpElem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElemIdType;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddElemnt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDictManage;
        private System.Windows.Forms.DataGridView dgvDutyList;
    }
}