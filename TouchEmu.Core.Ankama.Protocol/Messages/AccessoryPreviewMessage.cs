using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class AccessoryPreviewMessage : NetworkMessage
    {

	    public EntityLook look;


        public AccessoryPreviewMessage()
        {
        }

        public AccessoryPreviewMessage(EntityLook look)
        {
            this.look = look;

        }
    }
}