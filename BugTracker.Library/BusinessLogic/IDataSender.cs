using BugTracker.Controller.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Model.BusinessLogic {
    public interface IDataSender {
        void SetDataAccess(IDataAccess dataAccess);
    }
}
