using System;
using System.CodeDom;
using System.Runtime.CompilerServices;

namespace YourName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // display a literal value
            Console.WriteLine("What is your name?");
            // input a value and assign it to a string variable
            string name = Console.ReadLine();
            // display the string variable
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Hello, {0}", name);

            Phone phone = new Phone();
            phone.Manufacturer = "Apple";
            phone.Number = 23422344;

            Phone anotherPhone = new Phone(456456456, "Android", "Black");

        }

        public class Phone
        {
            public int Number { get; set; }

            public string Color { get; set; }

            public string Manufacturer { get; set; }

            public string Model { get; set; }


            // constructors

            public Phone()
            {
                Number = 123123123;
                Manufacturer = "Apple";
                Color = "Silver";
            }

            public Phone(int number, string manu, string color)
            {
                Number = number;
                Manufacturer = manu;
                Color = color;
            }

            public Phone(string model, int num, string color)
            {
                // same name different signature
            }

            // methods

            public void MakeCall() { }
            public void SendText() { }
            public void TakePicture() { }


            // old way of doing before 2019
            //private int _number;

            //public int Number

            //{
            //    get { return _number;  }
            //    set { _number = value; }
            //}

        }

        class Ticket1
        {
            // properties
            public string Name { get; set; }


            // methods
            public void ReadFile() { }

            public void WriteFile() { }

            public void CheckInput() { }

            public void DisplayMenu() { }

            public void GetFileIndex() { }
        }

        class Ticket2
        {
            // properties
            public int Number { get; set; }
            public string Description { get; set; }
            public string Priority { get; set; }
            public DateTime ExpirationDate { get; set; }

            // methods

            public bool IsValid()
            {
                // TODO:  Check ExpirationDate
                return true;
            }

        }

        class TicketManager
        {
            private Ticket2 ticket = new Ticket2();
        }
    }
}
