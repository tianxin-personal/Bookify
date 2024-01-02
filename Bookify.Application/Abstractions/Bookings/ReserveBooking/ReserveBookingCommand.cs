using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Abstractions.Bookings.ReserveBooking;

public record ReserveBookingCommand(
    Guid ApartmenmtId,
    Guid UserId,
    DateOnly StartDate,
    DateOnly EndDate) : ICommand<Guid>
{
}

