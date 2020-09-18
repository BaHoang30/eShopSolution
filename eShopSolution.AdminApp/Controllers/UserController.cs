using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.AdminApp.Services;
using eShopSolutionViewModels.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace eShopSolution.AdminApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;
        public UserController(IUserApiClient userApiClient,
            IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var user = User.Identity.Name;
            var sessions = HttpContext.Session.GetString("Token");
            var request = new GetUserPagingRequest()
            {
                BearerToken = sessions,
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _userApiClient.GetUsersPagings(request);
            return View(data);
        }
    }
}
