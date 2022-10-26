using ScavengeRUS.Models.Entities;

namespace ScavengeRUS.Services
{
    public interface IHuntRepository
    {
        Task<Hunt> Create(Hunt hunt);
        ICollection<Hunt>? GetAll();
    }
}
