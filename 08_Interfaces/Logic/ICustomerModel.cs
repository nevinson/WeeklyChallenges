using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Logic
{
    public interface ICustomerModel
    {
        string City { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string StreetAddress { get; set; }
    }
}
