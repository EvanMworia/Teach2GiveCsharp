using Newtonsoft.Json;
using ProductsModels;
using ProductStore.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Services
{
    public class ProductService : IProduct
    {   

        private readonly HttpClient _httpClient;
        private readonly string URL= "http://localhost:3000/products";
        public ProductService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> AddProduct(AddProduct newproduct)
        {
            var content =JsonConvert.SerializeObject(newproduct);//request.body
            var body=new StringContent(content, Encoding.UTF8, "application/json");//JSON.stringify. to string
            var response = await _httpClient.PostAsync(URL, body);
            if(response.IsSuccessStatusCode)
            {
                return "Product Added Successfully";
            }
            return "";
        }

        public async Task<string> DeleteProduct(int id)
        {
            var response= await _httpClient.DeleteAsync(URL+"/"+id);
            if (response.IsSuccessStatusCode)
            {
                return "Product Deleted Successfully";
            }
            return "";
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync(URL+"/"+id);
            var content = await response.Content.ReadAsStringAsync();//string
            var product = JsonConvert.DeserializeObject<Product>(content);
            if (response.IsSuccessStatusCode && product != null)
            {
                return product;
            }
            return new Product();
           
        }

        public async Task<List<Product>> GetProductsAsync()
        {
           var response = await  _httpClient.GetAsync(URL);
           var content = await response.Content.ReadAsStringAsync();//string
           var products=JsonConvert.DeserializeObject<List<Product>>(content);
           if (response.IsSuccessStatusCode && products!=null)
           {
                return products;
           }
           return new List<Product>();
            
        }

        public async Task<string> UpdateProduct(int id, AddProduct updatedProduct)
        {
            var content = JsonConvert.SerializeObject(updatedProduct);
            var body = new StringContent(content, Encoding.UTF8, "application/json");//JSON.stringify. to string
            var response = await _httpClient.PutAsync(URL+"/"+id, body);
            if (response.IsSuccessStatusCode)
            {
                return "Product Updated Successfully";
            }
            return "";
        }
    }
}
