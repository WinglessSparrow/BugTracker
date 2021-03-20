using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.Models;
using BugTracker.Model.Exceptions;
using System;
using System.Collections.Generic;
namespace DataAccess.temp {
    public class UserAccessHandler : IUserAccessHandler {

        private List<UserModel> _usersList;

        public UserAccessHandler() {
            _usersList = new List<UserModel>();
            _usersList.Add(new UserModel("Pavel-0", "Smirnov-0", "wingless"));
            _usersList.Add(new UserModel("Pavel-1", "Smirnov-1", "sparrow"));
            _usersList.Add(new UserModel("Pavel-2", "Smirnov-2", "spor"));
            _usersList.Add(new UserModel("Pavel-3", "Smirnov-3", "name"));
            _usersList.Add(new UserModel("Pavel-4", "Smirnov-4", "tobe"));
            _usersList.Add(new UserModel("Pavel-5", "Smirnov-5", "string"));
        }

        public UserModel GetAllUser() {
            throw new NotImplementedException();
        }

        public UserModel GetUser(string username) {
            var user = _usersList.Find(UserModel.ByUsername(username));
            return user;
        }

        public void SendUser(UserModel user) {
            throw new NotImplementedException();
        }
    }
}
