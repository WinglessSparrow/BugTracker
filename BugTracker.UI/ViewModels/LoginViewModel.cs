using BugTracker.Model.BusinessLogic.Controllers;
using Stylet;
using System;
using System.Windows.Controls;

namespace BugTracker.UI.ViewModels {
    public class LoginViewModel : Screen {

        private ILoginController _loginController;

        public PasswordBox PasswordBox { get; set; }

        public LoginViewModel(ILoginController loginController) {
            _loginController = loginController;
        }


        public void Login() {
            bool loginSuccessfull = _loginController.CheckLogin(null);
            if (loginSuccessfull) {
                _loginController.GetUser(null);
            }
        }
    }
}
