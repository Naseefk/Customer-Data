using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Data
{
    class CommonCode
    {
        public bool checkValidation(string CustomerName)
        {
            if (CustomerName.Length == 0)
            {
                return false;
            }else
            {
                return true;
            }
            
        }
    }
}
