using App05.Model;

namespace App05.Repository;

public class ProductRepository
{
    public void Add(Product model)
    {
        using var ctx = new AppDbContext();
        ctx.Products.Add(model);
        ctx.SaveChanges();
    }

    //TODO: ExecuteUpdate
    public void Update(Product model)
    {
        using var ctx = new AppDbContext();
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    //TODO: ExecuteDelete 
    public void Delete(Product model)
    {
        using var ctx = new AppDbContext();
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        ctx.SaveChanges();
    }

    public IQueryable<Product> Get()
    {
        var ctx = new AppDbContext();
        return ctx.Products.AsQueryable();
    }
}
