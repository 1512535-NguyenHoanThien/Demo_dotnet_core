using SPA_Application.Domains.Entity;
using SPA_Application.Infrastructure.Context;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Infrastructure.Repository.Repository
{
    public class RoomRepository : IRoomRepository
    {

        private SPAContext _context;
        public RoomRepository(SPAContext context)
        {
            _context = context;
        }

        public void Active(long id)
        {
            var room = _context.Rooms.FirstOrDefault(p => p.Id == id);
            room.UpdatedEntity();

            _context.Rooms.Update(room);
            _context.SaveChanges();
        }

        public void Add(Room room)
        {
            room.AddEntity();

            _context.Add(room);
            _context.SaveChanges();
        }

        public void InActive(long id)
        {
            var room = _context.Rooms.FirstOrDefault(p => p.Id == id);
            room.DeleteEntity();

            _context.Rooms.Update(room);
            _context.SaveChanges();
        }

        public void Update(Room room)
        {
            var _room = _context.Rooms.FirstOrDefault(p => p.Id == room.Id);

            _room.UpdatedEntity();

            _context.Rooms.Update(_room);
            _context.SaveChanges();
        }

        public IEnumerable<Room> GetRoomsByStatus(Status status)
        {
            return _context.Rooms.Where(t => t.Status == status).ToList();
        }
       
        public Room GetRoomsById(long id)
        {
            return _context.Rooms.Where(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<Room> GetRooms()
        {
            return _context.Rooms.ToList();
        }
    }
}
