namespace J.S.R_Holdings
{
    partial class AgentDetailsView
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
            this.agentGridView = new System.Windows.Forms.DataGridView();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentMobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agentDataSet = new J.S.R_Holdings.AgentDataSet();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.agentTableAdapter = new J.S.R_Holdings.AgentDataSetTableAdapters.AgentTableAdapter();
            this.passengerGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.agentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // agentGridView
            // 
            this.agentGridView.AllowUserToAddRows = false;
            this.agentGridView.AllowUserToDeleteRows = false;
            this.agentGridView.AllowUserToResizeColumns = false;
            this.agentGridView.AutoGenerateColumns = false;
            this.agentGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.agentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.agentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentNameDataGridViewTextBoxColumn,
            this.agentMobileNoDataGridViewTextBoxColumn,
            this.agentAddressDataGridViewTextBoxColumn});
            this.agentGridView.DataSource = this.agentBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.agentGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.agentGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.agentGridView.Location = new System.Drawing.Point(57, 124);
            this.agentGridView.Name = "agentGridView";
            this.agentGridView.ReadOnly = true;
            this.agentGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.agentGridView.RowHeadersVisible = false;
            this.agentGridView.RowTemplate.Height = 25;
            this.agentGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.agentGridView.Size = new System.Drawing.Size(564, 354);
            this.agentGridView.TabIndex = 1;
            this.agentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.agentGridView_CellContentClick);
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
            this.agentMobileNoDataGridViewTextBoxColumn.Width = 180;
            // 
            // agentAddressDataGridViewTextBoxColumn
            // 
            this.agentAddressDataGridViewTextBoxColumn.DataPropertyName = "AgentAddress";
            this.agentAddressDataGridViewTextBoxColumn.HeaderText = "Agent Address";
            this.agentAddressDataGridViewTextBoxColumn.Name = "agentAddressDataGridViewTextBoxColumn";
            this.agentAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentAddressDataGridViewTextBoxColumn.Width = 180;
            // 
            // agentBindingSource1
            // 
            this.agentBindingSource1.DataMember = "Agent";
            this.agentBindingSource1.DataSource = this.agentDataSet;
            // 
            // agentDataSet
            // 
            this.agentDataSet.DataSetName = "AgentDataSet";
            this.agentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(287, 15);
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
            this.label12.Location = new System.Drawing.Point(209, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 31;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // passengerGridView
            // 
            this.passengerGridView.AllowUserToAddRows = false;
            this.passengerGridView.AllowUserToDeleteRows = false;
            this.passengerGridView.AllowUserToResizeColumns = false;
            this.passengerGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passengerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passengerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.passengerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passengerGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.passengerGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.passengerGridView.Location = new System.Drawing.Point(713, 124);
            this.passengerGridView.Name = "passengerGridView";
            this.passengerGridView.ReadOnly = true;
            this.passengerGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.passengerGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.passengerGridView.RowTemplate.Height = 25;
            this.passengerGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.passengerGridView.Size = new System.Drawing.Size(551, 431);
            this.passengerGridView.TabIndex = 0;
            // 
            // AgentDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.agentGridView);
            this.Controls.Add(this.passengerGridView);
            this.Name = "AgentDetailsView";
            this.Text = "AgentDetailsView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AgentDetailsView_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.agentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView agentGridView;
        
        private System.Windows.Forms.BindingSource agentBindingSource;
       
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private AgentDataSet agentDataSet;
        private System.Windows.Forms.BindingSource agentBindingSource1;
        private AgentDataSetTableAdapters.AgentTableAdapter agentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentMobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView passengerGridView;
    }
}