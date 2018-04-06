namespace J.S.R_Holdings
{
    partial class DeleteCompany
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
            this.refresh = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteCompanygridview = new System.Windows.Forms.DataGridView();
            this.companyBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSet = new J.S.R_Holdings.CompanyDataSet();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new J.S.R_Holdings.CompanyDataSetTableAdapters.CompanyTableAdapter();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deleteCompanygridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(396, 18);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(103, 36);
            this.refresh.TabIndex = 41;
            this.refresh.Text = "Refresh";
            this.refresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            this.refresh.MouseEnter += new System.EventHandler(this.refresh_MouseEnter);
            this.refresh.MouseLeave += new System.EventHandler(this.refresh_MouseLeave);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(249, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 36);
            this.label13.TabIndex = 40;
            this.label13.Text = "Homepage";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(187, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 36);
            this.label12.TabIndex = 39;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // deleteCompanygridview
            // 
            this.deleteCompanygridview.AllowUserToAddRows = false;
            this.deleteCompanygridview.AllowUserToDeleteRows = false;
            this.deleteCompanygridview.AllowUserToResizeColumns = false;
            this.deleteCompanygridview.AllowUserToResizeRows = false;
            this.deleteCompanygridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCompanygridview.AutoGenerateColumns = false;
            this.deleteCompanygridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteCompanygridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCompanygridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deleteCompanygridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteCompanygridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.workTypeDataGridViewTextBoxColumn,
            this.vacancyDataGridViewTextBoxColumn});
            this.deleteCompanygridview.DataSource = this.companyBindingSource5;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteCompanygridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.deleteCompanygridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.deleteCompanygridview.EnableHeadersVisualStyles = false;
            this.deleteCompanygridview.GridColor = System.Drawing.Color.Gray;
            this.deleteCompanygridview.Location = new System.Drawing.Point(102, 114);
            this.deleteCompanygridview.Margin = new System.Windows.Forms.Padding(0);
            this.deleteCompanygridview.Name = "deleteCompanygridview";
            this.deleteCompanygridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCompanygridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.deleteCompanygridview.RowHeadersVisible = false;
            this.deleteCompanygridview.RowTemplate.Height = 23;
            this.deleteCompanygridview.ShowCellToolTips = false;
            this.deleteCompanygridview.ShowEditingIcon = false;
            this.deleteCompanygridview.Size = new System.Drawing.Size(494, 566);
            this.deleteCompanygridview.TabIndex = 42;
            this.deleteCompanygridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteCompanygridview_CellDoubleClick);
            // 
            // companyBindingSource5
            // 
            this.companyBindingSource5.DataMember = "Company";
            this.companyBindingSource5.DataSource = this.companyDataSetBindingSource;
            // 
            // companyDataSetBindingSource
            // 
            this.companyDataSetBindingSource.DataSource = this.companyDataSet;
            this.companyDataSetBindingSource.Position = 0;
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataMember = "Company";
            // 
            // companyBindingSource3
            // 
            this.companyBindingSource3.DataMember = "Company";
            // 
            // companyBindingSource4
            // 
            this.companyBindingSource4.DataMember = "Company";
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 80;
            // 
            // workTypeDataGridViewTextBoxColumn
            // 
            this.workTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.HeaderText = "Work Type";
            this.workTypeDataGridViewTextBoxColumn.Name = "workTypeDataGridViewTextBoxColumn";
            this.workTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.workTypeDataGridViewTextBoxColumn.Width = 130;
            // 
            // vacancyDataGridViewTextBoxColumn
            // 
            this.vacancyDataGridViewTextBoxColumn.DataPropertyName = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn.HeaderText = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn.Name = "vacancyDataGridViewTextBoxColumn";
            this.vacancyDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacancyDataGridViewTextBoxColumn.Width = 80;
            // 
            // DeleteCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.deleteCompanygridview);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "DeleteCompany";
            this.Text = "DeleteCompany";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeleteCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteCompanygridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label refresh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView deleteCompanygridview;
        
        private System.Windows.Forms.BindingSource companyBindingSource;
        
        
        private System.Windows.Forms.BindingSource companyBindingSource1;
        
        
        private System.Windows.Forms.BindingSource companyBindingSource2;
        
        private System.Windows.Forms.BindingSource companyBindingSource3;
        private System.Windows.Forms.BindingSource companyBindingSource4;
        private System.Windows.Forms.BindingSource companyDataSourceBindingSource;
        private System.Windows.Forms.BindingSource companyDataSetBindingSource;
        private CompanyDataSet companyDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource5;
        private CompanyDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDataGridViewTextBoxColumn;
    }
}