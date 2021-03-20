using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.Models;
using BugTracker.Model.BusinessLogic;
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
