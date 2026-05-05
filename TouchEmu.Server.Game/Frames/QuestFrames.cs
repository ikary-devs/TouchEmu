using TouchEmu.Core.Ankama.Protocol.Messages;
using TouchEmu.Core.Ankama.Protocol.SendMessages;
using TouchEmu.Core.Common.Managers.Frames;
using TouchEmu.Server.Game.Network;

namespace TouchEmu.Server.Game.Frames
{
    public class QuestFrames
    {
        //QuestListRequestMessage
        [InterceptFrame("QuestListRequestMessage")]
        public void QuestListRequestMessageFrame(GameClient client, QuestListRequestMessage questListRequestMessage)
        {
            client.Send(new QuestListMessage(new int[] {}, new int[] {}, new int[] {}));
        }
    }
}