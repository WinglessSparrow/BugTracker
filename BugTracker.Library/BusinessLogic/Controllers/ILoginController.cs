using BugTracker.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Model.BusinessLogic.Controllers {
    public interface ILoginController {
        bool CheckLogin(LoginDataModel loginData);
        UserModel GetUser(LoginDataModel loginData);
    }
}
