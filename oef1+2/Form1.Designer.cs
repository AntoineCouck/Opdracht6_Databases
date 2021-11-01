namespace Oef1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label aandeelIdLabel;
            System.Windows.Forms.Label symboolLabel;
            System.Windows.Forms.Label naamLabel;
            this.aandelenBeheerDataSet = new Oef1.AandelenBeheerDataSet();
            this.aandeelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aandeelTableAdapter = new Oef1.AandelenBeheerDataSetTableAdapters.AandeelTableAdapter();
            this.tableAdapterManager = new Oef1.AandelenBeheerDataSetTableAdapters.TableAdapterManager();
            this.aandeelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aandeelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aandeelIdTextBox = new System.Windows.Forms.TextBox();
            this.symboolTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.transactiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactiesTableAdapter = new Oef1.AandelenBeheerDataSetTableAdapters.TransactiesTableAdapter();
            this.transactiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aandeelIdLabel = new System.Windows.Forms.Label();
            symboolLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBeheerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandeelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandeelBindingNavigator)).BeginInit();
            this.aandeelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aandelenBeheerDataSet
            // 
            this.aandelenBeheerDataSet.DataSetName = "AandelenBeheerDataSet";
            this.aandelenBeheerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aandeelBindingSource
            // 
            this.aandeelBindingSource.DataMember = "Aandeel";
            this.aandeelBindingSource.DataSource = this.aandelenBeheerDataSet;
            // 
            // aandeelTableAdapter
            // 
            this.aandeelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AandeelTableAdapter = this.aandeelTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RSSTableAdapter = null;
            this.tableAdapterManager.TransactiesTableAdapter = this.transactiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Oef1.AandelenBeheerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aandeelBindingNavigator
            // 
            this.aandeelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aandeelBindingNavigator.BindingSource = this.aandeelBindingSource;
            this.aandeelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aandeelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aandeelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aandeelBindingNavigatorSaveItem});
            this.aandeelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aandeelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aandeelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aandeelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aandeelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aandeelBindingNavigator.Name = "aandeelBindingNavigator";
            this.aandeelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aandeelBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.aandeelBindingNavigator.TabIndex = 0;
            this.aandeelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // aandeelBindingNavigatorSaveItem
            // 
            this.aandeelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aandeelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aandeelBindingNavigatorSaveItem.Image")));
            this.aandeelBindingNavigatorSaveItem.Name = "aandeelBindingNavigatorSaveItem";
            this.aandeelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aandeelBindingNavigatorSaveItem.Text = "Save Data";
            this.aandeelBindingNavigatorSaveItem.Click += new System.EventHandler(this.aandeelBindingNavigatorSaveItem_Click_1);
            // 
            // aandeelIdLabel
            // 
            aandeelIdLabel.AutoSize = true;
            aandeelIdLabel.Location = new System.Drawing.Point(40, 164);
            aandeelIdLabel.Name = "aandeelIdLabel";
            aandeelIdLabel.Size = new System.Drawing.Size(61, 13);
            aandeelIdLabel.TabIndex = 1;
            aandeelIdLabel.Text = "Aandeel Id:";
            // 
            // aandeelIdTextBox
            // 
            this.aandeelIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aandeelBindingSource, "AandeelId", true));
            this.aandeelIdTextBox.Location = new System.Drawing.Point(107, 161);
            this.aandeelIdTextBox.Name = "aandeelIdTextBox";
            this.aandeelIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.aandeelIdTextBox.TabIndex = 2;
            // 
            // symboolLabel
            // 
            symboolLabel.AutoSize = true;
            symboolLabel.Location = new System.Drawing.Point(40, 190);
            symboolLabel.Name = "symboolLabel";
            symboolLabel.Size = new System.Drawing.Size(50, 13);
            symboolLabel.TabIndex = 3;
            symboolLabel.Text = "Symbool:";
            // 
            // symboolTextBox
            // 
            this.symboolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aandeelBindingSource, "Symbool", true));
            this.symboolTextBox.Location = new System.Drawing.Point(107, 187);
            this.symboolTextBox.Name = "symboolTextBox";
            this.symboolTextBox.Size = new System.Drawing.Size(100, 20);
            this.symboolTextBox.TabIndex = 4;
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(40, 216);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(38, 13);
            naamLabel.TabIndex = 5;
            naamLabel.Text = "Naam:";
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aandeelBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(107, 213);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(100, 20);
            this.naamTextBox.TabIndex = 6;
            // 
            // transactiesBindingSource
            // 
            this.transactiesBindingSource.DataMember = "FK_AandeelId";
            this.transactiesBindingSource.DataSource = this.aandeelBindingSource;
            // 
            // transactiesTableAdapter
            // 
            this.transactiesTableAdapter.ClearBeforeFill = true;
            // 
            // transactiesDataGridView
            // 
            this.transactiesDataGridView.AutoGenerateColumns = false;
            this.transactiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.transactiesDataGridView.DataSource = this.transactiesBindingSource;
            this.transactiesDataGridView.Location = new System.Drawing.Point(323, 115);
            this.transactiesDataGridView.Name = "transactiesDataGridView";
            this.transactiesDataGridView.Size = new System.Drawing.Size(453, 220);
            this.transactiesDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AandeelId";
            this.dataGridViewTextBoxColumn1.HeaderText = "AandeelId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AantalGekocht";
            this.dataGridViewTextBoxColumn2.HeaderText = "AantalGekocht";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Koers";
            this.dataGridViewTextBoxColumn3.HeaderText = "Koers";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TransactieDatum";
            this.dataGridViewTextBoxColumn4.HeaderText = "TransactieDatum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.transactiesDataGridView);
            this.Controls.Add(aandeelIdLabel);
            this.Controls.Add(this.aandeelIdTextBox);
            this.Controls.Add(symboolLabel);
            this.Controls.Add(this.symboolTextBox);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.aandeelBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBeheerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandeelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandeelBindingNavigator)).EndInit();
            this.aandeelBindingNavigator.ResumeLayout(false);
            this.aandeelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AandelenBeheerDataSet aandelenBeheerDataSet;
        private System.Windows.Forms.BindingSource aandeelBindingSource;
        private AandelenBeheerDataSetTableAdapters.AandeelTableAdapter aandeelTableAdapter;
        private AandelenBeheerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aandeelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aandeelBindingNavigatorSaveItem;
        private AandelenBeheerDataSetTableAdapters.TransactiesTableAdapter transactiesTableAdapter;
        private System.Windows.Forms.TextBox aandeelIdTextBox;
        private System.Windows.Forms.TextBox symboolTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.BindingSource transactiesBindingSource;
        private System.Windows.Forms.DataGridView transactiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

