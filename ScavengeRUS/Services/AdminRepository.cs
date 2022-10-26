using ScavengeRUS.Models.Entities;

namespace ScavengeRUS.Services
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _db;

        public AdminRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<Admin> GetAll()
        {
            return _db.Admin.ToList();
        }
        public async Task<Admin> Create(Admin admin)
        {
            _db.Admin.Add(admin);
            await _db.SaveChangesAsync();
            return admin;
        }
    }
}
