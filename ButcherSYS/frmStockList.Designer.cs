namespace ButcherSYS
{
    partial class frmStockList
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
            this.grdStock = new System.Windows.Forms.DataGridView();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.radStockNo = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdStock
            // 
            this.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStock.Location = new System.Drawing.Point(61, 236);
            this.grdStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdStock.Name = "grdStock";
            this.grdStock.Size = new System.Drawing.Size(711, 357);
            this.grdStock.TabIndex = 0;
            this.grdStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStock_CellContentClick);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.radStockNo);
            this.grpOrder.Controls.Add(this.radioButton1);
            this.grpOrder.Location = new System.Drawing.Point(73, 92);
            this.grpOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrder.Size = new System.Drawing.Size(697, 116);
            this.grpOrder.TabIndex = 1;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Stock Details";
            // 
            // radStockNo
            // 
            this.radStockNo.AutoSize = true;
            this.radStockNo.Location = new System.Drawing.Point(420, 25);
            this.radStockNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radStockNo.Name = "radStockNo";
            this.radStockNo.Size = new System.Drawing.Size(90, 21);
            this.radStockNo.TabIndex = 1;
            this.radStockNo.TabStop = true;
            this.radStockNo.Text = "Stock No.";
            this.radStockNo.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 25);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Description";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(367, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            // 
            // frmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 758);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grdStock);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStockList";
            this.Text = "frmStockList";
            this.Load += new System.EventHandler(this.frmStockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdStock;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.RadioButton radStockNo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblDate;
    }
}