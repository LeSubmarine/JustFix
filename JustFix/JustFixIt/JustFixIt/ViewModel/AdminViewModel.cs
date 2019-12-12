using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using JustFixIt.Annotations;
using JustFixIt.Model;

namespace JustFixIt.ViewModel
{
    class AdminViewModel : INotifyPropertyChanged
    {
        //Skal kunne adde en task, til Week.Weektable
        //Skal kunne remove en task, fra Week.Weektable
        //
        #region Instance field

        private User _selectedUser;
        private string _pickedUser;

        #endregion


        #region Constructor

        public AdminViewModel()
        {
            Users = new ObservableCollection<User>(MainViewModel.AllUsers);
        }

        #endregion


        #region Property

        public ObservableCollection<User> Users { get; set; }

        public string PickedUser
        {
            get => _pickedUser;
            set
            {
                _pickedUser = value;
                OnPropertyChanged();
            }
        }

        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
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
