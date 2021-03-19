
using BugTracker.Controller.Source.Interfaces;
using BugTracker.UI.Models;
using System;
using System.Collections.Generic;

namespace BugTracker.Library.DataAccess {
    public class DataRetriever : IDataAccess {

        private ILoginHandler _loginHandler;
        private IIssueAccessHandler _issueAccessHandler;
        private IUserAccessHandler _userAccessHandler;

        public DataRetriever(ILoginHandler loginHandler, IIssueAccessHandler issueAccessHandler, IUserAccessHandler userAccessHandler) {
            _loginHandler = loginHandler;
            _issueAccessHandler = issueAccessHandler;
            _userAccessHandler = userAccessHandler;
        }

        public DataRetriever() {

        }

        public IIssueAccessHandler GetIssueHandler() {
            return _issueAccessHandler;
        }

        public ILoginHandler GetLoginHandler() {
            return _loginHandler;
        }

        public IUserAccessHandler GetUserHandler() {
            return _userAccessHandler;
        }
    }
}
