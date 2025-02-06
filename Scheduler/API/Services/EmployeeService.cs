using API.Models;

namespace API.Services;

public class EmployeeService
{
    private readonly IEntityRepository<Employee> _repository;

    public EmployeeService(IEntityRepository<Employee> repository){
        _repository = repository;
    }

    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync(){
        return await _repository.GetAllAsync();
    }

    public async Task<Employee> GetEmployeeByIdAsync(int id){
        return await _repository.GetByIdAsync(id);
    }

    public async Task AddEmployeeAsync(Employee employee){
        employee.Active = true;
        await _repository.AddAsync(employee);
    }

    public async Task UpdateEmployeeAsync(Employee employee){
        await _repository.UpdateAsync(employee);
    }

    public async Task DeleteEmployeeAsync(int id){
        await _repository.DeleteAsync(id);
    }
}