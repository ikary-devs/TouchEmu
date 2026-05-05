using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class shopOpenSuccess : NetworkMessage
    {

	    public object home;


        public shopOpenSuccess()
        {
        }

        public shopOpenSuccess(object home)
        {
            this.home = home;

        }
    }
}