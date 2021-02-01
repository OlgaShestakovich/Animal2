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
    }
}