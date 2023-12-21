using Bookify.Domain.Abstracts;

namespace Bookify.Domain.Bookings.Events
{
    public record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;

}
