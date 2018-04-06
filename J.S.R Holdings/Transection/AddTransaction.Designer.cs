namespace J.S.R_Holdings.Transection
{
    partial class AddTransaction
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AmmountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailsTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.agentDataSet = new J.S.R_Holdings.AgentDataSet();
            this.agentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentDataSet2 = new J.S.R_Holdings.AgentDataSet2();
            this.agentDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AgentNameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTableAdapter = new J.S.R_Holdings.AgentDataSetTableAdapters.AgentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(405, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 36);
            this.label14.TabIndex = 31;
            this.label14.Text = "Clear All";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            this.label14.MouseEnter += new System.EventHandler(this.label14_MouseEnter);
            this.label14.MouseLeave += new System.EventHandler(this.label14_MouseLeave);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(248, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 36);
            this.label13.TabIndex = 30;
            this.label13.Text = "Homepage";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(181, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 29;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(289, 514);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(356, 70);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton1.TabIndex = 50;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "ADD";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 38);
            this.label9.TabIndex = 48;
            this.label9.Text = "Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 38);
            this.label6.TabIndex = 46;
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
            this.AmmountTextBox.Location = new System.Drawing.Point(289, 143);
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
            this.AmmountTextBox.TabIndex = 45;
            this.AmmountTextBox.UseSelectable = true;
            this.AmmountTextBox.WaterMark = "Ammount";
            this.AmmountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AmmountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 38);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ammount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DetailsTextBox1.Location = new System.Drawing.Point(289, 328);
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
            this.DetailsTextBox1.TabIndex = 52;
            this.DetailsTextBox1.UseSelectable = true;
            this.DetailsTextBox1.WaterMark = "Details";
            this.DetailsTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DetailsTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 38);
            this.label2.TabIndex = 51;
            this.label2.Text = "Bank Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(616, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(19, 20);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.dateTextBox.Location = new System.Drawing.Point(289, 259);
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
            this.dateTextBox.TabIndex = 53;
            this.dateTextBox.UseSelectable = true;
            this.dateTextBox.WaterMark = "Date";
            this.dateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // agentDataSet
            // 
            this.agentDataSet.DataSetName = "AgentDataSet";
            this.agentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentDataSetBindingSource
            // 
            this.agentDataSetBindingSource.DataSource = this.agentDataSet;
            this.agentDataSetBindingSource.Position = 0;
            // 
            // agentDataSet2
            // 
            this.agentDataSet2.DataSetName = "AgentDataSet2";
            this.agentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentDataSet2BindingSource
            // 
            this.agentDataSet2BindingSource.DataSource = this.agentDataSet2;
            this.agentDataSet2BindingSource.Position = 0;
            // 
            // AgentNameComboBox
            // 
            this.AgentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentBindingSource, "AgentName", true));
            this.AgentNameComboBox.DataSource = this.agentBindingSource;
            this.AgentNameComboBox.DisplayMember = "AgentName";
            this.AgentNameComboBox.FormattingEnabled = true;
            this.AgentNameComboBox.ItemHeight = 23;
            this.AgentNameComboBox.Location = new System.Drawing.Point(289, 201);
            this.AgentNameComboBox.Name = "AgentNameComboBox";
            this.AgentNameComboBox.Size = new System.Drawing.Size(356, 29);
            this.AgentNameComboBox.TabIndex = 55;
            this.AgentNameComboBox.UseSelectable = true;
            this.AgentNameComboBox.ValueMember = "AgentName";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "Agent";
            this.agentBindingSource.DataSource = this.agentDataSetBindingSource;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 657);
            this.Controls.Add(this.AgentNameComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.DetailsTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmmountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "AddTransaction";
            this.Text = "Add Transaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox AmmountTextBox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox DetailsTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroTextBox dateTextBox;
        private AgentDataSet agentDataSet;
        private System.Windows.Forms.BindingSource agentDataSetBindingSource;
        private AgentDataSet2 agentDataSet2;
        private System.Windows.Forms.BindingSource agentDataSet2BindingSource;
        private MetroFramework.Controls.MetroComboBox AgentNameComboBox;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private AgentDataSetTableAdapters.AgentTableAdapter agentTableAdapter;
    }
}