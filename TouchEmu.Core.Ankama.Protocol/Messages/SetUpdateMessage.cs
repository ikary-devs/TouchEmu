using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class SetUpdateMessage : NetworkMessage
    {

	    public int setId;
	    public int[] setObjects;
	    public ObjectEffectInteger[] setEffects;


        public SetUpdateMessage()
        {
        }

        public SetUpdateMessage(int setId, int[] setObjects, ObjectEffectInteger[] setEffects)
        {
            this.setId = setId;
            this.setObjects = setObjects;
            this.setEffects = setEffects;

        }
    }
}