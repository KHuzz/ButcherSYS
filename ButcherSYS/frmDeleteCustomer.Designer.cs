namespace ButcherSYS
{
    partial class frmDeleteCustomer
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
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCust = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdCust = new System.Windows.Forms.DataGridView();
            this.grpCustDetails.SuspendLayout();
            this.grpCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(9, 332);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.btnSearch);
            this.grpCustDetails.Controls.Add(this.txtSearchCust);
            this.grpCustDetails.Controls.Add(this.label1);
            this.grpCustDetails.Location = new System.Drawing.Point(54, 17);
            this.grpCustDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustDetails.Size = new System.Drawing.Size(533, 70);
            this.grpCustDetails.TabIndex = 2;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Delete Customer: ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(386, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Location = new System.Drawing.Point(214, 25);
            this.txtSearchCust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(149, 20);
            this.txtSearchCust.TabIndex = 1;
            this.txtSearchCust.TextChanged += new System.EventHandler(this.txtSearchCust_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter Customer Surname: ";
            // 
            // grpCust
            // 
            this.grpCust.Controls.Add(this.btnDelete);
            this.grpCust.Controls.Add(this.grdCust);
            this.grpCust.Location = new System.Drawing.Point(56, 101);
            this.grpCust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCust.Name = "grpCust";
            this.grpCust.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCust.Size = new System.Drawing.Size(531, 207);
            this.grpCust.TabIndex = 3;
            this.grpCust.TabStop = false;
            this.grpCust.Text = "Customer Details";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDelete.Location = new System.Drawing.Point(373, 159);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdCust
            // 
            this.grdCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCust.Location = new System.Drawing.Point(14, 23);
            this.grdCust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdCust.Name = "grdCust";
            this.grdCust.RowTemplate.Height = 24;
            this.grdCust.Size = new System.Drawing.Size(482, 123);
            this.grdCust.TabIndex = 0;
            this.grdCust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCust_CellContentClick);
            // 
            // frmDeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(699, 374);
            this.Controls.Add(this.grpCust);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDeleteCustomer";
            this.Text = "DeleteCustomer";
            this.Load += new System.EventHandler(this.DeleteCustomer_Load);
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            this.grpCust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCust;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grdCust;
    }
}