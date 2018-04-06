namespace J.S.R_Holdings
{
    partial class Agent_Update
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.agentupdateGridView = new System.Windows.Forms.DataGridView();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentMobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentDataSet2 = new J.S.R_Holdings.AgentDataSet2();
            this.agentTableAdapter = new J.S.R_Holdings.AgentDataSet2TableAdapters.AgentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agentupdateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(253, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 36);
            this.label13.TabIndex = 31;
            this.label13.Text = "Homepage";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(175, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 30;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // agentupdateGridView
            // 
            this.agentupdateGridView.AllowUserToAddRows = false;
            this.agentupdateGridView.AllowUserToDeleteRows = false;
            this.agentupdateGridView.AllowUserToResizeColumns = false;
            this.agentupdateGridView.AutoGenerateColumns = false;
            this.agentupdateGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agentupdateGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.agentupdateGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agentupdateGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.agentupdateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentupdateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentNameDataGridViewTextBoxColumn,
            this.agentMobileNoDataGridViewTextBoxColumn,
            this.agentAddressDataGridViewTextBoxColumn});
            this.agentupdateGridView.DataSource = this.agentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.agentupdateGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.agentupdateGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.agentupdateGridView.Location = new System.Drawing.Point(111, 133);
            this.agentupdateGridView.Name = "agentupdateGridView";
            this.agentupdateGridView.ReadOnly = true;
            this.agentupdateGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.agentupdateGridView.RowHeadersVisible = false;
            this.agentupdateGridView.RowTemplate.Height = 25;
            this.agentupdateGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.agentupdateGridView.Size = new System.Drawing.Size(606, 354);
            this.agentupdateGridView.TabIndex = 32;
            this.agentupdateGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.agentGridView_CellClick);
            // 
            // agentNameDataGridViewTextBoxColumn
            // 
            this.agentNameDataGridViewTextBoxColumn.DataPropertyName = "AgentName";
            this.agentNameDataGridViewTextBoxColumn.HeaderText = "Agent Name";
            this.agentNameDataGridViewTextBoxColumn.Name = "agentNameDataGridViewTextBoxColumn";
            this.agentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // agentMobileNoDataGridViewTextBoxColumn
            // 
            this.agentMobileNoDataGridViewTextBoxColumn.DataPropertyName = "AgentMobileNo";
            this.agentMobileNoDataGridViewTextBoxColumn.HeaderText = "Agent Mobile No";
            this.agentMobileNoDataGridViewTextBoxColumn.Name = "agentMobileNoDataGridViewTextBoxColumn";
            this.agentMobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentMobileNoDataGridViewTextBoxColumn.Width = 200;
            // 
            // agentAddressDataGridViewTextBoxColumn
            // 
            this.agentAddressDataGridViewTextBoxColumn.DataPropertyName = "AgentAddress";
            this.agentAddressDataGridViewTextBoxColumn.HeaderText = "Agent Address";
            this.agentAddressDataGridViewTextBoxColumn.Name = "agentAddressDataGridViewTextBoxColumn";
            this.agentAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "Agent";
            this.agentBindingSource.DataSource = this.agentDataSet2;
            // 
            // agentDataSet2
            // 
            this.agentDataSet2.DataSetName = "AgentDataSet2";
            this.agentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // Agent_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.agentupdateGridView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "Agent_Update";
            this.Text = "Agent Update";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Agent_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentupdateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView agentupdateGridView;
        private AgentDataSet2 agentDataSet2;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private AgentDataSet2TableAdapters.AgentTableAdapter agentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentMobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentAddressDataGridViewTextBoxColumn;
    }
}