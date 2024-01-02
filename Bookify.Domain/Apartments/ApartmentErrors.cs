﻿using Bookify.Domain.Abstracts;

namespace Bookify.Domain.Apartments;

public static class ApartmentErrors
{
    public static Error NotFound = new(
        "Property.Found",
        "The property with the specified identifier was not found");
}
