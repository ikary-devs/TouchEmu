using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class GameEntitiesDispositionMessage : NetworkMessage
    {

	    public IdentifiedEntityDispositionInformations[] dispositions;


        public GameEntitiesDispositionMessage()
        {
        }

        public GameEntitiesDispositionMessage(IdentifiedEntityDispositionInformations[] dispositions)
        {
            this.dispositions = dispositions;

        }
    }
}