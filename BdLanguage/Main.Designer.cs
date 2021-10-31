
namespace BdLanguage
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ClientDG = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languageDataSet = new BdLanguage.LanguageDataSet();
            this.VisitBtn = new System.Windows.Forms.Button();
            this.LFPlb = new System.Windows.Forms.Label();
            this.FLPtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.EmailLb = new System.Windows.Forms.Label();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.PhoneLb = new System.Windows.Forms.Label();
            this.ViewCB = new System.Windows.Forms.ComboBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.LohoPb = new System.Windows.Forms.PictureBox();
            this.SexLb = new System.Windows.Forms.Label();
            this.SexCB = new System.Windows.Forms.ComboBox();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.NewClientBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ViewLb = new System.Windows.Forms.Label();
            this.clientTableAdapter = new BdLanguage.LanguageDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LohoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientDG
            // 
            this.ClientDG.AutoGenerateColumns = false;
            this.ClientDG.BackgroundColor = System.Drawing.Color.White;
            this.ClientDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.genderCodeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.LastVisit,
            this.Total});
            this.ClientDG.DataSource = this.clientBindingSource;
            this.ClientDG.Location = new System.Drawing.Point(12, 164);
            this.ClientDG.Name = "ClientDG";
            this.ClientDG.Size = new System.Drawing.Size(1170, 294);
            this.ClientDG.TabIndex = 0;
            this.ClientDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientDG_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderCodeDataGridViewTextBoxColumn
            // 
            this.genderCodeDataGridViewTextBoxColumn.DataPropertyName = "GenderCode";
            this.genderCodeDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderCodeDataGridViewTextBoxColumn.Name = "genderCodeDataGridViewTextBoxColumn";
            this.genderCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Width = 120;
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "Дата регистрации";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // LastVisit
            // 
            this.LastVisit.DataPropertyName = "StartTime";
            this.LastVisit.HeaderText = "Последнее посещение";
            this.LastVisit.Name = "LastVisit";
            this.LastVisit.ReadOnly = true;
            this.LastVisit.Width = 150;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "countproc";
            this.Total.HeaderText = "Всего";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 60;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.languageDataSet;
            // 
            // languageDataSet
            // 
            this.languageDataSet.DataSetName = "LanguageDataSet";
            this.languageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VisitBtn
            // 
            this.VisitBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.VisitBtn.ForeColor = System.Drawing.Color.White;
            this.VisitBtn.Location = new System.Drawing.Point(1044, 96);
            this.VisitBtn.Name = "VisitBtn";
            this.VisitBtn.Size = new System.Drawing.Size(121, 23);
            this.VisitBtn.TabIndex = 1;
            this.VisitBtn.Text = "Посещения";
            this.VisitBtn.UseVisualStyleBackColor = false;
            this.VisitBtn.Click += new System.EventHandler(this.VisitBtn_Click);
            // 
            // LFPlb
            // 
            this.LFPlb.AutoSize = true;
            this.LFPlb.Location = new System.Drawing.Point(6, 27);
            this.LFPlb.Name = "LFPlb";
            this.LFPlb.Size = new System.Drawing.Size(34, 13);
            this.LFPlb.TabIndex = 2;
            this.LFPlb.Text = "ФИО";
            // 
            // FLPtb
            // 
            this.FLPtb.Location = new System.Drawing.Point(46, 24);
            this.FLPtb.Name = "FLPtb";
            this.FLPtb.Size = new System.Drawing.Size(120, 20);
            this.FLPtb.TabIndex = 3;
            this.FLPtb.TextChanged += new System.EventHandler(this.FLPtb_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhoneTb);
            this.groupBox1.Controls.Add(this.EmailLb);
            this.groupBox1.Controls.Add(this.EmailTb);
            this.groupBox1.Controls.Add(this.PhoneLb);
            this.groupBox1.Controls.Add(this.LFPlb);
            this.groupBox1.Controls.Add(this.FLPtb);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(244, 24);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(120, 20);
            this.PhoneTb.TabIndex = 5;
            this.PhoneTb.TextChanged += new System.EventHandler(this.PhoneTb_TextChanged);
            // 
            // EmailLb
            // 
            this.EmailLb.AutoSize = true;
            this.EmailLb.Location = new System.Drawing.Point(383, 27);
            this.EmailLb.Name = "EmailLb";
            this.EmailLb.Size = new System.Drawing.Size(32, 13);
            this.EmailLb.TabIndex = 6;
            this.EmailLb.Text = "Email";
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(423, 24);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(120, 20);
            this.EmailTb.TabIndex = 7;
            this.EmailTb.TextChanged += new System.EventHandler(this.EmailTb_TextChanged);
            // 
            // PhoneLb
            // 
            this.PhoneLb.AutoSize = true;
            this.PhoneLb.Location = new System.Drawing.Point(186, 27);
            this.PhoneLb.Name = "PhoneLb";
            this.PhoneLb.Size = new System.Drawing.Size(52, 13);
            this.PhoneLb.TabIndex = 4;
            this.PhoneLb.Text = "Телефон";
            // 
            // ViewCB
            // 
            this.ViewCB.FormattingEnabled = true;
            this.ViewCB.Items.AddRange(new object[] {
            "10 из 100",
            "25 из 100",
            "50 из 100",
            "Все"});
            this.ViewCB.Location = new System.Drawing.Point(1098, 127);
            this.ViewCB.Name = "ViewCB";
            this.ViewCB.Size = new System.Drawing.Size(67, 21);
            this.ViewCB.TabIndex = 5;
            this.ViewCB.SelectedIndexChanged += new System.EventHandler(this.ViewCB_SelectedIndexChanged);
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NameLb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NameLb.Location = new System.Drawing.Point(128, 42);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(102, 26);
            this.NameLb.TabIndex = 8;
            this.NameLb.Text = "Клиенты";
            // 
            // LohoPb
            // 
            this.LohoPb.Image = global::BdLanguage.Properties.Resources.school_logo80px;
            this.LohoPb.Location = new System.Drawing.Point(21, 12);
            this.LohoPb.Name = "LohoPb";
            this.LohoPb.Size = new System.Drawing.Size(81, 80);
            this.LohoPb.TabIndex = 9;
            this.LohoPb.TabStop = false;
            // 
            // SexLb
            // 
            this.SexLb.AutoSize = true;
            this.SexLb.Location = new System.Drawing.Point(930, 130);
            this.SexLb.Name = "SexLb";
            this.SexLb.Size = new System.Drawing.Size(27, 13);
            this.SexLb.TabIndex = 10;
            this.SexLb.Text = "Пол";
            // 
            // SexCB
            // 
            this.SexCB.FormattingEnabled = true;
            this.SexCB.Items.AddRange(new object[] {
            "1",
            "2",
            "All"});
            this.SexCB.Location = new System.Drawing.Point(963, 127);
            this.SexCB.Name = "SexCB";
            this.SexCB.Size = new System.Drawing.Size(67, 21);
            this.SexCB.TabIndex = 11;
            this.SexCB.SelectedIndexChanged += new System.EventHandler(this.SexCB_SelectedIndexChanged);
            // 
            // MinusBtn
            // 
            this.MinusBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MinusBtn.ForeColor = System.Drawing.Color.White;
            this.MinusBtn.Location = new System.Drawing.Point(1036, 125);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(25, 25);
            this.MinusBtn.TabIndex = 12;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = false;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlusBtn.ForeColor = System.Drawing.Color.White;
            this.PlusBtn.Location = new System.Drawing.Point(1067, 125);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(25, 25);
            this.PlusBtn.TabIndex = 13;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = false;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // NewClientBtn
            // 
            this.NewClientBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewClientBtn.ForeColor = System.Drawing.Color.White;
            this.NewClientBtn.Location = new System.Drawing.Point(12, 475);
            this.NewClientBtn.Name = "NewClientBtn";
            this.NewClientBtn.Size = new System.Drawing.Size(121, 23);
            this.NewClientBtn.TabIndex = 14;
            this.NewClientBtn.Text = "Новый клиент";
            this.NewClientBtn.UseVisualStyleBackColor = false;
            this.NewClientBtn.Click += new System.EventHandler(this.NewClientBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(157, 475);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(121, 23);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(306, 475);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(121, 23);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ViewLb
            // 
            this.ViewLb.AutoSize = true;
            this.ViewLb.Location = new System.Drawing.Point(1116, 480);
            this.ViewLb.Name = "ViewLb";
            this.ViewLb.Size = new System.Drawing.Size(23, 13);
            this.ViewLb.TabIndex = 17;
            this.ViewLb.Text = "null";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 501);
            this.Controls.Add(this.ViewLb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.NewClientBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.SexCB);
            this.Controls.Add(this.SexLb);
            this.Controls.Add(this.LohoPb);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.ViewCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VisitBtn);
            this.Controls.Add(this.ClientDG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Language";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LohoPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientDG;
        private System.Windows.Forms.Button VisitBtn;
        private System.Windows.Forms.Label LFPlb;
        private System.Windows.Forms.TextBox FLPtb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label EmailLb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label PhoneLb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.ComboBox ViewCB;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.PictureBox LohoPb;
        private System.Windows.Forms.Label SexLb;
        private System.Windows.Forms.ComboBox SexCB;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button NewClientBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label ViewLb;
        private LanguageDataSet languageDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private LanguageDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

