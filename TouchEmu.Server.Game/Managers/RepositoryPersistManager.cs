using System.Data;
using System.Threading.Tasks;
using TouchEmu.Core.Common.Managers.Repository;
using TouchEmu.Core.Common.Repository;

namespace TouchEmu.Server.Game.Managers
{
    public class RepositoryPersistManager : AbstractRepositoryPersistManager
    {
        private ICharacterRepository _characterRepository;
        
        public RepositoryPersistManager(IDbConnection connection, ICharacterRepository characterRepository) : base(connection, 80000)
        {
            this._characterRepository = characterRepository;
        }

        protected override Task PersistCallback()
        {
            
            this._logger.Debug($"Save in progress...");

            this._characterRepository.PersistEntities();
            
            return base.PersistCallback();
        }
    }
}