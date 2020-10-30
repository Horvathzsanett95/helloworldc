using System;

namespace ConsoleApp1
{
    class CreateClass
    {
        static void Main(string[] args)
        {
            Emloyee Kovacs = new Emloyee(200, "archer", "Béla", 1995);
            Kovacs.Room = new Room(111);
            Emloyee Kovacs2 = (Emloyee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }

    public abstract class Person
    {
        private String _name;
        private int _birthDate;
        public Person(String name, int birthDate)
        {
            this._name = name;
            this._birthDate = birthDate;
        }

        public override string ToString()
        {
            return "name:" + _name;
        }
    }
}