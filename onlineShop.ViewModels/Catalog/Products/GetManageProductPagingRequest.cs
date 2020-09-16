using onlineShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShop.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
