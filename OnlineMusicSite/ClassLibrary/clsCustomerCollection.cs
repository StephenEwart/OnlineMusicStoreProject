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

        private clsCustomer mThisCustomer;
        private List<clsCustomer> mAllCustomers;

        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

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
            set
            {

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
            clsDataConnection dataConnect = new clsDataConnection();
            
            dataConnect.AddParameter("@customerName", mThisCustomer.mCustomerName);
            dataConnect.AddParameter("@username", mThisCustomer.mUsername);
            dataConnect.AddParameter("@email", mThisCustomer.mEmail);
            dataConnect.AddParameter("@password", mThisCustomer.mPassword);
            dataConnect.AddParameter("@phoneNo", mThisCustomer.mPhoneNo);
            dataConnect.AddParameter("@cardDetails", mThisCustomer.mCardDetails);
            dataConnect.AddParameter("@address", mThisCustomer.mAddress);

            return dataConnect.Execute("sproc_tblCustomer_AddCustomer");

        }

        public void Update()
        {
            clsDataConnection dataConnect = new clsDataConnection();

            dataConnect.AddParameter("@customerId", mThisCustomer.mCustomerId);
            dataConnect.AddParameter("@customerName", mThisCustomer.mCustomerName);
            dataConnect.AddParameter("@username", mThisCustomer.mUsername);
            dataConnect.AddParameter("@email", mThisCustomer.mEmail);
            dataConnect.AddParameter("@phoneNo", mThisCustomer.mPhoneNo);
            dataConnect.AddParameter("@cardDetails", mThisCustomer.mCardDetails);
            dataConnect.AddParameter("@address", mThisCustomer.mAddress);

            dataConnect.Execute("sproc_tblCustomer_UpdateCustomer");
        }

    }
}
