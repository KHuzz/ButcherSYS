namespace ButcherSYS
{
    partial class frmAddStock
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
            this.lblStockID = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.lblBBDate = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblCostP = new System.Windows.Forms.Label();
            this.lblSaleP = new System.Windows.Forms.Label();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtWeightUnitQty = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.txtBBD = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtCostP = new System.Windows.Forms.TextBox();
            this.txtSaleP = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.Location = new System.Drawing.Point(146, 49);
            this.lblStockID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(63, 17);
            this.lblStockID.TabIndex = 0;
            this.lblStockID.Text = "StockID";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(146, 136);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(122, 17);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight Unit Qty";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchNo.Location = new System.Drawing.Point(146, 179);
            this.lblBatchNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(74, 17);
            this.lblBatchNo.TabIndex = 4;
            this.lblBatchNo.Text = "BatchNo.";
            // 
            // lblBBDate
            // 
            this.lblBBDate.AutoSize = true;
            this.lblBBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBBDate.Location = new System.Drawing.Point(146, 238);
            this.lblBBDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBBDate.Name = "lblBBDate";
            this.lblBBDate.Size = new System.Drawing.Size(132, 17);
            this.lblBBDate.TabIndex = 5;
            this.lblBBDate.Text = "Best Before Date";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(146, 288);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(101, 17);
            this.lblTemp.TabIndex = 6;
            this.lblTemp.Text = "Temperature";
            // 
            // lblCostP
            // 
            this.lblCostP.AutoSize = true;
            this.lblCostP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostP.Location = new System.Drawing.Point(146, 341);
            this.lblCostP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostP.Name = "lblCostP";
            this.lblCostP.Size = new System.Drawing.Size(82, 17);
            this.lblCostP.TabIndex = 7;
            this.lblCostP.Text = "Cost Price";
            // 
            // lblSaleP
            // 
            this.lblSaleP.AutoSize = true;
            this.lblSaleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleP.Location = new System.Drawing.Point(146, 383);
            this.lblSaleP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaleP.Name = "lblSaleP";
            this.lblSaleP.Size = new System.Drawing.Size(82, 17);
            this.lblSaleP.TabIndex = 8;
            this.lblSaleP.Text = "Sale Price";
            // 
            // txtStockID
            // 
            this.txtStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockID.Location = new System.Drawing.Point(320, 46);
            this.txtStockID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStockID.MaxLength = 4;
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(175, 23);
            this.txtStockID.TabIndex = 9;
            this.txtStockID.TextChanged += new System.EventHandler(this.txtStockID_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(535, 485);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 30);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(320, 449);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(102, 30);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtWeightUnitQty
            // 
            this.txtWeightUnitQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightUnitQty.Location = new System.Drawing.Point(320, 130);
            this.txtWeightUnitQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWeightUnitQty.MaxLength = 2;
            this.txtWeightUnitQty.Name = "txtWeightUnitQty";
            this.txtWeightUnitQty.Size = new System.Drawing.Size(175, 23);
            this.txtWeightUnitQty.TabIndex = 21;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNo.Location = new System.Drawing.Point(320, 173);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBatchNo.MaxLength = 2;
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(175, 23);
            this.txtBatchNo.TabIndex = 23;
            // 
            // txtBBD
            // 
            this.txtBBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBBD.Location = new System.Drawing.Point(320, 232);
            this.txtBBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBBD.MaxLength = 6;
            this.txtBBD.Name = "txtBBD";
            this.txtBBD.Size = new System.Drawing.Size(175, 23);
            this.txtBBD.TabIndex = 24;
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(320, 282);
            this.txtTemp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTemp.MaxLength = 3;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(175, 23);
            this.txtTemp.TabIndex = 25;
            // 
            // txtCostP
            // 
            this.txtCostP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostP.Location = new System.Drawing.Point(320, 335);
            this.txtCostP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCostP.MaxLength = 4;
            this.txtCostP.Name = "txtCostP";
            this.txtCostP.Size = new System.Drawing.Size(175, 23);
            this.txtCostP.TabIndex = 26;
            // 
            // txtSaleP
            // 
            this.txtSaleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleP.Location = new System.Drawing.Point(320, 377);
            this.txtSaleP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSaleP.MaxLength = 6;
            this.txtSaleP.Name = "txtSaleP";
            this.txtSaleP.Size = new System.Drawing.Size(175, 23);
            this.txtSaleP.TabIndex = 27;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(146, 94);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(90, 17);
            this.lblDesc.TabIndex = 28;
            this.lblDesc.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(320, 88);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesc.MaxLength = 20;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(175, 23);
            this.txtDesc.TabIndex = 29;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Please enter date in format \"ddmyy\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Temp must be between 0-5 C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "€";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cost and Sale Price in format 000.00";
            // 
            // frmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 526);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtSaleP);
            this.Controls.Add(this.txtCostP);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtBBD);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.txtWeightUnitQty);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtStockID);
            this.Controls.Add(this.lblSaleP);
            this.Controls.Add(this.lblCostP);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblBBDate);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblStockID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddStock";
            this.Text = "Add Stock";
            this.Load += new System.EventHandler(this.frmAddStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.Label lblBBDate;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblCostP;
        private System.Windows.Forms.Label lblSaleP;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtWeightUnitQty;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.TextBox txtBBD;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtCostP;
        private System.Windows.Forms.TextBox txtSaleP;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
     

     
    }
}