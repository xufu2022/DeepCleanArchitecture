using Domain.Admins;

namespace Application.Common.Interfaces;

public interface IAdminsRepository
{
    Task AddAdminAsync(Admin admin);
    Task<Admin?> GetByIdAsync(Guid adminId);
    Task UpdateAsync(Admin admin);
}