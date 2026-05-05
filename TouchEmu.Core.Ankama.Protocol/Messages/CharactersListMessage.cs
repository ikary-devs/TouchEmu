using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class CharactersListMessage : NetworkMessage
    {

	    public bool hasStartupActions;
	    public CharacterBaseInformations[] characters;


        public CharactersListMessage()
        {
        }

        public CharactersListMessage(bool hasStartupActions, CharacterBaseInformations[] characters)
        {
            this.hasStartupActions = hasStartupActions;
            this.characters = characters;

        }
    }
}