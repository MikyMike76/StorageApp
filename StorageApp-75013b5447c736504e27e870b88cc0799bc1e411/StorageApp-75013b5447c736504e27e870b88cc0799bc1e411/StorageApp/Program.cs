using System.Collections.Immutable;
using System.Xml.Linq;
using StorageApp.Data;
using StorageApp.Entities;
using StorageApp.Repos;

var medicineRepo = new SqlRepository<Medicine>(new StorageAppDbContext());
medicineRepo.Add(new Medicine { Name = "Ibuprofen", Amount = 5 });
medicineRepo.Add(new Medicine { Name = "Augmentin", Amount = 3 });
medicineRepo.Save();

var itemUpdated = new Medicine { Id = 1, Name = "Ibuprofen", Amount = 2 };
medicineRepo.Update(itemUpdated);
medicineRepo.Save();
var repo = medicineRepo.GetAll();
foreach (var item in repo)
{
    Console.WriteLine(item);
}