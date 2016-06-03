using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeerBilling.view;
using domain_lib.controller;
using domain_lib.dto;

namespace BeerBilling.presenter
{
    public class BillingDAOImpl : IBillingDAO
    {
        private Controller _controller = new Controller();

        public List<BillDto> GetAllBill()
        {
            return _controller.GetAllBill();
        }

        public List<BillDto> GetAllNotCompletedBill()
        {
            return _controller.GetAllNotCompletedBill();
        }

        public bool SaveBill(BillDto billDto)
        {
            return _controller.SaveBill(billDto);
        }

        public bool SaveCategory(DanhMucDto dto)
        {
            return _controller.SaveCategory(dto);
        }

        public bool SaveMenu(MenuDto dto)
        {
            return _controller.SaveMenu(dto);
        }

        public List<ResTableDto> GetAllResTableDto()
        {
            return _controller.GetAllResTableDto();
        }

        public List<ResOrderDto> GetAllResOrderBy(long billId)
        {
            return _controller.GetAllResOrderBy(billId);
        }

        public List<MenuDto> GetAllMenuDto()
        {
            return _controller.GetAllMenuDto();
        }

        public List<ResOrderDto> GetAllResOrderDto(StatisticMenuSearchDto dto)
        {
            return _controller.GetAllResOrderDto(dto);
        }

        public bool AddNewResOrder(ResOrderDto resOrderDto)
        {
            return _controller.SaveResOrder(resOrderDto);
        }

        public List<EmployeeDto> GetAllEmployee()
        {
            return _controller.GetAllEmployee();
        }

        public BillDto getBillDto(long billId)
        {
            return _controller.getBillDto(billId);
        }

        public ResOrderDto getResOrderDto(long id)
        {
            return _controller.getResOrderDto(id);
        }

        public bool DeleteResOrder(long id)
        {
            return _controller.DeleteResOrder(id);
        }

        public bool ThanhToan(BillDto billDto)
        {
            return _controller.ThanhToan(billDto);
        }

        public List<BillDto> GetAllBillBy(string tuNgay, string denNgay, string billingNumber, string tableId, string billStatusCode)
        {
            return _controller.GetAllBillBy(tuNgay, denNgay, billingNumber, tableId, billStatusCode);
        }

        public List<DanhMucDto> GetAllCategory()
        {
            return _controller.GetAllCategory();
        }

        public List<MenuDto> GetAllMenuBy(long categoryId)
        {
            return _controller.GetAllMenuBy(categoryId);
        }

        public DanhMucDto getCategoryDto(long categoryId)
        {
            return _controller.getCategoryDto(categoryId);
        }

        public bool IsExistCategoryCode(string categoryCode, long oldCategoryId)
        {
            return _controller.IsExistCategoryCode(categoryCode, oldCategoryId);
        }

        public bool IsExistMenuCode(string menuCode, long oldMenuId)
        {
            return _controller.IsExistMenuCode(menuCode, oldMenuId);
        }

        public List<DanhMucDto> GetAllUnit()
        {
            return _controller.GetAllUnit();
        }

        public MenuDto getMenuDto(long menuId)
        {
            return _controller.GetMenuDto(menuId);
        }
    }
}
