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
            this.tpDuty = new System.Windows.Forms.TabPage();
            this.lbProd = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDutyTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDutyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tvDuty = new System.Windows.Forms.TreeView();
            this.tpElement = new System.Windows.Forms.TabPage();
            this.cmbElem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtElemName = new System.Windows.Forms.TextBox();
            this.tvElem = new System.Windows.Forms.TreeView();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProdDescript = new System.Windows.Forms.TextBox();
            this.dgvElem = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProdElem = new System.Windows.Forms.ComboBox();
            this.tvProduct = new System.Windows.Forms.TreeView();
            this.tpProdTask = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.tvProd = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteStruct = new System.Windows.Forms.Button();
            this.btnAddBranchLow = new System.Windows.Forms.Button();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnElemDel = new System.Windows.Forms.Button();
            this.btnElemAdd = new System.Windows.Forms.Button();
            this.btnDutyDelete = new System.Windows.Forms.Button();
            this.btnDutySave = new System.Windows.Forms.Button();
            this.btnAddTypeDuty = new System.Windows.Forms.Button();
            this.btnDutyTypeDelete = new System.Windows.Forms.Button();
            this.btnProdElemAdd = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.btnProdDel = new System.Windows.Forms.Button();
            this.btnSaveProdData = new System.Windows.Forms.Button();
            this.btnPodElemeDel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbDict.SuspendLayout();
            this.tpStruct.SuspendLayout();
            this.tpDuty.SuspendLayout();
            this.tpElement.SuspendLayout();
            this.tpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElem)).BeginInit();
            this.tpProdTask.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDict
            // 
            this.tbDict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDict.Controls.Add(this.tpStruct);
            this.tbDict.Controls.Add(this.tpProdTask);
            this.tbDict.Controls.Add(this.tpElement);
            this.tbDict.Controls.Add(this.tpDuty);
            this.tbDict.Controls.Add(this.tpProduct);
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
            // tpDuty
            // 
            this.tpDuty.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // lbProd
            // 
            this.lbProd.FormattingEnabled = true;
            this.lbProd.ItemHeight = 28;
            this.lbProd.Location = new System.Drawing.Point(90, 84);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(262, 340);
            this.lbProd.TabIndex = 21;
            this.lbProd.SelectedIndexChanged += new System.EventHandler(this.lbProd_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 42);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lista zadań";
            // 
            // txtDutyName
            // 
            this.txtDutyName.Location = new System.Drawing.Point(25, 102);
            this.txtDutyName.Name = "txtDutyName";
            this.txtDutyName.Size = new System.Drawing.Size(317, 34);
            this.txtDutyName.TabIndex = 3;
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
            // tvDuty
            // 
            this.tvDuty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDuty.Location = new System.Drawing.Point(6, 6);
            this.tvDuty.Name = "tvDuty";
            this.tvDuty.Size = new System.Drawing.Size(279, 784);
            this.tvDuty.TabIndex = 1;
            this.tvDuty.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDuty_AfterSelect);
            // 
            // tpElement
            // 
            this.tpElement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpElement.Controls.Add(this.groupBox6);
            this.tpElement.Controls.Add(this.tvElem);
            this.tpElement.Controls.Add(this.btnElemDel);
            this.tpElement.Location = new System.Drawing.Point(4, 37);
            this.tpElement.Name = "tpElement";
            this.tpElement.Padding = new System.Windows.Forms.Padding(3);
            this.tpElement.Size = new System.Drawing.Size(1870, 796);
            this.tpElement.TabIndex = 4;
            this.tpElement.Text = "Elementy";
            // 
            // cmbElem
            // 
            this.cmbElem.FormattingEnabled = true;
            this.cmbElem.Location = new System.Drawing.Point(367, 99);
            this.cmbElem.Name = "cmbElem";
            this.cmbElem.Size = new System.Drawing.Size(360, 36);
            this.cmbElem.TabIndex = 24;
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
            // txtElemName
            // 
            this.txtElemName.Location = new System.Drawing.Point(20, 98);
            this.txtElemName.Name = "txtElemName";
            this.txtElemName.Size = new System.Drawing.Size(315, 34);
            this.txtElemName.TabIndex = 19;
            // 
            // tvElem
            // 
            this.tvElem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvElem.Location = new System.Drawing.Point(6, 6);
            this.tvElem.Name = "tvElem";
            this.tvElem.Size = new System.Drawing.Size(260, 784);
            this.tvElem.TabIndex = 18;
            this.tvElem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvElem_AfterSelect);
            // 
            // tpProduct
            // 
            this.tpProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpProduct.Controls.Add(this.groupBox4);
            this.tpProduct.Controls.Add(this.groupBox3);
            this.tpProduct.Controls.Add(this.btnSaveProdData);
            this.tpProduct.Controls.Add(this.label10);
            this.tpProduct.Controls.Add(this.tvProduct);
            this.tpProduct.Controls.Add(this.btnPodElemeDel);
            this.tpProduct.Location = new System.Drawing.Point(4, 37);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduct.Size = new System.Drawing.Size(1870, 796);
            this.tpProduct.TabIndex = 3;
            this.tpProduct.Text = "Produkty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "Opis produktu";
            // 
            // txtProdDescript
            // 
            this.txtProdDescript.Location = new System.Drawing.Point(459, 65);
            this.txtProdDescript.Multiline = true;
            this.txtProdDescript.Name = "txtProdDescript";
            this.txtProdDescript.Size = new System.Drawing.Size(425, 155);
            this.txtProdDescript.TabIndex = 33;
            // 
            // dgvElem
            // 
            this.dgvElem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElem.Location = new System.Drawing.Point(73, 88);
            this.dgvElem.Name = "dgvElem";
            this.dgvElem.RowTemplate.Height = 24;
            this.dgvElem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElem.Size = new System.Drawing.Size(506, 196);
            this.dgvElem.TabIndex = 32;
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
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(22, 81);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(327, 34);
            this.txtProdName.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 28);
            this.label11.TabIndex = 29;
            this.label11.Text = "Element";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 708);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 28);
            this.label10.TabIndex = 28;
            this.label10.Text = "Usuń zaznaczone";
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(274, 333);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(100, 34);
            this.txtQuan.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 28);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ilość";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "Element";
            // 
            // cmbProdElem
            // 
            this.cmbProdElem.FormattingEnabled = true;
            this.cmbProdElem.Location = new System.Drawing.Point(73, 333);
            this.cmbProdElem.Name = "cmbProdElem";
            this.cmbProdElem.Size = new System.Drawing.Size(195, 36);
            this.cmbProdElem.TabIndex = 24;
            // 
            // tvProduct
            // 
            this.tvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvProduct.Location = new System.Drawing.Point(6, 6);
            this.tvProduct.Name = "tvProduct";
            this.tvProduct.Size = new System.Drawing.Size(421, 784);
            this.tvProduct.TabIndex = 4;
            this.tvProduct.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProduct_AfterSelect);
            // 
            // tpProdTask
            // 
            this.tpProdTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpProdTask.Controls.Add(this.groupBox5);
            this.tpProdTask.Controls.Add(this.tvProd);
            this.tpProdTask.Controls.Add(this.btnDeleteType);
            this.tpProdTask.Location = new System.Drawing.Point(4, 37);
            this.tpProdTask.Name = "tpProdTask";
            this.tpProdTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpProdTask.Size = new System.Drawing.Size(1870, 796);
            this.tpProdTask.TabIndex = 2;
            this.tpProdTask.Text = "Słownik zadań produkcyjnych";
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
            // tvProd
            // 
            this.tvProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvProd.Location = new System.Drawing.Point(6, 6);
            this.tvProd.Name = "tvProd";
            this.tvProd.Size = new System.Drawing.Size(260, 784);
            this.tvProd.TabIndex = 2;
            this.tvProd.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProd_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbProd);
            this.groupBox1.Controls.Add(this.btnAddTypeDuty);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbDutyTypes);
            this.groupBox1.Location = new System.Drawing.Point(315, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 437);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj zadania do wybranego obowiązku";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDutyDelete);
            this.groupBox2.Controls.Add(this.txtDutyName);
            this.groupBox2.Controls.Add(this.btnDutySave);
            this.groupBox2.Location = new System.Drawing.Point(315, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 183);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wprowadź nowy obowiązek";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnProdAdd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnProdDel);
            this.groupBox3.Controls.Add(this.txtProdDescript);
            this.groupBox3.Controls.Add(this.txtProdName);
            this.groupBox3.Location = new System.Drawing.Point(451, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1077, 264);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodaj produkt";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvElem);
            this.groupBox4.Controls.Add(this.btnProdElemAdd);
            this.groupBox4.Controls.Add(this.cmbProdElem);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtQuan);
            this.groupBox4.Location = new System.Drawing.Point(451, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1077, 397);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wprowadź elementy";
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
            // btnDeleteType
            // 
            this.btnDeleteType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteType.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnDeleteType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteType.Location = new System.Drawing.Point(330, 672);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(173, 36);
            this.btnDeleteType.TabIndex = 16;
            this.btnDeleteType.Text = "Usuń ";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
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
            // btnElemDel
            // 
            this.btnElemDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElemDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElemDel.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnElemDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElemDel.Location = new System.Drawing.Point(294, 688);
            this.btnElemDel.Name = "btnElemDel";
            this.btnElemDel.Size = new System.Drawing.Size(173, 36);
            this.btnElemDel.TabIndex = 21;
            this.btnElemDel.Text = "Usuń ";
            this.btnElemDel.UseVisualStyleBackColor = true;
            this.btnElemDel.Click += new System.EventHandler(this.btnElemDel_Click);
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
            // btnDutyDelete
            // 
            this.btnDutyDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDutyDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDutyDelete.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnDutyDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDutyDelete.Location = new System.Drawing.Point(628, 100);
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
            this.btnDutySave.Location = new System.Drawing.Point(395, 100);
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
            this.btnDutyTypeDelete.Location = new System.Drawing.Point(305, 754);
            this.btnDutyTypeDelete.Name = "btnDutyTypeDelete";
            this.btnDutyTypeDelete.Size = new System.Drawing.Size(157, 36);
            this.btnDutyTypeDelete.TabIndex = 20;
            this.btnDutyTypeDelete.Text = "Usuń ";
            this.btnDutyTypeDelete.UseVisualStyleBackColor = true;
            this.btnDutyTypeDelete.Click += new System.EventHandler(this.btnDutyTypeDelete_Click);
            // 
            // btnProdElemAdd
            // 
            this.btnProdElemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdElemAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProdElemAdd.Image = global::RCPSystem.Properties.Resources.Add1;
            this.btnProdElemAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdElemAdd.Location = new System.Drawing.Point(432, 334);
            this.btnProdElemAdd.Name = "btnProdElemAdd";
            this.btnProdElemAdd.Size = new System.Drawing.Size(147, 36);
            this.btnProdElemAdd.TabIndex = 22;
            this.btnProdElemAdd.Text = "Dodaj";
            this.btnProdElemAdd.UseVisualStyleBackColor = true;
            this.btnProdElemAdd.Click += new System.EventHandler(this.btnProdElemAdd_Click);
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
            this.btnProdDel.Click += new System.EventHandler(this.btnProdDel_Click);
            // 
            // btnSaveProdData
            // 
            this.btnSaveProdData.Image = global::RCPSystem.Properties.Resources.Floppy2;
            this.btnSaveProdData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProdData.Location = new System.Drawing.Point(1585, 24);
            this.btnSaveProdData.Name = "btnSaveProdData";
            this.btnSaveProdData.Size = new System.Drawing.Size(201, 71);
            this.btnSaveProdData.TabIndex = 35;
            this.btnSaveProdData.Text = "Aktualizuj dane";
            this.btnSaveProdData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveProdData.UseVisualStyleBackColor = true;
            this.btnSaveProdData.Click += new System.EventHandler(this.btnSaveProdData_Click);
            // 
            // btnPodElemeDel
            // 
            this.btnPodElemeDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodElemeDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPodElemeDel.Image = global::RCPSystem.Properties.Resources.Delete;
            this.btnPodElemeDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPodElemeDel.Location = new System.Drawing.Point(451, 749);
            this.btnPodElemeDel.Name = "btnPodElemeDel";
            this.btnPodElemeDel.Size = new System.Drawing.Size(147, 36);
            this.btnPodElemeDel.TabIndex = 23;
            this.btnPodElemeDel.Text = "Usuń ";
            this.btnPodElemeDel.UseVisualStyleBackColor = true;
            this.btnPodElemeDel.Click += new System.EventHandler(this.btnPodElemeDel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddType);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtTypeName);
            this.groupBox5.Location = new System.Drawing.Point(306, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(623, 230);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodaj nowe zadanie";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnElemAdd);
            this.groupBox6.Controls.Add(this.cmbElem);
            this.groupBox6.Controls.Add(this.txtElemName);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(306, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1072, 191);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dodaj nowy element";
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
            this.tpDuty.ResumeLayout(false);
            this.tpElement.ResumeLayout(false);
            this.tpProduct.ResumeLayout(false);
            this.tpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElem)).EndInit();
            this.tpProdTask.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.TreeView tvProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.TreeView tvProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProdElem;
        private System.Windows.Forms.Button btnPodElemeDel;
        private System.Windows.Forms.Button btnProdElemAdd;
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
        private System.Windows.Forms.TreeView tvElem;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}