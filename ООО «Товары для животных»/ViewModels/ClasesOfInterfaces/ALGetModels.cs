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
    public class ALGetModels : GetModels
    {
        List<Category> GetModels.GetCategoriesList()
        {
            return DB.Instance.Categories.ToList();
             
        }
        List<Manufacturer> GetModels.GetManufacturesList()
        {
            return DB.Instance.Manufacturers.ToList();
            
        }
        List<Provider> GetModels.GetProvidersList()
        {
            return DB.Instance.Providers.ToList();
            
        }
    }
}
