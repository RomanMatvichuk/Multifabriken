using System;

namespace dotNet_Multifabriken
{
    public class Milk : Product
    {
        private double Fat;

        private double Liter;

        public Milk(double Fat, double Liter)
        {
            Name = "Havremjölk";
            this.Fat = Fat;
            this.Liter = Liter;

        }

        public override void PrintOut()
        {
            Console.WriteLine($"{Name} (Fetthalt: {Fat} %, Mängd: {Liter} lit.)");
        }
        
    }
}