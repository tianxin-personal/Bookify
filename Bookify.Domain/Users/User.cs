using Bookify.Domain.Abstracts;
using Bookify.Domain.Users.Events;

namespace Bookify.Domain.Users;

public sealed class User : Entity
{
    public User(Guid id, FirstName firstname, LastName lastname, Email email) : base(id)
    {
        Firstname = firstname;
        Lastname = lastname;
        Email = email;
    }

    public FirstName Firstname { get; private set; }
    public LastName Lastname { get; private set; }
    public Email Email { get; private set; }

    public static User Create(FirstName firstname, LastName lastname, Email email)
    {
        var user = new User(Guid.NewGuid(), firstname, lastname, email);

        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

        return user;
    }
}
