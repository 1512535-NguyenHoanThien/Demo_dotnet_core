using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Entity
{
    public class FeedBack : TrackEntity
    {
        public long Id { set; get; }

        public FeedbackTargetType TargetType { set; get; }
        public long IdTarget { set; get; }
        public string Content { set; get; }
        public int Star { set; get; }

        public long UserId { set; get; }
        public User User { set; get; }
    }
}
