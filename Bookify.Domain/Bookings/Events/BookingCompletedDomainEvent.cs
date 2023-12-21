using Bookify.Domain.Abstracts;

namespace Bookify.Domain.Bookings.Events
{
    public record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;

}
