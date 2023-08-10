using Pecan.Entities;
using Pecan.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pecan.ViewModels;

public class TransactionVM : ViewModelBase
{
    private readonly TransactionItem _transactionItem;

    public string Barcode => _transactionItem.Product.CodBar ?? string.Empty;
    public string Product => _transactionItem.Product.CommodityName ?? string.Empty;
    public string QuantityOfProducts => _transactionItem.QuantityOfProducts.ToString();
    public string Price => _transactionItem.Product.PricePublic.ToString();
    public string Subtotal => _transactionItem.Subtotal.ToString();

    public TransactionVM(TransactionItem transactionItem)
    {
        _transactionItem = transactionItem;
    }
}
