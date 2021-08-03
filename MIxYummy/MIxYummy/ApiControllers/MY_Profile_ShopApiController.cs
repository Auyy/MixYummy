using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MIxYummy.Models;
using MIxYummy.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MIxYummy.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MY_Profile_ShopApiController : ControllerBase
    {
        private MY_Profile_ShopServices mY_Profile_ShopServices;

        public MY_Profile_ShopApiController()
        {
          mY_Profile_ShopServices = new MY_Profile_ShopServices();
        }

        [HttpGet()]
        public IEnumerable<MY_Profile_Shop> GetAll()
        {
            return mY_Profile_ShopServices.GetAll().ToList();
        }

        [HttpPost()]
        public bool Add([FromBody] MY_Profile_Shop mY_Profile_Shop)
        {
            return mY_Profile_ShopServices.Add(mY_Profile_Shop);
        }

        [HttpPost("{id:int}")]
        public int Update([FromBody] MY_Profile_Shop mY_Profile_Shop , int id)
        {
            return mY_Profile_ShopServices.Update(mY_Profile_Shop, id);
        }

        [HttpGet("{id:int}")]
        public MY_Profile_Shop GetById(int id)
        {
            return mY_Profile_ShopServices.GetById(id);
        }



    }
}
