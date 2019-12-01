using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model
{
    class CustomerUser: User
    {
        public CustomerUser(string id, string userName, string password, string name) : base(id, userName, password, name)
        {
            PersonType = PersonTypes.Customer;
        }
    }
}
