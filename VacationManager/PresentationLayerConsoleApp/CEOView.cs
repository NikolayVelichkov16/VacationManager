using System;
using System.Collections.Generic;
using System.Text;
using ServiceLayer;
using BusinessLayer;

namespace PresentationLayerConsoleApp
{
    class CEOView
    {
        private DBManager<CEO, string> manager;
        private DBContextManager dBContextManager;

        public CEOView()
        {
           // manager = new DBManager<CEO, int>(DBContextManager.CreateCEOContext(DBContextManager.CreateContext()));
        }
        //string id, string name, string surname, string lastname, string password, string phoneNumber, string email, string company
        public void Create() 
        {
            Console.WriteLine("CEO Create!");
            Console.WriteLine("string Id: ");
            string id = Console.ReadLine();
            Console.WriteLine("name: ");
            string name = Console.ReadLine();
            Console.WriteLine("surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("password: ");
            string password = Console.ReadLine();
            Console.WriteLine("phonenumber: ");
            string phonenumber = Console.ReadLine();
            Console.WriteLine("email: ");
            string email = Console.ReadLine();
            Console.WriteLine("company: ");
            string company = Console.ReadLine();

            CEO ceo = new CEO(id, name, surname, lastname, password, phonenumber, email, company);
            manager.Create(ceo);
        }
    }
}
