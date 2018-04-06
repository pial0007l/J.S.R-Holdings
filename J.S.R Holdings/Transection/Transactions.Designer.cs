namespace J.S.R_Holdings.Transection
{
    partial class Transactions
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
            this.button3 = new System.Windows.Forms.Button();
            this.RemoveTransaction = new System.Windows.Forms.Button();
            this.AddTransaction = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(82, 329);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(334, 143);
            this.button3.TabIndex = 15;
            this.button3.Text = "Update Transaction";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RemoveTransaction
            // 
            this.RemoveTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.RemoveTransaction.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTransaction.ForeColor = System.Drawing.Color.LightGray;
            this.RemoveTransaction.Location = new System.Drawing.Point(504, 112);
            this.RemoveTransaction.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveTransaction.Name = "RemoveTransaction";
            this.RemoveTransaction.Size = new System.Drawing.Size(334, 143);
            this.RemoveTransaction.TabIndex = 14;
            this.RemoveTransaction.Text = "Remove Transaction";
            this.RemoveTransaction.UseVisualStyleBackColor = false;
            this.RemoveTransaction.Click += new System.EventHandler(this.RemoveTransaction_Click);
            // 
            // AddTransaction
            // 
            this.AddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.AddTransaction.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransaction.ForeColor = System.Drawing.Color.LightGray;
            this.AddTransaction.Location = new System.Drawing.Point(82, 112);
            this.AddTransaction.Margin = new System.Windows.Forms.Padding(5);
            this.AddTransaction.Name = "AddTransaction";
            this.AddTransaction.Size = new System.Drawing.Size(334, 143);
            this.AddTransaction.TabIndex = 13;
            this.AddTransaction.Text = "Add Transaction";
            this.AddTransaction.UseVisualStyleBackColor = false;
            this.AddTransaction.Click += new System.EventHandler(this.AddTransaction_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(152, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 30;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(504, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 143);
            this.button1.TabIndex = 31;
            this.button1.Text = "View Transaction";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RemoveTransaction);
            this.Controls.Add(this.AddTransaction);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button RemoveTransaction;
        private System.Windows.Forms.Button AddTransaction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}