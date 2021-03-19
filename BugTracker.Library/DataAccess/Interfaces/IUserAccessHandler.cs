using BugTracker.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Controller.Source.Interfaces {
    public interface IUserAccessHandler {
        UserModel GetUser(string username);
        UserModel GetAllUser();
        void SendUser(UserModel user);
    }
}
