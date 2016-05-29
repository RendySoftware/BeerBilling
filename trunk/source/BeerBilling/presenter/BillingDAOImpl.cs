using System;
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
    }
}
