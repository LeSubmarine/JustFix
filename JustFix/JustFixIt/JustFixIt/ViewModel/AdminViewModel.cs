using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustFixIt.Model;

namespace JustFixIt.ViewModel
{
    class AdminViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public AdminViewModel()
        {
            Users = new ObservableCollection<User>(MainViewModel.AllUsers);
        }
    }
}
