using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Common
{
    public class TrackEntity
    {

        //true is Active entity
        //false is INActive entity
        public bool EntityStatus { get; set; }
        public DateTime LastCreatedDate { set; get; }
        public DateTime LastUpdatedDate { set; get; }

        public void AddEntity()
        {
            EntityStatus = true;
            LastCreatedDate = DateTime.Now;
            LastUpdatedDate = DateTime.Now;
        }

        public void UpdatedEntity()
        {
            EntityStatus = true;
            LastUpdatedDate = DateTime.Now;
        }

        public void DeleteEntity()
        {
            EntityStatus = false;
            LastUpdatedDate = DateTime.Now;
        }
    }
}
