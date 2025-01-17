using Lagrange.Core.Message;

namespace Lagrange.Core.Internal.Event.EventArg;

public class GroupMessageEvent : EventBase
{
    public MessageChain Chain { get; set; }
    
    public GroupMessageEvent(MessageChain chain)
    {
        Chain = chain;
    }
}