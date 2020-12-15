
namespace SQL_shit
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_BOOKSDataSet = new SQL_shit.DB_BOOKSDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeauthorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepublishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.codedeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.codepublishDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishinghouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.codepurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codebookDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codedeliveryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typepurchaseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new SQL_shit.DB_BOOKSDataSetTableAdapters.AuthorsTableAdapter();
            this.booksTableAdapter = new SQL_shit.DB_BOOKSDataSetTableAdapters.BooksTableAdapter();
            this.deliveriesTableAdapter = new SQL_shit.DB_BOOKSDataSetTableAdapters.DeliveriesTableAdapter();
            this.publishing_houseTableAdapter = new SQL_shit.DB_BOOKSDataSetTableAdapters.Publishing_houseTableAdapter();
            this.purchasesTableAdapter = new SQL_shit.DB_BOOKSDataSetTableAdapters.PurchasesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_BOOKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishinghouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeauthorDataGridViewTextBoxColumn,
            this.nameauthorDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(853, 117);
            this.dataGridView1.TabIndex = 0;
            // 
            // codeauthorDataGridViewTextBoxColumn
            // 
            this.codeauthorDataGridViewTextBoxColumn.DataPropertyName = "Code_author";
            this.codeauthorDataGridViewTextBoxColumn.HeaderText = "Code_author";
            this.codeauthorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeauthorDataGridViewTextBoxColumn.Name = "codeauthorDataGridViewTextBoxColumn";
            this.codeauthorDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameauthorDataGridViewTextBoxColumn
            // 
            this.nameauthorDataGridViewTextBoxColumn.DataPropertyName = "name_author";
            this.nameauthorDataGridViewTextBoxColumn.HeaderText = "name_author";
            this.nameauthorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameauthorDataGridViewTextBoxColumn.Name = "nameauthorDataGridViewTextBoxColumn";
            this.nameauthorDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.dB_BOOKSDataSet;
            // 
            // dB_BOOKSDataSet
            // 
            this.dB_BOOKSDataSet.DataSetName = "DB_BOOKSDataSet";
            this.dB_BOOKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codebookDataGridViewTextBoxColumn,
            this.titlebookDataGridViewTextBoxColumn,
            this.codeauthorDataGridViewTextBoxColumn1,
            this.pagesDataGridViewTextBoxColumn,
            this.codepublishDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.booksBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(980, 96);
            this.dataGridView2.TabIndex = 1;
            // 
            // codebookDataGridViewTextBoxColumn
            // 
            this.codebookDataGridViewTextBoxColumn.DataPropertyName = "Code_book";
            this.codebookDataGridViewTextBoxColumn.HeaderText = "Code_book";
            this.codebookDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codebookDataGridViewTextBoxColumn.Name = "codebookDataGridViewTextBoxColumn";
            this.codebookDataGridViewTextBoxColumn.Width = 150;
            // 
            // titlebookDataGridViewTextBoxColumn
            // 
            this.titlebookDataGridViewTextBoxColumn.DataPropertyName = "Title_book";
            this.titlebookDataGridViewTextBoxColumn.HeaderText = "Title_book";
            this.titlebookDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titlebookDataGridViewTextBoxColumn.Name = "titlebookDataGridViewTextBoxColumn";
            this.titlebookDataGridViewTextBoxColumn.Width = 150;
            // 
            // codeauthorDataGridViewTextBoxColumn1
            // 
            this.codeauthorDataGridViewTextBoxColumn1.DataPropertyName = "Code_author";
            this.codeauthorDataGridViewTextBoxColumn1.HeaderText = "Code_author";
            this.codeauthorDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.codeauthorDataGridViewTextBoxColumn1.Name = "codeauthorDataGridViewTextBoxColumn1";
            this.codeauthorDataGridViewTextBoxColumn1.Width = 150;
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            this.pagesDataGridViewTextBoxColumn.Width = 150;
            // 
            // codepublishDataGridViewTextBoxColumn
            // 
            this.codepublishDataGridViewTextBoxColumn.DataPropertyName = "Code_publish";
            this.codepublishDataGridViewTextBoxColumn.HeaderText = "Code_publish";
            this.codepublishDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codepublishDataGridViewTextBoxColumn.Name = "codepublishDataGridViewTextBoxColumn";
            this.codepublishDataGridViewTextBoxColumn.Width = 150;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.dB_BOOKSDataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codedeliveryDataGridViewTextBoxColumn,
            this.namedeliveryDataGridViewTextBoxColumn,
            this.namecompanyDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.deliveriesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 309);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.Size = new System.Drawing.Size(1189, 115);
            this.dataGridView3.TabIndex = 2;
            // 
            // codedeliveryDataGridViewTextBoxColumn
            // 
            this.codedeliveryDataGridViewTextBoxColumn.DataPropertyName = "Code_delivery";
            this.codedeliveryDataGridViewTextBoxColumn.HeaderText = "Code_delivery";
            this.codedeliveryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codedeliveryDataGridViewTextBoxColumn.Name = "codedeliveryDataGridViewTextBoxColumn";
            this.codedeliveryDataGridViewTextBoxColumn.Width = 150;
            // 
            // namedeliveryDataGridViewTextBoxColumn
            // 
            this.namedeliveryDataGridViewTextBoxColumn.DataPropertyName = "Name_delivery";
            this.namedeliveryDataGridViewTextBoxColumn.HeaderText = "Name_delivery";
            this.namedeliveryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namedeliveryDataGridViewTextBoxColumn.Name = "namedeliveryDataGridViewTextBoxColumn";
            this.namedeliveryDataGridViewTextBoxColumn.Width = 150;
            // 
            // namecompanyDataGridViewTextBoxColumn
            // 
            this.namecompanyDataGridViewTextBoxColumn.DataPropertyName = "Name_company";
            this.namecompanyDataGridViewTextBoxColumn.HeaderText = "Name_company";
            this.namecompanyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namecompanyDataGridViewTextBoxColumn.Name = "namecompanyDataGridViewTextBoxColumn";
            this.namecompanyDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            this.iNNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveriesBindingSource
            // 
            this.deliveriesBindingSource.DataMember = "Deliveries";
            this.deliveriesBindingSource.DataSource = this.dB_BOOKSDataSet;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepublishDataGridViewTextBoxColumn1,
            this.publishDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.publishinghouseBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(12, 456);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.Size = new System.Drawing.Size(523, 91);
            this.dataGridView4.TabIndex = 3;
            // 
            // codepublishDataGridViewTextBoxColumn1
            // 
            this.codepublishDataGridViewTextBoxColumn1.DataPropertyName = "Code_publish";
            this.codepublishDataGridViewTextBoxColumn1.HeaderText = "Code_publish";
            this.codepublishDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.codepublishDataGridViewTextBoxColumn1.Name = "codepublishDataGridViewTextBoxColumn1";
            this.codepublishDataGridViewTextBoxColumn1.Width = 150;
            // 
            // publishDataGridViewTextBoxColumn
            // 
            this.publishDataGridViewTextBoxColumn.DataPropertyName = "Publish";
            this.publishDataGridViewTextBoxColumn.HeaderText = "Publish";
            this.publishDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publishDataGridViewTextBoxColumn.Name = "publishDataGridViewTextBoxColumn";
            this.publishDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 150;
            // 
            // publishinghouseBindingSource
            // 
            this.publishinghouseBindingSource.DataMember = "Publishing_house";
            this.publishinghouseBindingSource.DataSource = this.dB_BOOKSDataSet;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepurchaseDataGridViewTextBoxColumn,
            this.codebookDataGridViewTextBoxColumn1,
            this.dateorderDataGridViewTextBoxColumn,
            this.codedeliveryDataGridViewTextBoxColumn1,
            this.typepurchaseDataGridViewCheckBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.purchasesBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(12, 598);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.Size = new System.Drawing.Size(1130, 131);
            this.dataGridView5.TabIndex = 4;
            // 
            // codepurchaseDataGridViewTextBoxColumn
            // 
            this.codepurchaseDataGridViewTextBoxColumn.DataPropertyName = "Code_purchase";
            this.codepurchaseDataGridViewTextBoxColumn.HeaderText = "Code_purchase";
            this.codepurchaseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codepurchaseDataGridViewTextBoxColumn.Name = "codepurchaseDataGridViewTextBoxColumn";
            this.codepurchaseDataGridViewTextBoxColumn.Width = 150;
            // 
            // codebookDataGridViewTextBoxColumn1
            // 
            this.codebookDataGridViewTextBoxColumn1.DataPropertyName = "Code_book";
            this.codebookDataGridViewTextBoxColumn1.HeaderText = "Code_book";
            this.codebookDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.codebookDataGridViewTextBoxColumn1.Name = "codebookDataGridViewTextBoxColumn1";
            this.codebookDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dateorderDataGridViewTextBoxColumn
            // 
            this.dateorderDataGridViewTextBoxColumn.DataPropertyName = "Date_order";
            this.dateorderDataGridViewTextBoxColumn.HeaderText = "Date_order";
            this.dateorderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateorderDataGridViewTextBoxColumn.Name = "dateorderDataGridViewTextBoxColumn";
            this.dateorderDataGridViewTextBoxColumn.Width = 150;
            // 
            // codedeliveryDataGridViewTextBoxColumn1
            // 
            this.codedeliveryDataGridViewTextBoxColumn1.DataPropertyName = "Code_delivery";
            this.codedeliveryDataGridViewTextBoxColumn1.HeaderText = "Code_delivery";
            this.codedeliveryDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.codedeliveryDataGridViewTextBoxColumn1.Name = "codedeliveryDataGridViewTextBoxColumn1";
            this.codedeliveryDataGridViewTextBoxColumn1.Width = 150;
            // 
            // typepurchaseDataGridViewCheckBoxColumn
            // 
            this.typepurchaseDataGridViewCheckBoxColumn.DataPropertyName = "Type_purchase";
            this.typepurchaseDataGridViewCheckBoxColumn.HeaderText = "Type_purchase";
            this.typepurchaseDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.typepurchaseDataGridViewCheckBoxColumn.Name = "typepurchaseDataGridViewCheckBoxColumn";
            this.typepurchaseDataGridViewCheckBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "Purchases";
            this.purchasesBindingSource.DataSource = this.dB_BOOKSDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // deliveriesTableAdapter
            // 
            this.deliveriesTableAdapter.ClearBeforeFill = true;
            // 
            // publishing_houseTableAdapter
            // 
            this.publishing_houseTableAdapter.ClearBeforeFill = true;
            // 
            // purchasesTableAdapter
            // 
            this.purchasesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Авторы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Книги";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Издательства";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поставщики";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Поставки";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Работа с процедурами";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 1050);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_BOOKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishinghouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private DB_BOOKSDataSet dB_BOOKSDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private DB_BOOKSDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private DB_BOOKSDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeauthorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deliveriesBindingSource;
        private DB_BOOKSDataSetTableAdapters.DeliveriesTableAdapter deliveriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource publishinghouseBindingSource;
        private DB_BOOKSDataSetTableAdapters.Publishing_houseTableAdapter publishing_houseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private DB_BOOKSDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepurchaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codebookDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedeliveryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typepurchaseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

