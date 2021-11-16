using System;
using System.Diagnostics;

namespace FoodClassLib
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public int LowLevel { get; set; }
        public string TypeOfFood { get; set; }
        public Food()
        {
            
        }

        public Food(int id, string name, int inStock, int lowLevel)
        {
            Id = id;
            Name = name;
            InStock = inStock;
            LowLevel = lowLevel;
        }

        public Food(string typeOfFood)
        {
            TypeOfFood = typeOfFood;
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, " +
                   $"InStock= {InStock}," +
                   $" LowLevel = {LowLevel}";

        }

    }
}
