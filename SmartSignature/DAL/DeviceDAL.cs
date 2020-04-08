using System;
using SmartSignature.Models;
using SmartSignature.Repository.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SmartSignature.DAL
{
    public class DeviceDAL
    {
        public DeviceDAL()
        {
        }

        public Device Find(int id)
        {
            DataBaseContext context = new DataBaseContext();
            var dev = context.Device.Include(t => t.Account)
                .FirstOrDefault(p => p.DeviceId == id);
            return dev;
        }
    }
}
