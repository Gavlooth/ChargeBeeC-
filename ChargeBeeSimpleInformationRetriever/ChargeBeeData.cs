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
        private Dictionary<string, string> customerList = new Dictionary<string, string>();

       public Dictionary<string, string>CustomerList
         {
             get { return this.customerList; }
         }


        public ChargeBeeData(string site, string apiKey)
        {
            if (site == null || apiKey == null)
                throw new ArgumentNullException("Please provide the site name AND the api key");
 
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
            catch (InvalidRequestException)
            {
                MessageBox.Show("There was made and invalid request to recieve data. Failing...", "InvalidRequestException");


            }
            catch (OperationFailedException)
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

                    if (entry.Customer.LastName == null || entry.Customer.FirstName == null)
                        MessageBox.Show("it is iempty");
                    else
                    customerList.Add(entry.Customer.Id, entry.Customer.LastName + ", " + entry.Customer.FirstName);
                   
                    //MessageBox.Show(JsonConvert.SerializeObject(entry));

                }

             }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "error: ");
            }

            
        }


    }




}

