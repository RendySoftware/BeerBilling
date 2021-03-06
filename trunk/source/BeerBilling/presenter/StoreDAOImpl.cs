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

        public bool AddNew(StoreDto storeDto)
        {
            return _controller.AddNewStore(storeDto);
        }

        public bool AddList(List<StoreDto> list)
        {
            foreach (StoreDto store in list)
            {
                AddNew(store);
            }
            return true;
        }

        public List<StoreDto> GetStores(DateTime? fromDate, DateTime? toDate, bool isImport, bool isExport)
        {
            return _controller.getStores(fromDate, toDate, isImport, isExport);
        }

        public List<StatisticStoreDto> GetStatisticStores(string fromDate, string toDate)
        {
            return _controller.GetStatisticStores(fromDate, toDate);
        }
    }
}
