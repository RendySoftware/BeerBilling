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

        public bool AddNewBill(BillDto billDto)
        {
            return _controller.AddNewBill(billDto);
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

        public bool AddNewResOrder(ResOrderDto resOrderDto)
        {
            return _controller.SaveResOrder(resOrderDto);
        }
    }
}
