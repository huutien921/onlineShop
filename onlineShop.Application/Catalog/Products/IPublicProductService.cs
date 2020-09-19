using onlineShop.ViewModels.Catalog.Products;
using onlineShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace onlineShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll(string language);
    }
}
