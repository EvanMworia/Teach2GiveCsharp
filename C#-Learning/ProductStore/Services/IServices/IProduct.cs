using ProductsModels;

namespace ProductStore.Services.IServices
{
    public interface IProduct
    {
        Task<List<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<string> AddProduct(AddProduct newproduct);

        Task<string> UpdateProduct(int id, AddProduct updatedProduct);

        Task<string> DeleteProduct(int id);
    }
}
