using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WFARepairShop
{
    public partial class MainForm : Form
    {
        private int id = 0;
        Repairs repairDevice = new Repairs();

        public MainForm()
        {
            InitializeComponent();
            repairDevice.Workers = GetTestUsers();

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tBName.Text;
                string manufacturer = tBProducer.Text;
                DateTime date = dateTimePicker1.Value;
                string classRepair = cBCategory.Text;
                double cost = Convert.ToDouble(tBCost.Text);
                Devices device = new Devices(id++, name, manufacturer, date);
                repairDevice.Category = classRepair;
                repairDevice.Device = device;
                repairDevice.CostRepair = cost;
                rTBResultAssign.Text = repairDevice.getMastersForRepairDevice();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка");
            }
        }

        private List<Masters> GetTestUsers()
        {
            var masters = new List<Masters>
            {
                new Masters("Антонов", "Павел", "Аркадьевич", 1, "техник"),
                new Masters("Петров", "Алексей", "Николаевич", 2, "мастер"),
                new Masters("Гаврилов", "Олег", "Брониславович", 3, "электрик"),
                new Masters("Акумова", "Наталья", "Валерьевна", 4, "технолог")
            };
            return masters;
        }
    }
}
