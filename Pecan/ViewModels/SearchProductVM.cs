using Pecan.Entities;
using Pecan.Utils;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Pecan.ViewModels;

public class SearchProductVM : ViewModelBase
{
    //Properties
    private string _name = string.Empty;
    public string Name { get { return _name; } set { _name = value; OnPropertyChanged(); } }

    private float _amount;
    public float Amount { get { return _amount; } set { _amount = value; OnPropertyChanged(); } }

    private float _subtotal;
    public float Subtotal { get { return _subtotal; } set { _subtotal = value; OnPropertyChanged(); } }

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
