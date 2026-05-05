using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class HelloConnectMessage : NetworkMessage
    {

	    public string salt;
	    public int[] key;


        public HelloConnectMessage()
        {
        }

        public HelloConnectMessage(string salt, int[] key)
        {
            this.salt = salt;
            this.key = key;

        }
    }
}