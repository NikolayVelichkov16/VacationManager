using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace ServiceLayer
{
    public class DBContextManager
    {
        private static CEOContext _context;
        private static DeveloperContext _developerContext;
        private static TeamContext _teamContext;
        private static TeamLeaderContext _teamleaderContext;
        private static VacationDocContext _vacationdocContextContext;

        public static CEOContext CreateContext()
        {
            _context = new CEOContext();
            return _context;
        }

        public static CEOContext GetContext()
        {
            return _context;
        }
      

        //DeveloperContexts
        public static DeveloperContext CreateDeveloperContext(CEOContext context)
        {
            _developerContext = new DeveloperContext(context);
            return _developerContext;
        }

        public static DeveloperContext GetDeveloperContext()
        {
            return _developerContext;
        }

        //TeamContext
        public static TeamContext CreateCommentContext(CEOContext context)
        {
            _teamContext = new TeamContext(context);
            return _teamContext;
        }

        public static TeamContext GetCommentContext()
        {
            return _teamContext;
        }

        //TeamLeaderContext
        public static TeamLeaderContext CreateTeamLeaderContext(CEOContext context)
        {
            _teamleaderContext = new TeamLeaderContext(context);
            return _teamleaderContext;
        }
        public static TeamLeaderContext GetTeamLeaderContext()
        {
            return _teamleaderContext;
        }

        //VacationDocContext
        public static VacationDocContext CreateVacationDocContext(CEOContext context)
        {
            _vacationdocContextContext = new VacationDocContext(context);
            return _vacationdocContextContext;
        }
        public static VacationDocContext GetVacationDocContext()
        {
            return _vacationdocContextContext;
        }


    }
}
