using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.UI.Models {
    public class UserModel {
        //role : enum
        //assignedProject : ProjectModel
        private string _firstName;
        private string _surname;

        public string Firstname {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string Surname {
            get { return _surname; }
            set { _surname = value; }
        }

        public string FullName {
            get {
                return $"{ _firstName } { _surname }";
            }
            private set { }
        }

        public UserModel(string Firstname, string Surname) {
            _firstName = Firstname;
            _surname = Surname;
        }


    }
}
