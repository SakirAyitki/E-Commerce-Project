using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            ProductManager productManager = new ProductManager(new EfProductDal(),categoryManager);
            var result = productManager.GetProductDetails();

            if (result.Success) {
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine("Product Name: " + product.ProductName + " || Category Name: " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
}