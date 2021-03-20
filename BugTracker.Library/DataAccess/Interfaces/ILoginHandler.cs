using BugTracker.Library.Models;

namespace BugTracker.Controller.Source.Interfaces {
    public interface ILoginHandler {
        bool ProveLoginData(out UserModel user, LoginDataModel loginData);
    }
}
