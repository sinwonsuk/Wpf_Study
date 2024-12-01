using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiDesktopApp1.interfaces;
using UiDesktopApp1.Models;
namespace UiDesktopApp1.Services
{
    internal class GangnamguPopulationService : IDataBase<GangnamguPopulation>
    {
        private readonly WpfProjectDatabaseContext? wpfProjectDatabaseContext;

        public GangnamguPopulationService(WpfProjectDatabaseContext databaseContext)
        {
            wpfProjectDatabaseContext = databaseContext;
        }

        public void Create(GangnamguPopulation entity)
        {
            wpfProjectDatabaseContext?.GangnamguPopulations.Add(entity);
            wpfProjectDatabaseContext?.SaveChanges();
        }

        public void Delete(int id)
        {
            var validData = this.wpfProjectDatabaseContext?.GangnamguPopulations.FirstOrDefault(c => c.Id == id);

           if (validData != null)
           {
               this.wpfProjectDatabaseContext?.GangnamguPopulations.Remove(validData);
           }
           else
           {
               throw new InvalidOperationException();
           }
        }

        public List<GangnamguPopulation>? Get()
        {
            return wpfProjectDatabaseContext?.GangnamguPopulations.ToList();
        }

        public Task<GangnamguPopulation>? GetDetail(int id)
        {
            var validData = wpfProjectDatabaseContext?.GangnamguPopulations.FirstOrDefaultAsync(c => c.Id == id);

            return validData;
        }

        public void Update(GangnamguPopulation entity)
        {
        wpfProjectDatabaseContext?.GangnamguPopulations.Update(entity);
            wpfProjectDatabaseContext?.SaveChanges();
        }
    }
}
