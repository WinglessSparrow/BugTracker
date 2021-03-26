using BugTracker.Library.Models;
using BugTracker.Model.BusinessLogic.Controllers;
using Stylet;
using System;
using System.Security;
using System.Windows.Controls;
using System.Windows.Input;

namespace BugTracker.UI.ViewModels {
    public class LoginViewModel : PropertyChangedBase {

        private readonly ILoginController _loginController;
        private SecureString _password;

        //this to another class and bind from viewModel, since we're (I'm alone) using Stylet
        //but do it later
        private string _loginStatus;
        public string LoginStatus {
            get { return _loginStatus; }
            set {
                SetAndNotify(ref _loginStatus, value);
                this.NotifyOfPropertyChange(nameof(this.LoginStatus));
            }
        }
        public string Username { get; set; }

        public LoginViewModel(ILoginController loginController) {
            _loginController = loginController;
            LoginStatus = "Login Status";
        }

        public void Login() {

            if (_password != null) {

                var loginData = new LoginDataModel(_password, Username);

                bool loginSuccessfull = _loginController.CheckLogin(loginData);
                _password.Clear();

                if (loginSuccessfull) {
                    var lVar = _loginController.GetUser(loginData.Username);
                    LoginStatus = lVar.Username;
                } else {
                    LoginStatus = "Login Failed";
                }
            }
        }

        public void ChangePasswordEvent(object sender, EventArgs e) {
            _password = ((PasswordBox)sender).SecurePassword;
        }
    }
}
