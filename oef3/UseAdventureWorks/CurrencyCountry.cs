using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace UseAdventureWorks
{
    public partial class CurrencyCountry : Form
    {

       private static AdventureWorks2016CTP3Entities2 databaseAcces = new AdventureWorks2016CTP3Entities2();
       

        public CurrencyCountry()
        {
            InitializeComponent();

        }

        private void countryRegionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryRegionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorks2016CTP3DataSet);

        }

        private void CurrencyCountry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads lijstVanLanden into the 'adventureWorks2016CTP3DataSet.CountryRegionCurrency' table. You can move, or remove it, as needed.
            this.countryRegionCurrencyTableAdapter.Fill(this.adventureWorks2016CTP3DataSet.CountryRegionCurrency);
            // TODO: This line of code loads lijstVanLanden into the 'adventureWorks2016CTP3DataSet.CountryRegion' table. You can move, or remove it, as needed.
            this.countryRegionTableAdapter.Fill(this.adventureWorks2016CTP3DataSet.CountryRegion);

        }



        private void countryRegionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          


            DataGridView lijstVanLanden = (DataGridView)sender;

            string value = (string)lijstVanLanden.CurrentCell.Value;

            var result = databaseAcces.CountryRegionCurrencies.Join(databaseAcces.CountryRegion, x => x.CountryRegionCode, y => y.CountryRegionCode, (x, y) => new { currency = x, countryregionName = y.Name, countryRegionCode = y.CountryRegionCode })
                                                    .Join(databaseAcces.Currencies, x => x.currency.CurrencyCode, y => y.CurrencyCode, (x, y) => new { currencyCode = x, currencyName = y.Name });



            foreach(var currency in result)
            {
                if (currency.currencyCode.countryregionName.Contains(value) || currency.currencyCode.countryRegionCode.Contains(value))
                {
                   listBox1.Items.Add(currency.currencyCode.countryregionName +" : " + currency.currencyName);
                } 


            }

            // if the country 

            if(listBox1.Items.Count <= 0)
            {
                MessageBox.Show("Er zijn geen currencies voor dit land , try again");
            }

        }


        // clear list with button


        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                listBox1.Items.Clear();
            }
        }
    }
}
            