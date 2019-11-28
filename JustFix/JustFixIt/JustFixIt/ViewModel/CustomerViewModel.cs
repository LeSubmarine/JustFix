using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel.Store;
using NoteMVVM;

namespace JustFixIt.ViewModel
{
    class CustomerViewModel
    {
        public ICommand BackCommand { get; set; }
        public CustomerViewModel()
        {
            BackCommand = new RelayCommand(Back);
        }

        public void Back()
        {
            
        }
    }
}
