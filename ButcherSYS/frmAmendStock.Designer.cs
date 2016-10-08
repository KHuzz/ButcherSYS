namespace ButcherSYS
{
    partial class frmAmendStock
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
            this.lblEnterStock = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpSearchStock = new System.Windows.Forms.GroupBox();
            this.txtDescSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchStockID = new System.Windows.Forms.TextBox();
            this.lblSearchStocjID = new System.Windows.Forms.Label();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtSaleP = new System.Windows.Forms.TextBox();
            this.txtCostP = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtBBD = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.txtWeightUnitQty = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.lblSaleP = new System.Windows.Forms.Label();
            this.lblCostP = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblBBDate = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblStockID = new System.Windows.Forms.Label();
            this.grpSearchStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.grpProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterStock
            // 
            this.lblEnterStock.AutoSize = true;
            this.lblEnterStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterStock.Location = new System.Drawing.Point(125, 9);
            this.lblEnterStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterStock.Name = "lblEnterStock";
            this.lblEnterStock.Size = new System.Drawing.Size(290, 26);
            this.lblEnterStock.TabIndex = 2;
            this.lblEnterStock.Text = "Please enter The Stock ID";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(709, 616);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 33);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(491, 32);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(69, 29);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Search";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // grpSearchStock
            // 
            this.grpSearchStock.Controls.Add(this.txtDescSearch);
            this.grpSearchStock.Controls.Add(this.label1);
            this.grpSearchStock.Controls.Add(this.txtSearchStockID);
            this.grpSearchStock.Controls.Add(this.btnConfirm);
            this.grpSearchStock.Controls.Add(this.lblSearchStocjID);
            this.grpSearchStock.Location = new System.Drawing.Point(96, 60);
            this.grpSearchStock.Name = "grpSearchStock";
            this.grpSearchStock.Size = new System.Drawing.Size(591, 94);
            this.grpSearchStock.TabIndex = 5;
            this.grpSearchStock.TabStop = false;
            this.grpSearchStock.Text = "Seach by";
            // 
            // txtDescSearch
            // 
            this.txtDescSearch.Location = new System.Drawing.Point(119, 32);
            this.txtDescSearch.Name = "txtDescSearch";
            this.txtDescSearch.Size = new System.Drawing.Size(192, 20);
            this.txtDescSearch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description:";
            // 
            // txtSearchStockID
            // 
            this.txtSearchStockID.Location = new System.Drawing.Point(402, 35);
            this.txtSearchStockID.Name = "txtSearchStockID";
            this.txtSearchStockID.Size = new System.Drawing.Size(62, 20);
            this.txtSearchStockID.TabIndex = 1;
            // 
            // lblSearchStocjID
            // 
            this.lblSearchStocjID.AutoSize = true;
            this.lblSearchStocjID.Location = new System.Drawing.Point(328, 40);
            this.lblSearchStocjID.Name = "lblSearchStocjID";
            this.lblSearchStocjID.Size = new System.Drawing.Size(68, 13);
            this.lblSearchStocjID.TabIndex = 0;
            this.lblSearchStocjID.Text = "OR Stock ID";
            // 
            // grdProducts
            // 
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Location = new System.Drawing.Point(101, 168);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.Size = new System.Drawing.Size(585, 147);
            this.grdProducts.TabIndex = 6;
            this.grdProducts.Visible = false;
            this.grdProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellClick);
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.lblDesc);
            this.grpProduct.Controls.Add(this.txtDesc);
            this.grpProduct.Controls.Add(this.txtSaleP);
            this.grpProduct.Controls.Add(this.txtCostP);
            this.grpProduct.Controls.Add(this.txtTemp);
            this.grpProduct.Controls.Add(this.txtBBD);
            this.grpProduct.Controls.Add(this.txtBatchNo);
            this.grpProduct.Controls.Add(this.txtWeightUnitQty);
            this.grpProduct.Controls.Add(this.btnUpdate);
            this.grpProduct.Controls.Add(this.txtStockID);
            this.grpProduct.Controls.Add(this.lblSaleP);
            this.grpProduct.Controls.Add(this.lblCostP);
            this.grpProduct.Controls.Add(this.lblTemp);
            this.grpProduct.Controls.Add(this.lblBBDate);
            this.grpProduct.Controls.Add(this.lblBatchNo);
            this.grpProduct.Controls.Add(this.lblWeight);
            this.grpProduct.Controls.Add(this.lblStockID);
            this.grpProduct.Location = new System.Drawing.Point(110, 345);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(594, 304);
            this.grpProduct.TabIndex = 8;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Edit Product Details";
            this.grpProduct.Visible = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(29, 68);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(94, 18);
            this.lblDesc.TabIndex = 44;
            this.lblDesc.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(203, 66);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(175, 20);
            this.txtDesc.TabIndex = 43;
            // 
            // txtSaleP
            // 
            this.txtSaleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleP.Location = new System.Drawing.Point(203, 241);
            this.txtSaleP.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleP.Name = "txtSaleP";
            this.txtSaleP.Size = new System.Drawing.Size(175, 23);
            this.txtSaleP.TabIndex = 42;
            // 
            // txtCostP
            // 
            this.txtCostP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostP.Location = new System.Drawing.Point(203, 197);
            this.txtCostP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostP.Name = "txtCostP";
            this.txtCostP.Size = new System.Drawing.Size(175, 23);
            this.txtCostP.TabIndex = 41;
            // 
            // txtTemp
            // 
            this.txtTemp.Enabled = false;
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(203, 159);
            this.txtTemp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(175, 23);
            this.txtTemp.TabIndex = 40;
            // 
            // txtBBD
            // 
            this.txtBBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBBD.Location = new System.Drawing.Point(203, 118);
            this.txtBBD.Margin = new System.Windows.Forms.Padding(2);
            this.txtBBD.Name = "txtBBD";
            this.txtBBD.Size = new System.Drawing.Size(175, 23);
            this.txtBBD.TabIndex = 39;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Enabled = false;
            this.txtBatchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNo.Location = new System.Drawing.Point(203, 91);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(175, 23);
            this.txtBatchNo.TabIndex = 38;
            // 
            // txtWeightUnitQty
            // 
            this.txtWeightUnitQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightUnitQty.Location = new System.Drawing.Point(477, 27);
            this.txtWeightUnitQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeightUnitQty.Name = "txtWeightUnitQty";
            this.txtWeightUnitQty.Size = new System.Drawing.Size(63, 23);
            this.txtWeightUnitQty.TabIndex = 37;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(406, 241);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 30);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStockID
            // 
            this.txtStockID.Enabled = false;
            this.txtStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockID.Location = new System.Drawing.Point(203, 26);
            this.txtStockID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(63, 23);
            this.txtStockID.TabIndex = 35;
            // 
            // lblSaleP
            // 
            this.lblSaleP.AutoSize = true;
            this.lblSaleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleP.Location = new System.Drawing.Point(29, 241);
            this.lblSaleP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaleP.Name = "lblSaleP";
            this.lblSaleP.Size = new System.Drawing.Size(82, 17);
            this.lblSaleP.TabIndex = 34;
            this.lblSaleP.Text = "Sale Price";
            // 
            // lblCostP
            // 
            this.lblCostP.AutoSize = true;
            this.lblCostP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostP.Location = new System.Drawing.Point(29, 197);
            this.lblCostP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostP.Name = "lblCostP";
            this.lblCostP.Size = new System.Drawing.Size(82, 17);
            this.lblCostP.TabIndex = 33;
            this.lblCostP.Text = "Cost Price";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(29, 159);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(101, 17);
            this.lblTemp.TabIndex = 32;
            this.lblTemp.Text = "Temperature";
            // 
            // lblBBDate
            // 
            this.lblBBDate.AutoSize = true;
            this.lblBBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBBDate.Location = new System.Drawing.Point(29, 118);
            this.lblBBDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBBDate.Name = "lblBBDate";
            this.lblBBDate.Size = new System.Drawing.Size(132, 17);
            this.lblBBDate.TabIndex = 31;
            this.lblBBDate.Text = "Best Before Date";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchNo.Location = new System.Drawing.Point(29, 97);
            this.lblBatchNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(74, 17);
            this.lblBatchNo.TabIndex = 30;
            this.lblBatchNo.Text = "BatchNo.";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(303, 27);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(122, 17);
            this.lblWeight.TabIndex = 29;
            this.lblWeight.Text = "Weight Unit Qty";
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.Location = new System.Drawing.Point(29, 27);
            this.lblStockID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(63, 17);
            this.lblStockID.TabIndex = 28;
            this.lblStockID.Text = "StockID";
            // 
            // frmAmendStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(885, 673);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.grpSearchStock);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEnterStock);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAmendStock";
            this.Text = "AmendStock";
            this.Load += new System.EventHandler(this.frmAmendStock_Load);
            this.grpSearchStock.ResumeLayout(false);
            this.grpSearchStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterStock;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox grpSearchStock;
        private System.Windows.Forms.TextBox txtSearchStockID;
        private System.Windows.Forms.Label lblSearchStocjID;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.TextBox txtDescSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.TextBox txtSaleP;
        private System.Windows.Forms.TextBox txtCostP;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtBBD;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.TextBox txtWeightUnitQty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.Label lblSaleP;
        private System.Windows.Forms.Label lblCostP;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblBBDate;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        //   private frmStock frmStock;


    }
}