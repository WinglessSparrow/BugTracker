using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.Models;
using System;
using System.Collections.Generic;
namespace DataAccess.temp {
    public class UserAccessHandler : IUserAccessHandler {

        private List<UserModel> _usersList;

        public UserAccessHandler() {
            _usersList = new List<UserModel>();
            _usersList.Add(new UserModel("Pavel-0", "Smirnov-0", "user_1"));
            _usersList.Add(new UserModel("Pavel-1", "Smirnov-1", "user_2"));
            _usersList.Add(new UserModel("Pavel-2", "Smirnov-2", "user_3"));
            _usersList.Add(new UserModel("Pavel-3", "Smirnov-3", "user_4"));
            _usersList.Add(new UserModel("Pavel-4", "Smirnov-4", "user_5"));
            _usersList.Add(new UserModel("Pavel-5", "Smirnov-5", "user_6"));
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
