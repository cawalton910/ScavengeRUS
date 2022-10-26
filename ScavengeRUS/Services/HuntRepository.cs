using ScavengeRUS.Models.Entities;

namespace ScavengeRUS.Services
{
    public class HuntRepository : IHuntRepository
    {
        private readonly ApplicationDbContext _db;

        public HuntRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<Hunt>? GetAll()
        {
            return _db.Hunt.ToList();
        }
        public async Task<Hunt> Create(Hunt hunt)
        {
            _db.Hunt.Add(hunt);
            await _db.SaveChangesAsync();
            return hunt;
        }
    }
}
