using BugTracker.Library.Models;

namespace BugTracker.Model.BusinessLogic.Controllers {
    public interface ILoginController {
        bool CheckLogin(LoginDataModel loginData);
        UserModel GetUser(LoginDataModel loginData);
    }
}
