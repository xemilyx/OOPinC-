using System;

namespace DrinksMachinesDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine();
            myMachine.Location = "kitchen";
            myMachine.Model = "DM1000";

            Console.WriteLine(myMachine.Location);
        }
    }

    class DrinksMachine
    {
        private string make;
        private string model;
        private string location;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Location { get => location; set => location = value; }
    }
}
