using System;

namespace ClassAnimal
{
    public class Animal
    {
        int _food = 0;
        public int SaveFood(int amount)
        {
            this._food += amount;
            return amount;
        }

        public void Eat(int amount)
        {
            if (this._food < amount)
            {
                Console.WriteLine("There is not enough food");
            }
            else
            {
                this._food += amount;
            }
        }
    }
}