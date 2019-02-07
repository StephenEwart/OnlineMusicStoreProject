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
            int errors = 0;
            string errorOutput = "";
            if (customerName.Length > 50)
            {
                errorOutput = errorOutput + "Name is too long" + Environment.NewLine;
                errors = errors + 1;
            }
            if (customerName == "")
            {
                errorOutput = errorOutput + "No name entered" + Environment.NewLine;
                errors = errors + 1;
            }
            if (userName.Length > 50)
            {
                errorOutput = errorOutput + "Username is too long" + Environment.NewLine;
                errors = errors + 1;
            }
            if (userName == "")
            {
                errorOutput = errorOutput + "No userName has been entered" + Environment.NewLine;
                errors = errors + 1;
            }
            if (email.Length > 50)
            {
                errorOutput = errorOutput + "Email entered is too long" + Environment.NewLine;
                errors = errors + 1;
            }
            if (email == "")
            {
                errorOutput = errorOutput + "No email has been entered" + Environment.NewLine;
                errors = errors + 1;
            }
            if (password.Length > 50)
            {
                errorOutput = errorOutput + "Password is too long" + Environment.NewLine;
                errors = errors + 1;
            }
            if (password == "")
            {
                errorOutput = errorOutput + "No password has been entered" + Environment.NewLine;
                errors = errors = 1;
            }
            if (phoneNo.Length > 10)
            {
                errorOutput = errorOutput + "Invalid phone number" + Environment.NewLine;
                errors = errors + 1;
            }
            if (cardDetails.Length > 50)
            {
                errorOutput = errorOutput + "Invalid card details" + Environment.NewLine;
                errors = errors + 1;
            }
            if (address.Length > 200)
            {
                errorOutput = errorOutput + "Address is too long" + Environment.NewLine;
                errors = errors + 1;
            }


            //if the customers name is longer than  

            /*
            note to self, add code on user interface that tells user what exactly the errors were
            
            should look like this

            MessageBox.Show("There were ")

            */

            if (errors == 0)
            {
                return errorOutput;
            }
            else
            {
                return string.Format("{0}{1}", errors, errorOutput);
            }
        }
    }
}
