using HotelRez.BusinessLayer.Abstract;
using HotelRez.DataAccessLayer.Abstract;
using HotelRez.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRez.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _room;

        public RoomManager(IRoomDal roomDal)
        {
            _room = roomDal;
        }

        public void TDelete(Room entity)
        {
            _room.Delete(entity);
        }

        public Room TGetByID(int id)
        {
            return _room.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return _room.GetList();
        }

        public void TInsert(Room entity)
        {
            _room.Insert(entity);
        }

        public void TUpdate(Room entity)
        {
            _room.Update(entity);
        }
    }
}
