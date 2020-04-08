using System;
using SmartSignature.Models;
using SmartSignature.Repository.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SmartSignature.Repository.Context
{
    public class DeviceRepository
    {
        private readonly DataBaseContext context;

        public DeviceRepository()
        {
            context = new DataBaseContext();
        }

        public IList<Device> FindDeviceByUser(int caixaAccount)
        {
            var user =
                context.User
                    .Include(t => t.Devices)
                    .FirstOrDefault(t => t.CaixaAccount == caixaAccount);

            return user.Devices;
        }
    }
}