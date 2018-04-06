namespace J.S.R_Holdings
{
    partial class ViewCompany
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.companyGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSet = new J.S.R_Holdings.CompanyDataSet();
            this.companyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new J.S.R_Holdings.CompanyDataSetTableAdapters.CompanyTableAdapter();
            this.passengerGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(261, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 36);
            this.label13.TabIndex = 34;
            this.label13.Text = "Homepage";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(183, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 33;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // companyGridView
            // 
            this.companyGridView.AllowUserToAddRows = false;
            this.companyGridView.AllowUserToDeleteRows = false;
            this.companyGridView.AllowUserToResizeColumns = false;
            this.companyGridView.AutoGenerateColumns = false;
            this.companyGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.companyGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.companyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.companyGridView.DataSource = this.companyBindingSource4;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.companyGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.companyGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.companyGridView.Location = new System.Drawing.Point(61, 137);
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.ReadOnly = true;
            this.companyGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.companyGridView.RowHeadersVisible = false;
            this.companyGridView.RowTemplate.Height = 25;
            this.companyGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.companyGridView.Size = new System.Drawing.Size(553, 354);
            this.companyGridView.TabIndex = 35;
            this.companyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Company Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn2.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WorkType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Work Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vacancy";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vacancy";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // companyBindingSource4
            // 
            this.companyBindingSource4.DataMember = "Company";
            this.companyBindingSource4.DataSource = this.companyDataSet;
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource2
            // 
            this.companyBindingSource2.DataMember = "Company";
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // passengerGridView
            // 
            this.passengerGridView.AllowUserToAddRows = false;
            this.passengerGridView.AllowUserToDeleteRows = false;
            this.passengerGridView.AllowUserToResizeColumns = false;
            this.passengerGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passengerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passengerGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passengerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.passengerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passengerGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.passengerGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.passengerGridView.Location = new System.Drawing.Point(764, 137);
            this.passengerGridView.Name = "passengerGridView";
            this.passengerGridView.ReadOnly = true;
            this.passengerGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.passengerGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.passengerGridView.RowTemplate.Height = 25;
            this.passengerGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.passengerGridView.Size = new System.Drawing.Size(424, 431);
            this.passengerGridView.TabIndex = 37;
            // 
            // ViewCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.passengerGridView);
            this.Controls.Add(this.companyGridView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "ViewCompany";
            this.Text = "ViewCompany";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView companyGridView;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        
        private System.Windows.Forms.BindingSource companyBindingSource2;
        private System.Windows.Forms.BindingSource companyBindingSource3;
        private CompanyDataSet companyDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource4;
        private CompanyDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView passengerGridView;
    }
}