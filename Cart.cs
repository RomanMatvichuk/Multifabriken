using System;
using System.Collections.Generic;

namespace dotNet_Multifabriken
{
    public class Cart
    {
        private List<Product> Products;

        public Cart()
        {
            Products = new List<Product>();
        }

        public void AddCar(string Model, string Color, string RegistrationNumber)
        {
            Car NewCar = new Car(RegistrationNumber, Model, Color);
            Products.Add(NewCar);
        }

        public void AddCandy(string Taste, int Quantity)
        {
            Candy NewCar = new Candy(Taste, Quantity);
            Products.Add(NewCar);
        }

        public void AddPipe(int Diameter, int Length)
        {
            Pipe NewCar = new Pipe(Diameter, Length);
            Products.Add(NewCar);
        }

        public void AddMilk(double Fat, double Liter)
        {
            Milk NewCar = new Milk(Fat, Liter);
            Products.Add(NewCar);
        }

        public void ShowCart()
        {
            Console.Clear();

            if (Products.Count != 0)
            {
                Console.WriteLine("Beställda produkter:");
                Console.WriteLine();

                foreach (Product Current in Products)
                {
                    Current.PrintOut();
                    Console.WriteLine();
                }

                Console.WriteLine($"Totalt: {Products.Count}");
            }
            else
            {
                Console.WriteLine("Här finns inga produkter!");
            }            

            Console.ReadKey();
        }

        public int GetProductQuantity()
        {
            return Products.Count;
        }
    }
}