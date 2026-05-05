using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchEmu.Core.Ankama.Protocol.Types;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class JobExperienceMultiUpdateMessage : NetworkMessage
    {

	    public JobExperience[] experiencesUpdate;


        public JobExperienceMultiUpdateMessage()
        {
        }

        public JobExperienceMultiUpdateMessage(JobExperience[] experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;

        }
    }
}