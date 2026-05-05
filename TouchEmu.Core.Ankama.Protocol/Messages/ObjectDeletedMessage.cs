using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class ObjectDeletedMessage : NetworkMessage
    {

	    public int objectUID;


        public ObjectDeletedMessage()
        {
        }

        public ObjectDeletedMessage(int objectUID)
        {
            this.objectUID = objectUID;

        }
    }
}