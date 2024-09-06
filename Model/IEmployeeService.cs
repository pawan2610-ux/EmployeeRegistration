public interface IEmployeeService
{
    Task<Employee> CreateEmployee(Employee employee);
    Task<List<Employee>> GetAllEmployees();
    Task<Employee> GetEmployeeById(int id);
    Task<Employee> UpdateEmployee(int id, Employee employee);
    Task<bool> DeleteEmployee(int id);
}
