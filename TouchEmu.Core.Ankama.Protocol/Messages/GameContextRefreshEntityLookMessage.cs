using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class GameContextRefreshEntityLookMessage : NetworkMessage
    {

	    public int id;
	    public EntityLook look;


        public GameContextRefreshEntityLookMessage()
        {
        }

        public GameContextRefreshEntityLookMessage(int id, EntityLook look)
        {
            this.id = id;
            this.look = look;

        }
    }
}