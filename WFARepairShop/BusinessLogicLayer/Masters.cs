using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Masters
    {
        private int id;
        private string firstName;
        private string secondName;
        private string patronymic;
        private string position;
        private bool busyness;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public string Position { get => position; set => position = value; }
        public bool Busyness { get => busyness; set => busyness = value; }

        public Masters(string surname, string name, string middleName, int id, string position)
        {
            this.id = id;
            firstName = surname;
            secondName = name;
            patronymic = middleName;
            this.position = position;
            busyness = true;
        }
    }
}
