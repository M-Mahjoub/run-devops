﻿using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ProductContext _productContext;
        private readonly ILogger<ProductController> _logger;
        public ProductController(ProductContext productContext, ILogger<ProductController> logger)
        {
            _logger = logger;
            _productContext = productContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productContext.Products.Find(c => true).ToListAsync();
        }
    }
}
