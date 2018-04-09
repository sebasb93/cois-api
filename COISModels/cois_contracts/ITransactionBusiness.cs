using COIS_Models.transaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace COIS_Models.cois_contracts
{
    public interface ITransactionBusiness
    {
        List<Transaction> GetAll();
    }
}
