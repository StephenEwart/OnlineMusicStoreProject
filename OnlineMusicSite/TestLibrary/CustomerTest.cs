using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestLibrary
{
    [TestClass]
    public class CustomerTest
    {
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
            Assert.AreEqual(customer.mPassword, password);
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

        [TestMethod]
        public void mDataConnectionExists()
        {
            clsDataConnection dataConnect = new clsDataConnection();
            clsCustomer customer = new clsCustomer();
            customer.dataConnect = dataConnect;
            Assert.AreEqual(customer.dataConnect, dataConnect);
        }

        /////////////////////////////////////////Methods////////////////////////////////////////

        [TestMethod]
        public void InputValidationExists()
        {
            clsCustomer customer = new clsCustomer();
            string customerName = "Calum";
            string userName = "SCREwart";
            string email = "screwart127@gmail.com";
            string password = "password";
            string phoneNo = "4896345092734";
            string cardDetails = "3489345/356842328928";
            string address = "10 albion street";
            string Error = "";

            string result = customer.InputValidation(customerName, userName, email, password, phoneNo, cardDetails, address);
            Assert.AreEqual(Error, result);
        }

        [TestMethod]
        public void FindExists()
        {
            clsCustomer customer = new clsCustomer();
        }
    }
}
