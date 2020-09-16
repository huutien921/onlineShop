using onlineShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShop.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
