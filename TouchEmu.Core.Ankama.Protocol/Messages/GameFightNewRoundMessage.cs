using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class GameFightNewRoundMessage : NetworkMessage
    {

	    public int roundNumber;


        public GameFightNewRoundMessage()
        {
        }

        public GameFightNewRoundMessage(int roundNumber)
        {
            this.roundNumber = roundNumber;

        }
    }
}