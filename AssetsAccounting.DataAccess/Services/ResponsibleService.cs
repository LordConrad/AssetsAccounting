using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsAccounting.DataAccess.Models;

namespace AssetsAccounting.DataAccess.Services
{
    public class ResponsibleService : IResponsibleService
    {
        public IEnumerable<Responsible> GetResponsibles()
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    return context.Responsibles.ToList();
                }
            }
            catch(Exception)
            { }
            return null;
        }

        public Responsible GetResponsible(int id)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    return context.Responsibles.FirstOrDefault(x => x.Id.Equals(id));
                }
            }
            catch (Exception)
            {
            }
            return null;
        }

        public void AddResponsible(Responsible responsible)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    context.Responsibles.Attach(responsible);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
            }
        }

        public void RemoveResponsible(int id)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    var responsible = new Responsible {Id = id};
                    context.Responsibles.Attach(responsible);
                    context.Responsibles.Remove(responsible);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
