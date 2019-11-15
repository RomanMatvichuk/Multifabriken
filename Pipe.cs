using System;

namespace dotNet_Multifabriken
{
    public class Pipe : Product
    {
        private int Diameter;

        private int Length;

        public Pipe(int Diameter, int Length)
        {
            Name = "Rör";
            this.Diameter = Diameter;
            this.Length = Length;

        }

        public override void PrintOut()
        {
            Console.WriteLine($"{Name} (Diameter: {Diameter} mm, Längd: {Length} mm)");
        }
        
    }
}