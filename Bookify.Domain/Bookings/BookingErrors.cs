using Bookify.Domain.Abstracts;

namespace Bookify.Domain.Bookings;

public static class BookingErrors
{
    public static readonly Error NotFound = new(
        "Booking.Notfound",
        "The booking you are looking for is not found.");

    public static readonly Error NotReserved = new(
        "Booking.NotReserved",
        "The booking is not reserved.");

    public static readonly Error Overlap = new(
        "Booking.Overlap",
        "The booking overlaps with another booking.");

    public static readonly Error NotConfirmed = new(
        "Booking.NotComfirmed",
        "The booking is not confirmed.");

    public static readonly Error AlreadyStarted = new(
               "Booking.AlreadyStarted",
                      "The booking has already started.");

    public static readonly Error NotPending = new(
               "Booking.NotPending",
                      "The booking is not pending.");
}
