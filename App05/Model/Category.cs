using System.Collections.ObjectModel;

namespace App05.Model;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    //Navigation Peoperty
    public ICollection<Product> Products { get; set; }
}
