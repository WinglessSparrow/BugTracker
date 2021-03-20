

using BugTracker.Library.Models;

namespace BugTracker.Controller.Source.Interfaces {
    public interface IIssueAccessHandler {
        IssueModel GetIssuesOfUser(string username);
        void SendIssue(IssueModel issue);
    }
}
