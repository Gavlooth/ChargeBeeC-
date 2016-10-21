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
    public class ChargeBeeFetchData
    {
        private Dictionary<string, string> customerList = new Dictionary<string, string>();
        private ListResult result = null;


        public Dictionary<string, string>CustomerList
         {
             get { return this.customerList; }
         }
        public ListResult Data
        {
          get  { return this.result; }
        }


        public ChargeBeeFetchData(string site, string apiKey)
        {
            if (site == null || apiKey == null)
                throw new ArgumentNullException("Please provide the site name AND the api key");
 
            try
            {
                ApiConfig.Configure(site, apiKey);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Failed for reason: ");

            }


        }

        public void GetClientInfo()
        {


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
                MessageBox.Show("Failed for reason: ", ex.Message );

            }

            try

            {
                
                foreach (ListResult.Entry entry in result.List)
                {

                    if (entry.Customer.LastName == null || entry.Customer.FirstName == null)
                        MessageBox.Show("it is iempty");
                    else
                    customerList.Add(entry.Customer.Id, entry.Customer.LastName + ", " + entry.Customer.FirstName);
                   

                }

             }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "error: ");
            }

            
        }


    }




}

