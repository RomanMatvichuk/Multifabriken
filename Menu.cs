using System;

namespace dotNet_Multifabriken
{
    public class Menu
    {
        private bool Run = true;
        private Cart Order = new Cart();

        private string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Multifabriken AB!");
            Console.WriteLine();
            Console.WriteLine("Välj en produkt för att beställa:");
            Console.WriteLine("[1] Bil");
            Console.WriteLine("[2] Godis");
            Console.WriteLine("[3] Rör");
            Console.WriteLine("[4] Havremjölk");
            Console.WriteLine();
            Console.WriteLine($"[V] Visa beställda produkter ({Order.GetProductQuantity()})");
            Console.WriteLine("[A] Avsluta");
            Console.WriteLine();
            return Console.ReadLine();
        }

        public void Show()
        {
            while(Run)
            {
                switch(MainMenu().ToUpper())
                {
                    case "1":
                    
                        AddCar();
                        break;

                    case "2":

                        AddCandy();
                        break;

                    case "3":
                        
                        AddPipe();
                        break;

                    case "4":

                        AddMilk();
                        break;

                    case "V":

                        Order.ShowCart();
                        break;

                    case "A":

                        Run = false;
                        Console.Clear();
                        Console.WriteLine("Tack för besöket!");
                        break;
                }
            }
        }

        private void AddCar()
        {
            string Model, Color, RegistrationNumber;
            Console.Clear();
            Console.WriteLine("Tillverkning...");
            Console.WriteLine();
            Console.WriteLine("Ange bilmärke:");
            Model = Console.ReadLine();
            Console.WriteLine("Ange färg:");
            Color = Console.ReadLine();
            Console.WriteLine("Ange registreringsnummer:");
            RegistrationNumber = Console.ReadLine().ToUpper();

            var isOk = Model != "" || Color != "" || RegistrationNumber != "";

            Console.Clear();

            if (isOk)
            {
                Order.AddCar(Model, Color, RegistrationNumber);
                Console.WriteLine("Tack!");                        
            }
            else
            {
                Console.WriteLine("Ops...Försök igen!");
            }

            Console.ReadKey();
        }

        private void AddCandy()
        {
            string Taste, Quantity;
            int _Quantity = 0;

            Console.Clear();
            Console.WriteLine("Tillverkning...");
            Console.WriteLine();
            Console.WriteLine("Ange smak:");
            Taste = Console.ReadLine();
            Console.WriteLine("Ange antal:");
            Quantity = Console.ReadLine();

            var isOk = Taste != "" && int.TryParse(Quantity, out _Quantity) && _Quantity != 0;

            Console.Clear();

            if (isOk)
            {
                Order.AddCandy(Taste, _Quantity);
                Console.WriteLine("Tack!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ops...Försök igen!");
            }

            Console.ReadKey();            
        }

        private void AddPipe()
        {
            string Diameter, Length;
            int _Diameter = 0;
            int _Length = 0;

            Console.Clear();
            Console.WriteLine("Tillverkning...");
            Console.WriteLine();
            Console.WriteLine("Ange diameter, mm:");
            Diameter = Console.ReadLine();
            Console.WriteLine("Ange längd, mm:");
            Length = Console.ReadLine();

            var isOk = int.TryParse(Diameter, out _Diameter) && _Diameter != 0 && 
                    int.TryParse(Length, out _Length) && _Length != 0;

            Console.Clear();

            if (isOk)
            {
                Order.AddPipe(_Diameter, _Length);
                Console.WriteLine("Tack!");
            }
            else
            {
                Console.WriteLine("Ops...Försök igen!");
            }

            Console.ReadKey();
        }

        private void AddMilk()
        {
            string Fat, Liter;
            double _Fat = 0;
            double _Liter = 0;

            Console.Clear();
            Console.WriteLine("Tillverkning...");
            Console.WriteLine();
            Console.WriteLine("Ange fetthalt, %:");
            Fat = Console.ReadLine();
            Console.WriteLine("Ange litermängd, l:");
            Liter = Console.ReadLine();

            var isOk = double.TryParse(Fat, out _Fat) && _Fat != 0 && 
                    double.TryParse(Liter, out _Liter) && _Liter != 0;

            Console.Clear();

            if (isOk)
            {
                Order.AddMilk(_Fat, _Liter);
                Console.WriteLine("Tack!");
            }
            else
            {
                Console.WriteLine("Ops...Försök igen!");
            }

            Console.ReadKey();
        }
    }
}