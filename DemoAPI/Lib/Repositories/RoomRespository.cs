using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IRoomRepository : IRepository<Room>
    {
        List<Room> GetAllRooms();
        Room GetRoomById(Guid id);
    }
    public class RoomRespository : RepositoryBase<Room>, IRoomRepository
    {
        public RoomRespository(DbContextFactory factory)
            : base(factory)
        {

        }
        public List<Room> GetAllRooms()
        {
            var query = dataContext.Room.AsQueryable();
            return query.ToList();
        }


        public Room GetRoomById(Guid id)
        {
            var query = dataContext.Room.FirstOrDefault(x => x.Id == id);
            return query;
        }

    }
}