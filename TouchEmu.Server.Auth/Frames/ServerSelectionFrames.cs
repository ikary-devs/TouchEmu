using System;
using Autofac;
using TouchEmu.Core.Ankama.Protocol.Messages;
using TouchEmu.Core.Ankama.Protocol.SendMessages;
using TouchEmu.Core.Common.Managers.Frames;
using TouchEmu.Core.Common.Network;
using TouchEmu.Core.Common.Repository;

namespace TouchEmu.Server.Auth.Frames
{
    public class ServerSelectionFrames
    {
        [InterceptFrame("ServerSelectionMessage")]
        public void ServerSelectionMessage(Client client, ServerSelectionMessage serverSelectionMessage)
        {
            Container.Instance().Resolve<IAccountRepository>().Entities().AddOrUpdate(client.Account.Id, client.Account,
                (i, account) =>
                {
                    account.Ticket = Guid.NewGuid().ToString();
                    account.IsEdited = true;
                    return account;
                });

            client.Send(new SelectedServerDataMessage(serverSelectionMessage.serverId, "localhost", 666, true, client.Account.Ticket, "http://localhost:666"));
        }
    }
}