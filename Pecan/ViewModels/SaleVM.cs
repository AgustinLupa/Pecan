using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pecan.Entities;
using Pecan.Utils;

namespace Pecan.ViewModels
{
    public class SaleVM : ViewModelBase
    {
        //Properties
        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; OnPropertyChanged(); } }

        private readonly ObservableCollection<SaleXCommodityModel> _saleItems;

        //List Commodities
        private readonly List<SaleModel> _sales;


    }
}
