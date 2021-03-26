using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.UI.ViewModels {
    public class MainViewModel : Conductor<Screen> {

        public void TabEvent(string args) {
            Tabs tabName = (Tabs)Enum.Parse(typeof(Tabs), args, false);

            switch (tabName) {
                case Tabs.Home:
                    break;
                case Tabs.Issues:
                    break;
                case Tabs.Projects:
                    break;
                case Tabs.Settings:
                    break;
                case Tabs.Logout:
                    break;
                default:
                    break;
            }
        }

    }

    public enum Tabs {
        Home, Issues, Projects, Settings, Logout
    }
}
