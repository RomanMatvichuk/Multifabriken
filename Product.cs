using System;

namespace dotNet_Multifabriken
{
    public abstract class Product
    {
        public string Name {get; set;}
        public abstract void PrintOut();
    }
}