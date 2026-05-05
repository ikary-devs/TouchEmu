using System.Collections.Generic;
using System.Linq;
using Autofac;
using TouchEmu.Core.Ankama.Protocol.Messages;
using TouchEmu.Core.Ankama.Protocol.SendMessages;
using TouchEmu.Core.Ankama.Protocol.Types;
using TouchEmu.Core.Common.Managers.Frames;
using TouchEmu.Core.Common.Repository;
using TouchEmu.Server.Game.Managers;
using TouchEmu.Server.Game.Network;

namespace TouchEmu.Server.Game.Frames
{
    public class ApproachFrames
    {
        [InterceptFrame("CharactersListRequestMessage")]
        public void CharactersListRequestMessageFrame(GameClient client,
            CharactersListRequestMessage charactersListRequestMessage)
        {
            ApproachFrames.SendCharactersListMessage(client);
        }

        [InterceptFrame("CharacterCreationRequestMessage")]
        public void CharacterCreationRequestMessageFrame(GameClient client,
            CharacterCreationRequestMessage characterCreationRequestMessage)
        {
            Container.Instance().Resolve<ICharacterManager>().CreateCharacter(client, characterCreationRequestMessage);
        }

        [InterceptFrame("CharacterDeletionRequestMessage")]
        public void CharacterDeletionRequestMessageFrame(GameClient client,
            CharacterDeletionRequestMessage characterDeletionRequestMessage)
        {
            Container.Instance().Resolve<ICharacterManager>()
                .CharacterDeletion(client, characterDeletionRequestMessage);
        }


        [InterceptFrame("CharacterSelectionMessage")]
        public void CharacterSelectionMessageFrame(GameClient client,
            CharacterSelectionMessage characterSelectionMessage)
        {
            Container.Instance().Resolve<ICharacterManager>()
                .CharacterSelection(client, characterSelectionMessage.id);
            
        }
        
        [InterceptFrame("CharacterFirstSelectionMessage")]
        public void CharacterFirstSelectionMessageFrame(GameClient client,
            CharacterFirstSelectionMessage characterFirstSelectionMessage)
        {
            Container.Instance().Resolve<ICharacterManager>()
                .CharacterSelection(client, characterFirstSelectionMessage.id);
            
        }

        /**
         * Send CharactersListMessage from GameClient
         */
        public static void SendCharactersListMessage(GameClient client)
        {
            var characters = Container.Instance().Resolve<ICharacterRepository>().Entities().Values
                .Where(x => x.AccountId == 1 && !x.IsDeleted);

            client.Send(new CharactersListMessage(false, characters.Select(x => x.ToCharacterBaseInformations()).ToArray()));
        }
    }
}