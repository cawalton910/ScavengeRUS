using ScavengeRUS.Models.Entities;

namespace ScavengeRUS.Services
{
    public interface IAdminRepository
    {
        Task<Admin> Create(Admin admin);
        ICollection<Admin> GetAll();
    }
}
