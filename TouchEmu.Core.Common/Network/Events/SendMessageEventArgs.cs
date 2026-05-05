using System;

namespace TouchEmu.Core.Common.Network.Events
{
    public class SendMessageEventArgs : EventArgs
    {
        public string message { get; set; }
    }
}