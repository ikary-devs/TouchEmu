using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class GameFightSynchronizeMessage : NetworkMessage
    {

	    public GameFightMonsterInformations[] fighters;


        public GameFightSynchronizeMessage()
        {
        }

        public GameFightSynchronizeMessage(GameFightMonsterInformations[] fighters)
        {
            this.fighters = fighters;

        }
    }
}