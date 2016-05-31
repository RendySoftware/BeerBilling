using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeerBilling.view;

namespace BeerBilling.report
{
    public class BillingReportDAOImpl : IBillingReportDAO
    {
        private BillingDataSet _billingDataSet;

        public BillingReportDAOImpl(BillingDataSet billingDataSet)
        {
            _billingDataSet = billingDataSet;
        }

        public virtual BillingDataSet BillingDataSet
        {
            get { return _billingDataSet; }
            set { _billingDataSet = value; }
        }
    }
}
