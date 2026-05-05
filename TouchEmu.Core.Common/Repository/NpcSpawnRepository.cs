using System.Collections.Generic;
using System.Data;
using System.Linq;
using TouchEmu.Core.Common.Entity;

namespace TouchEmu.Core.Common.Repository
{
    public interface INpcSpawnRepository
    {
        public List<NpcSpawn> GetNpcsFromMapId(long mapId);
    }
    
    public class NpcSpawnRepository: Repository<NpcSpawn>, INpcSpawnRepository
    {
        public NpcSpawnRepository(IDbConnection databaseManager) : base(databaseManager)
        {
        }

        public List<NpcSpawn> GetNpcsFromMapId(long mapId)
        {
            return this.Entities().Values.Where(x => x.MapId == mapId).ToList();
        }
    }
}