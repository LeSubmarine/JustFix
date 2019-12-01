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
        }


    }
}
