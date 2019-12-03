using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustFixIt.Model;

namespace JustFixIt.ViewModel
{
    class MainViewModel
    {
        #region Constructor
        public MainViewModel()
        {
            NavigationPage = typeof(MainPage);
            MainViewModel.AllUsers.Add(new AdminUser("13", "Admin", "Admin", "sss", "11122233", "Xd@Lmao.dk"));
            MainViewModel.AllUsers.Add(new CustomerUser("14", "Customer", "Customer", "ss", "11122234", "Eyyy@yoyo.dk"));
            MainViewModel.AllUsers.Add(new MechanicUser("15", "Mechanic", "Mechanic", "sds", "11122235", "gfto@IDontNeedNoDocumentationLmao.Ik'LæsMinKodeYo"));
            MainViewModel.AllUsers.Add(new CustomerUser("16", "Test", "Test", "sdds", "11122236", "asd@asdd.dk"));
        }
        #endregion


        #region Properties
        public static List<User> AllUsers { get; set; } = new List<User>();
        public static User ActiveUser { get; set; }
        public static System.Type NavigationPage { get; set; }
        #endregion


        #region Methods

        public static void Save()
        {

        }

        public static void Load()
        {

        }
        #endregion
    }
}
