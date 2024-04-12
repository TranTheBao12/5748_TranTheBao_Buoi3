namespace _4743_TranNhatAnhThuan_Buoi3.Models
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product, IFormFile imageUrl);
        Task DeleteAsync(int id);

    }
}
