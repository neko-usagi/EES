using EES.Database.Entities;
using System;
using System.Collections.ObjectModel;

namespace EES.Services.Interfaces
{
    public interface IEmployeeService
    {
        ObservableCollection<DtEmployee> GetEmployees();
    }
}
