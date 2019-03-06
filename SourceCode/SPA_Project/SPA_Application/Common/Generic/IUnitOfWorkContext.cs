using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Common.Generic
{
    public interface IUnitOfWorkContext
    {
        object GetUnitOfWorkContext();
    }
}
