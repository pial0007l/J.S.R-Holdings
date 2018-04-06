namespace J.S.R_Holdings
{
    partial class PassengerUpdate
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
            this.updatepassengergridview = new System.Windows.Forms.DataGridView();
            this.passengerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._PassengerDataSet = new J.S.R_Holdings._PassengerDataSet();
            this.passengerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTableAdapter = new J.S.R_Holdings._PassengerDataSetTableAdapters.PassengerTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextbox = new MetroFramework.Controls.MetroTextBox();
            this.passengerGridView = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.updatepassengergridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PassengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(286, 16);
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
            this.label12.Location = new System.Drawing.Point(208, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 30;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // updatepassengergridview
            // 
            this.updatepassengergridview.AllowUserToAddRows = false;
            this.updatepassengergridview.AllowUserToDeleteRows = false;
            this.updatepassengergridview.AllowUserToResizeColumns = false;
            this.updatepassengergridview.AllowUserToResizeRows = false;
            this.updatepassengergridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatepassengergridview.AutoGenerateColumns = false;
            this.updatepassengergridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatepassengergridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.updatepassengergridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.updatepassengergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatepassengergridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.agentsNameDataGridViewTextBoxColumn,
            this.Status});
            this.updatepassengergridview.DataSource = this.passengerBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.updatepassengergridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.updatepassengergridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.updatepassengergridview.EnableHeadersVisualStyles = false;
            this.updatepassengergridview.GridColor = System.Drawing.Color.Gray;
            this.updatepassengergridview.Location = new System.Drawing.Point(29, 122);
            this.updatepassengergridview.Margin = new System.Windows.Forms.Padding(0);
            this.updatepassengergridview.Name = "updatepassengergridview";
            this.updatepassengergridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.updatepassengergridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.updatepassengergridview.RowHeadersVisible = false;
            this.updatepassengergridview.RowTemplate.Height = 23;
            this.updatepassengergridview.ShowCellToolTips = false;
            this.updatepassengergridview.ShowEditingIcon = false;
            this.updatepassengergridview.Size = new System.Drawing.Size(1025, 558);
            this.updatepassengergridview.TabIndex = 32;
            this.updatepassengergridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.passengergridview_CellMouseClick);
            // 
            // passengerBindingSource2
            // 
            this.passengerBindingSource2.DataMember = "Passenger";
            this.passengerBindingSource2.DataSource = this._PassengerDataSet;
            // 
            // _PassengerDataSet
            // 
            this._PassengerDataSet.DataSetName = "_PassengerDataSet";
            this._PassengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataMember = "Passenger";
            // 
            // passengerTableAdapter
            // 
            this.passengerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SerialNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serial No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PassengerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Passenger Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PassportNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Passport No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PassengerAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "Passenger Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // agentsNameDataGridViewTextBoxColumn
            // 
            this.agentsNameDataGridViewTextBoxColumn.DataPropertyName = "AgentsName";
            this.agentsNameDataGridViewTextBoxColumn.HeaderText = "Agents Name";
            this.agentsNameDataGridViewTextBoxColumn.Name = "agentsNameDataGridViewTextBoxColumn";
            this.agentsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentsNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // searchTextbox
            // 
            this.searchTextbox.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.searchTextbox.CustomButton.Image = null;
            this.searchTextbox.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.searchTextbox.CustomButton.Name = "";
            this.searchTextbox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.searchTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextbox.CustomButton.TabIndex = 1;
            this.searchTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextbox.CustomButton.UseSelectable = true;
            this.searchTextbox.CustomButton.Visible = false;
            this.searchTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchTextbox.Lines = new string[0];
            this.searchTextbox.Location = new System.Drawing.Point(1085, 122);
            this.searchTextbox.MaxLength = 32767;
            this.searchTextbox.Multiline = true;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.PasswordChar = '\0';
            this.searchTextbox.PromptText = "Enter Passport No";
            this.searchTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextbox.SelectedText = "";
            this.searchTextbox.SelectionLength = 0;
            this.searchTextbox.SelectionStart = 0;
            this.searchTextbox.ShortcutsEnabled = true;
            this.searchTextbox.Size = new System.Drawing.Size(201, 38);
            this.searchTextbox.Style = MetroFramework.MetroColorStyle.Black;
            this.searchTextbox.TabIndex = 37;
            this.searchTextbox.UseSelectable = true;
            this.searchTextbox.WaterMark = "Enter Passport No";
            this.searchTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // passengerGridView
            // 
            this.passengerGridView.AllowUserToAddRows = false;
            this.passengerGridView.AllowUserToDeleteRows = false;
            this.passengerGridView.AllowUserToResizeColumns = false;
            this.passengerGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passengerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passengerGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passengerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.passengerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengerGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passengerGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.passengerGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.passengerGridView.Location = new System.Drawing.Point(1085, 186);
            this.passengerGridView.Name = "passengerGridView";
            this.passengerGridView.ReadOnly = true;
            this.passengerGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.passengerGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.passengerGridView.RowTemplate.Height = 25;
            this.passengerGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.passengerGridView.Size = new System.Drawing.Size(201, 116);
            this.passengerGridView.TabIndex = 38;
            this.passengerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passengerGridView_CellClick);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(1085, 336);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(201, 44);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton1.TabIndex = 60;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "SEARCH";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PassengerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.passengerGridView);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.updatepassengergridview);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "PassengerUpdate";
            this.Text = "PassengerUpdate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PassengerUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updatepassengergridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PassengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView updatepassengergridview;
        
        private System.Windows.Forms.BindingSource passengerBindingSource;
        
        
        private System.Windows.Forms.BindingSource passengerBindingSource1;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerAddressDataGridViewTextBoxColumn;
        private _PassengerDataSet _PassengerDataSet;
        private System.Windows.Forms.BindingSource passengerBindingSource2;
        private _PassengerDataSetTableAdapters.PassengerTableAdapter passengerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private MetroFramework.Controls.MetroTextBox searchTextbox;
        private System.Windows.Forms.DataGridView passengerGridView;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}