namespace J.S.R_Holdings
{
    partial class DeleteAgent
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
            this.passengerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deletepassengergridview = new System.Windows.Forms.DataGridView();
            this.agentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.agentDataSet = new J.S.R_Holdings.AgentDataSet();
            this.agentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.agentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.agentTableAdapter = new J.S.R_Holdings.AgentDataSetTableAdapters.AgentTableAdapter();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentMobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletepassengergridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(362, 17);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(103, 36);
            this.refresh.TabIndex = 38;
            this.refresh.Text = "Refresh";
            this.refresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            this.refresh.MouseEnter += new System.EventHandler(this.refresh_MouseEnter);
            this.refresh.MouseLeave += new System.EventHandler(this.refresh_MouseLeave);
            // 
            // passengerBindingSource1
            // 
            this.passengerBindingSource1.DataMember = "Passenger";
            // 
            // deletepassengergridview
            // 
            this.deletepassengergridview.AllowUserToAddRows = false;
            this.deletepassengergridview.AllowUserToDeleteRows = false;
            this.deletepassengergridview.AllowUserToResizeColumns = false;
            this.deletepassengergridview.AllowUserToResizeRows = false;
            this.deletepassengergridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletepassengergridview.AutoGenerateColumns = false;
            this.deletepassengergridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletepassengergridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deletepassengergridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deletepassengergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletepassengergridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentNameDataGridViewTextBoxColumn,
            this.agentMobileNoDataGridViewTextBoxColumn,
            this.agentAddressDataGridViewTextBoxColumn});
            this.deletepassengergridview.DataSource = this.agentBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deletepassengergridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.deletepassengergridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.deletepassengergridview.EnableHeadersVisualStyles = false;
            this.deletepassengergridview.GridColor = System.Drawing.Color.Gray;
            this.deletepassengergridview.Location = new System.Drawing.Point(98, 94);
            this.deletepassengergridview.Margin = new System.Windows.Forms.Padding(0);
            this.deletepassengergridview.Name = "deletepassengergridview";
            this.deletepassengergridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deletepassengergridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.deletepassengergridview.RowHeadersVisible = false;
            this.deletepassengergridview.RowTemplate.Height = 23;
            this.deletepassengergridview.ShowCellToolTips = false;
            this.deletepassengergridview.ShowEditingIcon = false;
            this.deletepassengergridview.Size = new System.Drawing.Size(541, 566);
            this.deletepassengergridview.TabIndex = 37;
            this.deletepassengergridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletepassengergridview_CellDoubleClick);
            // 
            // agentBindingSource3
            // 
            this.agentBindingSource3.DataMember = "Agent";
            this.agentBindingSource3.DataSource = this.agentDataSet;
            // 
            // agentDataSet
            // 
            this.agentDataSet.DataSetName = "AgentDataSet";
            this.agentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentBindingSource2
            // 
            this.agentBindingSource2.DataMember = "Agent";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(215, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 36);
            this.label13.TabIndex = 36;
            this.label13.Text = "Homepage";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // agentBindingSource1
            // 
            this.agentBindingSource1.DataMember = "Agent";
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataMember = "Passenger";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "Agent";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(153, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 35;
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
            this.agentMobileNoDataGridViewTextBoxColumn.Width = 175;
            // 
            // agentAddressDataGridViewTextBoxColumn
            // 
            this.agentAddressDataGridViewTextBoxColumn.DataPropertyName = "AgentAddress";
            this.agentAddressDataGridViewTextBoxColumn.HeaderText = "Agent Address";
            this.agentAddressDataGridViewTextBoxColumn.Name = "agentAddressDataGridViewTextBoxColumn";
            this.agentAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentAddressDataGridViewTextBoxColumn.Width = 160;
            // 
            // DeleteAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.deletepassengergridview);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "DeleteAgent";
            this.Text = "DeleteAgent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeleteAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletepassengergridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label refresh;
        
        private System.Windows.Forms.BindingSource passengerBindingSource1;
       
        private System.Windows.Forms.DataGridView deletepassengergridview;
        private System.Windows.Forms.BindingSource passengerBindingSource2;
        
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource agentBindingSource1;
        
        private System.Windows.Forms.BindingSource passengerBindingSource;
        
        private System.Windows.Forms.BindingSource agentBindingSource;
       
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource agentBindingSource2;
        private AgentDataSet agentDataSet;
        private System.Windows.Forms.BindingSource agentBindingSource3;
        private AgentDataSetTableAdapters.AgentTableAdapter agentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentMobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentAddressDataGridViewTextBoxColumn;
    }
}