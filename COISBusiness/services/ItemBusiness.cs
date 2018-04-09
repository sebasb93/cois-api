using COIS_Models.cois_contracts;
using COIS_Models.item;
using System;
using System.Collections.Generic;
using System.Text;
using UtilsDB.contracts;


namespace COIS_Business.services
{
    public class ItemBusiness : IItemBusiness
    {
        private IDBService _dbService;

        public ItemBusiness(IDBService dbService)
        {
            _dbService = dbService;
        }

        public List<Item> GetAll()
        {
            return new List<Item>();
        }

        public string Test()
        {
            var res = _dbService.MongoTest();
            return res;
        }
    }
}
