﻿using Bookify.Domain.Abstracts;
namespace Bookify.Domain.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;