using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISuggestionRepository Suggestion { get; }

        void Save();
    }
}
