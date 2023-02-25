using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Team
    {
        private Team()
        {

        }
        public int ID { get; set; }
        public List<Worker> Workers { get; set; }
        public string ProjectName { get; set; }
    }
}
