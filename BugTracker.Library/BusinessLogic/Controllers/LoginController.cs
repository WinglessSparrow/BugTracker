

using BCrypt.Net;
using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.Models;
using BugTracker.Model.BusinessLogic.Controllers;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace BugTracker.Library.BusinessLogic.Controllers {
    public class LoginController : ILoginController {

        private IDataAccess _dataAccess;

        public LoginController(IDataAccess dataAccess) {
            _dataAccess = dataAccess;
        }

        public bool CheckLogin(LoginDataModel loginData) {

            string passwordHash = _dataAccess.getPasswordHash(loginData.Username);
            //comparing the password to the hash Value from the DB
            bool isMatched = BCrypt.Net.BCrypt.Verify(SecureStringToString(loginData.Password), passwordHash);

            //getting rid of the password
            loginData.Dispose();

            return isMatched;
        }

        public UserModel GetUser(LoginDataModel loginData) {
            Console.WriteLine("GETING USER");
            return null;
        }
        private String SecureStringToString(SecureString value) {
            IntPtr valuePtr = IntPtr.Zero;
            try {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            } finally {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

    }
}
