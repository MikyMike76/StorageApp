using System.Collections.Immutable;
using System.Xml.Linq;
using StorageApp.Data;
using StorageApp.Entities;
using StorageApp.Repos;

var medicineRepo = new SqlRepository<Medicine>(new StorageAppDbContext());
medicineRepo.Add(new Medicine { Name = "Ibuprofen", Amount = 5 });
medicineRepo.Add(new Medicine { Name = "Augmentin", Amount = 3 });
var offersRepo = new SqlRepository<Offers>(new StorageAppDbContext());
offersRepo.Add(new Offers { NameOfCompany = "Neureca" });
offersRepo.Add(new Offers { NameOfCompany = "DentaLux" });
medicineRepo.Save();
offersRepo.Save();
var repoMedicine = medicineRepo.GetAll();
foreach (var item in repoMedicine)
{
    Console.WriteLine(item);
}
var offersMedicine = offersRepo.GetAll();
foreach (var item in offersMedicine)
{
    Console.WriteLine(item);
}