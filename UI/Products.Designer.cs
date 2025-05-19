namespace UI
{
    partial class Products
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
            AddProd = new TabPage();
            tbName = new TextBox();
            nudAmount = new NumericUpDown();
            nudPrice = new NumericUpDown();
            cbCategory = new ComboBox();
            Category = new Label();
            Price = new Label();
            AmountProds = new Label();
            ProdName = new Label();
            UpdateProd = new TabPage();
            DeleteProd = new TabPage();
            lblProds = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            tbCustomers.SuspendLayout();
            AddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            DeleteProd.SuspendLayout();
            SuspendLayout();
            // 
            // tbCustomers
            // 
            tbCustomers.Controls.Add(AddProd);
            tbCustomers.Controls.Add(UpdateProd);
            tbCustomers.Controls.Add(DeleteProd);
            tbCustomers.Location = new Point(198, 103);
            tbCustomers.Name = "tbCustomers";
            tbCustomers.SelectedIndex = 0;
            tbCustomers.Size = new Size(404, 306);
            tbCustomers.TabIndex = 1;
            // 
            // AddProd
            // 
            AddProd.Controls.Add(button2);
            AddProd.Controls.Add(tbName);
            AddProd.Controls.Add(nudAmount);
            AddProd.Controls.Add(nudPrice);
            AddProd.Controls.Add(cbCategory);
            AddProd.Controls.Add(Category);
            AddProd.Controls.Add(Price);
            AddProd.Controls.Add(AmountProds);
            AddProd.Controls.Add(ProdName);
            AddProd.Location = new Point(4, 29);
            AddProd.Name = "AddProd";
            AddProd.Padding = new Padding(3);
            AddProd.Size = new Size(396, 273);
            AddProd.TabIndex = 0;
            AddProd.Text = "הוספה";
            AddProd.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Location = new Point(40, 32);
            tbName.Name = "tbName";
            tbName.Size = new Size(151, 27);
            tbName.TabIndex = 7;
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(40, 78);
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(150, 27);
            nudAmount.TabIndex = 6;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(40, 121);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 5;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(40, 160);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 4;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Location = new Point(271, 163);
            Category.Name = "Category";
            Category.Size = new Size(93, 20);
            Category.TabIndex = 3;
            Category.Text = "בחר קטגוריה";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(271, 128);
            Price.Name = "Price";
            Price.Size = new Size(41, 20);
            Price.TabIndex = 2;
            Price.Text = "מחיר";
            // 
            // AmountProds
            // 
            AmountProds.AutoSize = true;
            AmountProds.Location = new Point(271, 85);
            AmountProds.Name = "AmountProds";
            AmountProds.Size = new Size(91, 20);
            AmountProds.TabIndex = 1;
            AmountProds.Text = "כמות מוצרים";
            // 
            // ProdName
            // 
            ProdName.AutoSize = true;
            ProdName.Location = new Point(271, 43);
            ProdName.Name = "ProdName";
            ProdName.Size = new Size(66, 20);
            ProdName.TabIndex = 0;
            ProdName.Text = "שם מוצר";
            // 
            // UpdateProd
            // 
            UpdateProd.Location = new Point(4, 29);
            UpdateProd.Name = "UpdateProd";
            UpdateProd.Size = new Size(396, 211);
            UpdateProd.TabIndex = 1;
            UpdateProd.Text = "עדכון";
            UpdateProd.UseVisualStyleBackColor = true;
            // 
            // DeleteProd
            // 
            DeleteProd.Controls.Add(button1);
            DeleteProd.Controls.Add(label1);
            DeleteProd.Controls.Add(comboBox1);
            DeleteProd.Location = new Point(4, 29);
            DeleteProd.Name = "DeleteProd";
            DeleteProd.Size = new Size(396, 211);
            DeleteProd.TabIndex = 2;
            DeleteProd.Text = "מחיקה";
            DeleteProd.UseVisualStyleBackColor = true;
            // 
            // lblProds
            // 
            lblProds.AutoSize = true;
            lblProds.Location = new Point(374, 41);
            lblProds.Name = "lblProds";
            lblProds.Size = new Size(54, 20);
            lblProds.TabIndex = 3;
            lblProds.Text = "מוצרים";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(75, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 92);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(154, 153);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(160, 223);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProds);
            Controls.Add(tbCustomers);
            Name = "Products";
            Text = "Products";
            tbCustomers.ResumeLayout(false);
            AddProd.ResumeLayout(false);
            AddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            DeleteProd.ResumeLayout(false);
            DeleteProd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbCustomers;
        private TabPage AddProd;
        private TabPage UpdateProd;
        private TabPage DeleteProd;
        private Label lblProds;
        private TextBox tbName;
        private NumericUpDown nudAmount;
        private NumericUpDown nudPrice;
        private ComboBox cbCategory;
        private Label Category;
        private Label Price;
        private Label AmountProds;
        private Label ProdName;
        private Button button2;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
    }
}