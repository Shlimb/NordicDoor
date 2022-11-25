using NordicDoor.DataAccess.Repository.IRepository;
using NordicDoorWeb.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Suggestion = new SuggestionRepository(_db);
        }
        public ISuggestionRepository Suggestion{ get;private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
