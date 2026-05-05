using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class FighterStatsListMessage : NetworkMessage
    {

	    public CharacterCharacteristicsInformations stats;


        public FighterStatsListMessage()
        {
        }

        public FighterStatsListMessage(CharacterCharacteristicsInformations stats)
        {
            this.stats = stats;

        }
    }
}