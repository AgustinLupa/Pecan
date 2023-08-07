using Pecan.Interface.Contracts;

namespace Pecan.TestBackend.Managers;

public class TestMainManager : IMainManager
{
    ICommodityManager _commodityManager= new TestCommodityManager();

    public ICommodityManager GetCommodityManagerInstance()
    {
        return _commodityManager;
    }
}
