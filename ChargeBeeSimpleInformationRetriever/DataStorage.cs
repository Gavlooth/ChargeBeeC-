using ChargeBee.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ChargeBeeSimpleInformationRetriever
{
    public class DataStorage
    {
        private ListResult data = null;

        public ListResult GetData
        {

            set { this.data = value; }
        }



        public void SaveDataToJSON()
        {
            try
            {
                if (data != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML-File | *.xml";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(data.List));

                     }

                }
                else
                {
                    MessageBox.Show("You must load valid data first !!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Something went terribly wrong");

            }


        }




        public void SaveDataToXml()
        {
            try
            {
                if (data != null)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc = JsonConvert.DeserializeXmlNode("{\"Data\":" + JsonConvert.SerializeObject(data.List) +"}", "ChargeBee");
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML-File | *.xml";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        xmlDoc.Save(saveFileDialog.FileName);
                    }

                }
                else
                {
                    MessageBox.Show("You must load valid data first !!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Something went terribly wrong");

            }

        }


    public void XmlSaveListItemToFile(string id)
        {
            try
            {
                if (data != null)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    var record = data.List.Find(item => item.Customer.Id == id);
                    string output = JsonConvert.SerializeObject(record);
                    xmlDoc = JsonConvert.DeserializeXmlNode(output, "ChargeBee");

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML-File | *.xml";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        xmlDoc.Save(saveFileDialog.FileName);
                    }
                }
                else { MessageBox.Show("You must download some data first!!"); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  

        }
    }
}
