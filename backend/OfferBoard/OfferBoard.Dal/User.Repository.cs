using System.Collections.Concurrent;
using OfferBoard.Dto;

namespace OfferBoard.Dal;

public class UserRepository
{
    private readonly ConcurrentDictionary<int, User> _users = new();
    private int _nextId = 1;

    public User Add(User user)
    {
        if (user.Id == 0)
        {
            user.Id = Interlocked.Increment(ref _nextId);
        }

        _users[user.Id] = Clone(user);
        return Clone(user);
    }

    public User? Get(int id)
    {
        return _users.TryGetValue(id, out var user) ? Clone(user) : null;
    }

    public IEnumerable<User> GetAll()
    {
        return _users.Values.Select(Clone).ToList();
    }

    public User? Update(User user)
    {
        if (user.Id == 0) return null;
        if (!_users.ContainsKey(user.Id)) return null;

        _users[user.Id] = Clone(user);
        return Clone(user);
    }

    public bool Delete(int id)
    {
        return _users.TryRemove(id, out _);
    }

    // Create a shallow copy to avoid exposing internal references
    private static User Clone(User u)
    {
        return new User
        {
            Id = u.Id,
            Name = u.Name,
            Surname = u.Surname,
            Email = u.Email,
            Password = u.Password,
            Role = u.Role,
            RegistrationDate = u.RegistrationDate,
            IsActive = u.IsActive,
            // Offers collection is not deep-cloned to keep repository simple; copy references
            Offers = u.Offers.ToList()
        };
    }
}
