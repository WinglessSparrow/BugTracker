using BugTracker.Library.Models;

namespace BugTracker.Controller.Source.Interfaces {
    public interface ILoginHandler {
        string getPasswordHash(string username);
    }
}
