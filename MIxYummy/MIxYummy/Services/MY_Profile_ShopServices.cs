using System;
using System.Collections.Generic;
using System.Linq;
using MIxYummy.Models;
using MIxYummy.Repositories;
namespace MIxYummy.Services
{
    public class MY_Profile_ShopServices
    {
        private MY_Profile_ShopRepoitory mY_Profile_ShopRepository;

        public MY_Profile_ShopServices()
        {
            mY_Profile_ShopRepository = new MY_Profile_ShopRepoitory();
        }

        public IEnumerable<MY_Profile_Shop> GetAll()
        {
            return mY_Profile_ShopRepository.GetAll().OrderBy(m => m.Shop_Email).ToList();
        }

        public bool Add(MY_Profile_Shop mY_Profile_Shop)
        {
            return mY_Profile_ShopRepository.Add(mY_Profile_Shop)>0;
        }

        public int Update(MY_Profile_Shop mY_Profile_Shop,int id)
        {
            return mY_Profile_ShopRepository.Update(mY_Profile_Shop,id);
        }

        public MY_Profile_Shop GetById(int Id)
        {
            return mY_Profile_ShopRepository.GetById(Id);
        }


    }
}
