namespace J.S.R_Holdings
{
    partial class Delete
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
            this.DeleteCompany = new System.Windows.Forms.Button();
            this.deleteAgent = new System.Windows.Forms.Button();
            this.deletePassenger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteCompany
            // 
            this.DeleteCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DeleteCompany.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCompany.ForeColor = System.Drawing.Color.LightGray;
            this.DeleteCompany.Location = new System.Drawing.Point(477, 110);
            this.DeleteCompany.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteCompany.Name = "DeleteCompany";
            this.DeleteCompany.Size = new System.Drawing.Size(145, 145);
            this.DeleteCompany.TabIndex = 12;
            this.DeleteCompany.Text = "Delete Company";
            this.DeleteCompany.UseVisualStyleBackColor = false;
            this.DeleteCompany.Click += new System.EventHandler(this.DeleteCompany_Click);
            // 
            // deleteAgent
            // 
            this.deleteAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.deleteAgent.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAgent.ForeColor = System.Drawing.Color.LightGray;
            this.deleteAgent.Location = new System.Drawing.Point(290, 110);
            this.deleteAgent.Margin = new System.Windows.Forms.Padding(5);
            this.deleteAgent.Name = "deleteAgent";
            this.deleteAgent.Size = new System.Drawing.Size(145, 145);
            this.deleteAgent.TabIndex = 11;
            this.deleteAgent.Text = "Delete Agent";
            this.deleteAgent.UseVisualStyleBackColor = false;
            this.deleteAgent.Click += new System.EventHandler(this.deleteAgent_Click);
            // 
            // deletePassenger
            // 
            this.deletePassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.deletePassenger.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePassenger.ForeColor = System.Drawing.Color.LightGray;
            this.deletePassenger.Location = new System.Drawing.Point(99, 110);
            this.deletePassenger.Margin = new System.Windows.Forms.Padding(5);
            this.deletePassenger.Name = "deletePassenger";
            this.deletePassenger.Size = new System.Drawing.Size(145, 145);
            this.deletePassenger.TabIndex = 10;
            this.deletePassenger.Text = "Delete Passenger";
            this.deletePassenger.UseVisualStyleBackColor = false;
            this.deletePassenger.Click += new System.EventHandler(this.deletePassenger_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Back";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.DeleteCompany);
            this.Controls.Add(this.deleteAgent);
            this.Controls.Add(this.deletePassenger);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteCompany;
        private System.Windows.Forms.Button deleteAgent;
        private System.Windows.Forms.Button deletePassenger;
        private System.Windows.Forms.Label label1;
    }
}