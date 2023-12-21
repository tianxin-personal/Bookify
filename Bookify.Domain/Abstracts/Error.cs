namespace Bookify.Domain.Abstracts
{
    public record Error(string Code, string Name)
    {
        public static Error None = new(string.Empty, string.Empty);
        public static Error NullValue = new("NullValue", "Null value was provided");
    }
}
