using App05.Model;
using App05.Repository;
using Microsoft.EntityFrameworkCore;

namespace App05.Service;

public class ProductService
{
    //ProductRepository repository;
    GenericRepository<Product> repository;
    public ProductService()
    {
        //repository = new ProductRepository();
        repository = new GenericRepository<Product>();
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
    public (List<ProductVM>, int) Get(int categoryId, string fromStr, string toStr, int page, int perPage)
    {
        //load navigation data
        //1. 🚀 eager loading (join)
        //2. explicit loading - 1+n problem
        //3. lazy loding -> package - 1+n problem


        var query = repository
                 .Get()
                 ;
        if(categoryId > 0)
        {
            /*  Linq
             *  Lambda
             *  Imutable
             *  Functional Programing -> Haskell, Lisp, Closure, Erlang
             */
             query = query.Where(x => x.CategoryId == categoryId);
        }

        if (!string.IsNullOrEmpty(fromStr)){
           var from = Convert.ToInt32(fromStr);
           query = query.Where(x => x.Price >= from);
        }

        if (!string.IsNullOrEmpty(toStr))
        {
            var to = Convert.ToInt32(toStr);
            query = query.Where(x => x.Price <= to);
        }



        return (query
                 .Include(x => x.Category)
                 .Select(d => new ProductVM
                 {
                     Id = d.Id,
                     Name = d.Name,
                     Description = d.Description,
                     Price = d.Price,
                     CatgoryName = d.Category.Name
                 })
                 //.OrderBy(x => x.Price)
                 .OrderByDescending(x => x.Price)
                 .Skip((page -1) * perPage)
                 .Take(perPage)
                 .ToList(), query.Count());

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
