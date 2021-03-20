using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.UI.Events {
    public class PasswordChangedEvent {
        private SecureString _password;
        public SecureString Password { get { return _password; } }

        public PasswordChangedEvent(SecureString password) {
            _password = password;
        }
    }
}
