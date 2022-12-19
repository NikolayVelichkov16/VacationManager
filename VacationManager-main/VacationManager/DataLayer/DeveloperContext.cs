using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DeveloperContext : ICRUD<Developer, string>
    {
        private ProjectDBContext _context;
        private CEOContext context;

        public DeveloperContext(ProjectDBContext context)
        {
            this._context = context;
        }

        public DeveloperContext(CEOContext context)
        {
            this.context = context;
        }

        public void Create(Developer item)
        {

            try
            {
                _context.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(string key)
        {
            try
            {
                Developer devFromDB = Read(key);

                _context.Remove(devFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Developer Read(string key)
        {
            try
            {

                return _context.Developers.Find(key);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Developer> ReadAll()
        {
            try
            {
                return _context.Developers.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Developer item)
        {
            try
            {
                Developer devFromDB = Read(item.Id);

                _context.Entry(devFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
