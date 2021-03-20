using BugTracker.Controller.Source.Interfaces;
using BugTracker.Library.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.temp {
    public class LoginHandler : ILoginHandler {

        private List<Temp> _logins;

        public LoginHandler() {
            _logins = new List<Temp>();
            _logins.Add(new Temp() { Name = "user_1", Pass = "apfel" });
            _logins.Add(new Temp() { Name = "user_2", Pass = "apfel_g" });
            _logins.Add(new Temp() { Name = "user_3", Pass = "apfel_i" });
            _logins.Add(new Temp() { Name = "user_4", Pass = "apfel_k" });
            _logins.Add(new Temp() { Name = "user_5", Pass = "apfel_l" });
            _logins.Add(new Temp() { Name = "user_6", Pass = "apfel_p" });
        }

        public string getPasswordHash(string username) {
            var temp = _logins.Find(Temp.ByUsername(username));

            if (temp == null) return null;
            return BCrypt.Net.BCrypt.HashPassword(temp.Pass, "$2a$10$HRz42c08/iKLyZBu5/77ye");
        }
    }

    class Temp {
        public string Name { get; set; }
        public string Pass { get; set; }

        public static Predicate<Temp> ByUsername(string username) {
            return delegate (Temp temp) {
                return temp.Name == username;
            };
        }
    }
}
