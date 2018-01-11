using System;

namespace DrinksMachinesDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");
            //myMachine.Location = "kitchen";
            //myMachine.Model = "DM1000";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);
        }
    }

    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }

        private string make;
        private string model;
        private string location;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Location { get => location; set => location = value; }
    }
}
