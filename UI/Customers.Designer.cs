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
            IdCustomer = new Label();
            NameCustomer = new Label();
            AdressCuatomer = new Label();
            PhoneCustomer = new Label();
            tbIdCust = new TextBox();
            tbAdressCust = new TextBox();
            tbNameCust = new TextBox();
            textBtbPhoneCustox4 = new TextBox();
            DeleteCustomerButton = new Button();
            tbPhoneCustForUpdate = new TextBox();
            this.tbAdressCustForUpdate = new TextBox();
            tbIdCustForUpdate = new TextBox();
            PhoneCustForUpdate = new Label();
            AdressCustForUpdate = new Label();
            NameCustForUpdate = new Label();
            IdCustForUpdate = new Label();
            cbNameCustForUpdate = new ComboBox();
            cbSelectCustomerForDelete = new ComboBox();
            SelectCustomerForDelete = new Label();
            tbCustomers.SuspendLayout();
            AddCust.SuspendLayout();
            UpdateCust.SuspendLayout();
            DeleteCust.SuspendLayout();
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
            AddCust.Controls.Add(textBtbPhoneCustox4);
            AddCust.Controls.Add(tbNameCust);
            AddCust.Controls.Add(tbAdressCust);
            AddCust.Controls.Add(tbIdCust);
            AddCust.Controls.Add(PhoneCustomer);
            AddCust.Controls.Add(AdressCuatomer);
            AddCust.Controls.Add(NameCustomer);
            AddCust.Controls.Add(IdCustomer);
            AddCust.Location = new Point(4, 29);
            AddCust.Name = "AddCust";
            AddCust.Padding = new Padding(3);
            AddCust.Size = new Size(396, 211);
            AddCust.TabIndex = 0;
            AddCust.Text = "הוספה";
            AddCust.UseVisualStyleBackColor = true;
            AddCust.Click += AddCust_Click;
            // 
            // UpdateCust
            // 
            UpdateCust.Controls.Add(cbNameCustForUpdate);
            UpdateCust.Controls.Add(tbPhoneCustForUpdate);
            UpdateCust.Controls.Add(this.tbAdressCustForUpdate);
            UpdateCust.Controls.Add(tbIdCustForUpdate);
            UpdateCust.Controls.Add(PhoneCustForUpdate);
            UpdateCust.Controls.Add(AdressCustForUpdate);
            UpdateCust.Controls.Add(NameCustForUpdate);
            UpdateCust.Controls.Add(IdCustForUpdate);
            UpdateCust.Location = new Point(4, 29);
            UpdateCust.Name = "UpdateCust";
            UpdateCust.Size = new Size(396, 211);
            UpdateCust.TabIndex = 1;
            UpdateCust.Text = "עדכון";
            UpdateCust.UseVisualStyleBackColor = true;
            // 
            // DeleteCust
            // 
            DeleteCust.Controls.Add(DeleteCustomerButton);
            DeleteCust.Controls.Add(cbSelectCustomerForDelete);
            DeleteCust.Controls.Add(SelectCustomerForDelete);
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
            // IdCustomer
            // 
            IdCustomer.AutoSize = true;
            IdCustomer.Location = new Point(298, 23);
            IdCustomer.Name = "IdCustomer";
            IdCustomer.RightToLeft = RightToLeft.Yes;
            IdCustomer.Size = new Size(34, 20);
            IdCustomer.TabIndex = 0;
            IdCustomer.Text = "ת\"ז:";
            // 
            // NameCustomer
            // 
            NameCustomer.AutoSize = true;
            NameCustomer.Location = new Point(298, 66);
            NameCustomer.Name = "NameCustomer";
            NameCustomer.RightToLeft = RightToLeft.Yes;
            NameCustomer.Size = new Size(34, 20);
            NameCustomer.TabIndex = 1;
            NameCustomer.Text = "שם:";
            // 
            // AdressCuatomer
            // 
            AdressCuatomer.AutoSize = true;
            AdressCuatomer.Location = new Point(298, 111);
            AdressCuatomer.Name = "AdressCuatomer";
            AdressCuatomer.RightToLeft = RightToLeft.Yes;
            AdressCuatomer.Size = new Size(55, 20);
            AdressCuatomer.TabIndex = 2;
            AdressCuatomer.Text = "כתובת:";
            // 
            // PhoneCustomer
            // 
            PhoneCustomer.AutoSize = true;
            PhoneCustomer.Location = new Point(298, 156);
            PhoneCustomer.Name = "PhoneCustomer";
            PhoneCustomer.RightToLeft = RightToLeft.Yes;
            PhoneCustomer.Size = new Size(47, 20);
            PhoneCustomer.TabIndex = 3;
            PhoneCustomer.Text = "טלפון:";
            // 
            // tbIdCust
            // 
            tbIdCust.Location = new Point(108, 20);
            tbIdCust.Name = "tbIdCust";
            tbIdCust.Size = new Size(125, 27);
            tbIdCust.TabIndex = 4;
            // 
            // tbAdressCust
            // 
            tbAdressCust.Location = new Point(108, 111);
            tbAdressCust.Name = "tbAdressCust";
            tbAdressCust.Size = new Size(125, 27);
            tbAdressCust.TabIndex = 5;
            // 
            // tbNameCust
            // 
            tbNameCust.Location = new Point(108, 66);
            tbNameCust.Name = "tbNameCust";
            tbNameCust.Size = new Size(125, 27);
            tbNameCust.TabIndex = 6;
            // 
            // textBtbPhoneCustox4
            // 
            textBtbPhoneCustox4.Location = new Point(108, 153);
            textBtbPhoneCustox4.Name = "textBtbPhoneCustox4";
            textBtbPhoneCustox4.Size = new Size(125, 27);
            textBtbPhoneCustox4.TabIndex = 7;
            // 
            // DeleteCustomerButton
            // 
            DeleteCustomerButton.Location = new Point(159, 146);
            DeleteCustomerButton.Name = "DeleteCustomerButton";
            DeleteCustomerButton.Size = new Size(94, 29);
            DeleteCustomerButton.TabIndex = 2;
            DeleteCustomerButton.Text = " מחק";
            DeleteCustomerButton.UseVisualStyleBackColor = true;
            // 
            // tbPhoneCustForUpdate
            // 
            tbPhoneCustForUpdate.Location = new Point(76, 158);
            tbPhoneCustForUpdate.Name = "tbPhoneCustForUpdate";
            tbPhoneCustForUpdate.Size = new Size(125, 27);
            tbPhoneCustForUpdate.TabIndex = 15;
            // 
            // tbAdressCustForUpdate
            // 
            this.tbAdressCustForUpdate.Location = new Point(76, 116);
            this.tbAdressCustForUpdate.Name = "tbAdressCustForUpdate";
            this.tbAdressCustForUpdate.Size = new Size(125, 27);
            this.tbAdressCustForUpdate.TabIndex = 13;
            // 
            // tbIdCustForUpdate
            // 
            tbIdCustForUpdate.Location = new Point(76, 25);
            tbIdCustForUpdate.Name = "tbIdCustForUpdate";
            tbIdCustForUpdate.Size = new Size(125, 27);
            tbIdCustForUpdate.TabIndex = 12;
            // 
            // PhoneCustForUpdate
            // 
            PhoneCustForUpdate.AutoSize = true;
            PhoneCustForUpdate.Location = new Point(266, 161);
            PhoneCustForUpdate.Name = "PhoneCustForUpdate";
            PhoneCustForUpdate.RightToLeft = RightToLeft.Yes;
            PhoneCustForUpdate.Size = new Size(47, 20);
            PhoneCustForUpdate.TabIndex = 11;
            PhoneCustForUpdate.Text = "טלפון:";
            // 
            // AdressCustForUpdate
            // 
            AdressCustForUpdate.AutoSize = true;
            AdressCustForUpdate.Location = new Point(266, 116);
            AdressCustForUpdate.Name = "AdressCustForUpdate";
            AdressCustForUpdate.RightToLeft = RightToLeft.Yes;
            AdressCustForUpdate.Size = new Size(55, 20);
            AdressCustForUpdate.TabIndex = 10;
            AdressCustForUpdate.Text = "כתובת:";
            // 
            // NameCustForUpdate
            // 
            NameCustForUpdate.AutoSize = true;
            NameCustForUpdate.Location = new Point(266, 71);
            NameCustForUpdate.Name = "NameCustForUpdate";
            NameCustForUpdate.RightToLeft = RightToLeft.Yes;
            NameCustForUpdate.Size = new Size(34, 20);
            NameCustForUpdate.TabIndex = 9;
            NameCustForUpdate.Text = "שם:";
            // 
            // IdCustForUpdate
            // 
            IdCustForUpdate.AutoSize = true;
            IdCustForUpdate.Location = new Point(266, 28);
            IdCustForUpdate.Name = "IdCustForUpdate";
            IdCustForUpdate.RightToLeft = RightToLeft.Yes;
            IdCustForUpdate.Size = new Size(34, 20);
            IdCustForUpdate.TabIndex = 8;
            IdCustForUpdate.Text = "ת\"ז:";
            // 
            // cbNameCustForUpdate
            // 
            cbNameCustForUpdate.FormattingEnabled = true;
            cbNameCustForUpdate.Location = new Point(50, 68);
            cbNameCustForUpdate.Name = "cbNameCustForUpdate";
            cbNameCustForUpdate.Size = new Size(151, 28);
            cbNameCustForUpdate.TabIndex = 16;
            // 
            // cbSelectCustomerForDelete
            // 
            cbSelectCustomerForDelete.FormattingEnabled = true;
            cbSelectCustomerForDelete.Location = new Point(64, 73);
            cbSelectCustomerForDelete.Name = "cbSelectCustomerForDelete";
            cbSelectCustomerForDelete.Size = new Size(151, 28);
            cbSelectCustomerForDelete.TabIndex = 18;
            // 
            // SelectCustomerForDelete
            // 
            SelectCustomerForDelete.AutoSize = true;
            SelectCustomerForDelete.Location = new Point(280, 76);
            SelectCustomerForDelete.Name = "SelectCustomerForDelete";
            SelectCustomerForDelete.RightToLeft = RightToLeft.Yes;
            SelectCustomerForDelete.Size = new Size(75, 20);
            SelectCustomerForDelete.TabIndex = 17;
            SelectCustomerForDelete.Text = "בחר לקוח:";
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
            AddCust.ResumeLayout(false);
            AddCust.PerformLayout();
            UpdateCust.ResumeLayout(false);
            UpdateCust.PerformLayout();
            DeleteCust.ResumeLayout(false);
            DeleteCust.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbCustomers;
        private TabPage AddCust;
        private TabPage UpdateCust;
        private TabPage DeleteCust;
        private Label lblCust;
        private TextBox textBtbPhoneCustox4;
        private TextBox tbNameCust;
        private TextBox tbAdressCust;
        private TextBox tbIdCust;
        private Label PhoneCustomer;
        private Label AdressCuatomer;
        private Label NameCustomer;
        private Label IdCustomer;
        private Button DeleteCustomerButton;
        private TextBox tbPhoneCustForUpdate;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox tbIdCustForUpdate;
        private Label PhoneCustForUpdate;
        private Label AdressCustForUpdate;
        private Label NameCustForUpdate;
        private Label IdCustForUpdate;
        private ComboBox cbNameCustForUpdate;
        private ComboBox cbSelectCustomerForDelete;
        private Label SelectCustomerForDelete;
    }
}