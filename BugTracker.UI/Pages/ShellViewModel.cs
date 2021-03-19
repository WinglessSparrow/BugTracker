using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.BusinessLogic;
using BugTracker.Library.BusinessLogic.Controllers;
using BugTracker.Library.DataAccess;
using BugTracker.Model.BusinessLogic;
using BugTracker.Model.BusinessLogic.Controllers;
using BugTracker.UI.ViewModels;
using Stylet;
using StyletIoC;
using System;

namespace BugTracker.UI.Pages {
    public class ShellViewModel : Screen {


        public ShellViewModel(IWindowManager wM, ILoginController loginController) {

            //ViewModels are instantiated directly, since they are very View specific and shouldn't be exchanged, 
            //the Business Logic and controllers are what could be modified or smth.

            wM.ShowWindow(new LoginViewModel(loginController));
        }
    }
}
