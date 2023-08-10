using Pecan.Entities;
using Pecan.Interface.Contracts;
using System.Collections.ObjectModel;

namespace Pecan.TestBackend.Managers;

public class TestCommodityManager : ICommodityManager
{
    List<CommodityModel> _commodities;

    public TestCommodityManager() 
    {
        _commodities = new List<CommodityModel>() {
            new CommodityModel
            {
                CodBar= "0101234567890128TEC-IT",
                CommodityName= "Aji molido",
                CostPrice= 10,
                PricePublic= 15
            },
            new CommodityModel
            {
                CodBar= "0101749285765644TEC-IT",
                CommodityName= "Nuez moscada",
                CostPrice= 15,
                PricePublic= 80
            },
            new CommodityModel
            {
                CodBar= "010164775464889TEC-IT",
                CommodityName= "Galletitas",
                CostPrice= 20,
                PricePublic= 150
            }
        };
    }

    //Se puede crear una observablecollection directamente desde una list
    public ObservableCollection<CommodityModel> GetCommodities()
    {
        return new ObservableCollection<CommodityModel>(_commodities);
    }

    //Y una list directamente desde un observablecollection
    private void InsertCommodities(ObservableCollection<CommodityModel> commodities)
    {
        _commodities= new List<CommodityModel>(commodities);
    }
}
