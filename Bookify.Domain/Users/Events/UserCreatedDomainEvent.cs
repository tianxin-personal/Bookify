﻿using Bookify.Domain.Abstracts;

namespace Bookify.Domain.Users.Events
{
    public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;

}
