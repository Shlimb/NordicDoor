using NordicDoor.DataAccess.Repository.IRepository;
using NordicDoor.Models;
using NordicDoorWeb.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.DataAccess.Repository
{
    public class SuggestionRepository : Repository<Suggestion>, ISuggestionRepository
    {
        private ApplicationDbContext _db;

        public SuggestionRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }


        public void Update(Suggestion obj)
        {
            _db.Suggestions.Update(obj);
        }
    }
}
