using Pecan.Entities;
using Pecan.Utils;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Pecan.ViewModels;

public class SearchProductVM : ViewModelBase
{
    private readonly ObservableCollection<CommodityModel> _commodities; //<-- lista de productos
    // Puede ser que necesite recibir 
    // o una interfaz con un metodo que sea agregar a la lista de observable
    // o un ObservableCollection de una clase abstracta/interfaz de la que hereden SaleXCommodityModel y PurchaseXCommodityModel
    private readonly ObservableCollection<CommodityModel> _productList;

    public ICommand FilterCommand { get; set; }
    public ICommand AddProductCommand { get; set; } 

    public SearchProductVM(ObservableCollection<CommodityModel> commodities, ObservableCollection<CommodityModel> productList)
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
