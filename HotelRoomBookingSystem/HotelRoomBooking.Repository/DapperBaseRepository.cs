using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomBooking.Repository
{
    public abstract class DapperBaseRepository<T> where T : class
    {
        //Get/pust/post/delete ops to be done here

        public async Task Get(string anObjectToGet)
        {
            await Task.Delay(2000);
         // var  result = await action<int>() ;
            
        }       
       
    }
}
