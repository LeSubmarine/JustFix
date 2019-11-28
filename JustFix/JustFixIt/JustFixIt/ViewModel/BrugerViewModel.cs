using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NoteMVVM;

namespace JustFixIt.ViewModel
{
    class BrugerViewModel
    {
        public ICommand BrugerBack { get; set; }
        public BrugerViewModel()
        {
                BrugerBack = new RelayCommand(Back);
        }

        public void Back()
        {
        }
    }
}
