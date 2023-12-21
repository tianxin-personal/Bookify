using Bookify.Domain.Abstracts;

namespace Bookify.Domain.Bookings.Events
{
    public record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;

}
