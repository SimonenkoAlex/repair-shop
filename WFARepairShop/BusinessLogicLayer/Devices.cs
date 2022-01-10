using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Devices
    {
        private int id;
        private string devicesName;
        private string manufacturer;
        private DateTime releaseDate;

        public Devices(int id, string name, string producer, DateTime date) {
            this.id = id;
            devicesName = name;
            manufacturer = producer;
            releaseDate = date;
        }

        public string DevicesName { get => devicesName; set => devicesName = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public int Id { get => id; set => id = value; }
    }
}
