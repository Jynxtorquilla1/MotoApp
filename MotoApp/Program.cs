using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
AddEmployees(employeeRepository);
AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Kura" });
    employeeRepository.Add(new Employee { FirstName = "Kaczka" });
    employeeRepository.Add(new Employee { FirstName = "Gołąb" });
    employeeRepository.Save();
}



static void AddManagers(IWriteRepository<Manager> managerRepository)
{
    managerRepository.Add(new Manager { FirstName = "Ziutek" });
    managerRepository.Add(new Manager { FirstName = "Zbyniu" });
    managerRepository.Add(new Manager { FirstName = "Romuś" });
    managerRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach(var item in items)
    {
        Console.WriteLine(item);
    }
}

