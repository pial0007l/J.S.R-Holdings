namespace J.S.R_Holdings
{
    partial class ViewPassenger
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
            this.passengergridview = new System.Windows.Forms.DataGridView();
            this.passengerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._PassengerDataSet = new J.S.R_Holdings._PassengerDataSet();
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTableAdapter = new J.S.R_Holdings._PassengerDataSetTableAdapters.PassengerTableAdapter();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.passengergridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PassengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(263, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 36);
            this.label13.TabIndex = 29;
            this.label13.Text = "Homepage";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(185, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 28;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // passengergridview
            // 
            this.passengergridview.AllowUserToAddRows = false;
            this.passengergridview.AllowUserToDeleteRows = false;
            this.passengergridview.AllowUserToResizeColumns = false;
            this.passengergridview.AllowUserToResizeRows = false;
            this.passengergridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passengergridview.AutoGenerateColumns = false;
            this.passengergridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passengergridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passengergridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.passengergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengergridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoDataGridViewTextBoxColumn,
            this.passengerNameDataGridViewTextBoxColumn,
            this.passportNoDataGridViewTextBoxColumn,
            this.passengerAddressDataGridViewTextBoxColumn,
            this.agentsNameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn,
            this.Status});
            this.passengergridview.DataSource = this.passengerBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passengergridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.passengergridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.passengergridview.EnableHeadersVisualStyles = false;
            this.passengergridview.GridColor = System.Drawing.Color.Gray;
            this.passengergridview.Location = new System.Drawing.Point(29, 90);
            this.passengergridview.Margin = new System.Windows.Forms.Padding(0);
            this.passengergridview.Name = "passengergridview";
            this.passengergridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passengergridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.passengergridview.RowHeadersVisible = false;
            this.passengergridview.RowTemplate.Height = 23;
            this.passengergridview.ShowCellToolTips = false;
            this.passengergridview.ShowEditingIcon = false;
            this.passengergridview.Size = new System.Drawing.Size(1367, 558);
            this.passengergridview.TabIndex = 30;
            this.passengergridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passengergridview_CellDoubleClick);
            // 
            // passengerBindingSource1
            // 
            this.passengerBindingSource1.DataMember = "Passenger";
            this.passengerBindingSource1.DataSource = this._PassengerDataSet;
            // 
            // _PassengerDataSet
            // 
            this._PassengerDataSet.DataSetName = "_PassengerDataSet";
            this._PassengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerTableAdapter
            // 
            this.passengerTableAdapter.ClearBeforeFill = true;
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
            // passengerAddressDataGridViewTextBoxColumn
            // 
            this.passengerAddressDataGridViewTextBoxColumn.DataPropertyName = "PassengerAddress";
            this.passengerAddressDataGridViewTextBoxColumn.HeaderText = "Passenger Address";
            this.passengerAddressDataGridViewTextBoxColumn.Name = "passengerAddressDataGridViewTextBoxColumn";
            this.passengerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.passengerAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // agentsNameDataGridViewTextBoxColumn
            // 
            this.agentsNameDataGridViewTextBoxColumn.DataPropertyName = "AgentsName";
            this.agentsNameDataGridViewTextBoxColumn.HeaderText = "Agents Name";
            this.agentsNameDataGridViewTextBoxColumn.Name = "agentsNameDataGridViewTextBoxColumn";
            this.agentsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentsNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // expireDateDataGridViewTextBoxColumn
            // 
            this.expireDateDataGridViewTextBoxColumn.DataPropertyName = "ExpireDate";
            this.expireDateDataGridViewTextBoxColumn.HeaderText = "Expire Date";
            this.expireDateDataGridViewTextBoxColumn.Name = "expireDateDataGridViewTextBoxColumn";
            this.expireDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expireDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ViewPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.passengergridview);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "ViewPassenger";
            this.Text = "ViewPassenger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passengergridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PassengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView passengergridview;
       
        private System.Windows.Forms.BindingSource passengerBindingSource;
       
       
        private System.Windows.Forms.BindingSource agentBindingSource;
       
        private System.Windows.Forms.BindingSource agentBindingSource1;
        private _PassengerDataSet _PassengerDataSet;
        private System.Windows.Forms.BindingSource passengerBindingSource1;
        private _PassengerDataSetTableAdapters.PassengerTableAdapter passengerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}