namespace J.S.R_Holdings.Transection
{
    partial class UpdateTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteCompanygridview = new System.Windows.Forms.DataGridView();
            this._J_S_R_HoldingsDATADataSet = new J.S.R_Holdings._J_S_R_HoldingsDATADataSet();
            this.transectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transectionTableAdapter = new J.S.R_Holdings._J_S_R_HoldingsDATADataSetTableAdapters.TransectionTableAdapter();
            this.ammountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentNameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DetailsTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateButton1 = new MetroFramework.Controls.MetroButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AmmountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deleteCompanygridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._J_S_R_HoldingsDATADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transectionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(276, 18);
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
            this.label12.Location = new System.Drawing.Point(209, 18);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCompanygridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.deleteCompanygridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteCompanygridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ammountDataGridViewTextBoxColumn,
            this.agentNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.bankNameDataGridViewTextBoxColumn,
            this.Id});
            this.deleteCompanygridview.DataSource = this.transectionBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteCompanygridview.DefaultCellStyle = dataGridViewCellStyle8;
            this.deleteCompanygridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.deleteCompanygridview.EnableHeadersVisualStyles = false;
            this.deleteCompanygridview.GridColor = System.Drawing.Color.Gray;
            this.deleteCompanygridview.Location = new System.Drawing.Point(38, 105);
            this.deleteCompanygridview.Margin = new System.Windows.Forms.Padding(0);
            this.deleteCompanygridview.Name = "deleteCompanygridview";
            this.deleteCompanygridview.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Format = "N1";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCompanygridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.deleteCompanygridview.RowHeadersVisible = false;
            this.deleteCompanygridview.RowTemplate.Height = 23;
            this.deleteCompanygridview.ShowCellToolTips = false;
            this.deleteCompanygridview.ShowEditingIcon = false;
            this.deleteCompanygridview.Size = new System.Drawing.Size(776, 413);
            this.deleteCompanygridview.TabIndex = 44;
            this.deleteCompanygridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteCompanygridview_CellContentClick);
            this.deleteCompanygridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteCompanygridview_CellDoubleClick);
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // AgentNameComboBox
            // 
            this.AgentNameComboBox.DataSource = this.transectionBindingSource1;
            this.AgentNameComboBox.DisplayMember = "AgentName";
            this.AgentNameComboBox.FormattingEnabled = true;
            this.AgentNameComboBox.ItemHeight = 23;
            this.AgentNameComboBox.Location = new System.Drawing.Point(985, 162);
            this.AgentNameComboBox.Name = "AgentNameComboBox";
            this.AgentNameComboBox.Size = new System.Drawing.Size(356, 29);
            this.AgentNameComboBox.TabIndex = 65;
            this.AgentNameComboBox.UseSelectable = true;
            this.AgentNameComboBox.ValueMember = "AgentName";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1312, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(19, 20);
            this.dateTimePicker1.TabIndex = 64;
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.dateTextBox.CustomButton.Image = null;
            this.dateTextBox.CustomButton.Location = new System.Drawing.Point(320, 2);
            this.dateTextBox.CustomButton.Name = "";
            this.dateTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.dateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dateTextBox.CustomButton.TabIndex = 1;
            this.dateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dateTextBox.CustomButton.UseSelectable = true;
            this.dateTextBox.CustomButton.Visible = false;
            this.dateTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.dateTextBox.Lines = new string[0];
            this.dateTextBox.Location = new System.Drawing.Point(985, 220);
            this.dateTextBox.MaxLength = 32767;
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.PasswordChar = '\0';
            this.dateTextBox.PromptText = "Date";
            this.dateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dateTextBox.SelectedText = "";
            this.dateTextBox.SelectionLength = 0;
            this.dateTextBox.SelectionStart = 0;
            this.dateTextBox.ShortcutsEnabled = true;
            this.dateTextBox.Size = new System.Drawing.Size(356, 38);
            this.dateTextBox.Style = MetroFramework.MetroColorStyle.Black;
            this.dateTextBox.TabIndex = 63;
            this.dateTextBox.UseSelectable = true;
            this.dateTextBox.WaterMark = "Date";
            this.dateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DetailsTextBox1
            // 
            this.DetailsTextBox1.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.DetailsTextBox1.CustomButton.Image = null;
            this.DetailsTextBox1.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.DetailsTextBox1.CustomButton.Name = "";
            this.DetailsTextBox1.CustomButton.Size = new System.Drawing.Size(111, 111);
            this.DetailsTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DetailsTextBox1.CustomButton.TabIndex = 1;
            this.DetailsTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DetailsTextBox1.CustomButton.UseSelectable = true;
            this.DetailsTextBox1.CustomButton.Visible = false;
            this.DetailsTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.DetailsTextBox1.Lines = new string[0];
            this.DetailsTextBox1.Location = new System.Drawing.Point(985, 289);
            this.DetailsTextBox1.MaxLength = 32767;
            this.DetailsTextBox1.Multiline = true;
            this.DetailsTextBox1.Name = "DetailsTextBox1";
            this.DetailsTextBox1.PasswordChar = '\0';
            this.DetailsTextBox1.PromptText = "Details";
            this.DetailsTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DetailsTextBox1.SelectedText = "";
            this.DetailsTextBox1.SelectionLength = 0;
            this.DetailsTextBox1.SelectionStart = 0;
            this.DetailsTextBox1.ShortcutsEnabled = true;
            this.DetailsTextBox1.Size = new System.Drawing.Size(356, 116);
            this.DetailsTextBox1.Style = MetroFramework.MetroColorStyle.Black;
            this.DetailsTextBox1.TabIndex = 62;
            this.DetailsTextBox1.UseSelectable = true;
            this.DetailsTextBox1.WaterMark = "Details";
            this.DetailsTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DetailsTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(802, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 38);
            this.label2.TabIndex = 61;
            this.label2.Text = "Bank Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateButton1
            // 
            this.UpdateButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.UpdateButton1.Location = new System.Drawing.Point(985, 475);
            this.UpdateButton1.Name = "UpdateButton1";
            this.UpdateButton1.Size = new System.Drawing.Size(356, 70);
            this.UpdateButton1.Style = MetroFramework.MetroColorStyle.Black;
            this.UpdateButton1.TabIndex = 60;
            this.UpdateButton1.TabStop = false;
            this.UpdateButton1.Text = "UPDATE";
            this.UpdateButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UpdateButton1.UseSelectable = true;
            this.UpdateButton1.Click += new System.EventHandler(this.UpdateButton1_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(817, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 38);
            this.label9.TabIndex = 59;
            this.label9.Text = "Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(802, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 38);
            this.label6.TabIndex = 58;
            this.label6.Text = "Agent Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmmountTextBox
            // 
            this.AmmountTextBox.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.AmmountTextBox.CustomButton.Image = null;
            this.AmmountTextBox.CustomButton.Location = new System.Drawing.Point(320, 2);
            this.AmmountTextBox.CustomButton.Name = "";
            this.AmmountTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.AmmountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AmmountTextBox.CustomButton.TabIndex = 1;
            this.AmmountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AmmountTextBox.CustomButton.UseSelectable = true;
            this.AmmountTextBox.CustomButton.Visible = false;
            this.AmmountTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.AmmountTextBox.Lines = new string[0];
            this.AmmountTextBox.Location = new System.Drawing.Point(985, 104);
            this.AmmountTextBox.MaxLength = 32767;
            this.AmmountTextBox.Multiline = true;
            this.AmmountTextBox.Name = "AmmountTextBox";
            this.AmmountTextBox.PasswordChar = '\0';
            this.AmmountTextBox.PromptText = "Ammount";
            this.AmmountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AmmountTextBox.SelectedText = "";
            this.AmmountTextBox.SelectionLength = 0;
            this.AmmountTextBox.SelectionStart = 0;
            this.AmmountTextBox.ShortcutsEnabled = true;
            this.AmmountTextBox.Size = new System.Drawing.Size(356, 38);
            this.AmmountTextBox.Style = MetroFramework.MetroColorStyle.Black;
            this.AmmountTextBox.TabIndex = 57;
            this.AmmountTextBox.UseSelectable = true;
            this.AmmountTextBox.WaterMark = "Ammount";
            this.AmmountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AmmountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(817, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 38);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ammount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transectionBindingSource1
            // 
            this.transectionBindingSource1.DataMember = "Transection";
            this.transectionBindingSource1.DataSource = this._J_S_R_HoldingsDATADataSet;
            // 
            // UpdateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 584);
            this.Controls.Add(this.AgentNameComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.DetailsTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmmountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteCompanygridview);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "UpdateTransaction";
            this.Text = "UpdateTransaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdateTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteCompanygridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._J_S_R_HoldingsDATADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transectionBindingSource1)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox AgentNameComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroTextBox dateTextBox;
        private MetroFramework.Controls.MetroTextBox DetailsTextBox1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton UpdateButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox AmmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource transectionBindingSource1;
    }
}