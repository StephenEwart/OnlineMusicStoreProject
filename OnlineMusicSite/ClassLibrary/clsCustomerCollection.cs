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

        clsCustomer mThisCustomer = new clsCustomer();

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

        public void Delete(int customerId)
        {
            clsDataConnection dataConnect = new clsDataConnection();
            dataConnect.AddParameter("@customerId", customerId);
            dataConnect.Execute("sproc_tblCustomer_DeleteCustomer");
        }

        public int Count
        {
            get
            {
                return dataConnect.Count;
            }
        }
        
        public List<clsCustomer> CustomerList
        {
            get
            {
                List<clsCustomer> mCustomerList = new List<clsCustomer>();
                int recordCount;
                int index = 0;
                recordCount = dataConnect.Count;

                while (index < recordCount)
                {
                    clsCustomer cust = new clsCustomer();
                    cust.mCustomerId = Convert.ToInt32(dataConnect.DataTable.Rows[index]["CustomerId"]);
                    cust.mCustomerName = Convert.ToString(dataConnect.DataTable.Rows[index]["CustomerName"]);
                    cust.mUsername = Convert.ToString(dataConnect.DataTable.Rows[index]["Username"]);
                    cust.mEmail = Convert.ToString(dataConnect.DataTable.Rows[index]["Email"]);
                    cust.mPassword = Convert.ToString(dataConnect.DataTable.Rows[index]["customerPassword"]);
                    cust.mPhoneNo = Convert.ToString(dataConnect.DataTable.Rows[index]["PhoneNo"]);
                    cust.mCardDetails = Convert.ToString(dataConnect.DataTable.Rows[index]["CardDetails"]);
                    cust.mAddress = Convert.ToString(dataConnect.DataTable.Rows[index]["customerAddress"]);

                    mCustomerList.Add(cust);

                    index++;
                }
                return mCustomerList;
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

        public void FilterByName(string customerName)
        {
            dataConnect = new clsDataConnection();
            dataConnect.AddParameter("@customerName", customerName);
            dataConnect.Execute("sproc_tblCustomer_FilterByName");
        }
    }
}
