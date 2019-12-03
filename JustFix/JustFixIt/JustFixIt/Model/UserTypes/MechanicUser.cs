﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFixIt.Model
{
    class MechanicUser : User
    {
        public MechanicUser(string id, string userName, string password, string name, string number, string email) : base(id, userName, password, name, number, email)
        {
            PersonType = PersonTypes.Mechanic;
        }

        public MechanicUser()
        {
            
        }
    }
}
