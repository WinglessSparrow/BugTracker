using BugTracker.Controller.Source.Interfaces;
using BugTracker.Model.Models;
using BugTracker.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.temp {
    class LoginHandler : ILoginHandler {
        public bool ProveLoginData(out UserModel user, LoginDataModel loginData) {

            user = new UserModel("1", "2");

            return true;
        }
    }
}
