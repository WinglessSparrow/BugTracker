using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Library.Models {
    public class UserModel {
        //role : enum --> RoleFactory or smth
        //assignedProject : ProjectModel
        private string _firstName;
        private string _surname;
        private string _username;

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

        public string Username { get { return _username; } private set { } }

        public UserModel(string Firstname, string Surname, string username) {
            _firstName = Firstname;
            _surname = Surname;
            _username = username;
        }

        public static Predicate<UserModel> ByUsername(string username) {
            return delegate (UserModel userModel) {
                return userModel.Username == username;
            };
        }


    }
}
