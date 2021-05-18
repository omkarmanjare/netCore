using HotelRoomBooking.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelRoomBooking.Repository.Interfaces
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAllRooms();
    }
}
