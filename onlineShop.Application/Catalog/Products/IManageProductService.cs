
using onlineShop.ViewModels.Catalog.ProductImages;
using onlineShop.ViewModels.Catalog.Products;
using onlineShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace onlineShop.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId , string langId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage( int imageId , ProductImageUpdateRequest request);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
        Task<ProductImageViewModel> GetImagetById(int imageId);

    }
}
