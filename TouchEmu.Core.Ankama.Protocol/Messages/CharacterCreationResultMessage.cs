using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class CharacterCreationResultMessage : NetworkMessage
    {

	    public int result;


        public CharacterCreationResultMessage()
        {
        }

        public CharacterCreationResultMessage(int result)
        {
            this.result = result;

        }
    }
}