using Bookify.Domain.Abstracts;

namespace Bookify.Domain.Bookings.Events
{
    public record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;

}
