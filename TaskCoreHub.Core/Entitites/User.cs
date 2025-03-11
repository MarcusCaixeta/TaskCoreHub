using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskCoreHub.Core.Entitites
{
    public class User 
    {
        public User( string name, int idEmployee, int idTeam, int idPosition, string email, string password)
        {
            Name = name;
            IdEmployee = idEmployee;
            IdTeam = idTeam;
            IdPosition = idPosition;
            Email = email;
            Password = password;
        }
        public User() { }


        public int Id { get; private set; }
        public string Name { get; private set; }
        public int IdEmployee { get; private set; }
        public int IdTeam { get; private set; }
        public int IdPosition { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
