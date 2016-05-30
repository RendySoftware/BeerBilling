using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using domain_lib.dto;

namespace BeerBilling.view
{
    public interface IBillingDAO
    {
        List<BillDto> GetAllBill();
        List<BillDto> GetAllNotCompletedBill();
        bool AddNewBill(BillDto billDto);
        List<ResTableDto> GetAllResTableDto();
    }
}
