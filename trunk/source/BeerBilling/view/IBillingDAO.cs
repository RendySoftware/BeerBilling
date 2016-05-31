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
        bool ThanhToan(BillDto billDto);
        List<ResTableDto> GetAllResTableDto();
        List<ResOrderDto> GetAllResOrderBy(long billId);
        List<MenuDto> GetAllMenuDto();
        BillDto getBillDto(long billId);
        ResOrderDto getResOrderDto(long id);
        bool DeleteResOrder(long id);
        bool AddNewResOrder(ResOrderDto resOrderDto);
        List<EmployeeDto> GetAllEmployee();
        List<BillDto> GetAllBillBy(string tuNgay, string denNgay, string billingNumber, string tableId, string billStatusCode);
    }
}
