using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestClass]
    public class CustomerCollectionTest
    {
        /*
        [TestMethod]
        public void DataConnectExists()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            Assert.IsNotNull(customer.dataConnect);
        }
        */

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
            customer.thisCustomer = newCustomer;
            Assert.AreEqual(customer.thisCustomer, newCustomer);
        }

        [TestMethod]
        public void DeleteExists()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            int id = 2;
            bool result = customer.Delete(id);
            Assert.AreEqual(result, true);
        }

        /*
        [TestMethod]
        public void CustomerListExists()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            List<clsCustomer> custList = customer.customerList();
            Assert.IsNotNull(custList);
        }

        [TestMethod]
        public void CountExists()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            int dbCount = customer.Count;
            Assert.AreEqual(dbCount, customer.Count);

        }
        */

    }
}
