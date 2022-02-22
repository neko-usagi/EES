using EES.Core.Mvvm;
using EES.Database.Entities;
using EES.Services.Interfaces;
using Prism.Regions;
using Reactive.Bindings;

namespace EES.Modules.EmployeeInfo.ViewModels
{
    public class EmployeeListViewModel : RegionViewModelBase
    {
        public EmployeeListViewModel(IRegionManager regionManager, IEmployeeService employeeService) : base(regionManager)
        {
            this.EmployeeList.Add(new DtEmployee() { EmployeeId = 1, Name = "���{" });
            this.EmployeeList.Add(new DtEmployee() { EmployeeId = 2, Name = "�R�c" });
        }

        public ReactiveCollection<DtEmployee> EmployeeList { get; set; } = new ReactiveCollection<DtEmployee>();
    }
}
