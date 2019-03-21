using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestLibrary
{
    [TestClass]
    public class CustomerTest
    {

        /// <summary>
        /// /////////////////////////////////clsCustomer /////////////////////////////////////////////////
        /// ///////////////////////////////// Properties /////////////////////////////////////////////////
        /// </summary>
        public void clsCustomerExists()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //test if exists
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void mUsernameExists()
        {
            string username = "SCREwart";
            clsCustomer customer = new clsCustomer();
            customer.mUsername = username;
            Assert.AreEqual(customer.mUsername, username);
        }

        [TestMethod]
        public void mCustomerNameExists()
        {
            string customerName = "Calum";
            clsCustomer customer = new clsCustomer();
            customer.mCustomerName = customerName;
            Assert.AreEqual(customer.mCustomerName, customerName);
        }

        [TestMethod]
        public void mEmailExists()
        {
            string email = "SCREwart@gmail.com";
            clsCustomer customer = new clsCustomer();
            customer.mEmail = email;
            Assert.AreEqual(customer.mEmail, email);
        }

        [TestMethod]
        public void mPasswordExists()
        {
            string password = "password";
            clsCustomer customer = new clsCustomer();
            customer.mPassword = password;
            Assert.AreEqual(customer.mPassword,  password);
        }

        [TestMethod]
        public void mPhoneNoExists()
        {
            string phoneNo = "069887358357";
            clsCustomer customer = new clsCustomer();
            customer.mPhoneNo = phoneNo;
            Assert.AreEqual(customer.mPhoneNo, phoneNo);
        }

        [TestMethod]
        public void mCardDetailsExists()
        {
            string cardDetails = "069484/3246786768";
            clsCustomer customer = new clsCustomer();
            customer.mCardDetails = cardDetails;
            Assert.AreEqual(customer.mCardDetails, cardDetails);
        }

        [TestMethod]
        public void mAddressExists()
        {
            string address = "10 albions street";
            clsCustomer customer = new clsCustomer();
            customer.mAddress = address;
            Assert.AreEqual(customer.mAddress, address);
        }

        [TestMethod]
        public void mCustomerIdExists()
        {
            int customerId;
            clsCustomer customer = new clsCustomer();
            customerId = customer.mCustomerId;
            Assert.AreEqual(customer.mCustomerId, customerId);
        }

        /////////////////////////////////////////Methods////////////////////////////////////////

        [TestMethod]
        public void InputValidationExists()
        {
            clsCustomer customer = new clsCustomer();
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }
        
        [TestMethod]
        public void FindExists()
        {
            clsCustomer customer = new clsCustomer();
            bool found = false;
            int customerNo = 1;
            found = customer.Find(customerNo);
            Assert.IsNotNull(found);
        }
        


        /////////////////////////////////////// Boundary Testing ////////////////////////////////////
        /// <summary>
        /// /////////////////////////////////// Customer Name /////////////////////////////////////////
        /// </summary>

        [TestMethod]
        public void MinMinusOneCustomerName()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            customerName = "";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);

        }

        [TestMethod]
        public void MinBoundaryCustomerName()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            customerName = "a";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MinPlusOneCustomerName()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            customerName = "AB";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxMinusOneCustomerName()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            customerName = "1234567890123456789012345678901234567890123456789";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxBoundaryCustomerName()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            customerName = "12345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxPlusOneCustomerName()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            customerName = "123456789012345678901234567890123456789012345678901";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void ExtremeMaxCustomerName()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            customerName = "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MidCustomerName()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            customerName = "Stephen Ewart";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        /// <summary>
        /// ////////////////////////////////////////// Username ///////////////////////////////////////////
        /// </summary>

        [TestMethod]
        public void MinMinusOneUsername()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            userName = "";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MinBoundaryUsername()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            userName = "A";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MinPlusOneUsername()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            userName = "AB";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxMinusOneUsername()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            userName = "1234567890123456789012345678901234567890123456789";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxBoundaryUsername()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            userName = "12345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxPlusOneUsername()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            userName = "123456789012345678901234567890123456789012345678901";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void ExtremeMaxUsername()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            userName = "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MidUsername()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            userName = "SCREwart127";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        ////////////////////////////////////////////// Email //////////////////////////////////////

        [TestMethod]
        public void MinMinusOneEmail()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            email = "";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MinBoundaryEmail()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            email = "A";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MinPlusOneEmail()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            email = "AB";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxMinusOneEmail()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            email = "1234567890123456789012345678901234567890123456789";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxBoundaryEmail()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            email = "12345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxPlusOneEmail()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            email = "123456789012345678901234567890123456789012345678901";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void ExtremeMaxEmail()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            email = "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MidEmail()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            email = "SCREwart127@gmail.com";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        /// <summary>
        /// ///////////////////////////////////// Password ///////////////////////////////////////////////
        /// </summary>

        [TestMethod]
        public void MinMinusOnePassword()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            password = "Passwo";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MinBoundaryPassword()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            password = "password";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MinPlusOnePassword()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password1";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            password = "password1";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxMinusOnePassword()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "1234567890123456789012345678901234567890123456789";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            password = "1234567890123456789012345678901234567890123456789";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxBoundaryPassword()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "12345678901234567890123456789012345678901234567890";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            password = "12345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxPlusOnePassword()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "123456789012345678901234567890123456789012345678901";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            password = "123456789012345678901234567890123456789012345678901";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void ExtremeMinPassword()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            password = "";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void ExtremeMaxPassword()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            password = "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MidPassword()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "Password12345";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            password = "Password12345";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        ////////////////////////////////////////// PhoneNo //////////////////////////////////////

        [TestMethod]
        public void MaxMinusOnePhoneNo()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            phoneNo = "12345678901234";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxBoundaryPhoneNo()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            phoneNo = "123456789012345";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxPlusOnePhoneNo()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            phoneNo = "1234567890123456";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void ExtremeMaxPhoneNo()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            phoneNo = "123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MidPhoneNo()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            phoneNo = "1234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        /////////////////////////////////////////// Card Details ////////////////////////////////////////////

        [TestMethod]
        public void MaxMinusOneCardDetails()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            cardDetails = "1234567890123456789012345678901234567890123456789";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxBoundaryCardDetails()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            cardDetails = "12345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxPlusOneCardDetails()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            cardDetails = "123456789012345678901234567890123456789012345678901";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void ExtremeMaxCardDetails()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            cardDetails = "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MidCardDetails()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            cardDetails = "123456/436385763876";
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        /// <summary>
        /// //////////////////////////////////////// Address //////////////////////////////////////////////
        /// </summary>

        [TestMethod]
        public void MaxMinusOneAddress()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            address = "";
            address = address.PadRight(199, 'a');
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxBoundaryAddress()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            address = "";
            address = address.PadRight(200, 'a');
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void MaxPlusOneAddress()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            address = "";
            address = address.PadRight(201, 'a');
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void ExtremeMaxAddress()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            address = "";
            address = address.PadRight(500, 'a');
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreNotEqual(Error, result);
        }

        [TestMethod]
        public void MidAddress()
        {
            // defaults(mid) for the rest of required inputs
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";   string confirmPassword = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";
            //new changed value
            address = "";
            address = address.PadRight(100, 'a');
            clsCustomer customer = new clsCustomer();

            string result = customer.InputValidation(customerName, userName, email, password, confirmPassword,  phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }
    }
}
