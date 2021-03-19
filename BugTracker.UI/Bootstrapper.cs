
using Stylet;
using StyletIoC;
using BugTracker.UI.Pages;
using BugTracker.Model.BusinessLogic;
using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.BusinessLogic;
using BugTracker.Library.DataAccess;
using BugTracker.Model.BusinessLogic.Controllers;
using BugTracker.Library.BusinessLogic.Controllers;

namespace BugTracker.UI {
    public class Bootstrapper : Bootstrapper<ShellViewModel> {
        protected override void ConfigureIoC(IStyletIoCBuilder builder) {
            // Configure the IoC container in here
            builder.Bind<IBusinessLogic>().To<MainBusinessLogic>();
            builder.Bind<IDataAccess>().To<DataRetriever>();
            builder.Bind<ILoginController>().To<LoginController>();
        }

        protected override void Configure() {
            // Perform any other configuration before the application starts
        }
    }
}
