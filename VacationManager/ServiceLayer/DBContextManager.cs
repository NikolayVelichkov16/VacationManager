using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace ServiceLayer
{
    public class DBContextManager
    {
        private static ProjectDBContext _context;
        private static CEOContext _ceoContext;
        private static DeveloperContext _developerContext;
        private static TeamContext _teamContext;
        private static TeamLeaderContext _teamleaderContext;
        private static VacationDocContext _vacationdocContextContext;

        public static ProjectDBContext CreateContext()
        {
            _context = new ProjectDBContext();
            return _context;
        }

        public static ProjectDBContext GetProjectDBContext()
        {
            return _context;
        }

        //CEOContexts
        public static CEOContext CreateCEOContext(ProjectDBContext context)
        {
            _ceoContext = new CEOContext(context);
            return _ceoContext;
        }

        public static CEOContext GetCEOContext()
        {
            return _ceoContext;
        }
      

        //DeveloperContexts
        public static DeveloperContext CreateDeveloperContext(ProjectDBContext context)
        {
            _developerContext = new DeveloperContext(context);
            return _developerContext;
        }

        public static DeveloperContext GetDeveloperContext()
        {
            return _developerContext;
        }

        //TeamContext
        public static TeamContext CreateTeamContext(ProjectDBContext context)
        {
            _teamContext = new TeamContext(context);
            return _teamContext;
        }

        public static TeamContext GetTeamContext()
        {
            return _teamContext;
        }

        //TeamLeaderContext
        public static TeamLeaderContext CreateTeamLeaderContext(ProjectDBContext context)
        {
            _teamleaderContext = new TeamLeaderContext(context);
            return _teamleaderContext;
        }
        public static TeamLeaderContext GetTeamLeaderContext()
        {
            return _teamleaderContext;
        }

        //VacationDocContext
        public static VacationDocContext CreateVacationDocContext(ProjectDBContext context)
        {
            _vacationdocContextContext = new VacationDocContext(_context);
            return _vacationdocContextContext;
        }
        public static VacationDocContext GetVacationDocContext()
        {
            return _vacationdocContextContext;
        }
    }
}
