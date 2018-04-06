namespace J.S.R_Holdings
{
    partial class CompanyUpdate
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
            this.UpdateCompanygridview = new System.Windows.Forms.DataGridView();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSet2 = new J.S.R_Holdings.CompanyDataSet2();
            this.companyTableAdapter = new J.S.R_Holdings.CompanyDataSet2TableAdapters.CompanyTableAdapter();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.workTypeUpdateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.salaryUpdateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.companynameUpdateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vacancyUpdateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateCompanygridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(295, 17);
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
            this.label12.Location = new System.Drawing.Point(217, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 30;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // UpdateCompanygridview
            // 
            this.UpdateCompanygridview.AllowUserToAddRows = false;
            this.UpdateCompanygridview.AllowUserToDeleteRows = false;
            this.UpdateCompanygridview.AllowUserToResizeColumns = false;
            this.UpdateCompanygridview.AllowUserToResizeRows = false;
            this.UpdateCompanygridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateCompanygridview.AutoGenerateColumns = false;
            this.UpdateCompanygridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateCompanygridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateCompanygridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UpdateCompanygridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateCompanygridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn1,
            this.salaryDataGridViewTextBoxColumn1,
            this.workTypeDataGridViewTextBoxColumn1,
            this.vacancyDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn});
            this.UpdateCompanygridview.DataSource = this.companyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UpdateCompanygridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.UpdateCompanygridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UpdateCompanygridview.EnableHeadersVisualStyles = false;
            this.UpdateCompanygridview.GridColor = System.Drawing.Color.Gray;
            this.UpdateCompanygridview.Location = new System.Drawing.Point(77, 93);
            this.UpdateCompanygridview.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateCompanygridview.Name = "UpdateCompanygridview";
            this.UpdateCompanygridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateCompanygridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UpdateCompanygridview.RowHeadersVisible = false;
            this.UpdateCompanygridview.RowTemplate.Height = 23;
            this.UpdateCompanygridview.ShowCellToolTips = false;
            this.UpdateCompanygridview.ShowEditingIcon = false;
            this.UpdateCompanygridview.Size = new System.Drawing.Size(603, 566);
            this.UpdateCompanygridview.TabIndex = 43;
            this.UpdateCompanygridview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteCompanygridview_CellContentDoubleClick);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.companyDataSet2;
            // 
            // companyDataSet2
            // 
            this.companyDataSet2.DataSetName = "CompanyDataSet2";
            this.companyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(921, 441);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(356, 70);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton1.TabIndex = 67;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "UPDATE";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // workTypeUpdateTextBox
            // 
            this.workTypeUpdateTextBox.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.workTypeUpdateTextBox.CustomButton.Image = null;
            this.workTypeUpdateTextBox.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.workTypeUpdateTextBox.CustomButton.Name = "";
            this.workTypeUpdateTextBox.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.workTypeUpdateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.workTypeUpdateTextBox.CustomButton.TabIndex = 1;
            this.workTypeUpdateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.workTypeUpdateTextBox.CustomButton.UseSelectable = true;
            this.workTypeUpdateTextBox.CustomButton.Visible = false;
            this.workTypeUpdateTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.workTypeUpdateTextBox.Lines = new string[0];
            this.workTypeUpdateTextBox.Location = new System.Drawing.Point(921, 208);
            this.workTypeUpdateTextBox.MaxLength = 32767;
            this.workTypeUpdateTextBox.Multiline = true;
            this.workTypeUpdateTextBox.Name = "workTypeUpdateTextBox";
            this.workTypeUpdateTextBox.PasswordChar = '\0';
            this.workTypeUpdateTextBox.PromptText = "Work Type";
            this.workTypeUpdateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.workTypeUpdateTextBox.SelectedText = "";
            this.workTypeUpdateTextBox.SelectionLength = 0;
            this.workTypeUpdateTextBox.SelectionStart = 0;
            this.workTypeUpdateTextBox.ShortcutsEnabled = true;
            this.workTypeUpdateTextBox.Size = new System.Drawing.Size(356, 108);
            this.workTypeUpdateTextBox.Style = MetroFramework.MetroColorStyle.Black;
            this.workTypeUpdateTextBox.TabIndex = 66;
            this.workTypeUpdateTextBox.UseSelectable = true;
            this.workTypeUpdateTextBox.WaterMark = "Work Type";
            this.workTypeUpdateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.workTypeUpdateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(753, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 38);
            this.label9.TabIndex = 65;
            this.label9.Text = "Work Type";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salaryUpdateTextBox
            // 
            this.salaryUpdateTextBox.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.salaryUpdateTextBox.CustomButton.Image = null;
            this.salaryUpdateTextBox.CustomButton.Location = new System.Drawing.Point(320, 2);
            this.salaryUpdateTextBox.CustomButton.Name = "";
            this.salaryUpdateTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.salaryUpdateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.salaryUpdateTextBox.CustomButton.TabIndex = 1;
            this.salaryUpdateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salaryUpdateTextBox.CustomButton.UseSelectable = true;
            this.salaryUpdateTextBox.CustomButton.Visible = false;
            this.salaryUpdateTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.salaryUpdateTextBox.Lines = new string[0];
            this.salaryUpdateTextBox.Location = new System.Drawing.Point(921, 150);
            this.salaryUpdateTextBox.MaxLength = 32767;
            this.salaryUpdateTextBox.Multiline = true;
            this.salaryUpdateTextBox.Name = "salaryUpdateTextBox";
            this.salaryUpdateTextBox.PasswordChar = '\0';
            this.salaryUpdateTextBox.PromptText = "Salary";
            this.salaryUpdateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salaryUpdateTextBox.SelectedText = "";
            this.salaryUpdateTextBox.SelectionLength = 0;
            this.salaryUpdateTextBox.SelectionStart = 0;
            this.salaryUpdateTextBox.ShortcutsEnabled = true;
            this.salaryUpdateTextBox.Size = new System.Drawing.Size(356, 38);
            this.salaryUpdateTextBox.Style = MetroFramework.MetroColorStyle.Black;
            this.salaryUpdateTextBox.TabIndex = 64;
            this.salaryUpdateTextBox.UseSelectable = true;
            this.salaryUpdateTextBox.WaterMark = "Salary";
            this.salaryUpdateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.salaryUpdateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(753, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 38);
            this.label6.TabIndex = 63;
            this.label6.Text = "Salary";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companynameUpdateTextBox
            // 
            this.companynameUpdateTextBox.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.companynameUpdateTextBox.CustomButton.Image = null;
            this.companynameUpdateTextBox.CustomButton.Location = new System.Drawing.Point(320, 2);
            this.companynameUpdateTextBox.CustomButton.Name = "";
            this.companynameUpdateTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.companynameUpdateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.companynameUpdateTextBox.CustomButton.TabIndex = 1;
            this.companynameUpdateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.companynameUpdateTextBox.CustomButton.UseSelectable = true;
            this.companynameUpdateTextBox.CustomButton.Visible = false;
            this.companynameUpdateTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.companynameUpdateTextBox.Lines = new string[0];
            this.companynameUpdateTextBox.Location = new System.Drawing.Point(921, 92);
            this.companynameUpdateTextBox.MaxLength = 32767;
            this.companynameUpdateTextBox.Multiline = true;
            this.companynameUpdateTextBox.Name = "companynameUpdateTextBox";
            this.companynameUpdateTextBox.PasswordChar = '\0';
            this.companynameUpdateTextBox.PromptText = "Name";
            this.companynameUpdateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.companynameUpdateTextBox.SelectedText = "";
            this.companynameUpdateTextBox.SelectionLength = 0;
            this.companynameUpdateTextBox.SelectionStart = 0;
            this.companynameUpdateTextBox.ShortcutsEnabled = true;
            this.companynameUpdateTextBox.Size = new System.Drawing.Size(356, 38);
            this.companynameUpdateTextBox.Style = MetroFramework.MetroColorStyle.Black;
            this.companynameUpdateTextBox.TabIndex = 62;
            this.companynameUpdateTextBox.UseSelectable = true;
            this.companynameUpdateTextBox.WaterMark = "Name";
            this.companynameUpdateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.companynameUpdateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(753, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 38);
            this.label1.TabIndex = 61;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vacancyUpdateTextBox
            // 
            this.vacancyUpdateTextBox.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.vacancyUpdateTextBox.CustomButton.Image = null;
            this.vacancyUpdateTextBox.CustomButton.Location = new System.Drawing.Point(320, 2);
            this.vacancyUpdateTextBox.CustomButton.Name = "";
            this.vacancyUpdateTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.vacancyUpdateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vacancyUpdateTextBox.CustomButton.TabIndex = 1;
            this.vacancyUpdateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vacancyUpdateTextBox.CustomButton.UseSelectable = true;
            this.vacancyUpdateTextBox.CustomButton.Visible = false;
            this.vacancyUpdateTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.vacancyUpdateTextBox.Lines = new string[0];
            this.vacancyUpdateTextBox.Location = new System.Drawing.Point(921, 333);
            this.vacancyUpdateTextBox.MaxLength = 32767;
            this.vacancyUpdateTextBox.Multiline = true;
            this.vacancyUpdateTextBox.Name = "vacancyUpdateTextBox";
            this.vacancyUpdateTextBox.PasswordChar = '\0';
            this.vacancyUpdateTextBox.PromptText = "Vacancy";
            this.vacancyUpdateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vacancyUpdateTextBox.SelectedText = "";
            this.vacancyUpdateTextBox.SelectionLength = 0;
            this.vacancyUpdateTextBox.SelectionStart = 0;
            this.vacancyUpdateTextBox.ShortcutsEnabled = true;
            this.vacancyUpdateTextBox.Size = new System.Drawing.Size(356, 38);
            this.vacancyUpdateTextBox.Style = MetroFramework.MetroColorStyle.Black;
            this.vacancyUpdateTextBox.TabIndex = 60;
            this.vacancyUpdateTextBox.UseSelectable = true;
            this.vacancyUpdateTextBox.WaterMark = "Vacancy";
            this.vacancyUpdateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vacancyUpdateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(753, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 38);
            this.label11.TabIndex = 59;
            this.label11.Text = "Vacancy";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // workTypeDataGridViewTextBoxColumn
            // 
            this.workTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.HeaderText = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.Name = "workTypeDataGridViewTextBoxColumn";
            this.workTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // vacancyDataGridViewTextBoxColumn
            // 
            this.vacancyDataGridViewTextBoxColumn.DataPropertyName = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn.HeaderText = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn.Name = "vacancyDataGridViewTextBoxColumn";
            this.vacancyDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyNameDataGridViewTextBoxColumn1
            // 
            this.companyNameDataGridViewTextBoxColumn1.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn1.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn1.Name = "companyNameDataGridViewTextBoxColumn1";
            this.companyNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // salaryDataGridViewTextBoxColumn1
            // 
            this.salaryDataGridViewTextBoxColumn1.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn1.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn1.Name = "salaryDataGridViewTextBoxColumn1";
            this.salaryDataGridViewTextBoxColumn1.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn1.Width = 150;
            // 
            // workTypeDataGridViewTextBoxColumn1
            // 
            this.workTypeDataGridViewTextBoxColumn1.DataPropertyName = "WorkType";
            this.workTypeDataGridViewTextBoxColumn1.HeaderText = "WorkType";
            this.workTypeDataGridViewTextBoxColumn1.Name = "workTypeDataGridViewTextBoxColumn1";
            this.workTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.workTypeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // vacancyDataGridViewTextBoxColumn1
            // 
            this.vacancyDataGridViewTextBoxColumn1.DataPropertyName = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn1.HeaderText = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn1.Name = "vacancyDataGridViewTextBoxColumn1";
            this.vacancyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.vacancyDataGridViewTextBoxColumn1.Width = 150;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 5;
            // 
            // CompanyUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.workTypeUpdateTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.salaryUpdateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.companynameUpdateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vacancyUpdateTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.UpdateCompanygridview);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "CompanyUpdate";
            this.Text = "Company Update";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompanyUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateCompanygridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView UpdateCompanygridview;
        private CompanyDataSet2 companyDataSet2;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private CompanyDataSet2TableAdapters.CompanyTableAdapter companyTableAdapter;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox workTypeUpdateTextBox;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox salaryUpdateTextBox;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox companynameUpdateTextBox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox vacancyUpdateTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}