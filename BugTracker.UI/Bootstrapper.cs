
using Stylet;
using StyletIoC;
using BugTracker.UI.Pages;
using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.DataAccess;
using BugTracker.Model.BusinessLogic.Controllers;
using BugTracker.Library.BusinessLogic.Controllers;
using DataAccess.temp;

namespace BugTracker.UI {
    public class Bootstrapper : Bootstrapper<ShellViewModel> {
        protected override void ConfigureIoC(IStyletIoCBuilder builder) {
            // Configure the IoC container in here
            builder.Bind<IDataAccess>().To<DataRetriever>();
            builder.Bind<ILoginController>().To<LoginController>();
            builder.Bind<IIssueAccessHandler>().To<IssueAccessHandler>();
            builder.Bind<ILoginHandler>().To<LoginHandler>();
            builder.Bind<IUserAccessHandler>().To<UserAccessHandler>();
        }

        protected override void Configure() {
            // Perform any other configuration before the application starts
        }
    }
}
