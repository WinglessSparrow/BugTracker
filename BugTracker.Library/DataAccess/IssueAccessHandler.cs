using BugTracker.Controller.Source.Interfaces;
using BugTracker.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.temp {
    public class IssueAccessHandler : IIssueAccessHandler {

        private List<IssueModel> _issuesList;
        public IssueAccessHandler() {
            _issuesList = new List<IssueModel>();
            _issuesList.Add(new IssueModel("1", "1", null));
            _issuesList.Add(new IssueModel("2", "2", null));
            _issuesList.Add(new IssueModel("3", "3", null));
            _issuesList.Add(new IssueModel("4", "4", null));
            _issuesList.Add(new IssueModel("5", "5", null));
        }

        public IssueModel GetIssuesOfUser(string username) {
            throw new NotImplementedException();
        }

        public void SendIssue(IssueModel issue) {
            throw new NotImplementedException();
        }
    }
}
