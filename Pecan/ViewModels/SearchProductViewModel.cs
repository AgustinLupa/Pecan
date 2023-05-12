using Pecan.Entities;
using Pecan.Utils;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Pecan.ViewModels;

public class SearchProductViewModel : ViewModelBase
{
    private ObservableCollection<CommodityModel> _commodities;
    private ObservableCollection<CommodityModel> _productList;

    public ICommand FilterCommand { get; set; }
    public ICommand AddProductCommand { get; set; } 

    public SearchProductViewModel(ObservableCollection<CommodityModel> commodities, ObservableCollection<CommodityModel> productList)
    {
        _commodities = commodities;
        _productList = productList;

        FilterCommand = new RelayCommand(Filter);
        AddProductCommand = new RelayCommand(AddProduct, CanAddProduct);
    }

    private bool CanAddProduct(object arg)
    {
        throw new NotImplementedException();
    }

    private void AddProduct(object obj)
    {
        throw new NotImplementedException();
    }

    private void Filter(object obj)
    {
        throw new NotImplementedException();
    }
}
