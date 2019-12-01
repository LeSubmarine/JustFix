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

        #region Properties
        public static List<User> AllUsers { get; set; } = new List<User>();
        public static User ActiveUser { get; set; } 
        public static System.Type NavigationPage { get; set; }
        #endregion

        public MainViewModel()
        {
            NavigationPage = typeof(MainPage);
            MainViewModel.AllUsers.Add(new AdminUser("13", "Admin", "Admin", "sss", "11122233", "Xd@Lmao.dk"));
            MainViewModel.AllUsers.Add(new CustomerUser("14", "Customer", "Customer", "ss", "11122234", "Eyyy@yoyo.dk"));
            MainViewModel.AllUsers.Add(new MechanicUser("15", "Mechanic", "Mechanic", "sds", "11122235", "gfto@IDontNeedNoDocumentationLmao.Ik'LæsMinKodeYo"));
        }


    }
}
