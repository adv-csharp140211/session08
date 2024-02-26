using App05.Model;
using App05.Repository;

namespace App05.Service;

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

    public List<Category> Get()
    {
        return repository.Get();
    }
}
