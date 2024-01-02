using Bookify.Application.Abstractions.Messaging;
using Bookify.Domain.Abstracts;

namespace Bookify.Application.Abstractions.Bookings.ReserveBooking;

internal sealed class ReserveBookingCommandHandler : ICommandHandler<ReserveBookingCommand, Guid>
{
    public Task<Result<Guid>> Handle(ReserveBookingCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
