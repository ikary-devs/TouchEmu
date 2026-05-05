using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class SetCharacterRestrictionsMessage : NetworkMessage
    {

	    public ActorRestrictionsInformations restrictions;


        public SetCharacterRestrictionsMessage()
        {
        }

        public SetCharacterRestrictionsMessage(ActorRestrictionsInformations restrictions)
        {
            this.restrictions = restrictions;

        }
    }
}