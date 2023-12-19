using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new Employee { FirstName = "Kura" });
employeeRepository.Add(new Employee { FirstName = "Kaczka" });
employeeRepository.Add(new Employee { FirstName = "Gołąb" });
employeeRepository.Save();




