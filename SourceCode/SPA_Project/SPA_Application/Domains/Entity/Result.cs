using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Entity
{
    public class Result : TrackEntity
    {
        public long Id { set; get; }

        public int BMI { set; get; }
        public int Height { set; get; }
        public int Weight { set; get; }
        public int BodyMass { set; get; }
        public int FatContent { set; get; }
        public int MuscleContent { set; get; }
        public int StomachFat { set; get; }

        public long AppointmentId { set; get; }
        public Appointment Appointment { set; get; }
    }
}
