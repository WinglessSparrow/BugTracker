using BugTracker.Library.Models;
using BugTracker.Model.BusinessLogic.Controllers;
using BugTracker.UI.Events;
using Stylet;
using System;
using System.Diagnostics;
using System.Security;
using System.Windows;
using System.Windows.Controls;

namespace BugTracker.UI.ViewModels {
    public class LoginViewModel : Screen, IHandle<PasswordChangedEvent> {

        private ILoginController _loginController;

        //this to another class and bind from viewModel, since we're (I'm alone) using Stylet
        //but do it later
        public string LoginStatus { get; set; } = "Login Status";
        public string Username { get; set; }
        public SecureString Password { get; private set; }


        public LoginViewModel(ILoginController loginController, IEventAggregator eventAggregator) {
            _loginController = loginController;

            eventAggregator.Subscribe(this);
        }

        public void Login() {



            bool loginSuccessfull = _loginController.CheckLogin(null);
            if (loginSuccessfull) {
                _loginController.GetUser(null);
            }
        }

        //retrieving the password
        public void Handle(PasswordChangedEvent message) {
            Password = message.Password;
            message.Dispose();
        }
    }
}
