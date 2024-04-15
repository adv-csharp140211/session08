using app07.Model;
using app07.Repository;

namespace app07.Service;

public class CategoryService
{
    CategoryRepository repository;
    public CategoryService()
    {
        repository = new CategoryRepository();
    }

    public void Add(Category model)
    {
        //Validate
        //Busines Logic        
        repository.Add(model);
    }

    public void Update(Category model)
    {
        //Validate
        //Busines Logic  
        repository.Update(model);
    }

    public void Delete(Category model)
    {
        //Validate
        //Busines Logic  
        repository.Delete(model);
    }

    //Leak Layer
    public List<Category> Get(bool? isActive = null)
    {
        if (isActive.HasValue)
        {
            return repository.Get().Where(x => x.IsActive == isActive.Value).ToList();

        }
        else
        {
            return repository.Get().ToList();
        }
    }
}
