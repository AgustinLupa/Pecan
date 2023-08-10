using Pecan.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pecan.ViewModels
{
    public class ProductVM : ViewModelBase
    {
        //Properties
        private string _name = string.Empty;
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(); } }

        private string _barcode  = string.Empty;
        public string Barcode { get { return _barcode; } set { _barcode = value; OnPropertyChanged(); } }

        private string _supplierName = string.Empty;
        public string SupplierName { get { return _supplierName; } set { _supplierName = value; OnPropertyChanged(); } }

        private float _buyPrice;
        public float BuyPrice { get { return _buyPrice; } set { _buyPrice = value; OnPropertyChanged(); } }

        private float _sellPrice;
        public float SellPrice { get { return _sellPrice; } set { _sellPrice = value; OnPropertyChanged(); } }
    }
}
