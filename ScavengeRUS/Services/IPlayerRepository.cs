using ScavengeRUS.Models.Entities;

namespace ScavengeRUS.Services
{
    public interface IPlayerRepository
    {
        Task<Player> Create(Player player);
        ICollection<Player> GetAll();
    }
}
