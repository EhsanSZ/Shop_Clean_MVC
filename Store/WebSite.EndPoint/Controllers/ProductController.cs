using Application.Catalogs.CatalogItems.GetCatalogIItemPLP;
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGetCatalogIItemPLPService getCatalogIItemPLPService;

        public ProductController(IGetCatalogIItemPLPService getCatalogIItemPLPService)
        {
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
        }
        public IActionResult Index(int page = 1, int pageSize = 20)
        {
            var data = getCatalogIItemPLPService.Execute(page, pageSize);
            return View(data);
        }

    }
}

