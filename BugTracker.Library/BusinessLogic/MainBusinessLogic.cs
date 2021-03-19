using BugTracker.Controller.Source.Interfaces;
using BugTracker.Model.BusinessLogic;
using BugTracker.Model.Models;
using System;

namespace BugTracker.Library.BusinessLogic {
    public class MainBusinessLogic : IBusinessLogic {
        private IDataAccess _dataAccess;
        public MainBusinessLogic(IDataAccess dataAccess) {
            _dataAccess = dataAccess;
        }

        public bool CheckLoginData(LoginDataModel loginData) {
            Console.WriteLine("HIII");
            return true;
        }
    }
}
