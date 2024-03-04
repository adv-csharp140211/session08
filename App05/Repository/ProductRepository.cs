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

    public Product ById(int id)
    {
        using var ctx = new AppDbContext();

        //ctx.Products.Where(x => x.Id == id);
        //ctx.Products.First(x => x.Id == id); // age payda nakone, Error
        //ctx.Products.FirstOrDefault(x => x.Id == id); // age payda nakone, null
        //ctx.Products.Single(x => x.Id == id); // age payda nakone, Error, Bishtar 1 payda kone, Error
        //ctx.Products.SingleOrDefault(x => x.Id == id); // age payda nakone, null, , Bishtar 1 payda kone, Error

        return ctx.Products.Find(id);
    }
}
