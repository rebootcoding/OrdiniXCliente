namespace OrdiniXCliente
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
            this.cbx_customers = new System.Windows.Forms.ComboBox();
            this.btn_orders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_customers
            // 
            this.cbx_customers.FormattingEnabled = true;
            this.cbx_customers.Location = new System.Drawing.Point(175, 90);
            this.cbx_customers.Name = "cbx_customers";
            this.cbx_customers.Size = new System.Drawing.Size(425, 28);
            this.cbx_customers.TabIndex = 0;
            // 
            // btn_orders
            // 
            this.btn_orders.Location = new System.Drawing.Point(705, 54);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(231, 98);
            this.btn_orders.TabIndex = 1;
            this.btn_orders.Text = "Elenco Ordini";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 361);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.cbx_customers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_customers;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

