using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практика_ТРЗБД_.Models;


namespace Практика_ТРЗБД_
{
    public class Helper
    {
        private static Bus_CompanyEntities s_firstDBEntities;

        public static Bus_CompanyEntities GetContext()
        {
            if (s_firstDBEntities == null)
            {
                s_firstDBEntities = new Bus_CompanyEntities();
            }
            return s_firstDBEntities;
        }
    }
}
