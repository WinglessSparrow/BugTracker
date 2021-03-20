using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.Models;
using BugTracker.Model.BusinessLogic;
using System;
using System.Diagnostics;

namespace BugTracker.Library.BusinessLogic {
    public class MainBusinessLogic : IBusinessLogic {
        private IDataAccess _dataAccess;
        public MainBusinessLogic(IDataAccess dataAccess) {
            _dataAccess = dataAccess;
        }

        public string getPasswordHash(string username) {

            return BCrypt.Net.BCrypt.HashPassword("apfel", "$2a$10$HRz42c08/iKLyZBu5/77ye");
        }
    }
}
