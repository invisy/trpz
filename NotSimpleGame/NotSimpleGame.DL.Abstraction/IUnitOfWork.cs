namespace NotSimpleGame.DL.Abstraction
{
    public interface IUnitOfWork
    {
        public TRepository Repository<TRepository>();
        public void Save();
    }
}
