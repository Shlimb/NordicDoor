using NordicDoor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.DataAccess.Repository.IRepository
{
    //skal egentlig stå public istedenfor internal, men da får jeg rød strek under ISuggestionRepository//
    public interface ISuggestionRepository : IRepository<Suggestion>
    {
        void Update(Suggestion obj);
    }
}
