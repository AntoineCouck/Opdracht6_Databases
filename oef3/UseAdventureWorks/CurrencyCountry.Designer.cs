namespace UseAdventureWorks
{
    partial class CurrencyCountry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adventureWorks2016CTP3DataSet = new UseAdventureWorks.AdventureWorks2016CTP3DataSet();
            this.countryRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryRegionTableAdapter = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter();
            this.tableAdapterManager = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager();
            this.countryRegionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countryRegionCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryRegionCurrencyTableAdapter = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionCurrencyTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adventureWorks2016CTP3DataSet
            // 
            this.adventureWorks2016CTP3DataSet.DataSetName = "AdventureWorks2016CTP3DataSet";
            this.adventureWorks2016CTP3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryRegionBindingSource
            // 
            this.countryRegionBindingSource.DataMember = "CountryRegion";
            this.countryRegionBindingSource.DataSource = this.adventureWorks2016CTP3DataSet;
            // 
            // countryRegionTableAdapter
            // 
            this.countryRegionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryRegionCurrencyTableAdapter = null;
            this.tableAdapterManager.CountryRegionTableAdapter = this.countryRegionTableAdapter;
            this.tableAdapterManager.CurrencyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // countryRegionDataGridView
            // 
            this.countryRegionDataGridView.AutoGenerateColumns = false;
            this.countryRegionDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.countryRegionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryRegionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.countryRegionDataGridView.DataSource = this.countryRegionBindingSource;
            this.countryRegionDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.countryRegionDataGridView.Location = new System.Drawing.Point(12, 41);
            this.countryRegionDataGridView.Name = "countryRegionDataGridView";
            this.countryRegionDataGridView.RowHeadersWidth = 51;
            this.countryRegionDataGridView.RowTemplate.Height = 24;
            this.countryRegionDataGridView.Size = new System.Drawing.Size(508, 502);
            this.countryRegionDataGridView.TabIndex = 0;
            this.countryRegionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.countryRegionDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CountryRegionCode";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "CountryRegionCode";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(686, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currency of selected country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a country";
            // 
            // countryRegionCurrencyBindingSource
            // 
            this.countryRegionCurrencyBindingSource.DataMember = "CountryRegionCurrency";
            this.countryRegionCurrencyBindingSource.DataSource = this.adventureWorks2016CTP3DataSet;
            // 
            // countryRegionCurrencyTableAdapter
            // 
            this.countryRegionCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(617, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 404);
            this.listBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrencyCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryRegionDataGridView);
            this.Name = "CurrencyCountry";
            this.Text = "Country";
            this.Load += new System.EventHandler(this.CurrencyCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorks2016CTP3DataSet adventureWorks2016CTP3DataSet;
        private System.Windows.Forms.BindingSource countryRegionBindingSource;
        private AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter countryRegionTableAdapter;
        private AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView countryRegionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource countryRegionCurrencyBindingSource;
        private AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionCurrencyTableAdapter countryRegionCurrencyTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}