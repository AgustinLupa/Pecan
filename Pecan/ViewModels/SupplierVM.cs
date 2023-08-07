using Pecan.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pecan.ViewModels
{
    public class SupplierVM : ViewModelBase
    {
        //Properties
        private string _supplierName = string.Empty;
        public string SupplierName { get { return _supplierName; } set { _supplierName = value; OnPropertyChanged(); } }

        private string _telephoneNumber = string.Empty;
        public string TelephoneNumber { get { return _telephoneNumber; } set { _telephoneNumber = value; OnPropertyChanged(); } }

        private string _address = string.Empty;
        public string Address { get { return _address; } set { _address = value; OnPropertyChanged(); } }
    }
}
