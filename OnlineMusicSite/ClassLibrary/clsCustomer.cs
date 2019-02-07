using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsDataConnection dataConnect;

        public string mUsername { get; set; }
        public string mCustomerName { get; set; }
        public string mEmail { get; set; }
        public string mPassword { get; set; }
        public string mPhoneNo { get; set; }
        public string mAddress { get; set; }
        public string mCardDetails { get; set; }
        public int mCustomerId { get; }

        public string InputValidation(string customerName, string userName, string email, string password, string phoneNo, string cardDetails, string address)
        {
            //var to store any error messages
            string error = "";
            /*
            if (customerName.Length > 50)
            {
                error = error + "name is too long";
            }
            if (customerName == "")
            {
                error = error + "no name entered";
            }

    */
            //if the customers name is longer than  


            return error;
        }
    }
}
