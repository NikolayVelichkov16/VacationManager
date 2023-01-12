using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    class TeamManager : IManager<Team, int>
    {
        private TeamContext _TeamContext;

        public TeamManager(ProjectDBContext context)
        {
            this._TeamContext = new TeamContext(context);
        }

        public void Create(Team item)
        {
            try
            {
                _TeamContext.Create(item);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Delete(int key)
        {
            try
            {
                _TeamContext.Delete(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Team Read(int key)
        {
            try
            {
                return _TeamContext.Read(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public IEnumerable<Team> ReadAll()
        {
            try
            {
                return _TeamContext.ReadAll();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(Team item)
        {
            try
            {
                _TeamContext.Update(item);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
