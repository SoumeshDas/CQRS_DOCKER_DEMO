using System;

namespace Actio.Common.Events
{
    public interface IActivityEvent : IEvent
    {
        Guid UserId { get; }
    }

}