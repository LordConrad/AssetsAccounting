using System.Collections.Generic;
using AssetsAccounting.DataAccess.Models;

namespace AssetsAccounting.DataAccess.Services
{
    public interface IResponsibleService
    {
        IEnumerable<Responsible> GetResponsibles();
        Responsible GetResponsible(int id);
        void AddResponsible(Responsible responsible);
        void RemoveResponsible(int id);
    }
}
