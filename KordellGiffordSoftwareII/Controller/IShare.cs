using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordellGiffordCapstone.Controller
{
    interface IShare
    {
        //Created interface for future modifications across classes based on searches.
        bool SearchDataByCustomer(Customers customers);
    }
}
