using App05.Model;
using App05.Repository;
using Microsoft.EntityFrameworkCore;

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
    public List<ProductVM> Get()
    {
        //load navigation data
        //1. 🚀 eager loading (join)
        //2. explicit loading - 1+n problem
        //3. lazy loding -> package - 1+n problem

        return repository
                .Get()
                .Include(x => x.Category)
                .Select(d => new ProductVM  {
                    Id=  d.Id,
                    Name = d.Name, 
                    Description = d.Description, 
                    Price = d.Price,
                    CatgoryName = d.Category.Name })
                .ToList();
    }


    public Product ById(int id)
    {
        return repository.ById(id);
    }

    public class ProductVM
    {
        public int Id { get; set; }
            
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CatgoryName { get; set; }
    }
}
