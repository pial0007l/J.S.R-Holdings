namespace J.S.R_Holdings
{
    partial class UpdateHomePage
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
            this.CompanyUpdatebutton = new System.Windows.Forms.Button();
            this.AgentUpdateButton = new System.Windows.Forms.Button();
            this.updatePassengerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompanyUpdatebutton
            // 
            this.CompanyUpdatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CompanyUpdatebutton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyUpdatebutton.ForeColor = System.Drawing.Color.LightGray;
            this.CompanyUpdatebutton.Location = new System.Drawing.Point(498, 117);
            this.CompanyUpdatebutton.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyUpdatebutton.Name = "CompanyUpdatebutton";
            this.CompanyUpdatebutton.Size = new System.Drawing.Size(143, 143);
            this.CompanyUpdatebutton.TabIndex = 10;
            this.CompanyUpdatebutton.Text = "Company Update";
            this.CompanyUpdatebutton.UseVisualStyleBackColor = false;
            this.CompanyUpdatebutton.Click += new System.EventHandler(this.CompanyUpdatebutton_Click);
            // 
            // AgentUpdateButton
            // 
            this.AgentUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.AgentUpdateButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentUpdateButton.ForeColor = System.Drawing.Color.LightGray;
            this.AgentUpdateButton.Location = new System.Drawing.Point(304, 117);
            this.AgentUpdateButton.Margin = new System.Windows.Forms.Padding(5);
            this.AgentUpdateButton.Name = "AgentUpdateButton";
            this.AgentUpdateButton.Size = new System.Drawing.Size(143, 143);
            this.AgentUpdateButton.TabIndex = 9;
            this.AgentUpdateButton.Text = "Agent Update";
            this.AgentUpdateButton.UseVisualStyleBackColor = false;
            this.AgentUpdateButton.Click += new System.EventHandler(this.AgentUpdateButton_Click);
            // 
            // updatePassengerbutton
            // 
            this.updatePassengerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.updatePassengerbutton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePassengerbutton.ForeColor = System.Drawing.Color.LightGray;
            this.updatePassengerbutton.Location = new System.Drawing.Point(113, 117);
            this.updatePassengerbutton.Margin = new System.Windows.Forms.Padding(5);
            this.updatePassengerbutton.Name = "updatePassengerbutton";
            this.updatePassengerbutton.Size = new System.Drawing.Size(143, 143);
            this.updatePassengerbutton.TabIndex = 8;
            this.updatePassengerbutton.Text = "Passenger Update";
            this.updatePassengerbutton.UseVisualStyleBackColor = false;
            this.updatePassengerbutton.Click += new System.EventHandler(this.updatePassengerbutton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Back";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // UpdateHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompanyUpdatebutton);
            this.Controls.Add(this.AgentUpdateButton);
            this.Controls.Add(this.updatePassengerbutton);
            this.Name = "UpdateHomePage";
            this.Text = "Update Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CompanyUpdatebutton;
        private System.Windows.Forms.Button AgentUpdateButton;
        private System.Windows.Forms.Button updatePassengerbutton;
        private System.Windows.Forms.Label label1;
    }
}