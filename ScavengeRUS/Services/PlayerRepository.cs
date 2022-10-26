using Microsoft.AspNetCore.Identity;
using ScavengeRUS.Models.Entities;

namespace ScavengeRUS.Services
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext _db;

        public PlayerRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<Player> GetAll(){
            return _db.Players.ToList();
        }

        public async Task<Player> Create(Player player)
        {
            _db.Players.Add(player);
            await _db.SaveChangesAsync();
            return player;
        }
    }
}
