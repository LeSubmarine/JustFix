﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using JustFixIt.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace JustFixIt.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogIn : Page
    {
        public LogIn()
        {
            this.InitializeComponent();
        }

        private void NewAccButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateAccount));
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            LogInViewModel.LogUserIn(this.LogInName.Text,this.Password.Password);
            if (!(MainViewModel.NavigationPage == typeof(LogIn)))
            {
                this.Frame.Navigate(MainViewModel.NavigationPage);
            }
            else
            {
                this.LogInName.Text = "";
                this.Password.Password = "";
            }
        }
    }
}
