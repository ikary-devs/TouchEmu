using System.Data;
using TouchEmu.Core.Common.Entity;

namespace TouchEmu.Core.Common.Repository
{

    public interface ICharacterRepository : IRepository<Character>
    {
        
    }
    
    public class CharacterRepository : Repository<Character>, ICharacterRepository
    {
        public CharacterRepository(IDbConnection databaseManager) : base(databaseManager)
        {
        }
    }
}