using BugTracker.Library.Models;


namespace BugTracker.Controller.Source.Interfaces {
    public interface IUserAccessHandler {
        UserModel GetUser(string username);
        UserModel GetAllUser();
        void SendUser(UserModel user);
    }
}
