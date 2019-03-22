using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestClass]
    public class CustomerCollectionTest
    {

        [TestMethod]
        public void CustomerCollectionExist()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void clsCustomerObjectExists()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            clsCustomer newCustomer = new clsCustomer();
            customer.ThisCustomer = newCustomer;
            Assert.AreEqual(customer.ThisCustomer, newCustomer);
        }
        
        [TestMethod]
        public void DeleteExists()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            int id = 2;
            bool result = customer.Delete(id);
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void UpdateWorks()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();
        }

        /*
        [TestMethod]
        public void ListAndCountWorks()
        {
            clsCustomerCollection collect = new clsCustomerCollection();
            List<clsCustomer> testList = new List<clsCustomer>();
            clsCustomer testITem = new clsCustomer();
            int manualCount = 2;
            Assert.AreEqual(All, manualCount);
        }
        */
        
        [TestMethod]
        public void AddWorks()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            clsCustomer testItem = new clsCustomer();

            int PK = 0;

            testItem.mCustomerName = "Calum";
            testItem.mUsername = "SCREwart";
            testItem.mEmail = "screwart127@gmail.com";
            testItem.mPassword = "password";
            testItem.mPhoneNo = "34566475465";
            testItem.mCardDetails = "3489345/356842328928";
            testItem.mAddress = "10 albion street";

            PK = allCustomers.Add();

            testItem.mCustomerId = PK;

            bool result = allCustomers.ThisCustomer.Find(PK);

            Assert.IsTrue(result);
        }         
    }
}
