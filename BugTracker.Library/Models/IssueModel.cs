
namespace BugTracker.UI.Models {
    public class IssueModel {
        private string _name;
        private string _description;
        private UserModel _assignedUser;

        public IssueModel(string name, string description, UserModel assignedUser) {
            _name = name;
            _description = description;
            _assignedUser = assignedUser;
        }

    }
}
