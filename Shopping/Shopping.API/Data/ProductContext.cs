using MongoDB.Driver;
using Shopping.API.Models;

namespace Shopping.API.Data
{
    public class ProductContext
    {
        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DataBaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DataBaseSettings:DataBaseName"]);
            Products = database.GetCollection<Product>(configuration["DataBaseSettings:CollectionName"]);
            SeedData(Products);
        }

        private void SeedData(IMongoCollection<Product> products)
        {
            bool existProduct = products.Find(c => true).Any();
            if (!existProduct)
            {
                products.InsertManyAsync(GetPreConfigurationProducts());
            }
        }

        private IEnumerable<Product> GetPreConfigurationProducts()
        {
            return new List<Product>
           {
               new Product()
            {
                Name="TV"
            },
            new Product()
            {
                Name="Radio"
            },
            new Product()
            {
                Name="Laptop"
            }
           };
        }

        public IMongoCollection<Product> Products { get; }
    }
}
