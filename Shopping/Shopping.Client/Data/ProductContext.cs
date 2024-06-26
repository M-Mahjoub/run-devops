using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> products = new List<Product>
        {
            new Product()
            {
                Id=Guid.NewGuid(),
                Name="TV"
            },
            new Product()
            {
                Id=Guid.NewGuid(),
                Name="Radio"
            },
            new Product()
            {
                Id=Guid.NewGuid(),
                Name="Laptop"
            }

        };
    }
}
