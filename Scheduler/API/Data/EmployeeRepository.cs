
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API;
public class EmployeeRepository : IEntityRepository<Employee>
{
    private readonly ApplicationDbContext _context;

    public EmployeeRepository(ApplicationDbContext context){
        _context = context;
    }
    public async Task AddAsync(Employee entity)
    {
        await _context.Employees.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Employees.FindAsync(id);
        if(entity!=null){
            _context.Employees.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await _context.Employees.Include(e => e.Person).ToListAsync();
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        return await _context.Employees.Include(e => e.Person).FirstOrDefaultAsync(e => e.PersonId == id);
    }

    public async Task UpdateAsync(Employee entity)
    {
        _context.Employees.Update(entity);
        await _context.SaveChangesAsync();
    }
}