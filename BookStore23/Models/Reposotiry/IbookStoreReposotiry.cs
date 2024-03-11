namespace BookStore23.Models.Reposotiry
{
    public interface IbookStoreReposotiry<TEntity>// this TE for pass any type even author or Book 
    {
        IList<TEntity> List();
        TEntity find(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);    
    }
}
