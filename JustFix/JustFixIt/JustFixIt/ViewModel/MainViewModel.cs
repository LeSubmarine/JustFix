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
        static public List<User> AllUsers { get; set; }
        static public User ActiveUser { get; set; }
        #endregion

        public MainViewModel()
        {

        }

    }
}
