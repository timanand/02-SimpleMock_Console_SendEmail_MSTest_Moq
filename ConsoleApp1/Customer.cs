using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {

        public bool AddCustomer(MyEmail obj)
        {
         
            // Send Email
            bool rtn = obj.SendEmail(); 
            
            // Some code of ADO.NET will go here that inserts records into SQL Server
            return true;

        }


    }
}
