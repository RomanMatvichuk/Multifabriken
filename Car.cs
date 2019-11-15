using System;

namespace dotNet_Multifabriken
{
    public class Car : Product
    {
        private string RegistrationNumber;

        private string Model;

        private string Color;

        public Car(string Reg, string Model, string Color)
        {
            Name = "Bil";
            RegistrationNumber = Reg;
            this.Model = Model;
            this.Color = Color;

        }

        public override void PrintOut()
        {
            Console.WriteLine($"{Name} (Märke: {Model}, Färg: {Color}, Registreringsnummer: {RegistrationNumber})");
        }
        
    }
}