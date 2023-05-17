using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Models;
using ООО__Товары_для_животных_.Tools.Interfaces;

namespace ООО__Товары_для_животных_.ViewModels.ClasesOfInterfaces
{
    public class AlSearchProduct : SearchProduct
    {
        public object GetProductCount()
        {
            return DB.Instance.Products.Count();
        }

        public void RemoveProductMethod(Product selectedProduct)
        {
            DB.Instance.Products.Remove(selectedProduct);
            DB.Instance.SaveChanges();
        }

        public IQueryable<Product> SearchForProductsMethod(string searchText)
        {
            return DB.Instance.Products
                                  .Include(p => p.ProductManufacturer)
                                  .Include(p => p.ProductProvider)
                                  .Include(p => p.OrderProducts)
                                  .Include(p => p.ProductCategory)
                                  .Where(s => s.ProductArticleNumber.Contains(searchText) ||
                                              s.ProductCategory.Title.Contains(searchText) ||
                                              s.ProductDescription.Contains(searchText) ||
                                              s.ProductManufacturer.Title.Contains(searchText) ||
                                              s.ProductTitle.Contains(searchText) ||
                                              s.ProductProvider.Title.Contains(searchText));

        }
    }
}
