using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class TowerOfAscensionCompositionMessage : NetworkMessage
    {

	    public TowerOfAscensionStepComposition[] steps;


        public TowerOfAscensionCompositionMessage()
        {
        }

        public TowerOfAscensionCompositionMessage(TowerOfAscensionStepComposition[] steps)
        {
            this.steps = steps;

        }
    }
}