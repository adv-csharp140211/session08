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

    public List<Category> Get()
    {
        using var ctx = new AppDbContext();
        return ctx.Categories.ToList();
    }
}
