using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class IdentificationSuccessMessage : NetworkMessage
    {

	    public string login;
	    public string nickname;
	    public int accountId;
	    public int communityId;
	    public bool hasRights;
	    public string secretQuestion;
	    public int subscriptionEndDate;
	    public bool wasAlreadyConnected;
	    public int accountCreation;
	    public bool hasConsoleRight;
	    public string _groupFlags;
	    public string _applicationName;


        public IdentificationSuccessMessage()
        {
        }

        public IdentificationSuccessMessage(string login, string nickname, int accountId, int communityId, bool hasRights, string secretQuestion, int subscriptionEndDate, bool wasAlreadyConnected, int accountCreation, bool hasConsoleRight, string _groupFlags, string _applicationName)
        {
            this.login = login;
            this.nickname = nickname;
            this.accountId = accountId;
            this.communityId = communityId;
            this.hasRights = hasRights;
            this.secretQuestion = secretQuestion;
            this.subscriptionEndDate = subscriptionEndDate;
            this.wasAlreadyConnected = wasAlreadyConnected;
            this.accountCreation = accountCreation;
            this.hasConsoleRight = hasConsoleRight;
            this._groupFlags = _groupFlags;
            this._applicationName = _applicationName;

        }
    }
}