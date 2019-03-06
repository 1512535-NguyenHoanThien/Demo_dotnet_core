using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Entity
{
    public class Term : TrackEntity
    {
        public long Id { set; get; }

        public string Content { set; get; }
    }
}
