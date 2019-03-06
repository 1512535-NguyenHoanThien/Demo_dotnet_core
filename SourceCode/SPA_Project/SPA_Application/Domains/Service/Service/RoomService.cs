using SPA_Application.Domains.Entity;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Service.Service
{
    public class RoomService : IRoomService
    {
        private IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public void Add(Room room)
        {
            _roomRepository.Add(room);
        }

        public void Close(long id)
        {
            _roomRepository.InActive(id);
        }

        public IEnumerable<Room> GetRooms()
        {
            return _roomRepository.GetRooms();
        }

        public Room GetRoomsById(long id)
        {
            return _roomRepository.GetRoomsById(id);
        }

        public IEnumerable<Room> GetRoomsByStatus(Status status)
        {
            return _roomRepository.GetRoomsByStatus(status);
        }

        

        public void ReOpen(long id)
        {
            _roomRepository.Active(id);
        }

        public void Update(Room room)
        {
            _roomRepository.Update(room);
        }
    }
}
