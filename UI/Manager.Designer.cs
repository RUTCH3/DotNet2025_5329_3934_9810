namespace UI
{
    partial class Manager
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
            Sales = new Button();
            Customers = new Button();
            Products = new Button();
            SuspendLayout();
            // 
            // Sales
            // 
            Sales.Location = new Point(196, 211);
            Sales.Name = "Sales";
            Sales.Size = new Size(94, 29);
            Sales.TabIndex = 1;
            Sales.Text = "מבצעים";
            Sales.UseVisualStyleBackColor = true;
            Sales.Click += Sales_Click;
            // 
            // Customers
            // 
            Customers.Location = new Point(379, 211);
            Customers.Name = "Customers";
            Customers.Size = new Size(94, 29);
            Customers.TabIndex = 2;
            Customers.Text = "לקוחות";
            Customers.UseVisualStyleBackColor = true;
            Customers.Click += Customers_Click;
            // 
            // Products
            // 
            Products.Location = new Point(546, 211);
            Products.Name = "Products";
            Products.Size = new Size(94, 29);
            Products.TabIndex = 3;
            Products.Text = "מוצרים";
            Products.UseVisualStyleBackColor = true;
            Products.Click += Products_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Products);
            Controls.Add(Customers);
            Controls.Add(Sales);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button Sales;
        private Button Customers;
        private Button Products;
    }
}