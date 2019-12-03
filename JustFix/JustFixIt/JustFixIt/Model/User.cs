using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustFixIt.View;

namespace JustFixIt.Model
{
    //User parent class
    //
    abstract class User
    {
        #region Constants
        public enum PersonTypes
        {
            Admin,
            Customer,
            Mechanic
        }
        #endregion


        #region InstanceField

        #endregion


        #region Properties

        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public PersonTypes PersonType { get; set; }
        #endregion


        #region Constructor
        public User(string id, string userName, string password, string name, string number, string email)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Name = name;
            Email = email;
            Number = number;
        }

        public User()
        {
            
        }
        #endregion


        #region Methods

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}\n{nameof(UserName)}: {UserName}\n{nameof(Password)}: {Password}\n{nameof(Name)}: {Name}\n{nameof(Number)}: {Number}\n{nameof(Email)}: {Email}\n{nameof(PersonType)}: {PersonType}\n\n";
        }

        public System.Type PageNavigation()
        {
            switch (PersonType)
            {
                case PersonTypes.Admin:
                    return typeof(Admin);
                case PersonTypes.Customer:
                    return typeof(Customer);
                case PersonTypes.Mechanic:
                    return typeof(Mechanic);
                default:
                    return typeof(LogIn);
            }
        } 
        #endregion

    }
}
