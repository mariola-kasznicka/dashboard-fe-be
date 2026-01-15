using System.Collections.Concurrent;
using OfferBoard.Dto;

namespace OfferBoard.Dal;

public class OfferRepository
{
    private readonly ConcurrentDictionary<int, Offer> _offers = new();
    private int _nextId = 1;

    public Offer Add(Offer offer)
    {
        if (offer.Id == 0)
        {
            offer.Id = Interlocked.Increment(ref _nextId);
        }

        _offers[offer.Id] = Clone(offer);
        return Clone(offer);
    }

    public Offer? Get(int id)
    {
        return _offers.TryGetValue(id, out var offer) ? Clone(offer) : null;
    }

    public IEnumerable<Offer> GetAll()
    {
        return _offers.Values.Select(Clone).ToList();
    }

    public Offer? Update(Offer offer)
    {
        if (offer.Id == 0) return null;
        if (!_offers.ContainsKey(offer.Id)) return null;

        _offers[offer.Id] = Clone(offer);
        return Clone(offer);
    }

    public bool Delete(int id)
    {
        return _offers.TryRemove(id, out _);
    }

    // Shallow copy to avoid exposing internal references
    private static Offer Clone(Offer o)
    {
        return new Offer
        {
            Id = o.Id,
            Title = o.Title,
            Description = o.Description,
            Status = o.Status,
            CreationDate = o.CreationDate,
            PublishDate = o.PublishDate,
            ArchivedDate = o.ArchivedDate,
            User = o.User,
            Industry = o.Industry,
            Localization = o.Localization,
            ContractType = o.ContractType,
            WorkingMode = o.WorkingMode,
            WorkType = o.WorkType,
            ExperienceLevel = o.ExperienceLevel
        };
    }
}
