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
            AddProdButton = new Button();
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
            DeleteButton = new Button();
            SelectProd = new Label();
            comboBox1 = new ComboBox();
            lblProds = new Label();
            SelectProdToUpdate = new Label();
            SelectCategory = new Label();
            ProdPrice = new Label();
            AmountItems = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            comboBox2 = new ComboBox();
            UpdateProdButton = new Button();
            tbCustomers.SuspendLayout();
            AddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            UpdateProd.SuspendLayout();
            DeleteProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            AddProd.Controls.Add(AddProdButton);
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
            // AddProdButton
            // 
            AddProdButton.Location = new Point(160, 223);
            AddProdButton.Name = "AddProdButton";
            AddProdButton.Size = new Size(94, 29);
            AddProdButton.TabIndex = 8;
            AddProdButton.Text = "הוסף מוצר";
            AddProdButton.UseVisualStyleBackColor = true;
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
            cbCategory.Items.AddRange(new object[] { "מוצרי חשמל", "ביגוד", "מוצרי שיער", "אלקטרוניקה", "מוצרי מטבח", "מוצרי נקיון" });
            cbCategory.Location = new Point(40, 160);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 4;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
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
            UpdateProd.Controls.Add(UpdateProdButton);
            UpdateProd.Controls.Add(textBox1);
            UpdateProd.Controls.Add(numericUpDown1);
            UpdateProd.Controls.Add(numericUpDown2);
            UpdateProd.Controls.Add(comboBox2);
            UpdateProd.Controls.Add(SelectCategory);
            UpdateProd.Controls.Add(ProdPrice);
            UpdateProd.Controls.Add(AmountItems);
            UpdateProd.Controls.Add(SelectProdToUpdate);
            UpdateProd.Location = new Point(4, 29);
            UpdateProd.Name = "UpdateProd";
            UpdateProd.Size = new Size(396, 273);
            UpdateProd.TabIndex = 1;
            UpdateProd.Text = "עדכון";
            UpdateProd.UseVisualStyleBackColor = true;
            // 
            // DeleteProd
            // 
            DeleteProd.Controls.Add(DeleteButton);
            DeleteProd.Controls.Add(SelectProd);
            DeleteProd.Controls.Add(comboBox1);
            DeleteProd.Location = new Point(4, 29);
            DeleteProd.Name = "DeleteProd";
            DeleteProd.Size = new Size(396, 273);
            DeleteProd.TabIndex = 2;
            DeleteProd.Text = "מחיקה";
            DeleteProd.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(154, 153);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "מחק";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += button1_Click;
            // 
            // SelectProd
            // 
            SelectProd.AutoSize = true;
            SelectProd.Location = new Point(277, 92);
            SelectProd.Name = "SelectProd";
            SelectProd.Size = new Size(71, 20);
            SelectProd.TabIndex = 1;
            SelectProd.Text = "בחר מוצר";
            SelectProd.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "מקרר", "מאוורר", "מחשבון", "מטאטא", "מגב", "מסרק", "שמפו", "תנור" });
            comboBox1.Location = new Point(75, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
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
            // SelectProdToUpdate
            // 
            SelectProdToUpdate.AutoSize = true;
            SelectProdToUpdate.Location = new Point(264, 47);
            SelectProdToUpdate.Name = "SelectProdToUpdate";
            SelectProdToUpdate.Size = new Size(71, 20);
            SelectProdToUpdate.TabIndex = 1;
            SelectProdToUpdate.Text = "בחר מוצר";
            // 
            // SelectCategory
            // 
            SelectCategory.AutoSize = true;
            SelectCategory.Location = new Point(237, 168);
            SelectCategory.Name = "SelectCategory";
            SelectCategory.Size = new Size(93, 20);
            SelectCategory.TabIndex = 6;
            SelectCategory.Text = "בחר קטגוריה";
            // 
            // ProdPrice
            // 
            ProdPrice.AutoSize = true;
            ProdPrice.Location = new Point(289, 129);
            ProdPrice.Name = "ProdPrice";
            ProdPrice.Size = new Size(41, 20);
            ProdPrice.TabIndex = 5;
            ProdPrice.Text = "מחיר";
            // 
            // AmountItems
            // 
            AmountItems.AutoSize = true;
            AmountItems.Location = new Point(244, 88);
            AmountItems.Name = "AmountItems";
            AmountItems.Size = new Size(91, 20);
            AmountItems.TabIndex = 4;
            AmountItems.Text = "כמות פריטים";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(49, 86);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(49, 129);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "מוצרי חשמל", "ביגוד", "מוצרי שיער", "אלקטרוניקה", "מוצרי מטבח", "מוצרי נקיון" });
            comboBox2.Location = new Point(49, 168);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 8;
            // 
            // UpdateProdButton
            // 
            UpdateProdButton.Location = new Point(155, 222);
            UpdateProdButton.Name = "UpdateProdButton";
            UpdateProdButton.Size = new Size(94, 29);
            UpdateProdButton.TabIndex = 12;
            UpdateProdButton.Text = "עדכן";
            UpdateProdButton.UseVisualStyleBackColor = true;
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
            UpdateProd.ResumeLayout(false);
            UpdateProd.PerformLayout();
            DeleteProd.ResumeLayout(false);
            DeleteProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private Button AddProdButton;
        private Button DeleteButton;
        private Label SelectProd;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox2;
        private Label SelectCategory;
        private Label ProdPrice;
        private Label AmountItems;
        private Label SelectProdToUpdate;
        private Button UpdateProdButton;
    }
}