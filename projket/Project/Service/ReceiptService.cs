using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Repository;


namespace Service
{
    public class ReceiptService:IReceiptService
    {

        private readonly IReceiptRepository _receiptRepository;

        public ReceiptService(IReceiptRepository receiptRepository)
        {
            _receiptRepository = receiptRepository;
        }

        public List<Receipt> GetByUserJmbg(string userJmbg)
        {
            return _receiptRepository.GetByUserJmbg(userJmbg);
        }
        public void CreateReceipt(Receipt receipt)
        {
            _receiptRepository.CreateReceipt(receipt);
        }
    }
}