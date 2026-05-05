using System;

namespace TouchEmu.Core.Common.Managers.Frames
{
    public class InterceptCall : Attribute
    {
        public string CallType { get; }

        public InterceptCall(string callType)
        {
            this.CallType = callType;
        }
    }
}