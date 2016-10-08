namespace ButcherSYS
{
    partial class frmStock
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
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnAmendStock = new System.Windows.Forms.Button();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStockIn
            // 
            this.btnStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStockIn.Location = new System.Drawing.Point(157, 35);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(581, 135);
            this.btnStockIn.TabIndex = 0;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = false;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnAmendStock
            // 
            this.btnAmendStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAmendStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmendStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmendStock.Location = new System.Drawing.Point(157, 207);
            this.btnAmendStock.Name = "btnAmendStock";
            this.btnAmendStock.Size = new System.Drawing.Size(581, 122);
            this.btnAmendStock.TabIndex = 1;
            this.btnAmendStock.Text = "Amend Stock";
            this.btnAmendStock.UseVisualStyleBackColor = false;
            this.btnAmendStock.Click += new System.EventHandler(this.btnAmendStock_Click);
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchStock.Location = new System.Drawing.Point(157, 363);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(581, 132);
            this.btnSearchStock.TabIndex = 2;
            this.btnSearchStock.Text = "Search Stock";
            this.btnSearchStock.UseVisualStyleBackColor = false;
            this.btnSearchStock.Click += new System.EventHandler(this.btnSearchStock_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(29, 537);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 43);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 592);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchStock);
            this.Controls.Add(this.btnAmendStock);
            this.Controls.Add(this.btnStockIn);
            this.Name = "frmStock";
            this.Text = "Stock  Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnAmendStock;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.Button btnBack;
    }
}