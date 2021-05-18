using System;
using System.Collections.Generic;
using HotelRoomBooking.Repository.DTO;
using HotelRoomBooking.Repository.Interfaces;

namespace HotelRoomBooking.Repository
{
    public class RoomRepository : DapperBaseRepository<Room>,IRoomRepository
    {
        public RoomRepository()
        {
                    
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return new List<Room>() { new Room() };
        }

       
    }
}
