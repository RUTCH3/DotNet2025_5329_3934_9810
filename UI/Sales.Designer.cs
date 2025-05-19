namespace UI
{
    partial class Sales
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
            tbCustomers = new TabControl();
            AddSale = new TabPage();
            UpdateSale = new TabPage();
            DeleteSale = new TabPage();
            lblSales = new Label();
            tbCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // tbCustomers
            // 
            tbCustomers.Controls.Add(AddSale);
            tbCustomers.Controls.Add(UpdateSale);
            tbCustomers.Controls.Add(DeleteSale);
            tbCustomers.Location = new Point(198, 103);
            tbCustomers.Name = "tbCustomers";
            tbCustomers.SelectedIndex = 0;
            tbCustomers.Size = new Size(404, 244);
            tbCustomers.TabIndex = 1;
            // 
            // AddSale
            // 
            AddSale.Location = new Point(4, 29);
            AddSale.Name = "AddSale";
            AddSale.Padding = new Padding(3);
            AddSale.Size = new Size(396, 211);
            AddSale.TabIndex = 0;
            AddSale.Text = "הוספה";
            AddSale.UseVisualStyleBackColor = true;
            // 
            // UpdateSale
            // 
            UpdateSale.Location = new Point(4, 29);
            UpdateSale.Name = "UpdateSale";
            UpdateSale.Size = new Size(396, 211);
            UpdateSale.TabIndex = 1;
            UpdateSale.Text = "עדכון";
            UpdateSale.UseVisualStyleBackColor = true;
            // 
            // DeleteSale
            // 
            DeleteSale.Location = new Point(4, 29);
            DeleteSale.Name = "DeleteSale";
            DeleteSale.Size = new Size(396, 211);
            DeleteSale.TabIndex = 2;
            DeleteSale.Text = "מחיקה";
            DeleteSale.UseVisualStyleBackColor = true;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Location = new Point(385, 38);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(60, 20);
            lblSales.TabIndex = 2;
            lblSales.Text = "מבצעים";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSales);
            Controls.Add(tbCustomers);
            Name = "Sales";
            Text = "Sales";
            tbCustomers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbCustomers;
        private TabPage AddSale;
        private TabPage UpdateSale;
        private TabPage DeleteSale;
        private Label lblSales;
    }
}