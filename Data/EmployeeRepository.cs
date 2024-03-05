using Microsoft.EntityFrameworkCore;

namespace anguarCrudBackend.Data
{
    public class EmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _appDbContext.Set<Employee>().AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

      public async Task<Employee> GetEmployeeById(int id)
        {
            return await _appDbContext.Employees.FindAsync(id);
        }

        public async Task UpdateEmployeeAsync(int id, Employee model)
        {
            var employee =await _appDbContext.Employees.FindAsync(id);
            if(employee == null)
            {
                throw new Exception("Employee Not Found");
            }
            employee.Name= model.Name;
            employee.Email= model.Email;
            employee.Phone= model.Phone;
            employee.Salary= model.Salary;

            await _appDbContext.SaveChangesAsync();
            
        }

       
    }
    
}
