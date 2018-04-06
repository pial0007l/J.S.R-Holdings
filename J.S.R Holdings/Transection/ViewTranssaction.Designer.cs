namespace J.S.R_Holdings.Transection
{
    partial class ViewTranssaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.viewtransactiongridview = new System.Windows.Forms.DataGridView();
            this._J_S_R_HoldingsDATADataSet = new J.S.R_Holdings._J_S_R_HoldingsDATADataSet();
            this.transectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transectionTableAdapter = new J.S.R_Holdings._J_S_R_HoldingsDATADataSetTableAdapters.TransectionTableAdapter();
            this.ammountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewByAgentGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewtransactiongridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._J_S_R_HoldingsDATADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewByAgentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(263, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 36);
            this.label13.TabIndex = 32;
            this.label13.Text = "Homepage";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(196, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 31;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // viewtransactiongridview
            // 
            this.viewtransactiongridview.AllowUserToAddRows = false;
            this.viewtransactiongridview.AllowUserToDeleteRows = false;
            this.viewtransactiongridview.AllowUserToResizeColumns = false;
            this.viewtransactiongridview.AllowUserToResizeRows = false;
            this.viewtransactiongridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewtransactiongridview.AutoGenerateColumns = false;
            this.viewtransactiongridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewtransactiongridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewtransactiongridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewtransactiongridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewtransactiongridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ammountDataGridViewTextBoxColumn,
            this.agentNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.bankNameDataGridViewTextBoxColumn});
            this.viewtransactiongridview.DataSource = this.transectionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewtransactiongridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewtransactiongridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.viewtransactiongridview.EnableHeadersVisualStyles = false;
            this.viewtransactiongridview.GridColor = System.Drawing.Color.Gray;
            this.viewtransactiongridview.Location = new System.Drawing.Point(48, 103);
            this.viewtransactiongridview.Margin = new System.Windows.Forms.Padding(0);
            this.viewtransactiongridview.Name = "viewtransactiongridview";
            this.viewtransactiongridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewtransactiongridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewtransactiongridview.RowHeadersVisible = false;
            this.viewtransactiongridview.RowTemplate.Height = 23;
            this.viewtransactiongridview.ShowCellToolTips = false;
            this.viewtransactiongridview.ShowEditingIcon = false;
            this.viewtransactiongridview.Size = new System.Drawing.Size(735, 574);
            this.viewtransactiongridview.TabIndex = 44;
            this.viewtransactiongridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewtransactiongridview_CellDoubleClick);
            // 
            // _J_S_R_HoldingsDATADataSet
            // 
            this._J_S_R_HoldingsDATADataSet.DataSetName = "_J_S_R_HoldingsDATADataSet";
            this._J_S_R_HoldingsDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transectionBindingSource
            // 
            this.transectionBindingSource.DataMember = "Transection";
            this.transectionBindingSource.DataSource = this._J_S_R_HoldingsDATADataSet;
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
            this.agentNameDataGridViewTextBoxColumn.Width = 180;
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
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "Bank Name";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            this.bankNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // viewByAgentGridView
            // 
            this.viewByAgentGridView.AllowUserToAddRows = false;
            this.viewByAgentGridView.AllowUserToDeleteRows = false;
            this.viewByAgentGridView.AllowUserToResizeColumns = false;
            this.viewByAgentGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewByAgentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewByAgentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.viewByAgentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewByAgentGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.viewByAgentGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.viewByAgentGridView.Location = new System.Drawing.Point(828, 103);
            this.viewByAgentGridView.Name = "viewByAgentGridView";
            this.viewByAgentGridView.ReadOnly = true;
            this.viewByAgentGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.viewByAgentGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.viewByAgentGridView.RowTemplate.Height = 25;
            this.viewByAgentGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.viewByAgentGridView.Size = new System.Drawing.Size(492, 431);
            this.viewByAgentGridView.TabIndex = 45;
            // 
            // ViewTranssaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 680);
            this.Controls.Add(this.viewByAgentGridView);
            this.Controls.Add(this.viewtransactiongridview);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "ViewTranssaction";
            this.Text = "ViewTranssaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewTranssaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewtransactiongridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._J_S_R_HoldingsDATADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewByAgentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView viewtransactiongridview;
        private _J_S_R_HoldingsDATADataSet _J_S_R_HoldingsDATADataSet;
        private System.Windows.Forms.BindingSource transectionBindingSource;
        private _J_S_R_HoldingsDATADataSetTableAdapters.TransectionTableAdapter transectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView viewByAgentGridView;
    }
}