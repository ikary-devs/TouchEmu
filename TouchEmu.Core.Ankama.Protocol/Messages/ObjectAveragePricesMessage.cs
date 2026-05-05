using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class ObjectAveragePricesMessage : NetworkMessage
    {

	    public int[] ids;
	    public int[] avgPrices;


        public ObjectAveragePricesMessage()
        {
        }

        public ObjectAveragePricesMessage(int[] ids, int[] avgPrices)
        {
            this.ids = ids;
            this.avgPrices = avgPrices;

        }
    }
}