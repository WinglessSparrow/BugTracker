using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.Models;

namespace DataAccess.temp {
    class LoginHandler : ILoginHandler {
        public bool ProveLoginData(out UserModel user, LoginDataModel loginData) {

            user = new UserModel("1", "2");

            return true;
        }
    }
}
