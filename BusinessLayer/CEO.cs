using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class CEO : Worker
    {
        
        public CEO(string id, string name, string surname, string lastname, string password, string phoneNumber, string email, string company)
            : base(id, name, surname, lastname, password, phoneNumber, email)
        {
            this.Company = company;
        }

        private CEO() : base()
        {

        }

        public string Company { get; set; }
        
    }
}
