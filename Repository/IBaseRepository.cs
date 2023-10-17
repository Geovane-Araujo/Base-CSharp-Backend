namespace Base_Backend.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(int id, TEntity obj);
        void Remove(int id);
        void Dispose();
    }
}
