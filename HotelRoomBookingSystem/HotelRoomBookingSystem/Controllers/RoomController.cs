using HotelRoomBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRoomBookingSystem.Controllers
{
    [Route("[controller]")]
   // [Route("api/[controller]")]
    public class RoomController : Controller
    {
        //Authorization Piece
        
        [HttpPost]
        [Route("addRoom")]
        public string AddRoom([FromBody] Room room)
        {
            //input/model validation
            //logging the request
            return"AddedRoom";
        }

        [HttpPut]
        [Route("updateRoom")]
        public string UpdateRoom([FromBody] Room room)
        {
            //input/model validation
            //logging the request
            return "Update Room";
        }



    }
}
