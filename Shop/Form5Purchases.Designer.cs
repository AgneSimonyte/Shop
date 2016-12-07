namespace Shop
{
    partial class Form5Purchases
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAllPurchases = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 33;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(96, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(117, 20);
            this.txtLastName.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Vardas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pavardė:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 256);
            this.dataGridView1.TabIndex = 34;
            // 
            // btnAllPurchases
            // 
            this.btnAllPurchases.Location = new System.Drawing.Point(15, 79);
            this.btnAllPurchases.Name = "btnAllPurchases";
            this.btnAllPurchases.Size = new System.Drawing.Size(198, 23);
            this.btnAllPurchases.TabIndex = 35;
            this.btnAllPurchases.Text = "Visi pirkimai";
            this.btnAllPurchases.UseVisualStyleBackColor = true;
            this.btnAllPurchases.Click += new System.EventHandler(this.btnAllPurchases_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 281);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Atgal";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLastWeek
            // 
            this.btnLastWeek.Location = new System.Drawing.Point(15, 108);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(198, 23);
            this.btnLastWeek.TabIndex = 37;
            this.btnLastWeek.Text = "Praeitos savaitės pirkimai";
            this.btnLastWeek.UseVisualStyleBackColor = true;
            this.btnLastWeek.Click += new System.EventHandler(this.btnLastWeek_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.Location = new System.Drawing.Point(15, 137);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(198, 23);
            this.btnLastMonth.TabIndex = 38;
            this.btnLastMonth.Text = "Praeitos mėnesio pirkimai";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(15, 167);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(198, 23);
            this.btnDetails.TabIndex = 39;
            this.btnDetails.Text = "Detalūs pirkimai";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // Form5Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 308);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnLastMonth);
            this.Controls.Add(this.btnLastWeek);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAllPurchases);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form5Purchases";
            this.Text = "Form5Purchases";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAllPurchases;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLastWeek;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnDetails;
    }
}