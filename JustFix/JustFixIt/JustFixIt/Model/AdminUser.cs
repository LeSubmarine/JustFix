using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model
{
    class AdminUser : User
    {
        public AdminUser()
        {
            PersonType = PersonTypes.Admin;
        }
    }
}
