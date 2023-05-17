using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Товары_для_животных_.Models;

namespace ООО__Товары_для_животных_.Tools.Interfaces
{
    internal interface GetModels
    {
        List<Category> GetCategoriesList();
        List<Manufacturer> GetManufacturesList();
        List<Provider> GetProvidersList();
    }
}
