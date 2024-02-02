using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
AddEmployees(employeeRepository);
AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);
var businessPartnerRepository = new SqlRepository<BusinessPartner>(new MotoAppDbContext());
AddBusinessPartner(businessPartnerRepository);
PrintBusinessPartners(businessPartnerRepository);

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Kura" });
    employeeRepository.Add(new Employee { FirstName = "Kaczka" });
    employeeRepository.Add(new Employee { FirstName = "Gołąb" });
    employeeRepository.Save();
}


static void AddBusinessPartner(IWriteRepository<BusinessPartner> businessPartnerRepository)
{
    businessPartnerRepository.Add(new BusinessPartner { Name = "Kurapol" });
    businessPartnerRepository.Add(new BusinessPartner { Name = "Kaczkapol" });
    businessPartnerRepository.Add(new BusinessPartner { Name = "Gołąbex" });
    businessPartnerRepository.Save();
}


static void AddManagers(IWriteRepository<Manager> managerRepository)
{
    managerRepository.Add(new Manager { FirstName = "Ziutek" });
    managerRepository.Add(new Manager { FirstName = "Zbyniu" });
    managerRepository.Add(new Manager { FirstName = "Romuś" });
    managerRepository.Save();
}

//static void WriteAllToConsole(IReadRepository<IEntity> repository)
//{
//    var items = repository.GetAll();
//    foreach(var item in items)
//    {
//        Console.WriteLine(item);
//    }
//}

static void WriteAllToConsole(IReadRepository<Employee> repository) 
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}



static void PrintBusinessPartners(IReadRepository<BusinessPartner> repository)
{
    var businessPartners = repository.GetAll();
    foreach (var partner in businessPartners)
    {
        Console.WriteLine($"BusinessPartner Id: {partner.Id}, Name: {partner.Name}");
    }
    Console.Beep();
}

