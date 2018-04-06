namespace J.S.R_Holdings.Transection
{
    partial class RemoveTransaction
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteCompanygridview = new System.Windows.Forms.DataGridView();
            this.transectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._J_S_R_HoldingsDATADataSet = new J.S.R_Holdings._J_S_R_HoldingsDATADataSet();
            this.transectionTableAdapter = new J.S.R_Holdings._J_S_R_HoldingsDATADataSetTableAdapters.TransectionTableAdapter();
            this.ammountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deleteCompanygridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._J_S_R_HoldingsDATADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(274, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 36);
            this.label13.TabIndex = 33;
            this.label13.Text = "Homepage";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(217, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 32;
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
            this.ammountDataGridViewTextBoxColumn,
            this.agentNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.bankNameDataGridViewTextBoxColumn,
            this.Id});
            this.deleteCompanygridview.DataSource = this.transectionBindingSource;
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
            this.deleteCompanygridview.Location = new System.Drawing.Point(100, 106);
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
            this.deleteCompanygridview.Size = new System.Drawing.Size(810, 413);
            this.deleteCompanygridview.TabIndex = 43;
            this.deleteCompanygridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteCompanygridview_CellDoubleClick);
            // 
            // transectionBindingSource
            // 
            this.transectionBindingSource.DataMember = "Transection";
            this.transectionBindingSource.DataSource = this._J_S_R_HoldingsDATADataSet;
            // 
            // _J_S_R_HoldingsDATADataSet
            // 
            this._J_S_R_HoldingsDATADataSet.DataSetName = "_J_S_R_HoldingsDATADataSet";
            this._J_S_R_HoldingsDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transectionTableAdapter
            // 
            this.transectionTableAdapter.ClearBeforeFill = true;
            // 
            // ammountDataGridViewTextBoxColumn
            // 
            this.ammountDataGridViewTextBoxColumn.DataPropertyName = "Ammount";
            this.ammountDataGridViewTextBoxColumn.HeaderText = "Ammount";
            this.ammountDataGridViewTextBoxColumn.Name = "ammountDataGridViewTextBoxColumn";
            this.ammountDataGridViewTextBoxColumn.ReadOnly = true;
            this.ammountDataGridViewTextBoxColumn.Width = 150;
            // 
            // agentNameDataGridViewTextBoxColumn
            // 
            this.agentNameDataGridViewTextBoxColumn.DataPropertyName = "AgentName";
            this.agentNameDataGridViewTextBoxColumn.HeaderText = "Agent Name";
            this.agentNameDataGridViewTextBoxColumn.Name = "agentNameDataGridViewTextBoxColumn";
            this.agentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 200;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "Bank Details";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            this.bankNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // RemoveTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 564);
            this.Controls.Add(this.deleteCompanygridview);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "RemoveTransaction";
            this.Text = "RemoveTransaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RemoveTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteCompanygridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._J_S_R_HoldingsDATADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView deleteCompanygridview;
        private _J_S_R_HoldingsDATADataSet _J_S_R_HoldingsDATADataSet;
        private System.Windows.Forms.BindingSource transectionBindingSource;
        private _J_S_R_HoldingsDATADataSetTableAdapters.TransectionTableAdapter transectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}