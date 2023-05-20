using Domain.Models;
using Domain.Permissions;
using Domain.Roles;
using Microsoft.EntityFrameworkCore;

namespace Application.Abstraction;
public interface IAplicationDbContext
{
    DbSet<Grade> Grades { get; }
    DbSet<Subject> Subjects { get; }
    DbSet<Student> students { get; }
    DbSet<Teacher> Teachers { get; }
    DbSet<Role> Roles { get;}
    DbSet<RolePermission> RolePermissions { get; }
    DbSet<Permission> Permissions { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
