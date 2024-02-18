//using MotoApp.Data;
//using MotoApp.Entities;
//using MotoApp.Repositories;
//using MotoApp.Repositories.Extensions;

//var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
//AddEmployees(employeeRepository);

//WriteAllToConsole(employeeRepository);
//var businessPartnerRepository = new SqlRepository<BusinessPartner>(new MotoAppDbContext());

//static void AddEmployees(IRepository<Employee> employeeRepository)
//{
//    var employees = new[]
//    {
//        new Employee { FirstName = "Kura" },
//        new Employee { FirstName = "Kaczka" },
//        new Employee { FirstName = "Gołąb" }
//    };

//    employeeRepository.AddBatch(employees);
//}


////    employeeRepository.Add(new Employee { FirstName = "Kura" });
////    employeeRepository.Add(new Employee { FirstName = "Kaczka" });
////    employeeRepository.Add(new Employee { FirstName = "Gołąb" });
////    employeeRepository.Save();
////}


//static void WriteAllToConsole(IReadRepository<IEntity> repository)
//{
//    var items = repository.GetAll();
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);
//    }
//}

using MotoApp.Entities;
using MotoApp.Data;
using MotoApp.Repositories;

var context = new MotoAppDbContext();

var employeeRepository = new SqlRepository<Employee>(context);
AddEmployees(employeeRepository);
AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);
//WriteAllToConsole(businessPartnerRepository);

var businessPartnerRepository = new SqlRepository<BusinessPartner>(context);
AddBusinessPartner(businessPartnerRepository);
WriteAllToConsole(businessPartnerRepository);

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Zenon" });
    employeeRepository.Add(new Employee { FirstName = "Wiesława" });
    employeeRepository.Add(new Employee { FirstName = "Wiesław" });
    employeeRepository.Save();
}


static void AddManagers(IWriteRepository<Manager> managerRepository)
{
    managerRepository.Add(new Manager { FirstName = "Ziutek" });
    managerRepository.Add(new Manager { FirstName = "Zbyniu" });
    managerRepository.Add(new Manager { FirstName = "Romuś" });
    managerRepository.Save();
}

static void AddBusinessPartner(IWriteRepository<BusinessPartner> businessPartnerRepository)
{
    businessPartnerRepository.Add(new BusinessPartner { Name = "MirekPol" });
    businessPartnerRepository.Add(new BusinessPartner { Name = "WózTrans" });
    businessPartnerRepository.Add(new BusinessPartner { Name = "BorysEx" });
    businessPartnerRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}



