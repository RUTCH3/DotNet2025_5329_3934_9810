namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            manager = new Button();
            salesman = new Button();
            SuspendLayout();
            // 
            // manager
            // 
            manager.Location = new Point(219, 184);
            manager.Name = "manager";
            manager.Size = new Size(94, 29);
            manager.TabIndex = 0;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += manager_Click;
            // 
            // salesman
            // 
            salesman.Location = new Point(503, 184);
            salesman.Name = "salesman";
            salesman.Size = new Size(94, 29);
            salesman.TabIndex = 1;
            salesman.Text = "קופאי";
            salesman.UseVisualStyleBackColor = true;
            salesman.Click += salesman_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(salesman);
            Controls.Add(manager);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button manager;
        private Button salesman;
    }
}