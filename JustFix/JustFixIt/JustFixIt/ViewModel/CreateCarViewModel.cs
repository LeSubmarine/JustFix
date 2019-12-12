using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Text;
using JustFixIt.Annotations;
using JustFixIt.Model;

namespace JustFixIt.ViewModel
{
    class CreateCarViewModel : INotifyPropertyChanged
    {
        private int _carYear;
        private string _licensePlate;

        public int CarYear
        {
            get => _carYear;
            set
            {
                _carYear = value;
                OnPropertyChanged();
            }
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                _licensePlate = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> CarTypes { get; set; }

        public CreateCarViewModel()
        {
            CarTypes = new ObservableCollection<string>(Car.CarTypesString);
        }


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
