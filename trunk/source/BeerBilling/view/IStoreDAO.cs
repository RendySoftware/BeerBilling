﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using domain_lib.dto;

namespace BeerBilling.view
{
    interface IStoreDAO
    {
        List<StoreDto> GetAllStore();
        List<MaterialDto> GetAllMaterial();
        bool AddNew(StoreDto storeDto);
        bool AddList(List<StoreDto> list);
        List<StoreDto> GetStores(DateTime? fromDate, DateTime? toDate, bool isImport, bool isExport);
        List<StatisticStoreDto> GetStatisticStores(string fromDate, string toDate);
    }
}
