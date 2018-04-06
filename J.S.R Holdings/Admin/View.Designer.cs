namespace J.S.R_Holdings
{
    partial class View
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
            this.label1 = new System.Windows.Forms.Label();
            this.viewPassenger = new System.Windows.Forms.Button();
            this.viewAgent = new System.Windows.Forms.Button();
            this.viewCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Back";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // viewPassenger
            // 
            this.viewPassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.viewPassenger.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPassenger.ForeColor = System.Drawing.Color.LightGray;
            this.viewPassenger.Location = new System.Drawing.Point(97, 112);
            this.viewPassenger.Margin = new System.Windows.Forms.Padding(5);
            this.viewPassenger.Name = "viewPassenger";
            this.viewPassenger.Size = new System.Drawing.Size(145, 145);
            this.viewPassenger.TabIndex = 6;
            this.viewPassenger.Text = "View Passenger";
            this.viewPassenger.UseVisualStyleBackColor = false;
            this.viewPassenger.Click += new System.EventHandler(this.viewPassenger_Click);
            // 
            // viewAgent
            // 
            this.viewAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.viewAgent.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAgent.ForeColor = System.Drawing.Color.LightGray;
            this.viewAgent.Location = new System.Drawing.Point(288, 112);
            this.viewAgent.Margin = new System.Windows.Forms.Padding(5);
            this.viewAgent.Name = "viewAgent";
            this.viewAgent.Size = new System.Drawing.Size(145, 145);
            this.viewAgent.TabIndex = 7;
            this.viewAgent.Text = "View Agent";
            this.viewAgent.UseVisualStyleBackColor = false;
            this.viewAgent.Click += new System.EventHandler(this.viewAgent_Click);
            // 
            // viewCompany
            // 
            this.viewCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.viewCompany.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCompany.ForeColor = System.Drawing.Color.LightGray;
            this.viewCompany.Location = new System.Drawing.Point(475, 112);
            this.viewCompany.Margin = new System.Windows.Forms.Padding(5);
            this.viewCompany.Name = "viewCompany";
            this.viewCompany.Size = new System.Drawing.Size(145, 145);
            this.viewCompany.TabIndex = 8;
            this.viewCompany.Text = "View Company";
            this.viewCompany.UseVisualStyleBackColor = false;
            this.viewCompany.Click += new System.EventHandler(this.viewCompany_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.viewCompany);
            this.Controls.Add(this.viewAgent);
            this.Controls.Add(this.viewPassenger);
            this.Controls.Add(this.label1);
            this.Name = "View";
            this.Text = "View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewPassenger;
        private System.Windows.Forms.Button viewAgent;
        private System.Windows.Forms.Button viewCompany;
    }
}