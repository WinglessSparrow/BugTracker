using BugTracker.Model.Models;
using BugTracker.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Controller.Source.Interfaces {
    public interface ILoginHandler {
        bool ProveLoginData(out UserModel user, LoginDataModel loginData);
    }
}
