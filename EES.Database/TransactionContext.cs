using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Database
{
    public class TransactionContext : ITransactionContext
    {
        public EESContext EESContext { get; private set; }

        public TransactionContext()
        {
            Open();
        }

        public void Open()
            => this.EESContext = new EESContext();
    }
}
