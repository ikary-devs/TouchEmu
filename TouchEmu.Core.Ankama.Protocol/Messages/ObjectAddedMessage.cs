using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;
using Newtonsoft.Json;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class ObjectAddedMessage : NetworkMessage
    {

        [JsonProperty("object")]
	    public ObjectItem @object;


        public ObjectAddedMessage()
        {
        }

        public ObjectAddedMessage(ObjectItem @object)
        {
            this.@object = @object;

        }
    }
}