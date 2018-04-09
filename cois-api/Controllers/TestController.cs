using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COIS_Models.cois_contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cois_api.Controllers
{
    [Produces("application/json")]
    [Route("api/Test")]
    public class TestController : Controller
    {
        private IItemBusiness _itemBusiness;

        public TestController(IItemBusiness itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }

        [HttpGet]
        public IActionResult Test()
        {
            var res = _itemBusiness.Test();
            return new JsonResult("Success: " + res) { StatusCode = 200 };
        }
    }
}