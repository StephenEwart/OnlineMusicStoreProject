using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //instanciate clsDataConnection 
        public clsDataConnection dataConnect;

        //variable setting and getting
        public string mUsername { get; set; }
        public string mCustomerName { get; set; }
        public string mEmail { get; set; }
        public string mPassword { get; set; }
        public string mPhoneNo { get; set; }
        public string mAddress { get; set; }
        public string mCardDetails { get; set; }
        public int mCustomerId { get; set;  }

        public string InputValidation(string customerName, string userName, string email, string password, string confirmPassword, string phoneNo, string cardDetails, string address)
        {
            //var to store amount of error messages
            int errors = 0;
            //var to store a string of all the errors
            string errorOutput = "";
            //check if length of customerName is greater than 50 
            if (customerName.Length > 50)
            {
                errorOutput = errorOutput + "Name is too long" + Environment.NewLine;
                errors = errors + 1;
            }
            //check if customerName is empty
            if (customerName == "")
            {
                errorOutput = errorOutput + "No name entered" + Environment.NewLine;
                errors = errors + 1;
            }
            //userName length is greater than 50
            if (userName.Length > 50)
            {
                errorOutput = errorOutput + "Username is too long" + Environment.NewLine;
                errors = errors + 1;
            }
            //check if userName is empty
            if (userName == "")
            {
                errorOutput = errorOutput + "No userName has been entered" + Environment.NewLine;
                errors = errors + 1;
            }
            //email length is greater than 50
            if (email.Length > 50)
            {
                errorOutput = errorOutput + "Email entered is too long" + Environment.NewLine;
                errors = errors + 1;
            }
            //check if email is empty
            if (email == "")
            {
                errorOutput = errorOutput + "No email has been entered" + Environment.NewLine;
                errors = errors + 1;
            }
            //check if password length is greater than 50
            if (password.Length > 50)
            {
                errorOutput = errorOutput + "Password is too long" + Environment.NewLine;
                errors = errors + 1;
            }
            //check if password is empty
            if (password.Length < 7)
            {
                errorOutput = errorOutput + "No password has been entered" + Environment.NewLine;
                errors = errors = 1;
            }
            //add REGex stuff here for password?




            //check if phoneNo legth is greater than 10
            if (phoneNo.Length > 15)
            {
                errorOutput = errorOutput + "Invalid phone number" + Environment.NewLine;
                errors = errors + 1;
            }
            //if passwords dont match
            if (confirmPassword != password)
            {
                errorOutput = errorOutput + "Passwords do not match" + Environment.NewLine;
                errors = errors + 1;
            }
            //check if cardDetails length is greater than 50
            if (cardDetails.Length > 50)
            {
                errorOutput = errorOutput + "Invalid card details" + Environment.NewLine;
                errors = errors + 1;
            }
            //check if address length is greater than 200
            if (address.Length > 200)
            {
                errorOutput = errorOutput + "Address is too long" + Environment.NewLine;
                errors = errors + 1;
            }

            return errorOutput;

        }

        public Boolean Find(int customerId)
        {
            //create connection
            dataConnect = new clsDataConnection();
            //add customerId as parameter
            dataConnect.AddParameter("@CustomerId", customerId);
            //execute
            dataConnect.Execute("sproc_tblCustomer_FindCustomer");

            if (dataConnect.Count == 1)
            {
                //get Id
                mCustomerId = Convert.ToInt32(dataConnect.DataTable.Rows[0]["CustomerId"]);
                mCustomerName = Convert.ToString(dataConnect.DataTable.Rows[0]["CustomerName"]);
                mUsername = Convert.ToString(dataConnect.DataTable.Rows[0]["Username"]);
                mEmail = Convert.ToString(dataConnect.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(dataConnect.DataTable.Rows[0]["customerPassword"]);
                mPhoneNo = Convert.ToString(dataConnect.DataTable.Rows[0]["PhoneNo"]);
                mCardDetails = Convert.ToString(dataConnect.DataTable.Rows[0]["CardDetails"]);
                mAddress = Convert.ToString(dataConnect.DataTable.Rows[0]["customerAddress"]);

                return true;
            }   
            else
            {
                return false;
            }

        }
    }
}
