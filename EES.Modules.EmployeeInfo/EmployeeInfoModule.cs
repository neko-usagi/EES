using EES.Core;
using EES.Modules.EmployeeInfo.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace EES.Modules.EmployeeInfo
{
    public class EmployeeInfoModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public EmployeeInfoModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        } 

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "EmployeeList");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<EmployeeList>();
        }
    }
}
