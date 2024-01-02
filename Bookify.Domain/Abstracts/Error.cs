namespace Bookify.Domain.Abstracts
{
    public record Error(string Code, string Name)
    {
        public static readonly Error None = new(string.Empty, string.Empty);
        public static readonly Error NullValue = new("NullValue", "Null value was provided");
    }
}
