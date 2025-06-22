﻿namespace Enemies
{
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        public int GetHealth()
        {
            return health;
        }
    }
}