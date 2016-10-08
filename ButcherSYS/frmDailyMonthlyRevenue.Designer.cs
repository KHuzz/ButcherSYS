namespace ButcherSYS
{
    partial class frmDailyMonthlyRevenue
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
            this.grdViewSales = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSaleItems = new System.Windows.Forms.Button();
            this.btnTotalSales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTotalSale = new System.Windows.Forms.GroupBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.grpSaleItems = new System.Windows.Forms.GroupBox();
            this.txtSaleItemID = new System.Windows.Forms.TextBox();
            this.btnSTotalSale = new System.Windows.Forms.Button();
            this.btnSSaleItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSales)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpTotalSale.SuspendLayout();
            this.grpSaleItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 432);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 46);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdViewSales
            // 
            this.grdViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewSales.Location = new System.Drawing.Point(15, 253);
            this.grdViewSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdViewSales.Name = "grdViewSales";
            this.grdViewSales.Size = new System.Drawing.Size(753, 173);
            this.grdViewSales.TabIndex = 1;
            this.grdViewSales.Visible = false;
            this.grdViewSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewSales_CellContentClick);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSaleItems);
            this.grpSearch.Controls.Add(this.btnTotalSales);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Location = new System.Drawing.Point(19, 10);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearch.Size = new System.Drawing.Size(751, 135);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Stock: ";
            // 
            // btnSaleItems
            // 
            this.btnSaleItems.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSaleItems.Location = new System.Drawing.Point(433, 60);
            this.btnSaleItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaleItems.Name = "btnSaleItems";
            this.btnSaleItems.Size = new System.Drawing.Size(256, 44);
            this.btnSaleItems.TabIndex = 5;
            this.btnSaleItems.Text = "Sale Items";
            this.btnSaleItems.UseVisualStyleBackColor = false;
            this.btnSaleItems.Click += new System.EventHandler(this.btnSaleItems_Click);
            // 
            // btnTotalSales
            // 
            this.btnTotalSales.BackColor = System.Drawing.Color.Cyan;
            this.btnTotalSales.Location = new System.Drawing.Point(37, 60);
            this.btnTotalSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTotalSales.Name = "btnTotalSales";
            this.btnTotalSales.Size = new System.Drawing.Size(256, 46);
            this.btnTotalSales.TabIndex = 4;
            this.btnTotalSales.Text = "Total Sales";
            this.btnTotalSales.UseVisualStyleBackColor = false;
            this.btnTotalSales.Click += new System.EventHandler(this.btnTotalSales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select Total Cash Sales or Sale Items\r\n";
            // 
            // grpTotalSale
            // 
            this.grpTotalSale.Controls.Add(this.btnSTotalSale);
            this.grpTotalSale.Controls.Add(this.txtSaleID);
            this.grpTotalSale.Location = new System.Drawing.Point(25, 156);
            this.grpTotalSale.Name = "grpTotalSale";
            this.grpTotalSale.Size = new System.Drawing.Size(351, 79);
            this.grpTotalSale.TabIndex = 4;
            this.grpTotalSale.TabStop = false;
            this.grpTotalSale.Text = "Please enter SaleID: ";
            this.grpTotalSale.Visible = false;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(15, 27);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(175, 22);
            this.txtSaleID.TabIndex = 0;
            // 
            // grpSaleItems
            // 
            this.grpSaleItems.Controls.Add(this.btnSSaleItem);
            this.grpSaleItems.Controls.Add(this.txtSaleItemID);
            this.grpSaleItems.Location = new System.Drawing.Point(421, 156);
            this.grpSaleItems.Name = "grpSaleItems";
            this.grpSaleItems.Size = new System.Drawing.Size(347, 78);
            this.grpSaleItems.TabIndex = 5;
            this.grpSaleItems.TabStop = false;
            this.grpSaleItems.Text = "Pleases enter SaleID: ";
            this.grpSaleItems.Visible = false;
            // 
            // txtSaleItemID
            // 
            this.txtSaleItemID.Location = new System.Drawing.Point(18, 27);
            this.txtSaleItemID.Name = "txtSaleItemID";
            this.txtSaleItemID.Size = new System.Drawing.Size(175, 22);
            this.txtSaleItemID.TabIndex = 0;
            // 
            // btnSTotalSale
            // 
            this.btnSTotalSale.Location = new System.Drawing.Point(225, 21);
            this.btnSTotalSale.Name = "btnSTotalSale";
            this.btnSTotalSale.Size = new System.Drawing.Size(109, 36);
            this.btnSTotalSale.TabIndex = 1;
            this.btnSTotalSale.Text = "Search";
            this.btnSTotalSale.UseVisualStyleBackColor = true;
            this.btnSTotalSale.Click += new System.EventHandler(this.btnSTotalSale_Click);
            // 
            // btnSSaleItem
            // 
            this.btnSSaleItem.Location = new System.Drawing.Point(227, 21);
            this.btnSSaleItem.Name = "btnSSaleItem";
            this.btnSSaleItem.Size = new System.Drawing.Size(103, 36);
            this.btnSSaleItem.TabIndex = 1;
            this.btnSSaleItem.Text = "Search";
            this.btnSSaleItem.UseVisualStyleBackColor = true;
            this.btnSSaleItem.Click += new System.EventHandler(this.btnSSaleItem_Click);
            // 
            // frmDailyMonthlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(785, 501);
            this.Controls.Add(this.grpSaleItems);
            this.Controls.Add(this.grpTotalSale);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grdViewSales);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDailyMonthlyRevenue";
            this.Text = "DailyMonthlyRevenue";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSales)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpTotalSale.ResumeLayout(false);
            this.grpTotalSale.PerformLayout();
            this.grpSaleItems.ResumeLayout(false);
            this.grpSaleItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdViewSales;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaleItems;
        private System.Windows.Forms.Button btnTotalSales;
        private System.Windows.Forms.GroupBox grpTotalSale;
        private System.Windows.Forms.Button btnSTotalSale;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.GroupBox grpSaleItems;
        private System.Windows.Forms.Button btnSSaleItem;
        private System.Windows.Forms.TextBox txtSaleItemID;
    }
}