using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Model.Models {
    public class LoginDataModel {
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
    }
}
