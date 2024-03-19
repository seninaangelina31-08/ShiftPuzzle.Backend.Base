﻿namespace PracticeABC
{
    public interface IProductRepository
    { 
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductByName(string name);
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(string name);
    }
}