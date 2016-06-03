using System;
using System.Collections;
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
        bool SaveBill(BillDto billDto);
        bool SaveCategory(DanhMucDto dto);
        bool SaveMenu(MenuDto dto);
        bool ThanhToan(BillDto billDto);
        List<ResTableDto> GetAllResTableDto();
        List<ResOrderDto> GetAllResOrderBy(long billId);
        List<MenuDto> GetAllMenuDto();
        List<ResOrderDto> GetAllResOrderDto(StatisticMenuSearchDto dto);
        BillDto getBillDto(long billId);
        ResOrderDto getResOrderDto(long id);
        bool DeleteResOrder(long id);
        bool AddNewResOrder(ResOrderDto resOrderDto);
        List<EmployeeDto> GetAllEmployee();
        List<BillDto> GetAllBillBy(string tuNgay, string denNgay, string billingNumber, string tableId, string billStatusCode);
        List<DanhMucDto> GetAllCategory();
        List<MenuDto> GetAllMenuBy(long categoryId);
        DanhMucDto getCategoryDto(long categoryId);
        bool IsExistCategoryCode(string categoryCode, long oldCategoryId);
        bool IsExistMenuCode(string menuCode, long oldMenuId);
        List<DanhMucDto> GetAllUnit();
        MenuDto getMenuDto(long menuId);
    }
}
