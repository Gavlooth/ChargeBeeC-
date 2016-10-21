using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChargeBee.Api;
using ChargeBee.Models;

namespace ChargeBeeSimpleInformationRetriever
{
    public partial class DataViewer : Form
    {

        public DataStorage Storage = new DataStorage();
        public DataViewer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // "dummy-test"  "test_CAoGvnUyYyRVr09uj2NUhZm0l6YQewm0"

            string name = this.SiteUrl.Text,
                   apiKey =this.ApiKey.Text ;
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(apiKey))
                {
                MessageBox.Show("Please Provide Valid Site AND Api Key");
            }
            else {
                ChargeBeeFetchData MyBee = new ChargeBeeFetchData(name, apiKey);
                MyBee.GetClientInfo();
                CustomerList.DataSource = new BindingSource(MyBee.CustomerList, null);
                CustomerList.DisplayMember = "Value";
                CustomerList.ValueMember = "Key";
                Storage.GetData = MyBee.Data;
            }

        }

        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            if (this.CustomerList.SelectedIndex != -1)
            {
                KeyValuePair<string, string> tmpVar = (KeyValuePair<string, string>)CustomerList.SelectedItem;
                Storage.XmlSaveListItemToFile(tmpVar.Key) ;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
 
                Storage.SaveDataToXml();
             

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Storage.SaveDataToJSON();
        }
    }
}
