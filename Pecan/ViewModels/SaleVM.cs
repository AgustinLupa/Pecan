using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Pecan.Entities;
using Pecan.Utils;

namespace Pecan.ViewModels
{
    public class SaleVM : ViewModelBase
    {
        //Properties
        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; OnPropertyChanged(); } }

        private readonly ObservableCollection<TransactionVM> _saleItems;
        public IEnumerable<TransactionVM> SaleItems => _saleItems;

        public ICommand AddItemCommand { get; }
        public ICommand ConfirmSaleCommand { get; }
        public ICommand DeleteItemCommand { get; }

        public SaleVM()
        {
            _saleItems = new ObservableCollection<TransactionVM>();
        }
    }
}
