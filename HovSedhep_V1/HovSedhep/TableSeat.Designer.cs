namespace HovSedhep_V1.HovSedhep
{
    partial class TableSeat
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_waitress = new System.Windows.Forms.TextBox();
            this.txb_customer_name = new System.Windows.Forms.TextBox();
            this.txb_pax = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Waitress";
            // 
            // txb_waitress
            // 
            this.txb_waitress.Location = new System.Drawing.Point(184, 29);
            this.txb_waitress.Name = "txb_waitress";
            this.txb_waitress.ReadOnly = true;
            this.txb_waitress.Size = new System.Drawing.Size(269, 22);
            this.txb_waitress.TabIndex = 6;
            // 
            // txb_customer_name
            // 
            this.txb_customer_name.Location = new System.Drawing.Point(184, 73);
            this.txb_customer_name.Name = "txb_customer_name";
            this.txb_customer_name.ReadOnly = true;
            this.txb_customer_name.Size = new System.Drawing.Size(269, 22);
            this.txb_customer_name.TabIndex = 7;
            // 
            // txb_pax
            // 
            this.txb_pax.Location = new System.Drawing.Point(184, 117);
            this.txb_pax.Name = "txb_pax";
            this.txb_pax.ReadOnly = true;
            this.txb_pax.Size = new System.Drawing.Size(269, 22);
            this.txb_pax.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(26, 196);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 38);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel Table";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(323, 196);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(130, 38);
            this.btn_finish.TabIndex = 9;
            this.btn_finish.Text = "Finish Table";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // TableSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 277);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.txb_pax);
            this.Controls.Add(this.txb_customer_name);
            this.Controls.Add(this.txb_waitress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TableSeat";
            this.Text = "TableSeat";
            this.Load += new System.EventHandler(this.TableSeat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_waitress;
        private System.Windows.Forms.TextBox txb_customer_name;
        private System.Windows.Forms.TextBox txb_pax;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_finish;
    }
}