using Bookify.Domain.Abstracts;

namespace Bookify.Domain.Bookings.Events
{
    public record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;

}
