using App05.Model;
using App05.Repository;

namespace App05.Service;

public class ProductService
{
    ProductRepository repository;
    public ProductService()
    {
        repository = new ProductRepository();
    }

    public void Add(Product model)
    {
        //Validate
        //Busines Logic        
        repository.Add(model);
    }

    public void Update(Product model)
    {
        //Validate
        //Busines Logic  
        repository.Update(model);
    }

    public void Delete(Product model)
    {
        //Validate
        //Busines Logic  
        repository.Delete(model);
    }

    //Leak Layer
    public List<Product> Get()
    {
        return repository.Get().ToList();
    }
}
