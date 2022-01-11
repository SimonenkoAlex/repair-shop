using System;
using System.Collections.Generic;
using BusinessLogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepairShop.Tests
{
    [TestClass]
    public class RepairsTests
    {
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

        [TestMethod]
        public void getMastersForRepairDeviceTest1()
        {
            // Arrange
            Repairs repairDevice = new Repairs("чистка", 
                new Devices(1, "Утюг", "Scarlett", DateTime.Now), 45);
            repairDevice.Workers = GetTestUsers();
            repairDevice.Workers[0].Busyness = false;
            // Act
            var actualResult = repairDevice.getMastersForRepairDevice();
            // Assert
            Assert.AreEqual("Петров А.Н. -> Утюг", actualResult);
        }

        [TestMethod]
        public void getMastersForRepairDeviceExceptionTest()
        {
            // Arrange (Если все мастера заняты)
            Repairs repairDevice = new Repairs("чистка",
                new Devices(1, "Утюг", "Scarlett", DateTime.Now), 45);
            repairDevice.Workers = GetTestUsers();
            repairDevice.Workers[0].Busyness = false;
            repairDevice.Workers[1].Busyness = false;
            repairDevice.Workers[2].Busyness = false;
            repairDevice.Workers[3].Busyness = false;

            Assert.ThrowsException<Exception>(() => repairDevice.getMastersForRepairDevice());
        }
    }
}
