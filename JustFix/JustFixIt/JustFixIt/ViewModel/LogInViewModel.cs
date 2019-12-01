using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using JustFixIt.Annotations;
using JustFixIt.Model;
using JustFixIt.View;
using NoteMVVM;

namespace JustFixIt.ViewModel
{
    class LogInViewModel : INotifyPropertyChanged
    {
        #region Properties
        public string LogInName { get; set; }
        public string Password { get; set; }
        #endregion


        #region Constructor
        public LogInViewModel()
        {
            LogInName = "Log in";
            Password = "Password";
            MainViewModel.AllUsers.Add(new AdminUser("12","Admin","Admin","sss"));
            MainViewModel.AllUsers.Add(new CustomerUser("13","Customer","Customer","ss"));
            MainViewModel.AllUsers.Add(new MechanicUser("14","Mechanic","Mechanic","sds"));
        }
        #endregion


        #region Methods
        public static void LogUserIn(string LogInName, string Password)
        {
            MainViewModel.NavigationPage = typeof(LogIn);
            for (int i = 0; i < MainViewModel.AllUsers.Count; i++)
            {
                if (MainViewModel.AllUsers[i].UserName== LogInName)
                {
                    if (MainViewModel.AllUsers[i].Password == Password)
                    {
                        MainViewModel.ActiveUser = MainViewModel.AllUsers[i];
                        MainViewModel.NavigationPage = MainViewModel.AllUsers[i].PageNavigation();
                        break;
                    }
                }
            }
        }
        #endregion

        #region Property change support
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
