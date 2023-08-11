using Pecan.Entities;
using System.Collections.ObjectModel;

namespace Pecan.Interface.Contracts;

public interface ICommodityManager
{
    ObservableCollection<CommodityModel> GetCommodities();


}
