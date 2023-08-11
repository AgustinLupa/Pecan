using Pecan.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pecan.ViewModels
{
    public class PurchaseVM : ViewModelBase
    {
        //Properties
        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; OnPropertyChanged(); } }

        private string _supplierName = string.Empty;
        public string SupplierName { get { return _supplierName; } set { _supplierName = value; OnPropertyChanged(); } }

    }
}
