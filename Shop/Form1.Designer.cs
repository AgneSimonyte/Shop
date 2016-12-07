namespace Shop
{
    partial class Form1
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
            this.btnSellers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSellers
            // 
            this.btnSellers.Location = new System.Drawing.Point(12, 37);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(133, 63);
            this.btnSellers.TabIndex = 6;
            this.btnSellers.Text = "Pardavėjai";
            this.btnSellers.UseVisualStyleBackColor = true;
            this.btnSellers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 39);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Išeiti";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(156, 37);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(133, 63);
            this.btnItems.TabIndex = 8;
            this.btnItems.Text = "Prekės";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(300, 37);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(133, 63);
            this.btnCustomers.TabIndex = 9;
            this.btnCustomers.Text = "Pirkėjai";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 195);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSellers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnCustomers;
    }
}

