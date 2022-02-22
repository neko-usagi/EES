using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Database
{
    public interface ITransactionContext
    {
        EESContext EESContext { get; }

        void Open();
    }
}
