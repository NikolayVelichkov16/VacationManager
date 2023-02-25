using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Worker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public List<VacationDoc> Vacations { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Worker(string id, string name, string surname, string lastname, string password, string phoneNumber, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.LastName = lastname;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            //BDate();
        }
        public Worker()
        {

        }
        private void BDate()
        {
            string egn = this.Id;
            int day = Convert.ToInt32(egn[4] + egn[5]);
            int month = Convert.ToInt32(egn[2] + egn[3]);
            if (month > 40 && month < 53)
            {
                month -= 40;

            }
            else if (month > 20 && month < 33)
            {
                month -= 20;
            }
            int year = Convert.ToInt32(egn[0] + egn[1]);
            this.Birthday = new DateTime(year, month, day);
        }
    }
}
