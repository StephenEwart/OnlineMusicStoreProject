using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsDataConnection dataConnect;

        public clsCustomer thisCustomer { get; set; }

        public bool Delete(int customerId)
        {
            return true;
        }

        public List<clsCustomer> customerList()
        {
            throw new NotImplementedException();
        }
        /*
        public int Count
        {
            get dataConnect.count;
        }
        */
        public int Add()
        {
            return 2;
        }

        public void Update()
        {

        }

        public void FilterByCustomerName(string customerName)
        {
            dataConnect = new clsDataConnection();
            dataConnect.AddParameter("@customerName", customerName);
            dataConnect.Execute("sproc_tblCustomer_FilterByCustomerName");
        }
    }
}
