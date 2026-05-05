using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class SpellListMessage : NetworkMessage
    {

	    public bool spellPrevisualization;
	    public SpellItem[] spells;


        public SpellListMessage()
        {
        }

        public SpellListMessage(bool spellPrevisualization, SpellItem[] spells)
        {
            this.spellPrevisualization = spellPrevisualization;
            this.spells = spells;

        }
    }
}