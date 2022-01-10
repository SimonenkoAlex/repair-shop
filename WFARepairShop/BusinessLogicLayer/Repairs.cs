using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Repairs
    {
        private string category;
        private double costRepair;
        private List<Masters> workers;
        private Devices device;

        public Repairs(string category, Devices device, double cost) {
            this.category = category;
            this.device = device;
            costRepair = cost;
        }

        public string getMastersForRepairDevice(Devices device)
        {
            string surnameAndInitials = "";
            foreach (Masters master in workers) {
                if (master.Busyness == true)
                {
                    master.Busyness = false;
                    surnameAndInitials += master.FirstName + " " + master.SecondName.Substring(0, 1)
                        + "." + master.Patronymic[0] + ". починит " + device.DevicesName;
                }
                else {

                }
            }
            return surnameAndInitials;
        }
    }
}
