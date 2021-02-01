using System;
using ClassAnimal;
namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            string result = animal.SaveFood(5).ToString();
            Console.WriteLine(result);
        }
    }
}
