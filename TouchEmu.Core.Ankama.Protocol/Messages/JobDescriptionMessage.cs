using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class JobDescriptionMessage : NetworkMessage
    {

	    public JobDescription[] jobsDescription;


        public JobDescriptionMessage()
        {
        }

        public JobDescriptionMessage(JobDescription[] jobsDescription)
        {
            this.jobsDescription = jobsDescription;

        }
    }
}