using SPA_Application.Domains.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Service.IService
{
    public interface IRoomService
    {
        void Add(Room room);
        void Update(Room room);
        void Close(long id);
        void ReOpen(long id);

        IEnumerable<Room> GetRooms();
        IEnumerable<Room> GetRoomsByStatus(Status status);
        Room GetRoomsById(long id);
    }
}
