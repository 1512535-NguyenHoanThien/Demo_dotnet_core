using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Common
{
    public class EntityHelper
    {
        public enum Status
        {
            FREE,
            BUSY
        }

        public enum FeedbackTargetType
        {
            CUSTOMER,
            THERAPIST,
            OUTLET_MANAGER,
            SUPPER_OUTLET_MANAGER,
            OUTLET,
            ROOM,
            BED,
            SERVICE
        }
        public enum Gender
        {
            MALE,
            FEMALE
        }
        public enum AppointmentStatus
        {
            CONFIRMED,
            PENDING,
            COMPLETED,
            CANCLE
        }
        public enum NotìicationTargetType
        {
            USER,
            CUSTOMER,
            ALL_THERAPIST,
            ALL_OUTLET_MANAGER,
            ALL_USER
        }

        public enum UserRole
        {
            CUSTOMER,
            THERAPIT,
            OUTLET_MANAGER,
            SUPPER_OUTLET_MANAGER
        }
    }
}
