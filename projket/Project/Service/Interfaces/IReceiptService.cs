using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interfaces
{
    public interface IReceiptService
    {
        void CreateReceipt(Receipt receipt);

        List<Receipt> GetByUserJmbg(string userJmbg);
    }
}
