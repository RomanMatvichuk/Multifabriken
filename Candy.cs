using System;

namespace dotNet_Multifabriken
{
    public class Candy : Product
    {
        private string Taste;

        private int Quantity;

        public Candy(string Taste, int Quantity)
        {
            Name = "Godis";
            this.Taste = Taste;
            this.Quantity = Quantity;

        }

        public override void PrintOut()
        {
            Console.WriteLine($"{Name} (Smak: {Taste}, Antal: {Quantity} st.)");
        }
        
    }
}