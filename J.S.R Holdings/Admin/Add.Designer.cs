namespace J.S.R_Holdings
{
    partial class Add
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
            this.addPassenger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addAgent = new System.Windows.Forms.Button();
            this.addCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPassenger
            // 
            this.addPassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addPassenger.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPassenger.ForeColor = System.Drawing.Color.LightGray;
            this.addPassenger.Location = new System.Drawing.Point(72, 98);
            this.addPassenger.Margin = new System.Windows.Forms.Padding(5);
            this.addPassenger.Name = "addPassenger";
            this.addPassenger.Size = new System.Drawing.Size(145, 145);
            this.addPassenger.TabIndex = 1;
            this.addPassenger.Text = "Add Passenger";
            this.addPassenger.UseVisualStyleBackColor = false;
            this.addPassenger.Click += new System.EventHandler(this.addPassenger_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Back";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // addAgent
            // 
            this.addAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addAgent.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAgent.ForeColor = System.Drawing.Color.LightGray;
            this.addAgent.Location = new System.Drawing.Point(265, 98);
            this.addAgent.Margin = new System.Windows.Forms.Padding(5);
            this.addAgent.Name = "addAgent";
            this.addAgent.Size = new System.Drawing.Size(145, 145);
            this.addAgent.TabIndex = 2;
            this.addAgent.Text = "Add Agent";
            this.addAgent.UseVisualStyleBackColor = false;
            this.addAgent.Click += new System.EventHandler(this.addAgent_Click);
            // 
            // addCompany
            // 
            this.addCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addCompany.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompany.ForeColor = System.Drawing.Color.LightGray;
            this.addCompany.Location = new System.Drawing.Point(461, 98);
            this.addCompany.Margin = new System.Windows.Forms.Padding(5);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(145, 145);
            this.addCompany.TabIndex = 3;
            this.addCompany.Text = "Add Company";
            this.addCompany.UseVisualStyleBackColor = false;
            this.addCompany.Click += new System.EventHandler(this.addCompany_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCompany);
            this.Controls.Add(this.addAgent);
            this.Controls.Add(this.addPassenger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Pepole";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPassenger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAgent;
        private System.Windows.Forms.Button addCompany;
    }
}