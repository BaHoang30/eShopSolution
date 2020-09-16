using eShopSolutionViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolutionViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
