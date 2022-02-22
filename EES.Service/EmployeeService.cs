using EES.Database;
using EES.Database.Entities;
using EES.Services.Interfaces;
using System.Collections.ObjectModel;

namespace EES.Service
{
    public class EmployeeService : IEmployeeService
    {

        private readonly ITransactionContext _transactionContext;

        public EmployeeService(ITransactionContext transactionContext)
        {
            _transactionContext = transactionContext;
        }

        public ObservableCollection<DtEmployee> GetEmployees()
        {
            ObservableCollection<DtEmployee> list = new ObservableCollection<DtEmployee>();

            list.Add(new DtEmployee() { EmployeeId = 1, Name = "èºñ{X" });
            list.Add(new DtEmployee() { EmployeeId = 2, Name = "éRìcX" });

            return list;

        }
    }
}
