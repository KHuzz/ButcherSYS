namespace ButcherSYS
{
    partial class frmAmendCustomer
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
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustForeName = new System.Windows.Forms.Label();
            this.lblBuisName = new System.Windows.Forms.Label();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.lblAdd3 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCustForeName = new System.Windows.Forms.TextBox();
            this.txtBuisName = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.txtCustP = new System.Windows.Forms.TextBox();
            this.txtCustE = new System.Windows.Forms.TextBox();
            this.lblCustSurname = new System.Windows.Forms.Label();
            this.txtCustSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCustSur = new System.Windows.Forms.TextBox();
            this.grpSearchCust = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.txtCustID_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.grpSearchCust.SuspendLayout();
            this.grpCustDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(5, 692);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(13, 33);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(109, 20);
            this.lblCustID.TabIndex = 1;
            this.lblCustID.Text = "CustomerID";
            // 
            // txtCustID
            // 
            this.txtCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustID.Location = new System.Drawing.Point(140, 27);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(81, 26);
            this.txtCustID.TabIndex = 2;
            this.txtCustID.TextChanged += new System.EventHandler(this.txtCustID_TextChanged);
            // 
            // lblCustForeName
            // 
            this.lblCustForeName.AutoSize = true;
            this.lblCustForeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustForeName.Location = new System.Drawing.Point(23, 96);
            this.lblCustForeName.Name = "lblCustForeName";
            this.lblCustForeName.Size = new System.Drawing.Size(144, 20);
            this.lblCustForeName.TabIndex = 3;
            this.lblCustForeName.Text = "Customer Name";
            // 
            // lblBuisName
            // 
            this.lblBuisName.AutoSize = true;
            this.lblBuisName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuisName.Location = new System.Drawing.Point(27, 177);
            this.lblBuisName.Name = "lblBuisName";
            this.lblBuisName.Size = new System.Drawing.Size(141, 20);
            this.lblBuisName.TabIndex = 4;
            this.lblBuisName.Text = "Buisness Name";
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd1.Location = new System.Drawing.Point(29, 224);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(94, 20);
            this.lblAdd1.TabIndex = 5;
            this.lblAdd1.Text = "Address 1";
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd2.Location = new System.Drawing.Point(27, 261);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(94, 20);
            this.lblAdd2.TabIndex = 6;
            this.lblAdd2.Text = "Address 2";
            // 
            // lblAdd3
            // 
            this.lblAdd3.AutoSize = true;
            this.lblAdd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd3.Location = new System.Drawing.Point(27, 300);
            this.lblAdd3.Name = "lblAdd3";
            this.lblAdd3.Size = new System.Drawing.Size(94, 20);
            this.lblAdd3.TabIndex = 7;
            this.lblAdd3.Text = "Address 3";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(27, 341);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMail.Location = new System.Drawing.Point(27, 377);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(63, 20);
            this.lblEMail.TabIndex = 9;
            this.lblEMail.Text = "E-Mail";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(491, 308);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 38);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCustForeName
            // 
            this.txtCustForeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustForeName.Location = new System.Drawing.Point(203, 89);
            this.txtCustForeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustForeName.Name = "txtCustForeName";
            this.txtCustForeName.Size = new System.Drawing.Size(251, 26);
            this.txtCustForeName.TabIndex = 18;
            // 
            // txtBuisName
            // 
            this.txtBuisName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuisName.Location = new System.Drawing.Point(203, 170);
            this.txtBuisName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuisName.Name = "txtBuisName";
            this.txtBuisName.Size = new System.Drawing.Size(251, 26);
            this.txtBuisName.TabIndex = 19;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.Location = new System.Drawing.Point(203, 220);
            this.txtAdd1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(251, 26);
            this.txtAdd1.TabIndex = 20;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd2.Location = new System.Drawing.Point(203, 254);
            this.txtAdd2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(251, 26);
            this.txtAdd2.TabIndex = 21;
            // 
            // txtAdd3
            // 
            this.txtAdd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd3.Location = new System.Drawing.Point(200, 300);
            this.txtAdd3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.Size = new System.Drawing.Size(251, 26);
            this.txtAdd3.TabIndex = 22;
            // 
            // txtCustP
            // 
            this.txtCustP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustP.Location = new System.Drawing.Point(200, 334);
            this.txtCustP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustP.Name = "txtCustP";
            this.txtCustP.Size = new System.Drawing.Size(251, 26);
            this.txtCustP.TabIndex = 23;
            // 
            // txtCustE
            // 
            this.txtCustE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustE.Location = new System.Drawing.Point(203, 369);
            this.txtCustE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustE.Name = "txtCustE";
            this.txtCustE.Size = new System.Drawing.Size(251, 26);
            this.txtCustE.TabIndex = 24;
            // 
            // lblCustSurname
            // 
            this.lblCustSurname.AutoSize = true;
            this.lblCustSurname.Location = new System.Drawing.Point(29, 137);
            this.lblCustSurname.Name = "lblCustSurname";
            this.lblCustSurname.Size = new System.Drawing.Size(129, 17);
            this.lblCustSurname.TabIndex = 25;
            this.lblCustSurname.Text = "Customer Surname";
            // 
            // txtCustSurname
            // 
            this.txtCustSurname.Location = new System.Drawing.Point(200, 128);
            this.txtCustSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustSurname.Name = "txtCustSurname";
            this.txtCustSurname.Size = new System.Drawing.Size(248, 22);
            this.txtCustSurname.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer Surname";
            // 
            // txtSearchCustSur
            // 
            this.txtSearchCustSur.Location = new System.Drawing.Point(489, 27);
            this.txtSearchCustSur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchCustSur.Name = "txtSearchCustSur";
            this.txtSearchCustSur.Size = new System.Drawing.Size(157, 22);
            this.txtSearchCustSur.TabIndex = 28;
            // 
            // grpSearchCust
            // 
            this.grpSearchCust.Controls.Add(this.btnSearch);
            this.grpSearchCust.Controls.Add(this.label2);
            this.grpSearchCust.Controls.Add(this.txtSearchCustSur);
            this.grpSearchCust.Controls.Add(this.label1);
            this.grpSearchCust.Controls.Add(this.txtCustID);
            this.grpSearchCust.Controls.Add(this.lblCustID);
            this.grpSearchCust.Location = new System.Drawing.Point(15, 9);
            this.grpSearchCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearchCust.Name = "grpSearchCust";
            this.grpSearchCust.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearchCust.Size = new System.Drawing.Size(808, 91);
            this.grpSearchCust.TabIndex = 29;
            this.grpSearchCust.TabStop = false;
            this.grpSearchCust.Text = "Search Customer";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(669, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "OR";
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.txtCustID_1);
            this.grpCustDetails.Controls.Add(this.label3);
            this.grpCustDetails.Controls.Add(this.txtCustSurname);
            this.grpCustDetails.Controls.Add(this.lblCustSurname);
            this.grpCustDetails.Controls.Add(this.txtCustE);
            this.grpCustDetails.Controls.Add(this.txtCustP);
            this.grpCustDetails.Controls.Add(this.txtAdd3);
            this.grpCustDetails.Controls.Add(this.txtAdd2);
            this.grpCustDetails.Controls.Add(this.txtAdd1);
            this.grpCustDetails.Controls.Add(this.txtBuisName);
            this.grpCustDetails.Controls.Add(this.txtCustForeName);
            this.grpCustDetails.Controls.Add(this.btnUpdate);
            this.grpCustDetails.Controls.Add(this.lblEMail);
            this.grpCustDetails.Controls.Add(this.lblPhone);
            this.grpCustDetails.Controls.Add(this.lblAdd3);
            this.grpCustDetails.Controls.Add(this.lblAdd2);
            this.grpCustDetails.Controls.Add(this.lblAdd1);
            this.grpCustDetails.Controls.Add(this.lblBuisName);
            this.grpCustDetails.Controls.Add(this.lblCustForeName);
            this.grpCustDetails.Location = new System.Drawing.Point(12, 273);
            this.grpCustDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustDetails.Size = new System.Drawing.Size(648, 414);
            this.grpCustDetails.TabIndex = 30;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Amend Customer Details";
            this.grpCustDetails.Visible = false;
            // 
            // txtCustID_1
            // 
            this.txtCustID_1.Enabled = false;
            this.txtCustID_1.Location = new System.Drawing.Point(204, 37);
            this.txtCustID_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustID_1.Name = "txtCustID_1";
            this.txtCustID_1.Size = new System.Drawing.Size(83, 22);
            this.txtCustID_1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Customer ID";
            // 
            // grdCustomer
            // 
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Location = new System.Drawing.Point(19, 114);
            this.grdCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.RowTemplate.Height = 24;
            this.grdCustomer.Size = new System.Drawing.Size(644, 154);
            this.grdCustomer.TabIndex = 31;
            this.grdCustomer.Visible = false;
            this.grdCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellClick_1);
            this.grdCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellContentClick);
            // 
            // frmAmendCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(837, 752);
            this.Controls.Add(this.grdCustomer);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.grpSearchCust);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAmendCustomer";
            this.Load += new System.EventHandler(this.frmAmendCustomer_Load);
            this.grpSearchCust.ResumeLayout(false);
            this.grpSearchCust.PerformLayout();
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustForeName;
        private System.Windows.Forms.Label lblBuisName;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.Label lblAdd3;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCustForeName;
        private System.Windows.Forms.TextBox txtBuisName;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd3;
        private System.Windows.Forms.TextBox txtCustP;
        private System.Windows.Forms.TextBox txtCustE;
        private System.Windows.Forms.Label lblCustSurname;
        private System.Windows.Forms.TextBox txtCustSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCustSur;
        private System.Windows.Forms.GroupBox grpSearchCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.DataGridView grdCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCustID_1;
        private System.Windows.Forms.Label label3;
    }
}