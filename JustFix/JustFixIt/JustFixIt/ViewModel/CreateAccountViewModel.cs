using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel.VoiceCommands;
using JustFixIt.Annotations;
using JustFixIt.Model;
using NoteMVVM;

namespace JustFixIt.ViewModel
{
    class CreateAccountViewModel : INotifyPropertyChanged
    {
        #region Instance Field

        private string _name;
        private string _login;
        private string _password;
        private string _email;
        private string _number;

        #endregion


        #region Properties
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged();
            }
        }

        public ICommand CreateAccountCommand { get; set; }

        #endregion


        #region Constructor

        public CreateAccountViewModel()
        {
            CreateAccountCommand = new RelayCommand(CreateAccount);
        }

        #endregion


        #region Methods
        public void CreateAccount()
        {
            bool occupied = false;
            for (int i = 0; i < MainViewModel.AllUsers.Count; i++)
            {
                if (Login == MainViewModel.AllUsers[i].UserName)
                {
                    occupied = true;
                }
            }

            if (!(occupied))
            {
                string id = "42"; //Id skal ikke bare være 42 lmao
                MainViewModel.AllUsers.Add(new CustomerUser(id, Login, Password, Name, Number, Email));
                Name = "";
                Login = "";
                Password = "";
                Email = "";
                Number = "";
                MainViewModel.Save();
            }
        } 
        #endregion


        #region PropertyChangeSupport

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
