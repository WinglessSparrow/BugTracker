using BugTracker.Controller.Source.Interfaces;
using BugTracker.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Model.BusinessLogic {
    public interface IBusinessLogic {

        bool CheckLoginData(LoginDataModel loginData);

    }
}
