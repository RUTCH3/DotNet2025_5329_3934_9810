namespace UI
{
    partial class Customers
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
            AddCust = new TabPage();
            UpdateCust = new TabPage();
            DeleteCust = new TabPage();
            lblCust = new Label();
            tbCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // tbCustomers
            // 
            tbCustomers.Controls.Add(AddCust);
            tbCustomers.Controls.Add(UpdateCust);
            tbCustomers.Controls.Add(DeleteCust);
            tbCustomers.Location = new Point(196, 105);
            tbCustomers.Name = "tbCustomers";
            tbCustomers.SelectedIndex = 0;
            tbCustomers.Size = new Size(404, 244);
            tbCustomers.TabIndex = 0;
            // 
            // AddCust
            // 
            AddCust.Location = new Point(4, 29);
            AddCust.Name = "AddCust";
            AddCust.Padding = new Padding(3);
            AddCust.Size = new Size(396, 211);
            AddCust.TabIndex = 0;
            AddCust.Text = "הוספה";
            AddCust.UseVisualStyleBackColor = true;
            // 
            // UpdateCust
            // 
            UpdateCust.Location = new Point(4, 29);
            UpdateCust.Name = "UpdateCust";
            UpdateCust.Size = new Size(396, 211);
            UpdateCust.TabIndex = 1;
            UpdateCust.Text = "עדכון";
            UpdateCust.UseVisualStyleBackColor = true;
            // 
            // DeleteCust
            // 
            DeleteCust.Location = new Point(4, 29);
            DeleteCust.Name = "DeleteCust";
            DeleteCust.Size = new Size(396, 211);
            DeleteCust.TabIndex = 2;
            DeleteCust.Text = "מחיקה";
            DeleteCust.UseVisualStyleBackColor = true;
            // 
            // lblCust
            // 
            lblCust.AutoSize = true;
            lblCust.Location = new Point(359, 47);
            lblCust.Name = "lblCust";
            lblCust.Size = new Size(56, 20);
            lblCust.TabIndex = 1;
            lblCust.Text = "לקוחות";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCust);
            Controls.Add(tbCustomers);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            tbCustomers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbCustomers;
        private TabPage AddCust;
        private TabPage UpdateCust;
        private TabPage DeleteCust;
        private Label lblCust;
    }
}