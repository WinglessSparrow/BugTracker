
namespace BugTracker.Controller.Source.Interfaces {
    public interface IDataAccess {
        IIssueAccessHandler GetIssueHandler();
        IUserAccessHandler GetUserHandler();
        ILoginHandler GetLoginHandler();
        string getPasswordHash(string username);
    }
}
