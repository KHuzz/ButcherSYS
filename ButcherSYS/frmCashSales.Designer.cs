namespace ButcherSYS
{
    partial class frmCashSales
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCustSur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grdCustDetails = new System.Windows.Forms.DataGridView();
            this.grpCustDetails1 = new System.Windows.Forms.GroupBox();
            this.txtCustEMail = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtBuisName = new System.Windows.Forms.TextBox();
            this.txtCustFore = new System.Windows.Forms.TextBox();
            this.txtCustSur1 = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectCust = new System.Windows.Forms.Button();
            this.grpStockDetails = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFindStock = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdStock = new System.Windows.Forms.DataGridView();
            this.txtFindStock = new System.Windows.Forms.TextBox();
            this.lblStockDesc = new System.Windows.Forms.Label();
            this.grpShopping = new System.Windows.Forms.GroupBox();
            this.txtSaleItemID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lstShopping = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.grpCustDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustDetails)).BeginInit();
            this.grpCustDetails1.SuspendLayout();
            this.grpStockDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            this.grpShopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 919);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Lime;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(608, 138);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 78);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate Sale";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.btnFind);
            this.grpCustDetails.Controls.Add(this.txtCustSur);
            this.grpCustDetails.Controls.Add(this.label3);
            this.grpCustDetails.Location = new System.Drawing.Point(44, 36);
            this.grpCustDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustDetails.Size = new System.Drawing.Size(567, 95);
            this.grpCustDetails.TabIndex = 14;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Enter Customer Details:";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFind.Location = new System.Drawing.Point(416, 33);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(101, 39);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtCustSur
            // 
            this.txtCustSur.Location = new System.Drawing.Point(171, 38);
            this.txtCustSur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustSur.Name = "txtCustSur";
            this.txtCustSur.Size = new System.Drawing.Size(183, 22);
            this.txtCustSur.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Surname: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sales";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(677, 15);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date: ";
            // 
            // grdCustDetails
            // 
            this.grdCustDetails.AllowUserToAddRows = false;
            this.grdCustDetails.AllowUserToDeleteRows = false;
            this.grdCustDetails.AllowUserToResizeColumns = false;
            this.grdCustDetails.AllowUserToResizeRows = false;
            this.grdCustDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustDetails.Location = new System.Drawing.Point(44, 137);
            this.grdCustDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCustDetails.Name = "grdCustDetails";
            this.grdCustDetails.RowTemplate.Height = 24;
            this.grdCustDetails.Size = new System.Drawing.Size(789, 105);
            this.grdCustDetails.TabIndex = 18;
            this.grdCustDetails.Visible = false;
            this.grdCustDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustDetails_CellContentClick);
            this.grdCustDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustDetails_CellContentClick);
            // 
            // grpCustDetails1
            // 
            this.grpCustDetails1.Controls.Add(this.txtCustEMail);
            this.grpCustDetails1.Controls.Add(this.txtCustPhone);
            this.grpCustDetails1.Controls.Add(this.txtAdd3);
            this.grpCustDetails1.Controls.Add(this.txtAdd2);
            this.grpCustDetails1.Controls.Add(this.txtAdd1);
            this.grpCustDetails1.Controls.Add(this.txtBuisName);
            this.grpCustDetails1.Controls.Add(this.txtCustFore);
            this.grpCustDetails1.Controls.Add(this.txtCustSur1);
            this.grpCustDetails1.Controls.Add(this.txtCustID);
            this.grpCustDetails1.Controls.Add(this.label12);
            this.grpCustDetails1.Controls.Add(this.label11);
            this.grpCustDetails1.Controls.Add(this.label10);
            this.grpCustDetails1.Controls.Add(this.label9);
            this.grpCustDetails1.Controls.Add(this.label8);
            this.grpCustDetails1.Controls.Add(this.label7);
            this.grpCustDetails1.Controls.Add(this.label6);
            this.grpCustDetails1.Controls.Add(this.label5);
            this.grpCustDetails1.Controls.Add(this.label4);
            this.grpCustDetails1.Controls.Add(this.btnSelectCust);
            this.grpCustDetails1.Location = new System.Drawing.Point(44, 246);
            this.grpCustDetails1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustDetails1.Name = "grpCustDetails1";
            this.grpCustDetails1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustDetails1.Size = new System.Drawing.Size(787, 206);
            this.grpCustDetails1.TabIndex = 19;
            this.grpCustDetails1.TabStop = false;
            this.grpCustDetails1.Text = "Customer Details: ";
            this.grpCustDetails1.Visible = false;
            // 
            // txtCustEMail
            // 
            this.txtCustEMail.Enabled = false;
            this.txtCustEMail.Location = new System.Drawing.Point(411, 121);
            this.txtCustEMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustEMail.Name = "txtCustEMail";
            this.txtCustEMail.Size = new System.Drawing.Size(157, 22);
            this.txtCustEMail.TabIndex = 18;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Enabled = false;
            this.txtCustPhone.Location = new System.Drawing.Point(411, 86);
            this.txtCustPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(157, 22);
            this.txtCustPhone.TabIndex = 17;
            // 
            // txtAdd3
            // 
            this.txtAdd3.Enabled = false;
            this.txtAdd3.Location = new System.Drawing.Point(411, 53);
            this.txtAdd3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.Size = new System.Drawing.Size(157, 22);
            this.txtAdd3.TabIndex = 16;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Enabled = false;
            this.txtAdd2.Location = new System.Drawing.Point(411, 21);
            this.txtAdd2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(157, 22);
            this.txtAdd2.TabIndex = 15;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Enabled = false;
            this.txtAdd1.Location = new System.Drawing.Point(121, 150);
            this.txtAdd1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(157, 22);
            this.txtAdd1.TabIndex = 14;
            // 
            // txtBuisName
            // 
            this.txtBuisName.Enabled = false;
            this.txtBuisName.Location = new System.Drawing.Point(121, 114);
            this.txtBuisName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuisName.Name = "txtBuisName";
            this.txtBuisName.Size = new System.Drawing.Size(157, 22);
            this.txtBuisName.TabIndex = 13;
            // 
            // txtCustFore
            // 
            this.txtCustFore.Enabled = false;
            this.txtCustFore.Location = new System.Drawing.Point(121, 79);
            this.txtCustFore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustFore.Name = "txtCustFore";
            this.txtCustFore.Size = new System.Drawing.Size(157, 22);
            this.txtCustFore.TabIndex = 12;
            // 
            // txtCustSur1
            // 
            this.txtCustSur1.Enabled = false;
            this.txtCustSur1.Location = new System.Drawing.Point(123, 50);
            this.txtCustSur1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustSur1.Name = "txtCustSur1";
            this.txtCustSur1.Size = new System.Drawing.Size(157, 22);
            this.txtCustSur1.TabIndex = 11;
            // 
            // txtCustID
            // 
            this.txtCustID.Enabled = false;
            this.txtCustID.Location = new System.Drawing.Point(123, 25);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(157, 22);
            this.txtCustID.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Customer E-Mail: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Customer Phone: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Address 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Address 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Customer ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Address 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Buisness Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Forename: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Surname: ";
            // 
            // btnSelectCust
            // 
            this.btnSelectCust.BackColor = System.Drawing.Color.LightBlue;
            this.btnSelectCust.Location = new System.Drawing.Point(629, 159);
            this.btnSelectCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectCust.Name = "btnSelectCust";
            this.btnSelectCust.Size = new System.Drawing.Size(151, 41);
            this.btnSelectCust.TabIndex = 0;
            this.btnSelectCust.Text = "Select";
            this.btnSelectCust.UseVisualStyleBackColor = false;
            this.btnSelectCust.Click += new System.EventHandler(this.btnSelectCust_Click);
            // 
            // grpStockDetails
            // 
            this.grpStockDetails.Controls.Add(this.txtQty);
            this.grpStockDetails.Controls.Add(this.label13);
            this.grpStockDetails.Controls.Add(this.btnFindStock);
            this.grpStockDetails.Controls.Add(this.btnAdd);
            this.grpStockDetails.Controls.Add(this.grdStock);
            this.grpStockDetails.Controls.Add(this.txtFindStock);
            this.grpStockDetails.Controls.Add(this.lblStockDesc);
            this.grpStockDetails.Location = new System.Drawing.Point(45, 473);
            this.grpStockDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStockDetails.Name = "grpStockDetails";
            this.grpStockDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStockDetails.Size = new System.Drawing.Size(779, 178);
            this.grpStockDetails.TabIndex = 20;
            this.grpStockDetails.TabStop = false;
            this.grpStockDetails.Text = "Stock Details: ";
            this.grpStockDetails.Visible = false;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(457, 20);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(132, 22);
            this.txtQty.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Qty";
            // 
            // btnFindStock
            // 
            this.btnFindStock.BackColor = System.Drawing.Color.YellowGreen;
            this.btnFindStock.Location = new System.Drawing.Point(336, 21);
            this.btnFindStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindStock.Name = "btnFindStock";
            this.btnFindStock.Size = new System.Drawing.Size(68, 33);
            this.btnFindStock.TabIndex = 5;
            this.btnFindStock.Text = "Find";
            this.btnFindStock.UseVisualStyleBackColor = false;
            this.btnFindStock.Click += new System.EventHandler(this.btnFindStock_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Location = new System.Drawing.Point(608, 124);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdStock
            // 
            this.grdStock.AllowUserToAddRows = false;
            this.grdStock.AllowUserToDeleteRows = false;
            this.grdStock.AllowUserToResizeColumns = false;
            this.grdStock.AllowUserToResizeRows = false;
            this.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStock.Location = new System.Drawing.Point(27, 66);
            this.grdStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdStock.Name = "grdStock";
            this.grdStock.ReadOnly = true;
            this.grdStock.RowTemplate.Height = 24;
            this.grdStock.Size = new System.Drawing.Size(564, 102);
            this.grdStock.TabIndex = 2;
            // 
            // txtFindStock
            // 
            this.txtFindStock.Location = new System.Drawing.Point(143, 26);
            this.txtFindStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFindStock.Name = "txtFindStock";
            this.txtFindStock.Size = new System.Drawing.Size(187, 22);
            this.txtFindStock.TabIndex = 1;
            this.txtFindStock.TextChanged += new System.EventHandler(this.txtFindStock_TextChanged);
            // 
            // lblStockDesc
            // 
            this.lblStockDesc.AutoSize = true;
            this.lblStockDesc.Location = new System.Drawing.Point(23, 31);
            this.lblStockDesc.Name = "lblStockDesc";
            this.lblStockDesc.Size = new System.Drawing.Size(126, 17);
            this.lblStockDesc.TabIndex = 0;
            this.lblStockDesc.Text = "Stock Description: ";
            // 
            // grpShopping
            // 
            this.grpShopping.Controls.Add(this.txtSaleItemID);
            this.grpShopping.Controls.Add(this.label15);
            this.grpShopping.Controls.Add(this.label14);
            this.grpShopping.Controls.Add(this.lstShopping);
            this.grpShopping.Controls.Add(this.lblTotal);
            this.grpShopping.Controls.Add(this.txtSaleID);
            this.grpShopping.Controls.Add(this.txtTotalSale);
            this.grpShopping.Controls.Add(this.btnCalculate);
            this.grpShopping.Location = new System.Drawing.Point(45, 656);
            this.grpShopping.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpShopping.Name = "grpShopping";
            this.grpShopping.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpShopping.Size = new System.Drawing.Size(779, 234);
            this.grpShopping.TabIndex = 21;
            this.grpShopping.TabStop = false;
            this.grpShopping.Text = "Shopping Cart";
            this.grpShopping.Visible = false;
            // 
            // txtSaleItemID
            // 
            this.txtSaleItemID.Enabled = false;
            this.txtSaleItemID.Location = new System.Drawing.Point(363, 36);
            this.txtSaleItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaleItemID.Name = "txtSaleItemID";
            this.txtSaleItemID.Size = new System.Drawing.Size(117, 22);
            this.txtSaleItemID.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = "Sales Item ID: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Sale ID:";
            // 
            // lstShopping
            // 
            this.lstShopping.FormattingEnabled = true;
            this.lstShopping.ItemHeight = 16;
            this.lstShopping.Location = new System.Drawing.Point(7, 80);
            this.lstShopping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstShopping.Name = "lstShopping";
            this.lstShopping.Size = new System.Drawing.Size(539, 148);
            this.lstShopping.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(555, 98);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 17);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: ";
            // 
            // txtSaleID
            // 
            this.txtSaleID.Enabled = false;
            this.txtSaleID.Location = new System.Drawing.Point(95, 41);
            this.txtSaleID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(89, 22);
            this.txtSaleID.TabIndex = 22;
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.Enabled = false;
            this.txtTotalSale.Location = new System.Drawing.Point(608, 96);
            this.txtTotalSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.Size = new System.Drawing.Size(137, 22);
            this.txtTotalSale.TabIndex = 1;
            this.txtTotalSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCashSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(859, 1047);
            this.Controls.Add(this.grpShopping);
            this.Controls.Add(this.grpStockDetails);
            this.Controls.Add(this.grpCustDetails1);
            this.Controls.Add(this.grdCustDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCashSales";
            this.Text = "CashSales";
            this.Load += new System.EventHandler(this.frmCashSales_Load);
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustDetails)).EndInit();
            this.grpCustDetails1.ResumeLayout(false);
            this.grpCustDetails1.PerformLayout();
            this.grpStockDetails.ResumeLayout(false);
            this.grpStockDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            this.grpShopping.ResumeLayout(false);
            this.grpShopping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCustSur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdCustDetails;
        private System.Windows.Forms.GroupBox grpCustDetails1;
        private System.Windows.Forms.TextBox txtCustEMail;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtAdd3;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtBuisName;
        private System.Windows.Forms.TextBox txtCustFore;
        private System.Windows.Forms.TextBox txtCustSur1;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectCust;
        private System.Windows.Forms.GroupBox grpStockDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdStock;
        private System.Windows.Forms.TextBox txtFindStock;
        private System.Windows.Forms.Label lblStockDesc;
        private System.Windows.Forms.GroupBox grpShopping;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.Button btnFindStock;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstShopping;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSaleItemID;
        private System.Windows.Forms.Label label15;
    }
}