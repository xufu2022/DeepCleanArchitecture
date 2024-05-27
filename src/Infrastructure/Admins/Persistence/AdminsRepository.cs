using Application.Common.Interfaces;
using Domain.Admins;
using Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Admins.Persistence;

public class AdminsRepository(GymManagementDbContext _dbContext) : IAdminsRepository
{
    public async Task AddAdminAsync(Admin admin)
    {
        await _dbContext.Admins.AddAsync(admin);
    }

    public async Task<Admin?> GetByIdAsync(Guid adminId)
    {
        return await _dbContext.Admins
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Id == adminId);
    }

    public Task UpdateAsync(Admin admin)
    {
        _dbContext.Admins.Update(admin);

        return Task.CompletedTask;
    }
}