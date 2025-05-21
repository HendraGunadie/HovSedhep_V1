namespace HovSedhep_V1.HovSedhep
{
    partial class History
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
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_table_seating = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridOrderDetails = new System.Windows.Forms.DataGridView();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.dataGridTransactions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_table_name = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_apply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(12, 444);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(148, 102);
            this.btn_history.TabIndex = 5;
            this.btn_history.Text = "HISTORY";
            this.btn_history.UseVisualStyleBackColor = true;
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(12, 225);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(148, 102);
            this.btn_menu.TabIndex = 4;
            this.btn_menu.Text = "MENU";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_table_seating
            // 
            this.btn_table_seating.Location = new System.Drawing.Point(12, 17);
            this.btn_table_seating.Name = "btn_table_seating";
            this.btn_table_seating.Size = new System.Drawing.Size(148, 102);
            this.btn_table_seating.TabIndex = 3;
            this.btn_table_seating.Text = "TABLE SEATING";
            this.btn_table_seating.UseVisualStyleBackColor = true;
            this.btn_table_seating.Click += new System.EventHandler(this.btn_table_seating_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_apply);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.cmb_table_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(246, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridTransactions);
            this.groupBox2.Location = new System.Drawing.Point(246, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 161);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridOrders);
            this.groupBox3.Location = new System.Drawing.Point(246, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(842, 149);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orders";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridOrderDetails);
            this.groupBox4.Location = new System.Drawing.Point(246, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(842, 147);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Details";
            // 
            // dataGridOrderDetails
            // 
            this.dataGridOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderDetails.Location = new System.Drawing.Point(0, 21);
            this.dataGridOrderDetails.Name = "dataGridOrderDetails";
            this.dataGridOrderDetails.RowHeadersWidth = 49;
            this.dataGridOrderDetails.RowTemplate.Height = 24;
            this.dataGridOrderDetails.Size = new System.Drawing.Size(842, 126);
            this.dataGridOrderDetails.TabIndex = 0;
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(0, 17);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RowHeadersWidth = 49;
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.Size = new System.Drawing.Size(842, 132);
            this.dataGridOrders.TabIndex = 1;
            // 
            // dataGridTransactions
            // 
            this.dataGridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransactions.Location = new System.Drawing.Point(0, 21);
            this.dataGridTransactions.Name = "dataGridTransactions";
            this.dataGridTransactions.RowHeadersWidth = 49;
            this.dataGridTransactions.RowTemplate.Height = 24;
            this.dataGridTransactions.Size = new System.Drawing.Size(842, 140);
            this.dataGridTransactions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table Name";
            // 
            // cmb_table_name
            // 
            this.cmb_table_name.FormattingEnabled = true;
            this.cmb_table_name.Location = new System.Drawing.Point(128, 72);
            this.cmb_table_name.Name = "cmb_table_name";
            this.cmb_table_name.Size = new System.Drawing.Size(318, 24);
            this.cmb_table_name.TabIndex = 2;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(128, 33);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(318, 22);
            this.dtp_date.TabIndex = 3;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(495, 61);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(123, 34);
            this.btn_apply.TabIndex = 4;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 615);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_table_seating);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_table_seating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridOrderDetails;
        private System.Windows.Forms.DataGridView dataGridTransactions;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cmb_table_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}