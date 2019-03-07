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

        public clsCustomer mThisCustomer { get; set; }
        private List<clsCustomer> mAllCustomers;

        public bool Delete(int customerId)
        {
            return true;
        }

        public int Count
        {
            get
            {
                return mAllCustomers.Count;
            }
        }
        
        public List<clsCustomer> customerList
        {
            get
            {
                return mAllCustomers;
            }
            set
            {
                mAllCustomers = value;
            }
        }
        
        public int Add()
        {
            /*
            clsDataConnection dataConnect = new clsDataConnection();

            dataConnect.AddParameter("", );
            dataConnect.AddParameter("",);
            dataConnect.AddParameter("",);
            dataConnect.AddParameter("",);
            dataConnect.AddParameter("",);
            dataConnect.AddParameter("",);
            dataConnect.AddParameter("",);
            dataConnect.AddParameter("",);
            return true
            */
            return 1;
        }

        public void Update()
        {

        }

    }
}
