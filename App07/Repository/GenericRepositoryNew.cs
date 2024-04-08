using app07.Model;

namespace app07.Repository;

public class GenericRepositoryNew
{
    AppDbContext ctx = new AppDbContext();

    public void Add<T>(T model) where T : class
    {
        using var ctx = new AppDbContext();
        ctx.Set<T>().Add(model);
        ctx.SaveChanges();
    }

    //TODO: ExecuteUpdate
    public void Update<T>(T model) where T : class
    {
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    //TODO: ExecuteDelete 
    public void Delete<T>(T model) where T : class
    {
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        ctx.SaveChanges();
    }

    public IQueryable<T> Get<T>() where T : class
    {
        return ctx.Set<T>().AsQueryable();
    }


    public T ById<T>(int id) where T : class
    {
        return ctx.Set<T>().Find(id);
    }
}
