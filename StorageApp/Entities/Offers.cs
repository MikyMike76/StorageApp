namespace StorageApp.Entities
{
    public class Offers : EntityBase
    {
        public string NameOfCompany { get; set; }
        public override string ToString() => $"Id: {Id}, Name: {NameOfCompany}";
    }
}

