using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChargeBee.Api;
using ChargeBee.Models;
using ChargeBee.Exceptions;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ChargeBeeSimpleInformationRetriever
{
    public class ChargeBeeData
    {
        private Dictionary<string, string> customerList = null;
        //  string site;
        //  string apiKey;
        /* string serialize_customer;
         List<string> customerList;
       public List<string> CustomerList
         {
             get { return this.customerList; }
         }*/


        public ChargeBeeData(string site, string apiKey)
        {
            if (site == null || apiKey == null)
                throw new ArgumentNullException("Please provide the site name AND the api key");

            // this.site = site;
            //this.apiKey = apiKey;
            try
            {
                ApiConfig.Configure(site, apiKey);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed for reason: ", ex.Data.Values.ToString());

            }


        }

        public void GetClientInfo()
        {

            ListResult result = null;

            try
            {

                  result = Customer.List().Request();
 


            }
            catch (InvalidRequestException ex)
            {
                MessageBox.Show("There was made and invalid request to recieve data. Failing...", "InvalidRequestException");


            }
            catch (OperationFailedException ex)
            {
                MessageBox.Show("Something went wrong when trying to reicieve data from your account. Failing... (not your fault)", "OperationFailedException");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed for reason: ", ex.Data.Values.ToString());

            }

            try
            {
                foreach (ListResult.Entry entry in result.List)
                {

                    customerList.Add(entry.Customer.Id, entry.Customer.LastName + ", " + entry.Customer.FirstName);
                    MessageBox.Show(JsonConvert.SerializeObject(entry));

                }

                MessageBox.Show("data", skata);
            }
            catch (Exception e)
            {
                MessageBox.Show("error: ", e.Message);

            }


        }


    }




}

