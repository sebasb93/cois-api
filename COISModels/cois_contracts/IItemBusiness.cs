using COIS_Models.item;
using System;
using System.Collections.Generic;
using System.Text;

namespace COIS_Models.cois_contracts
{
    public interface IItemBusiness
    {
        List<Item> GetAll();
        string Test();
    }
}
