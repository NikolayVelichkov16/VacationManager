using DataLayer;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    class DeveloperManager : IManager<Developer, string>
    {
        private DeveloperContext _DeveloperContext;

        public DeveloperManager(ProjectDBContext context)
        {
            this._DeveloperContext = new DeveloperContext(context);
        }

        public void Create(Developer item)
        {
            try
            {
                _DeveloperContext.Create(item);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Delete(string key)
        {
            try
            {
                _DeveloperContext.Delete(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Developer Read(string key)
        {
            try
            {
                return _DeveloperContext.Read(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public IEnumerable<Developer> ReadAll()
        {
            try
            {
                return _DeveloperContext.ReadAll();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(Developer item)
        {
            try
            {
                _DeveloperContext.Update(item);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
