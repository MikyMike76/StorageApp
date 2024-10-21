namespace StorageApp.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public int Amount { get; set; }
    }
}
