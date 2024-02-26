using App05.Model;

namespace App05.Repository;

public class CategoryRepository
{
    public void Add(Category model)
    {
        using var ctx = new AppDbContext();
        ctx.Categories.Add(model);
        ctx.SaveChanges();
    }

    //TODO: ExecuteUpdate
    public void Update(Category model)
    {
        using var ctx = new AppDbContext();
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    //TODO: ExecuteDelete 
    public void Delete(Category model)
    {
        using var ctx = new AppDbContext();
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        ctx.SaveChanges();
    }

    public IQueryable<Category> Get()
    {
        var ctx = new AppDbContext();
        //var query = ctx.Categories
        //    .Where(x => x.IsActive)
        //    .OrderBy(x => x.Name);

        //return ctx.Categories.ToList();
        return ctx.Categories.AsQueryable();
    }
}
