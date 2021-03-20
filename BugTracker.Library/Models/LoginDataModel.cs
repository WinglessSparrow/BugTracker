using Stylet;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;

namespace BugTracker.Library.Models {
    public class LoginDataModel : PropertyChangedBase, IDisposable {
        private SecureString _password;
        private String _username;

        public SecureString Password {
            get { return _password; }
            private set { }
        }

        public string Username {
            get { return _username; }
            private set { }
        }

        public LoginDataModel(SecureString password, String username) {
            _password = password;
            _username = username;
        }

        public void Dispose() {
            //TODO something else should happen here aswell, I have no clue what thou
            _password.Dispose();
            _username = "";
        }
    }
}
