namespace ProductsAPIService.Infrastructure
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll(); 
        TEntity GetById(int id);
        void CreateNew(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }
}
