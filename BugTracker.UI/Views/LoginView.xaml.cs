﻿using BugTracker.UI.Events;
using Stylet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BugTracker.UI.Views {
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window {

        private IEventAggregator _eventAggregator;
        public LoginView(IEventAggregator eventAggregator) {
            InitializeComponent();
            _eventAggregator = eventAggregator;
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e) {

            //store it in clear text, since I don't really care about the password
            //since it's beign compared against the hash
            _eventAggregator.Publish(new PasswordChangedEvent(((PasswordBox)sender).SecurePassword));
        }
    }
}
