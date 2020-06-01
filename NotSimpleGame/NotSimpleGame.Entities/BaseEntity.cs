namespace NotSimpleGame.Entities
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
