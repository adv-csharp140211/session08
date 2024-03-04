using App05.Model;

namespace App05.Repository;

public class GenericRepository<T>
    where T : class
{

    public void Add(T model)
    {
        using var ctx = new AppDbContext();
        ctx.Set<T>().Add(model);
        ctx.SaveChanges();
    }

    //TODO: ExecuteUpdate
    public void Update(T model)
    {
        using var ctx = new AppDbContext();
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    //TODO: ExecuteDelete 
    public void Delete(T model)
    {
        using var ctx = new AppDbContext();
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        ctx.SaveChanges();
    }

    public IQueryable<T> Get()
    {
        var ctx = new AppDbContext();
        return ctx.Set<T>().AsQueryable();
    }

    public T ById(int id)
    {
        using var ctx = new AppDbContext();
        return ctx.Set<T>().Find(id);
    }
}
