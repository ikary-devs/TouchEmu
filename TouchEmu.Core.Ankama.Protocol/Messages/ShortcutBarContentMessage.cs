using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class ShortcutBarContentMessage : NetworkMessage
    {

	    public int barType;
	    public Shortcut[] shortcuts;


        public ShortcutBarContentMessage()
        {
        }

        public ShortcutBarContentMessage(int barType, Shortcut[] shortcuts)
        {
            this.barType = barType;
            this.shortcuts = shortcuts;

        }
    }
}