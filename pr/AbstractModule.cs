using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public abstract class AbstractModule
    {
        protected Coord position;
        protected int fuel;


        public Coord Position 
        { 
            get { return position; } 
        }
        public int Fuel 
        { 
            get { return fuel; } 
        }

        public AbstractModule(Coord position, int fuel ) 
        {
            this.position = position;
            this.fuel = fuel;
        }
        public void SetPosition(Coord newPosition)
        {
            this.position = newPosition;
        }
        public abstract void Act();

        public virtual void ConsumeFuel(int amount)
        {
            fuel = fuel - amount;
            if (fuel < 0)
            {
                fuel = 0;
            }
        }
        public override string ToString()
        {
            return "Position = " + position + ", Fuel = " + fuel;
        }
    }
}
