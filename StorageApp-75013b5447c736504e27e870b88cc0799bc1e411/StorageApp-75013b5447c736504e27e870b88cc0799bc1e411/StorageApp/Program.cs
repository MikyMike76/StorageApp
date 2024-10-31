using System.Collections.Immutable;
using System.Xml.Linq;
using StorageApp.Data;
using StorageApp.Entities;
using StorageApp.Repos;

var medicineRepo = new SqlRepository<Medicine>(new StorageAppDbContext());
medicineRepo.Add(new Medicine { Name = "Ibuprofen", Amount = 5 });
medicineRepo.Add(new Medicine { Name = "Augmentin", Amount = 3 });
medicineRepo.Save();

var itemMedicineUpdated = new Medicine { Id = 1, Name = "Ibuprofen", Amount = 2 };
medicineRepo.Update(itemMedicineUpdated);
medicineRepo.Save();

var offerRepo = new SqlRepository<Offer>(new StorageAppDbContext());
offerRepo.Add(new Offer { NameOfCompany = "Neuca" });
offerRepo.Add(new Offer { NameOfCompany = "Medi" });
offerRepo.Save();

var itemOfferUpdated = new Offer { Id = 2, NameOfCompany = "Medi_System" };
offerRepo.Update(itemOfferUpdated);
offerRepo.Save();

var repo = medicineRepo.GetAll();
foreach (var item in repo)
{
    Console.WriteLine(item);
}

var repo1 = offerRepo.GetAll();
foreach (var item in repo1)
{
    Console.WriteLine(item);
}