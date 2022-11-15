using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class TeamLeader : Worker
    {
        public TeamLeader(string id, string name, string surname, string lastname, string password, string phoneNumber, string email, int teamID)
            : base(id, name, surname, lastname, password, phoneNumber, email)
        {
            this.TeamID = teamID;
        }

        public int TeamID { get; set; }
    }
}
