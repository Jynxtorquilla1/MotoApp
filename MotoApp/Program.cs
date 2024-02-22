using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Entities.Extensions;
using MotoApp.Repositories;
using MotoApp.Repositories.Extensions;
using System.ComponentModel.DataAnnotations;

var itemAdded = new ItemAdded<Employee>(EmployeeAdded);
var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), itemAdded);

AddEmployees(employeeRepository);
WriteAllToConsole(employeeRepository);

static void EmployeeAdded(Employee item)
{
    Console.WriteLine($"{item.FirstName} added");
}

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    var employees = new[]
    {
        new Employee { FirstName = "Kura" },
        new Employee { FirstName = "Kaczka" },
        new Employee { FirstName = "Gołąb" }.Copy()
    };

    employeeRepository.AddBatch(employees);
}



//    employeeRepository.Add(new Employee { FirstName = "Kura" });
//    employeeRepository.Add(new Employee { FirstName = "Kaczka" });
//    employeeRepository.Add(new Employee { FirstName = "Gołąb" });
//    employeeRepository.Save();
//}


static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}




