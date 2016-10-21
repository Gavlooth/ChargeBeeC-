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
            string name = "dummy-test",
                   apiKey = "test_CAoGvnUyYyRVr09uj2NUhZm0l6YQewm0";
            ChargeBeeData MyBee = new ChargeBeeData(name, apiKey);
            MyBee.GetClientInfo();
            CustomerList.DataSource = new BindingSource(MyBee.CustomerList,null) ;
            CustomerList.DisplayMember = "Value";
            CustomerList.ValueMember = "Key";






        }
    }
}
