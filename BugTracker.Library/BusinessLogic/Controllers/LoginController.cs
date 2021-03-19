

using BugTracker.Model.BusinessLogic;
using BugTracker.Model.BusinessLogic.Controllers;
using BugTracker.Model.Models;
using BugTracker.UI.Models;
using System;

namespace BugTracker.Library.BusinessLogic.Controllers {
    public class LoginController : ILoginController {

        private IBusinessLogic _businessLogic;

        public LoginController(IBusinessLogic businessLogic) {
            _businessLogic = businessLogic;
        }

        public bool CheckLogin(LoginDataModel loginData) {
            Console.WriteLine("LOGIN DATA");
            return true;
        }

        public UserModel GetUser(LoginDataModel loginData) {
            Console.WriteLine("GETING USER");
            return null;
        }
    }
}
