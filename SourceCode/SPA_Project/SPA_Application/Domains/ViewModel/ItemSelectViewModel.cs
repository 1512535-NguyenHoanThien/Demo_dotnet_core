using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.ViewModel
{
    public class ItemSelectViewModel<T>
    {
        public T Id { set; get; }
        public string Name { set; get; }
    }

}
