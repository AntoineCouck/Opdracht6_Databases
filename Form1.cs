using System.Windows.Forms;

namespace Oef1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aandeelBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.aandeelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aandelenBeheerDataSet);

        }

        private void aandeelBindingNavigatorSaveItem_Click_1(object sender, System.EventArgs e)
        {
            this.Validate();
            this.aandeelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aandelenBeheerDataSet);

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'aandelenBeheerDataSet.Transacties' table. You can move, or remove it, as needed.
            this.transactiesTableAdapter.Fill(this.aandelenBeheerDataSet.Transacties);
            // TODO: This line of code loads data into the 'aandelenBeheerDataSet.Aandeel' table. You can move, or remove it, as needed.
            this.aandeelTableAdapter.Fill(this.aandelenBeheerDataSet.Aandeel);

        }
    }
}
