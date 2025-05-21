namespace HovSedhep_V1.HovSedhep
{
    partial class menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridMenu = new System.Windows.Forms.DataGridView();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_table_seating = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txb_name);
            this.groupBox1.Controls.Add(this.cmb_category);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(277, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(564, 63);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 33);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(140, 73);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(330, 22);
            this.txb_name.TabIndex = 3;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(140, 32);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(330, 24);
            this.cmb_category.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridMenu);
            this.groupBox2.Location = new System.Drawing.Point(277, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 461);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // dataGridMenu
            // 
            this.dataGridMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMenu.Location = new System.Drawing.Point(7, 33);
            this.dataGridMenu.Name = "dataGridMenu";
            this.dataGridMenu.RowHeadersWidth = 49;
            this.dataGridMenu.RowTemplate.Height = 24;
            this.dataGridMenu.Size = new System.Drawing.Size(767, 422);
            this.dataGridMenu.TabIndex = 0;
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(12, 447);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(148, 102);
            this.btn_history.TabIndex = 8;
            this.btn_history.Text = "HISTORY";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(12, 228);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(148, 102);
            this.btn_menu.TabIndex = 7;
            this.btn_menu.Text = "MENU";
            this.btn_menu.UseVisualStyleBackColor = true;
            // 
            // btn_table_seating
            // 
            this.btn_table_seating.Location = new System.Drawing.Point(12, 20);
            this.btn_table_seating.Name = "btn_table_seating";
            this.btn_table_seating.Size = new System.Drawing.Size(148, 102);
            this.btn_table_seating.TabIndex = 6;
            this.btn_table_seating.Text = "TABLE SEATING";
            this.btn_table_seating.UseVisualStyleBackColor = true;
            this.btn_table_seating.Click += new System.EventHandler(this.btn_table_seating_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 617);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_table_seating);
            this.Controls.Add(this.groupBox1);
            this.Name = "menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridMenu;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_table_seating;
    }
}