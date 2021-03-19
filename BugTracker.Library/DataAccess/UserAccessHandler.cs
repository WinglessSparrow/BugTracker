using BugTracker.Controller.Source.Interfaces;
using BugTracker.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.temp {
    class UserAccessHandler : IUserAccessHandler {

        private List<UserModel> _usersList;

        public UserAccessHandler() {
            _usersList = new List<UserModel>();
            _usersList.Add(new UserModel("Pavel-0", "Smirnov-0"));
            _usersList.Add(new UserModel("Pavel-1", "Smirnov-1"));
            _usersList.Add(new UserModel("Pavel-2", "Smirnov-2"));
            _usersList.Add(new UserModel("Pavel-3", "Smirnov-3"));
            _usersList.Add(new UserModel("Pavel-4", "Smirnov-4"));
            _usersList.Add(new UserModel("Pavel-5", "Smirnov-5"));
        }

        public UserModel GetAllUser() {
            throw new NotImplementedException();
        }

        public UserModel GetUser(string username) {
            throw new NotImplementedException();
        }

        public void SendUser(UserModel user) {
            throw new NotImplementedException();
        }
    }
}
