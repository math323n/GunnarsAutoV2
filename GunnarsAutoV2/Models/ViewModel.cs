using GunnarsAuto;
using GunnarsAutoV2.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GunnarsAutoV2
{
    public class ViewModel
    {


        public ViewModel()
        {

            List<SalesPerson> salesPersons = Repository.GetAllSalesPersons();

            SalesPersons = new ObservableCollection<SalesPerson>(salesPersons);
           
    }
        public ObservableCollection<SalesPerson> SalesPersons { get; set; }
        public SalesPerson SelectedSalesPerson { get; set; }
    }

}