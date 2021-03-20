using Stylet;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;

namespace BugTracker.Library.Models {
    public class LoginDataModel : PropertyChangedBase, IDisposable {
        private SecureString _password;
        private string _username;

        public SecureString Password {
            get { return _password; }
            private set { }
        }

        public string Username {
            get { return _username; }
            private set { }
        }

        public LoginDataModel(SecureString password, string username) {
            _password = password;
            _username = username;
        }

        public void Dispose() {
            _password.Clear();
        }
    }
}
