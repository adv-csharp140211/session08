using app07.Model;

namespace app07.Repository;

public class GenericRepository<T>
    where T : class
{

    AppDbContext ctx = new AppDbContext();

    public void Add(T model)
    {
        ctx.Set<T>().Add(model);
        ctx.SaveChanges();
    }

    //TODO: ExecuteUpdate
    public void Update(T model)
    {
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    //TODO: ExecuteDelete 
    public void Delete(T model)
    {
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        ctx.SaveChanges();
    }



    public IQueryable<T> Get()
    {
        return ctx.Set<T>().AsQueryable();
    }

    public T ById(int id)
    {
        return ctx.Set<T>().Find(id);
    }
}
