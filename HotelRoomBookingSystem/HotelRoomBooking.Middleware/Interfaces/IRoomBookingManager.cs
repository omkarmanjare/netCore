using System;
using System.Collections.Generic;
using System.Text;

namespace HotelRoomBooking.Middleware.Interfaces
{
    public interface IRoomBookingManager
    {
        bool AddRoom();
        bool AddRoomType();
    }
}
