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
        }
        #endregion


        #region Methods
        public static void LogUserIn(string logInName, string password)
        {
            MainViewModel.NavigationPage = typeof(LogIn);
            for (int i = 0; i < MainViewModel.AllUsers.Count; i++)
            {
                if (MainViewModel.AllUsers[i].UserName == logInName)
                {
                    if (MainViewModel.AllUsers[i].Password == password)
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
