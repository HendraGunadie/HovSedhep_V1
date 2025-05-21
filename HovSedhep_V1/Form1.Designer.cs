namespace HovSedhep_V1
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
            this.btn_table_seating = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.panelTables = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_table_seating
            // 
            this.btn_table_seating.Location = new System.Drawing.Point(12, 12);
            this.btn_table_seating.Name = "btn_table_seating";
            this.btn_table_seating.Size = new System.Drawing.Size(148, 102);
            this.btn_table_seating.TabIndex = 0;
            this.btn_table_seating.Text = "TABLE SEATING";
            this.btn_table_seating.UseVisualStyleBackColor = true;
            this.btn_table_seating.Click += new System.EventHandler(this.btn_table_seating_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(12, 220);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(148, 102);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "MENU";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(12, 439);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(148, 102);
            this.btn_history.TabIndex = 2;
            this.btn_history.Text = "HISTORY";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // panelTables
            // 
            this.panelTables.Location = new System.Drawing.Point(192, 12);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(873, 529);
            this.panelTables.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 585);
            this.Controls.Add(this.panelTables);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_table_seating);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_table_seating;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Panel panelTables;
    }
}

