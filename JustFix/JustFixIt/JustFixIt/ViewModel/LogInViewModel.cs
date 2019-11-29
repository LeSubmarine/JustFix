﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NoteMVVM;

namespace JustFixIt.ViewModel
{
    class LogInViewModel
    {
        #region Properties
        public string LogInName { get; set; }
        public string Password { get; set; }
        public ICommand LogInCommand { get; set; }
        #endregion


        #region Constructor
        public LogInViewModel()
        {
            LogInCommand = new RelayCommand(LogUserIn);
        }
        #endregion


        #region Methods
        public void LogUserIn()
        {
            for (int i = 0; i < MainViewModel.AllUsers.Count; i++)
            {
                if (MainViewModel.AllUsers[i].Name == LogInName)
                {
                    if (MainViewModel.AllUsers[i].Password == Password)
                    {
                        MainViewModel.ActiveUser = MainViewModel.AllUsers[i];
                        //Navigation
                    }
                }
            }
        } 
        #endregion
    }
}