namespace J.S.R_Holdings
{
    partial class DeletePassenger
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
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deletepassengergridview = new System.Windows.Forms.DataGridView();
            this.passengerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerDataSet2 = new J.S.R_Holdings.PassengerDataSet2();
            this.passengerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._PassengerDataSet = new J.S.R_Holdings._PassengerDataSet();
            this.passengerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.passengerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.refresh = new System.Windows.Forms.Label();
            this.passengerTableAdapter = new J.S.R_Holdings._PassengerDataSetTableAdapters.PassengerTableAdapter();
            this.passengerTableAdapter1 = new J.S.R_Holdings.PassengerDataSet2TableAdapters.PassengerTableAdapter();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletepassengergridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PassengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "Agent";
            // 
            // agentBindingSource1
            // 
            this.agentBindingSource1.DataMember = "Agent";
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
            this.serialNoDataGridViewTextBoxColumn,
            this.passengerNameDataGridViewTextBoxColumn,
            this.passportNoDataGridViewTextBoxColumn,
            this.agentsNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn,
            this.passengerAddressDataGridViewTextBoxColumn,
            this.Status});
            this.deletepassengergridview.DataSource = this.passengerBindingSource4;
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
            this.deletepassengergridview.Location = new System.Drawing.Point(46, 97);
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
            this.deletepassengergridview.Size = new System.Drawing.Size(1303, 558);
            this.deletepassengergridview.TabIndex = 33;
            this.deletepassengergridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletepassengergridview_CellDoubleClick);
            // 
            // passengerBindingSource4
            // 
            this.passengerBindingSource4.DataMember = "Passenger";
            this.passengerBindingSource4.DataSource = this.passengerDataSet2;
            // 
            // passengerDataSet2
            // 
            this.passengerDataSet2.DataSetName = "PassengerDataSet2";
            this.passengerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerBindingSource3
            // 
            this.passengerBindingSource3.DataMember = "Passenger";
            this.passengerBindingSource3.DataSource = this._PassengerDataSet;
            // 
            // _PassengerDataSet
            // 
            this._PassengerDataSet.DataSetName = "_PassengerDataSet";
            this._PassengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerBindingSource2
            // 
            this.passengerBindingSource2.DataMember = "Passenger";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(195, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 31;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(257, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 36);
            this.label13.TabIndex = 32;
            this.label13.Text = "Homepage";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(404, 16);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(103, 36);
            this.refresh.TabIndex = 34;
            this.refresh.Text = "Refresh";
            this.refresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            this.refresh.MouseEnter += new System.EventHandler(this.refresh_MouseEnter);
            this.refresh.MouseLeave += new System.EventHandler(this.refresh_MouseLeave);
            // 
            // passengerTableAdapter
            // 
            this.passengerTableAdapter.ClearBeforeFill = true;
            // 
            // passengerTableAdapter1
            // 
            this.passengerTableAdapter1.ClearBeforeFill = true;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "Serial No";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // passengerNameDataGridViewTextBoxColumn
            // 
            this.passengerNameDataGridViewTextBoxColumn.DataPropertyName = "PassengerName";
            this.passengerNameDataGridViewTextBoxColumn.HeaderText = "Passenger Name";
            this.passengerNameDataGridViewTextBoxColumn.Name = "passengerNameDataGridViewTextBoxColumn";
            this.passengerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.passengerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // passportNoDataGridViewTextBoxColumn
            // 
            this.passportNoDataGridViewTextBoxColumn.DataPropertyName = "PassportNo";
            this.passportNoDataGridViewTextBoxColumn.HeaderText = "Passport No";
            this.passportNoDataGridViewTextBoxColumn.Name = "passportNoDataGridViewTextBoxColumn";
            this.passportNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // agentsNameDataGridViewTextBoxColumn
            // 
            this.agentsNameDataGridViewTextBoxColumn.DataPropertyName = "AgentsName";
            this.agentsNameDataGridViewTextBoxColumn.HeaderText = "Agents Name";
            this.agentsNameDataGridViewTextBoxColumn.Name = "agentsNameDataGridViewTextBoxColumn";
            this.agentsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentsNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 185;
            // 
            // expireDateDataGridViewTextBoxColumn
            // 
            this.expireDateDataGridViewTextBoxColumn.DataPropertyName = "ExpireDate";
            this.expireDateDataGridViewTextBoxColumn.HeaderText = "Expire Date";
            this.expireDateDataGridViewTextBoxColumn.Name = "expireDateDataGridViewTextBoxColumn";
            this.expireDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expireDateDataGridViewTextBoxColumn.Width = 185;
            // 
            // passengerAddressDataGridViewTextBoxColumn
            // 
            this.passengerAddressDataGridViewTextBoxColumn.DataPropertyName = "PassengerAddress";
            this.passengerAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.passengerAddressDataGridViewTextBoxColumn.Name = "passengerAddressDataGridViewTextBoxColumn";
            this.passengerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.passengerAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DeletePassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 700);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.deletepassengergridview);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "DeletePassenger";
            this.Text = "DeletePassenger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeletePassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletepassengergridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PassengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.BindingSource agentBindingSource;
        
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private System.Windows.Forms.BindingSource agentBindingSource1;
        private System.Windows.Forms.DataGridView deletepassengergridview;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource passengerBindingSource1;
       
        private System.Windows.Forms.BindingSource passengerBindingSource2;
        
        private System.Windows.Forms.Label refresh;
        private _PassengerDataSet _PassengerDataSet;
        private System.Windows.Forms.BindingSource passengerBindingSource3;
        private _PassengerDataSetTableAdapters.PassengerTableAdapter passengerTableAdapter;
        private PassengerDataSet2 passengerDataSet2;
        private System.Windows.Forms.BindingSource passengerBindingSource4;
        private PassengerDataSet2TableAdapters.PassengerTableAdapter passengerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}