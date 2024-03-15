using System;

namespace MyConsoleApp
{
    public class Customer
    {
        private int cust_id;
        private string cust_name;
        // property for cust_id 
        public int MyID
        {
            get { return cust_id; }
            set { cust_id = value; }
        }
        public string MyName
        {
            get { return cust_name; }
            set { cust_name = value; }
        }

        public void setDetails(int id,string name)
        {
            cust_id = id;
            cust_name = name;
        }
        public void getDetails()
        {
            Console.Write("\nCustomer ID={0}",cust_id);
            Console.Write("\nCustomer ID={0}", cust_name);
        }
    }
}
