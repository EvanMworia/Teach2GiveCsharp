using ProductsModels;
using ProductStore.Services;
using ProductStore.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Controller
{
    public class ProductController
    {
        ProductService productService= new ProductService();

        public async Task init()
        {   
            Console.WriteLine("1. Add a new Product");
            Console.WriteLine("2. Get all Products");
            Console.WriteLine("3. Update a Product");
            Console.WriteLine("4. Delete a Product");
            Console.WriteLine("Enter your input:");
            var input = Console.ReadLine();
            Console.WriteLine(input);

            //convert this input to int
           
            var output =int.TryParse(input, out int option);
            //errors incase user enters a string/char
            //validation number is between 1 and 4


            //switch
            await redirectUser(option);
        }

        public async Task redirectUser(int option)
        {
            switch (option)
            {
                case 1:
                    await AddProductUI();
                    break;

                case 2:
                    await showProducts();
                    break;
                case 3:
                    await updateProductUI();
                    break;
                case 4:
                    await deleteProduct();
                    break;
                    
            }

        }

        public async Task AddProductUI()
        {
            Console.WriteLine("Add a new  Product");

            Console.WriteLine(" Product Name: ");
            var Name=Console.ReadLine();

            Console.WriteLine(" Product Description: ");
            var Description = Console.ReadLine();


            Console.WriteLine(" Product Price: ");
            var priceStr = Console.ReadLine();
            var res= int.TryParse(priceStr, out int Price);


            var newProduct = new AddProduct() { Name = Name, Description = Description, Price = Price };
            await AddProductRequest(newProduct);
            //validation

        }

        public async Task AddProductRequest(AddProduct newProduct)
        {
            //communicate with service

            var response= await productService.AddProduct(newProduct);
            Console.WriteLine(response);
            await init();
        }

        public async Task showProducts()
        {
            var products = await productService.GetProductsAsync();
            Console.WriteLine($"Id \t Name \t Description \t Price");
            foreach (var product in products)
            {
                Console.WriteLine($" {product.Id} \t {product.Name} \t {product.Description} \t {product.Price}");
            }
        }

        public async Task updateProductUI()
        {
            await showProducts();
            Console.WriteLine("Select Product Update by Id :");
            var prod= Console.ReadLine();
            var output = int.TryParse(prod, out int ProductId);
            Console.WriteLine("  Product Name: ");
            var Name = Console.ReadLine();

            Console.WriteLine(" Product Description: ");
            var Description = Console.ReadLine();


            Console.WriteLine(" Product Price: ");
            var priceStr = Console.ReadLine();
            var res = int.TryParse(priceStr, out int Price);
            var updatedProduct = new AddProduct() { Name = Name, Description = Description, Price = Price };
            await updateProductRequest(ProductId, updatedProduct);
        }


        public async Task updateProductRequest(int productId, AddProduct updatedProduct)
        {
            var response = await productService.UpdateProduct(productId, updatedProduct);
            Console.WriteLine(response);
            await init();
        }

        public async  Task deleteProduct()
        {
            await showProducts();
            Console.WriteLine("Select Product to Delete by Id :");
            var prod = Console.ReadLine();
            var output = int.TryParse(prod, out int ProductId);
            var response= await productService.DeleteProduct(ProductId); 
            Console.WriteLine(response);
        }



    }
}
