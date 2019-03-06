using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Entity
{
    public class Notification : TrackEntity
    {
        public long Id { set; get; }

        public NotìicationTargetType TargetType { set; get; }
        public string Content { set; get; }

        public long UserId { set; get; }

    }
}
