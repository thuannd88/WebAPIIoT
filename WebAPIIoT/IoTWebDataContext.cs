using Microsoft.EntityFrameworkCore;
using WebAPIIoT.Controllers;

namespace WebAPIIoT
{
    public class IoTWebDataContext:DbContext
    {
        public DbSet<Device> Devices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01;Database=IotDB;User ID=iotweb;TrustServerCertificate=True;Password=admin@123;");
            }
        }
    }
}
