﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeerBilling.view;
using domain_lib.dto;
using domain_lib.controller;


namespace BeerBilling.presenter
{
    class StoreDAOImpl : IStoreDAO
    {
        private Controller _controller = new Controller();

        public List<StoreDto> GetAllStore()
        {
            throw new NotImplementedException();
        }

        public List<MaterialDto> GetAllMaterial()
        {
            return _controller.GetAllMaterial();
        }
    }
}
