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
        private SecureString _password;

        //this to another class and bind from viewModel, since we're (I'm alone) using Stylet
        //but do it later
        public string LoginStatus { get; set; } = "Login Status";
        public string Username { get; set; }

        public LoginViewModel(ILoginController loginController, IEventAggregator eventAggregator) {
            _loginController = loginController;

            eventAggregator.Subscribe(this);
        }

        public void Login() {

            Debug.WriteLine("Loging in");

            if (_password != null) {

                var loginData = new LoginDataModel(_password, Username);

                bool loginSuccessfull = _loginController.CheckLogin(loginData);
                _password.Clear();

                if (loginSuccessfull) {
                    LoginStatus = (_loginController.GetUser(loginData.Username)).Username;
                }

            }
        }

        //retrieving the password
        public void Handle(PasswordChangedEvent message) {
            _password = message.Password;
        }
    }
}
