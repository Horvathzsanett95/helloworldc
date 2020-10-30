using System;
using System.ComponentModel;

namespace ConsoleApp1
{
    public class Emloyee : Person, ICloneable


    {
        private int salary;
        private String profession;

        public Emloyee(int salary, String profession, String name, int birthDate) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
        }


        public Room Room { get; set; }

        
        
            public object Clone()
            {
                Emloyee newEmployee = (Emloyee)this.MemberwiseClone();
                newEmployee.Room = new Room(Room.Number);
                return newEmployee;
            }
        
    }

    public class Room
    {
        private int _roomNumber;

        public Room(int number)
        {
            this._roomNumber = number;
        }

        public int Number { get; set; }
    }
}